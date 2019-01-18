using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Товар находящийся на складе
    /// </summary>
    public class Goods
    {
        /// <summary>
        /// Информация о товаре
        /// </summary>
        public Info About { get; set; } = new Info();

        /// <summary>
        /// Поставщик товара
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Цена товара
        /// </summary>
        public double Cost { get; set; }
    }
}
