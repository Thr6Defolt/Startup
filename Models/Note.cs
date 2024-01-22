namespace Startup.Models
{
    public class Note
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public int Priority { get; set; }
    }
}
