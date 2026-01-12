using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Core.Entities;

[Table("book_names")]
public class Reference : IReference
{
    public Guid Id { get; set; }
    public int FromVerse { get; set; }
    public int ToVerse { get; set; }
    public int FromChapter { get; set; }
    public int ToChapter { get; set; }
    public string FromBook { get; set; }
    public string ToBook { get; set; }
}