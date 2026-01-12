namespace Entities.Interfaces;

public interface IBookName
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string LanguageCode { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string BookIntroduction { get; set; }
}