namespace DeliveryApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Supplier { get; set; }
        public string Recipient { get; set; }
        public decimal Price { get; set; }
        public ProductType Type { get; set; }
    }

    public enum ProductType
    {
        Necessary,
        GoodToHave,
        NotNeeded
    }
}
