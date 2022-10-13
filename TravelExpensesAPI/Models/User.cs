using System.Text.Json.Serialization;

namespace TravelExpensesAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        [JsonIgnore]
        public List<Application>? Applications { get; set; }
        public BankDetails? BankDetails { get; set; }
    }
}
