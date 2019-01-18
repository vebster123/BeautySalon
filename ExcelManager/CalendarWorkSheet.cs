using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using Organization;
using System.Diagnostics;

namespace ExcelManager
{
    public class CalendarWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="sheet">Лист "Календарь"</param>
        public CalendarWorkSheet(ExcelWorksheet sheet)
        {
            Core = sheet;

            //Обновляем лист событий
            int j = 2;
            //Удивительно, но первая ячейка в таблице это 1,1
            while (Core.Cells[j, 1].Value != null)
            {
                Worker _master = null;
                try
                {
                    _master = Enterprise.Personal.First(worker => worker.About.Name == Core.Cells[j, 4].Value.ToString());
                    
                    Event _event = new Event();
                    Client _client = null;
                    try
                    {
                        Enterprise.Clients.First(client => client.About.Name == Core.Cells[j,2].Value.ToString());
                        _event.Customer = _client;
                    }
                    catch (Exception)
                    {
                        _event.Customer = new Client();
                        _event.Customer.About.Name = Core.Cells[j, 2].Value.ToString();
                    }

                    _event.Master = _master;
                    _event.RecordDate = DateTime.FromOADate(double.Parse(Core.Cells[j,1].Value.ToString()));

                    try
                    {
                        _event.Service = Enterprise.PriceList.First(service => service.About.Name == Core.Cells[j,3].Value.ToString());
                        _event.isComplete = (Core.Cells[j, 5].Value.ToString() == "Выполнено" ? true : false);
                        _event.Cost = double.Parse(Core.Cells[j, 6].Value.ToString());
                        _master.Events.Add(_event);
                        j++;
                    }
                    catch (Exception)
                    {
                        j++;
                        Debug.WriteLine("Услуга не найдена");
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                    //Нет такого рабочего или он не работает в этот день
                    //throw;
                }
            }
        }

        public void Update()
        {
            //Название солбцов
            string[] topFieldsNames = {"Дата начала", "Клиент", "Название услуги", "Имя мастера", "Статус выполнения", "Цена на момент записи"};
            for (int j = 0; j < topFieldsNames.Length; j++)
            {
                Core.Cells[1, j+1].Value = topFieldsNames[j];
            }

            int row = 2;
            //Поехали по персоналу
            for (int i = 0; i < Enterprise.Personal.Count; i++)
            {
                for (int j = 0; j < Enterprise.Personal[i].Events.Count; j++)
                {
                    //
                    Core.Cells[row, 1].Style.Numberformat.Format = "yyyy-mm-dd";
                    //
                    Core.Cells[row, 1].Value = Enterprise.Personal[i].Events[j].RecordDate;
                    Core.Cells[row, 2].Value = Enterprise.Personal[i].Events[j].Customer.About.Name;
                    Core.Cells[row, 3].Value = Enterprise.Personal[i].Events[j].Service.About.Name;
                    Core.Cells[row, 4].Value = Enterprise.Personal[i].About.Name;
                    Core.Cells[row, 5].Value = (Enterprise.Personal[i].Events[j].isComplete ? "Выполнено" : "Не выполнено");
                    Core.Cells[row, 6].Value = Enterprise.Personal[i].Events[j].Service.Cost;
                    row++;
                }
            }
        }
    }
}
