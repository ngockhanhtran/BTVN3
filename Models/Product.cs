namespace BTVN3.Models
{
    public class Product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public double oldPrice { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public string image { get; set; }
        public int categoryID { get; set; }
        public string description { get; set; }
        public string createdDate { get; set; }
    }

    public class Category
    {
        public int categoryID { get; set; }
        public string categoryName { get; set; }
    }
}