using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace DATAO
{
    sealed class Authorization
    {
        private static string DataoID { get; set;}
        public static UserCredential FillCredentials(ref UserCredential credential)
        {
            string[] scopes = { DriveService.Scope.Drive };

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, "datao/user");
                try
                {
                    credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    scopes,
                    "datao",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    //Предполагается, что уже на этом шаге мы знаем, что пользователь в офлайне.
                    //Однако, скажем ему мы это на этапе загрузки таблицы.
                }
            }
            return credential;
        }

        public static bool? GetDataoInit(ref UserCredential credential)
        { 
            FilesResource.ListRequest listRequest;
            DriveService service;
            IList<Google.Apis.Drive.v3.Data.File> files;
                //Создаем сервис запроса на гугл диск
                service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "datao",
                });

                //Определяем параметры запроса
                listRequest = service.Files.List();
                listRequest.PageSize = 50;
                listRequest.Fields = "nextPageToken, files(id, name)";
            try
            {
                //Лист айдишников файлов
                files = listRequest.Execute()
                .Files;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Offline mode");
                return false;
            }

            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    if (file.Name == "datao.init")
                    {
                        FilesResource.ExportRequest request = null;
                        MemoryStream stream = null;
                        try
                        {
                            //Загружаем с драйва datao.init
                            request = service.Files.Export(file.Id, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                            stream = new MemoryStream();
                            request.Download(stream);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Произошла ошибка при загрузке datao.init");
                            return false;
                        }
                        finally
                        {
                            if (stream != null)
                            {
                                //Сохраняем локально
                                byte[] fileFromServer = stream.ToArray();
                                try
                                {
                                    File.WriteAllBytes(@"..\..\datao.init.xlsx", fileFromServer);
                                } catch(IOException ex)
                                {
                                    Debug.WriteLine(ex.Message);
                                    MessageBox.Show("Произошла ошибка при записи таблицы на диск\n " + ex.Message);
                                }
                                stream.Close();
                                //Сохраняем ссылку на текущий datao.init файл, для последующего его удаления
                                DataoID = file.Id;
                            }
                        }
                        return true;
                    }
                }
            }

            //Если же не нашли datao.init
            DialogResult dialogResult = MessageBox.Show("Do you want to use our template?\n(Also upload to Drive, if available)", "No datao.init file found!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //Процедура закачки
                var fileMetadata = new Google.Apis.Drive.v3.Data.File();
                fileMetadata.Name = "datao.init";
                fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
                FilesResource.CreateMediaUpload _request;

                //TODO: Путь до локальной таблицы-шаблона
                using (var _stream = new FileStream("example.init.xlsx",
                                        FileMode.Open))
                {
                    _request = service.Files.Create(
                        fileMetadata, _stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                    _request.Fields = "id";
                    _request.Upload();
                }
                MessageBox.Show("Успешно!");
                //загрузить с диска
                return false;
            }
            //Закрываем программу в случае отрицательного ответа
            return null;
        }

        public static void UploadDatao(ref UserCredential credential)
        {
            DriveService service;
            Google.Apis.Drive.v3.Data.File fileMetadata = new Google.Apis.Drive.v3.Data.File();
            fileMetadata.Name = "datao.init";
            fileMetadata.MimeType = "application/vnd.google-apps.spreadsheet";
            FilesResource.CreateMediaUpload request;

            using (var stream = new FileStream(@"..\..\datao.init.xlsx",
                                    FileMode.Open))
            {
                //Создаем запрос
                service = new DriveService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = credential,
                    ApplicationName = "datao",
                });

                //Определяем параметры запроса удаление всех datao.init находящихся на сервере
                FilesResource.ListRequest listRequest = service.Files.List();
                listRequest.PageSize = 50;
                listRequest.Fields = "nextPageToken, files(id, name)";

                //Лист айдишников файлов
                IList<Google.Apis.Drive.v3.Data.File> files = listRequest.Execute()
                    .Files;

                foreach (var file in files)
                {
                    if (file.Name == "datao.init")
                    {
                        try
                        {
                            service.Files.Delete(file.Id).Execute();
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                    }
                }
                
                //Заполняем параметры запроса на создание файла
                request = service.Files.Create(
                    fileMetadata, stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet");
                request.Fields = "id";
                try
                {
                    request.Upload();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }

            File.Delete(@"..\..\datao.init.xlsx");
        }
    }
}
