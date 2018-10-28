namespace Core.Server.Dal.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        public string Caption { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }

    }
}