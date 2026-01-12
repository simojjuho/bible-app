using Entities.Interfaces;

namespace Entities.Entities;

public class DevotionalContent : IDevotionalContent
{
    public Guid Id { get; set; }
    public Guid DevotionalId { get; set; }
    public string LanguageCode { get; set; }
    public string Content { get; set; }
}