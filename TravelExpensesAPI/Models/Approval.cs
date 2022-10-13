namespace TravelExpensesAPI.Models
{
    public class Approval
    {
        public int Id { get; set; }
        public User User { get; set; }
        public ApplicationStatus Status { get; set; } = ApplicationStatus.Pending;
        public string Note { get; set; } = string.Empty;
    }
}
