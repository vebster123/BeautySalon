using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Информация
    /// </summary>
    public class Info
    {
        /// <summary>
        /// Словарь вторичных полей конкретного объекта
        /// </summary>
        public Dictionary<string, string> Fields { get; set; } = new Dictionary<string, string>();

        /// <summary>
        /// Имя объекта
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Идентификационный номер объекта
        /// </summary>
        public uint ID { get; set; }

        /// <summary>
        /// Конструктор по умолчанию, который генерирует уникальный ID объекта
        /// </summary>
        public Info()
        {
            Random _random = new Random();
            ID = (uint)_random.Next(0, 99999);
        }

        /// <summary>
        /// Расширенный конструктор, который принимает ID объекта
        /// </summary>
        /// <param name="id"></param>
        public Info(uint id)
        {
            ID = id;
        }
    }
}
