namespace Entities.Interfaces;

public interface ITranslation
{
    public Guid Id { get; set; }
    public string License { get; set; }
    public string TitleAbbreviation { get; set; }
    public string TranslationName { get; set; }
    public string LanguageCode { get; set; }
}