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
    public class StorehouseWorkSheet
    {
        private ExcelWorksheet Core { get; set; }

        public StorehouseWorkSheet(ExcelWorksheet _sheet)
        {
            Core = _sheet;

            int j = 2;
            while (Core.Cells[j,1].Value != null)
            {
                Goods _item = new Goods();
                _item.About.ID = uint.Parse(Core.Cells[j, 1].Value.ToString());
                _item.About.Name = Core.Cells[j, 2].Value.ToString();
                _item.Provider = Core.Cells[j, 3].Value.ToString();
                _item.Cost = double.Parse(Core.Cells[j, 4].Value.ToString());

                Dictionary<Months, uint> _itemExpences = new Dictionary<Months, uint>();
                Enterprise.GoodsAvailability.Add(_item, uint.Parse(Core.Cells[j, 5].Value.ToString()));

                for (int i = 0; i < 12; i++)
                {
                    _itemExpences.Add((Months)i + 1, uint.Parse(Core.Cells[j,6+i].Value.ToString()));
                }

                Enterprise.GoodsExpences.Add(_item, _itemExpences);
                j++;
            }
        }

        public void Update()
        {
            //Заполнили верхние поля
            string[] topFieldNames = { "Артикул","Наименование","Поставщик","Стоимость","Остаток на складе"};
            for (int i = 0; i < topFieldNames.Length; i++)
            {
                Core.Cells[1, i + 1].Value = topFieldNames[i];
            }

            int j = 2;
            //int k = topFieldNames.Length;

            foreach (var item in Enterprise.GoodsAvailability)
            {
                int k = topFieldNames.Length;
                Core.Cells[j, k].Value = item.Value.ToString();
                k = topFieldNames.Length + 1;

                //for (int i = 0; i < Enterprise.GoodsExpences[item.Key].Count; i++)
                //{
                //    Core.Cells[1, k].Value = $"Израсходовано за {(Months)i+1}";
                //    Core.Cells[j, k].Value = Enterprise.GoodsExpences[item.Key][(Months)i+1].ToString();
                //    k++;
                //}
                j++;
            }
        }
    }
}
