using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Абстрактный человек
    /// </summary>
    public class Human
    {
        /// <summary>
        /// Информация о человеке
        /// </summary>
        public Info About { get; set; } = new Info();

        public Human()
        {

        }

        public Human(uint id)
        {
            About.ID = id;
        }
    }
}
