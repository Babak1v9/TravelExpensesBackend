using System.Text.Json.Serialization;

namespace TravelExpensesAPI.Models
{
    public class Application
    {
        public int Id { get; set; }
        public User User { get; set; } = default!;
        public DateTime ApplicationDate { get; set; }
        public DateTime TravelBeginDate { get; set; }
        public DateTime TravelEndDate { get; set; }
        public TimeSpan TravelBeginTime { get; set; }
        public TimeSpan TravelEndTime { get; set; }
        public int StartAddressId { get; set; }
        public Address StartAddress { get; set; } = default!;
        public int EndAddressId { get; set; }
        public Address EndAddress { get; set; } = default!;
        public string Destination { get; set; } = string.Empty;
        public int AmountBreakfasts { get; set; } = 0;
        public int AmountOtherMeals { get; set; } = 0;
        public TravelReason TravelReason { get; set; } = default!;
        public int TravelReasonId { get; set; } 
        public double TotalAmount { get; set; } 
        public bool IsDirty { get; set; } 
        public List<Approval>? Approvals { get; set; }
    }
}
