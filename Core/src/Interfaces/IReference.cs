namespace Core.Interfaces;

public interface IReference
{
    public Guid Id { get; set; }
    public int FromVerse { get; set; }
    public int ToVerse { get; set; }
    public int FromChapter { get; set; }
    public int ToChapter { get; set; }
    public string FromBook { get; set; }
    public string ToBook { get; set; }
}