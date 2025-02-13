namespace FormsApp.Models
{
    public class Product
    {
        public int ProductId { get; set;}
        public string Name { get; set;} = string.Empty;
        public decimal Price { get; set; }
        public string Image { get; set; } = string.Empty;
        public bool isActive { get; set; }
        public int CategoryId { get; set; }
    }
}