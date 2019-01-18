using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Organization;

namespace ExcelManager
{
    public class IncomeWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        public IncomeWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;

            int j = 2;
            while (Core.Cells[j, 1].Value != null)
            {
                Income _income = new Income();
                try
                {
                    _income.Date = DateTime.FromOADate(double.Parse(Core.Cells[j, 1].Value.ToString()));
                    _income.Provider = Core.Cells[j, 2].Value.ToString();
                    _income.Cost = double.Parse(Core.Cells[j, 3].Value.ToString());
                    j++;
                    Enterprise.Earnings.Add(_income);
                }
                catch (Exception ex) when (ex is FormatException || ex is OverflowException)
                {
                    //
                }
            }
        }

        public void Update()
        {
            string[] topFieldNames = { "Дата", "Поставщик", "Стоимость"};
            for (int i = 0; i < topFieldNames.Length; i++)
            {
                Core.Cells[1, i + 1].Value = topFieldNames[i];
            }

            int j = 2;
            foreach (var item in Enterprise.Earnings)
            {
                Core.Cells[j, 1].Value = item.Date;
                Core.Cells[j, 2].Value = item.Provider;
                Core.Cells[j, 3].Value = item.Cost;
                j++;
            }
        }
    }
}
