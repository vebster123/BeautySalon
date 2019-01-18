using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    public class Income
    {
        /// <summary>
        /// Дата прихода
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Поставщик
        /// </summary>
        public string Provider { get; set; }

        /// <summary>
        /// Стоимость прихода
        /// </summary>
        public double Cost { get; set; }

    }
}
