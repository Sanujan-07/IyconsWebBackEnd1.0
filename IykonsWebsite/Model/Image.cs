namespace IykonsWebsite.Model
{
    public class Image
    {
        public int Id { get; set; }
        public string File_Name { get; set; }
        public string Path { get; set; }
        public Post PostId { get; set; }
    }
}
