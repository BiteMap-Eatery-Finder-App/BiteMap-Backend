namespace backend.Models
{

    public enum ReservationStatus
    {
        PENDING,
        APPROVED,
        DENIED
    }

    public class Reservation
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int NumberOfSeats { get; set; }
        public ReservationStatus Type { get; set; }
        public User? CreatedBy { get; set; }
        public int UserId { get; set; }
        public Establishment? Establishment { get; set; }
        public int EstablishmentId { get; set; }

        public Reservation() { }

        public Reservation(DateTime date, int numberOfSeats, ReservationStatus type, User? createdBy, int userId, Establishment? establishment, int establishmentId)
        {
            this.Date = date;
            this.NumberOfSeats = numberOfSeats;
            this.Type = type;
            this.CreatedBy = createdBy;
            this.UserId = userId;
            this.Establishment = establishment;
            this.EstablishmentId = establishmentId;
        }
    }
}
