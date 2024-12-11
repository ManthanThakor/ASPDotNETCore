namespace WebApplication1.Models.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool StackStatus { get; set; }
        public int StockLevel { get; set; }
    }
}
