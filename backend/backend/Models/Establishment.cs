namespace backend.Models
{
    public enum EstablishmentType
    {
        BarsAndPubs,
        CaffeeAndTea,
        Dessert,
        Restaurant,
        Bakery,
        QuickBite
    }

    public class Establishment
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public EstablishmentType Type { get; set; }

        //public List<Manager> Managers { get; set; } = new List<Manager> { };
    }
}
