using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Core.Entities;

[Table("verses")]
public class Verse : IVerse
{
    public Guid Id { get; set; }
    public Guid TranslationId { get; set; }
    public Guid BookId { get; set; }
    public int Chapter { get; set; }
    public int VerseNumber { get; set; }
}