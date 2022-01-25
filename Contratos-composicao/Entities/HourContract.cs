using System;

namespace Contratos_composicao.Entities
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public Double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract() { }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
