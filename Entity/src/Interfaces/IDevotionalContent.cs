namespace Entities.Interfaces;

public interface IDevotionalContent
{
    public Guid Id { get; set; }
    public Guid DevotionalId { get; set; }
    public string LanguageCode { get; set; }
    public string Content { get; set; }
}