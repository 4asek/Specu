namespace Specu.Application.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxPeople { get; set; }
        public string Type { get; set; }
        public bool WifiInf { get; set; }
        public bool IsFavorite { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }
        public double Mark { get; set; }
        public double Area { get; set; }

    }
}
