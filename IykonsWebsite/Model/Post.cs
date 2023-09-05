namespace IykonsWebsite.Model
{
    public class Post
    {
        public int Id { get; set; }
        public User UserId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Image ImageId { get; set; }
        public DateTime CreateDate { get; set; }

        public Category CategoryId { get; set; }
        public Tag TagId { get; set; }
    }
}
