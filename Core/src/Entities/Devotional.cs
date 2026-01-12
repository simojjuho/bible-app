using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Core.Entities;

[Table("devotionals")]
public class Devotional : IDevotional
{
    public Guid Id { get; set; }
    public DateOnly Date { get; set; }
    public int Verse { get; set; }
    public int Chapter { get; set; }
    public Guid BookId { get; set; }
    public string? ImageAddress { get; set; }
}