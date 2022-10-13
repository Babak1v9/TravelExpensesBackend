namespace TravelExpensesAPI.Models
{
    public class BankDetails
    {
        public int Id { get; set; }
        public string IBAN { get; set; } = string.Empty;
        public string BIC { get; set; } = string.Empty;
        public string BankInstitution { get; set; } = string.Empty;
        public int UserId { get; set; }
    }
}
