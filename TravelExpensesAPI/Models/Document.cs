namespace TravelExpensesAPI.Models
{
    public class Document
    {
        public int Id { get; set; }
        public byte[] File { get; set; }
        public string Filename { get; set; }
        public string FileType { get; set; }
        public AdditionalCost AdditionalCost { get; set; }
        public int AdditionalCostId { get; set; }
    }
}
