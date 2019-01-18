using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Запись клиента на услугу (-и) с указанным мастером
    /// </summary>
    public class Event
    {
        /// <summary>
        /// Мастер, оказывающий услугу
        /// </summary>
        public Worker Master { get; set; }

        /// <summary>
        /// Клиент, которому оказывается услуга
        /// </summary>
        public Client Customer { get; set; }

        /// <summary>
        /// Услуга, которая оказывается клиенту мастером
        /// </summary>
        public Service Service { get; set; }

        /// <summary>
        /// Отвечает за выполнение услуги в событии
        /// </summary>
        public bool isComplete { get; set; }

        /// <summary>
        /// Дата записи события
        /// </summary>
        public DateTime RecordDate { get; set; }

        /// <summary>
        /// Изменяемая цена события
        /// </summary>
        public double Cost { get; set; }

        public Event(Service _service)
        {
            Service = _service;
            Cost = Service.Cost;
        }

        public Event() { }
    }
}
