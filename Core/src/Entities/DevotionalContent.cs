using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Entities.Entities;

[Table("devotionals_content")]
public class DevotionalContent : IDevotionalContent
{
    public Guid Id { get; set; }
    public Guid DevotionalId { get; set; }
    public string LanguageCode { get; set; }
    public string Content { get; set; }
}