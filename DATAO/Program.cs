using System;
using System.Windows.Forms;
using Google.Apis.Auth.OAuth2;
using ExcelManager;

namespace DATAO
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //Авторизация
            UserCredential _user = null;
            Authorization.FillCredentials(ref _user);
            bool? isOnline = Authorization.GetDataoInit(ref _user);
            switch (isOnline)
            {
                case (true):
                    {
                        //Все круто, файл загружен, пользователь работал до этого
                        Table.FillTable(new System.IO.FileInfo(@"..\..\datao.init.xlsx"));
                        break;
                    }
                case (false):
                    {
                        //Первый запуск, можно скинуть ему инструкцию по работе
                        Table.FillTable(new System.IO.FileInfo(@"..\..\example.init.xlsx"));
                        break;
                    }
                case (null):
                    {
                        //Отказался от закачки, продолжать работать с нами не хочет
                        Environment.Exit(0);
                        break;
                    }
            }

            //Отрисовка формы
            try
            {
                Application.Run(new AdminForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Table.Update();
                Table.Save();
                Authorization.UploadDatao(ref _user);
            }

            //Сохранее при закрытие формы и отправка на сервер
            //Table.Update();
            //Table.Save();
            //Authorization.UploadDatao(ref _user);
        }
    }
}
