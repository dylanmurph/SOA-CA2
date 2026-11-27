namespace SOA_CA2.Api.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string? Genre { get; set; }
        public string? Platform { get; set; }
    }
}