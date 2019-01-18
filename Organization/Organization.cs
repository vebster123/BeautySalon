using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Предприятие, которое оказывает услуги, имеет рабочих и клиентов, а также
    /// свой собственный склад и расписание своей работы.
    /// </summary>
    public static class Enterprise
    {
        /// <summary>
        /// Информация о предприятии
        /// </summary>
        public static Info About { get; set; } = new Info();

        /// <summary>
        /// Расписание предприятие в формате:
        /// 1. Дата рабочего дня
        /// 2. Количество часов работы
        /// </summary>
        public static Dictionary<Days, TimeSpan[]> TimeTable { get; set; } = new Dictionary<Days, TimeSpan[]>(7);

        /// <summary>
        /// Персонал предприятия
        /// </summary>
        public static List<Worker> Personal { get; set; } = new List<Worker>();

        /// <summary>
        /// Перечень услуг предприятия
        /// </summary>
        public static List<Service> PriceList { get; set; } = new List<Service>();

        /// <summary>
        /// Расходы товаров ЭТА ШТУКА НЕ НУЖНА ТЕПЕРЬ
        /// </summary>
        public static Dictionary<Goods, Dictionary<Months, uint>> GoodsExpences { get; set; } = new Dictionary<Goods, Dictionary<Months, uint>>();
        
        /// <summary>
        /// Доступные товары
        /// </summary>
        public static Dictionary<Goods, uint> GoodsAvailability { get; set; } = new Dictionary<Goods, uint>();

        /// <summary>
        /// Лист событий, происходящих при привозе товара (приходов)
        /// </summary>
        public static List<Income> Earnings { get; set; } = new List<Income>();

        /// <summary>
        /// Клиенты (постоянные или не очень) предприятия
        /// </summary>
        public static List<Client> Clients { get; set; } = new List<Client>();
    }
}
