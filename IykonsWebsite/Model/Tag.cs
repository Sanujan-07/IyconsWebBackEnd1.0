namespace IykonsWebsite.Model
{
    public class Tag
    {
        public int Id { get; set; }
        public string Tag_Name { get; set; }
        public Post PostId { get; set; }
    }
}
