namespace SampleCQRS.Models.Dto 
{
    public class ProductResult
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public DateTime CreationDate { get; set; }
    }
}