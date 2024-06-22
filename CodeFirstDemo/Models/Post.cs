namespace CodeFirstDemo.Models
{
    public class Post
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public int Read {  get; set; }
        public virtual User User { get; set; }
    }
}

