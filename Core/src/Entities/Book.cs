using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Core.Entities;

[Table("books")]
public class Book : IBook
{
    public Guid Id { get; set; }
    public string DefaultAbbreviation { get; set; }
}