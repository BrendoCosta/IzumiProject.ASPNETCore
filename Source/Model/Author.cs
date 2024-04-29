namespace Izumi.Model;

public record Author
{
    public string Name { get; set; }
    public string? Biography { get; set; }
    public List<string> Hobbies { get; set; }
    public DateTime Birthday { get; set; }
}