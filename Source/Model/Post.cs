namespace Izumi.Model;

public record Post
{
    public long Id { get; set; }
    public string Title { get; set; }
    public Author Author { get; set; }
    public DateTime CreationDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public bool Visible { get; set; }
}