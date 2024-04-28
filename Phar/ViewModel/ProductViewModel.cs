namespace Phar.ViewModel
{
    public class ProductViewModel
    {
        public string ID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public string? Image { get; set; }
        public IFormFile? ImageFile { get; set; }
        public string P_Name { get; internal set; }
        public string P_Description { get; internal set; }
        public int P_Price { get; internal set; }
        //public object ImgeFile { get; internal set; }
        //public object P_Imagefile { get; internal set; }
    }
}
