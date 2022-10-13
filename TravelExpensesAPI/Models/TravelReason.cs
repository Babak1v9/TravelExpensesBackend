namespace TravelExpensesAPI.Models
{
    public class TravelReason
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public bool Internal { get; set; }
        public bool Active { get; set; }
        public double DayRate { get; set; }
        public double KilometerAllowance { get; set; }
        public double BreakfastAllowance { get; set; }
        public double OtherMealAllowance { get; set; }
        public double HoursArrivalDay { get; set; }
        public double HoursDepartureDay { get; set; }
        public bool IsDirty { get; set; }
    }
}
