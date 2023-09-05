namespace IykonsWebsite.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public Post PostId { get; set; }
        public string Commender_Name { get; set; }
        public DateTime Commend_date { get; set; }
        public string COmmand_Text { get; set; }
    }
}
