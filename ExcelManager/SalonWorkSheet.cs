using System;
using System.Collections.Generic;
using OfficeOpenXml;
using System.Diagnostics;
using Organization;
using System.Linq;

namespace ExcelManager
{
    public class SalonWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        public SalonWorkSheet(ExcelWorksheet _core)
        {
            Core = _core;
            Enterprise.TimeTable.Clear();
            Enterprise.About.Fields.Clear();

            //Заполняем расписание
            for (int i = 2; i < 9; i++)
            {
                try
                {
                    if (Core.Cells[2, i].Value != null)
                    {
                        string[] timeInterval = Core.Cells[2, i].Value.ToString().Split('-');
                        Enterprise.TimeTable.Add((Days)i - 1, new TimeSpan[] { TimeSpan.Parse(timeInterval[0]), TimeSpan.Parse(timeInterval[1]) });
                    }
                }
                catch (Exception ex) when (ex is FormatException || ex is NullReferenceException)
                {
                    Debug.WriteLine(ex.Message);
                }
            }

            //Заполняем имя
            Enterprise.About.Name = "Салон красоты";

            //Заполняем остальные информационные поля
            int j = 4;
            while (Core.Cells[j,2].Value != null)
            {
                Enterprise.About.Fields.Add(Core.Cells[j, 1].Value.ToString(), Core.Cells[j, 2].Value.ToString());
                j++;
            }
        }

        public void Update()
        {
            //Обновляем расписание
            for (int i = 2; i < 9; i++)
            {
                string timeInterval = $"{ Enterprise.TimeTable[(Days)i-1][0]} - {Enterprise.TimeTable[(Days)i - 1][1]}";
                Core.Cells[2, i].Value = timeInterval;
            }

            //Обновляем имя
            Core.Cells[3, 2].Value = Enterprise.About.Name;

            //Обновляем дополнительные поля
            int j = 4;
            foreach (var pair in Enterprise.About.Fields)
            {
                Core.Cells[j, 1].Value = pair.Key;
                Core.Cells[j, 2].Value = pair.Value;
                j++;
            }
        }
    }
}
