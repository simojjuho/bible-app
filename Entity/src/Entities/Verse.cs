using Entities.Interfaces;

namespace Entities.Entities;

public class Verse : IVerse
{
    public Guid Id { get; set; }
    public Guid TranslationId { get; set; }
    public Guid BookId { get; set; }
    public int Chapter { get; set; }
    public int VerseNumber { get; set; }
}