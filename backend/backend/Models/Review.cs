namespace backend.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public double Rating { get; set; }
        public DateTime CreatedAt { get; set; }
        public User? CreatedBy { get; set; }
        public int UserId { get; set; }
        public Establishment? Establishment { get; set; }
        public int EstablishmentId { get; set; }

        public Review() { }
        public Review(string title, string text, double rating, DateTime createdAt, User? createdBy, int userId, Establishment? establishment, int establishmentId)
        {
            this.Title = title;
            this.Text = text;
            this.Rating = rating;
            this.CreatedAt = createdAt;
            this.CreatedBy = createdBy;
            this.UserId = userId;
            this.Establishment = establishment;
            this.EstablishmentId = establishmentId;
        }
    }
}
