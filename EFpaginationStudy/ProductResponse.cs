namespace EFpaginationStudy
{
    public class ProductResponse
    {
        public int Pages { get; set; }
        public int CurrentPage { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
