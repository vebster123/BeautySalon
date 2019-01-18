using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Рабочий день мастера
    /// </summary>
    public class WorkDay
    {
        /// <summary>
        /// Дата рабочего дня
        /// </summary>
        public TimeSpan Start { get; set; }

        /// <summary>
        /// Длительность рабочего дня
        /// </summary>
        public TimeSpan End { get; set; }

        /// <summary>
        /// Все записи мастера за текущий день
        /// </summary>
        public Dictionary<DateTime, Event> Events { get; set; }

        public WorkDay(string dayTimeInterval, char separator = '-')
        {
            string[] timeInterval = new string[2];
            timeInterval = dayTimeInterval.Split(separator);

            DateTime _start, _end;
            if (DateTime.TryParse(timeInterval[0], out _start) && DateTime.TryParse(timeInterval[1], out _end))
            {
                Start = _start.TimeOfDay;
                End = _end.TimeOfDay;
            }
            else
            {
                throw new FormatException();
            }
        }
    }
}
