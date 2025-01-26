namespace Razor_Blog.Models
{
    public class Article
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Picture   { get; set; }
        public string PictureAlt   { get; set; }
        public string PictureTitle    { get; set; }
        public string ShortDescription { get; set; }
        public string Body { get; set; }
        public DateTime CreationDate { get; set; }= DateTime.Now;

    }
}
