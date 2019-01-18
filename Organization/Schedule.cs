using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization
{
    /// <summary>
    /// Расписание объекта
    /// </summary>
    public class Schedule
    {
        /// <summary>
        /// Непосредственно расписание объекта
        /// </summary>
        public Dictionary<DateTime, WorkDay> Data { get; set; } = new Dictionary<DateTime, WorkDay>();
    }

    public enum Months
    {
        January = 1,
        February, March, April, May, June, July, August, September, October, November, December
    }

    public enum Days
    {
        Monday = 1,
        Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
