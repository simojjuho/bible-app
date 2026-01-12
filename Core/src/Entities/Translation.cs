using System.ComponentModel.DataAnnotations.Schema;
using Core.Interfaces;

namespace Core.Entities;

[Table("translations")]
public class Translation : ITranslation
{
    public Guid Id { get; set; }
    public string License { get; set; }
    public string TitleAbbreviation { get; set; }
    public string TranslationName { get; set; }
    public string LanguageCode { get; set; }
}