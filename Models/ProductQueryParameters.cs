namespace MySecondWebApi.Models
{
    public class ProductQueryParameters:QueryParameters
    {
        public decimal ? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }


        public String Sku { get; set; } =String.Empty;
        public String Name { get; set; } = String.Empty;


    }
}
 