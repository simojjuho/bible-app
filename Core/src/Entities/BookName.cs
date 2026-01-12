using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Core.Entities;

[Table("book_names")]
public class BookName : IBookName
{
    public Guid Id { get; set; }
    public Guid BookId { get; set; }
    public string LanguageCode { get; set; }
    public string Name { get; set; }
    public string Abbreviation { get; set; }
    public string BookIntroduction { get; set; }
}