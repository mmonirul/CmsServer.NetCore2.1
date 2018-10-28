namespace Core.Server.Dal.Models
{
    public class Color
    {
        public int ColorId { get; set; }
        public string Name { get; set; }
        public int Url { get; set; }
        public int ProductId { get; set; }
        public int ImageId { get; set; }
    }
}