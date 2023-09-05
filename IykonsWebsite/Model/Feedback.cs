namespace IykonsWebsite
{
    public class Feedback
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }

        public int Phone { get; set; }
        public string Subject { get; set; }
        public DateTime Created { get; set; }
    }
}
