namespace LearnBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public double PriceOneWayBind { get; set; }
        public double PriceTwoWayBind { get; set; }
        public double PriceTwoWayBindUpdating { get; set; }
        public bool IsActive { get; set; }
        public IEnumerable<Product_Prop> ProductProperties { get; set; }
    }
}
