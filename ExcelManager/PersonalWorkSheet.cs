using OfficeOpenXml;
using Organization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelManager
{
    public class PersonalWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="_sheet">Лист "Персонал"</param>
        public PersonalWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;
            Enterprise.Personal.Clear();

            int j = 2;
            while (Core.Cells[j,1].Value != null)
            {
                Worker _worker = new Worker();
                _worker.About.Name = Core.Cells[j, 1].Value.ToString();

                //Заполнили свободные поля
                for (int i = 2; i < 7; i++)
                {
                    _worker.About.Fields.Add(Core.Cells[1, i].Value.ToString(), Core.Cells[j, i].Value.ToString());
                }

                //Заполнили расписание
                int k = 7;
                while (Core.Cells[j, k].Value != null)
                {
                    _worker.TimeTable.Data.Add(
                        DateTime.FromOADate(double.Parse(Core.Cells[1, k].Value.ToString())),
                        new WorkDay(Core.Cells[j, k].Value.ToString())
                        );
                    k++;
                }

                //Ищем в информации поле Ставка
                try
                {
                    _worker.WageRate = double.Parse(_worker.About.Fields.First(pair => pair.Key == "Ставка").Value);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }

                Enterprise.Personal.Add(_worker);
                j++;
            }
        }

        public void Update()
        {
            //Размечаем поля вверху таблицы по первому рабочему в таблице
            Core.Cells[1, 1].Value = "Имя";
            int j = 2;
            if (Enterprise.Personal.Count != 0)
            {
                foreach (var key in Enterprise.Personal[0].About.Fields.Keys)
                {
                    Core.Cells[1, j].Value = key;
                    j++;
                }
            }
            //Внутрянка информационных полей
            j = 2;
            for (int i = 0; i < Enterprise.Personal.Count; i++)
            {
                Core.Cells[j, 1].Value = Enterprise.Personal[i].About.Name;
                for (int k = 2; k < 7; k++)
                {
                    Core.Cells[j, k].Value = Enterprise.Personal[i].About.Fields[Core.Cells[1, k].Value.ToString()];
                }

                int l = 7;
                foreach (var pair in Enterprise.Personal[i].TimeTable.Data)
                {
                    //
                    Core.Cells[j, 1].Style.Numberformat.Format = "yyyy-mm-dd";
                    //
                    Core.Cells[1, l].Value = pair.Key;
                    Core.Cells[j, l].Value = $"{pair.Value.Start} - {pair.Value.End}";
                    l++;
                }
                j++;
            }
        }
    }
}
