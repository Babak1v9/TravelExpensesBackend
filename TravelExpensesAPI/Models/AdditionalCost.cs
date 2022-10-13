namespace TravelExpensesAPI.Models
{
    public class AdditionalCost
    {
        public int Id { get; set; }
        public AdditionalCostType Type { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Amount { get; set; }
        public List<Document> Documents { get; set; } = new();
    }
}
