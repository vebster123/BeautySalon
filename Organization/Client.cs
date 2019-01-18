using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Клиент предприятия
    /// </summary>
    public class Client : Human
    {
        /// <summary>
        /// Записи конкретного клиента
        /// </summary>
        public List<Event> Events { get; set; } = new List<Event>();

        public Client() : base()
        {

        }

        public Client(uint id) : base(id)
        {

        }
    }
}
