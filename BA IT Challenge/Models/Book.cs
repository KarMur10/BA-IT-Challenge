namespace BA_IT_Challenge.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Author { get; set; } = null!;
        public string? Publisher { get; set; }
        public string? PublishDate { get; set; }
        public string? Genre { get; set; }
        public string ISBN { get; set; } = null!;
        public string Status { get; set; } = null!;
        public string? LenderOrReserverId { get; set; }
    }
}
