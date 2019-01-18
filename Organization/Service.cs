using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Услуга предприятия
    /// </summary>
    public class Service
    {
        /// <summary>
        /// Информация о услуге
        /// </summary>
        public Info About { get; set; } = new Info();

        /// <summary>
        /// Чистая стоимость услуги без учета стоимости расходных материалов (пока не учитывается)
        /// </summary>
        private double ServiceCost { get; set; }

        /// <summary>
        /// Длительность услуги
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Расходы материалов за одну услугу (пока не учитываются)
        /// </summary>
        private Dictionary<Goods, double> Expences { get; set; } = new Dictionary<Goods, double>();

        /// <summary>
        /// Сумма ServiceCost и Expences
        /// </summary>
        public double Cost { get; set; }
    }
}
