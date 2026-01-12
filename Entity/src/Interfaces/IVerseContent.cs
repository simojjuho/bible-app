namespace Entities.Interfaces;

public interface IVerseContent
{
    public Guid Id { get; set; }
    public Guid TranslationId  { get; set; }
    public Guid BookId { get; set; }
    public int Chapter { get; set; }
    public int VerseNumber { get; set; }
}