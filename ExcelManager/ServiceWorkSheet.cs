using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organization;

namespace ExcelManager
{
    public class ServiceWorkSheet
    {
        private ExcelWorksheet Core { get; set; }
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="_sheet">Лист "Услуги"</param>
        public ServiceWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;

            int j = 2;
            while (Core.Cells[j,1].Value != null)
            {
                Service _service = new Service();
                _service.About.Name = Core.Cells[j, 1].Value.ToString();
                _service.Cost = double.Parse(Core.Cells[j, 2].Value.ToString());
                _service.Duration = TimeSpan.Parse(Core.Cells[j, 3].Value.ToString().Split(' ')[1]);

                int k = 4;
                while (Core.Cells[j, k].Value != null)
                {
                    _service.About.Fields.Add(Core.Cells[1, k].Value.ToString(), Core.Cells[j, k].Value.ToString());
                    k++;
                }
                Enterprise.PriceList.Add(_service);
                j++;
            }
        }

        public void Update()
        {
            Core.Cells[1, 1].Value = "Название";
            Core.Cells[1, 2].Value = "Стоимость";
            Core.Cells[1, 3].Value = "Длительность";

            int j = 4;
            if (Enterprise.PriceList.Count != 0)
            {
                foreach (var pair in Enterprise.PriceList[0].About.Fields)
                {
                    Core.Cells[1, j].Value = pair.Key;
                    j++;
                }
            }
            j = 2;

            foreach (var _service in Enterprise.PriceList)
            {
                Core.Cells[j, 1].Value = _service.About.Name;
                Core.Cells[j, 2].Value = _service.Cost;
                Core.Cells[j, 3].Value = _service.Duration;

                for (int i = 0; i < _service.About.Fields.Count; i++)
                {
                    Core.Cells[j, 4 + i].Value = _service.About.Fields[Core.Cells[1, 4 + i].Value.ToString()];
                }
                j++;
            }

        }
    }
}
