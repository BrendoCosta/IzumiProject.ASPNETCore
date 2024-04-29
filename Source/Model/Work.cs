namespace Izumi.Model;

public record Work
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Start { get; set; }
    public DateTime? End { get; set; }
    public bool Running { get; set; }
}