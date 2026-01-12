namespace Entities.Interfaces;

public interface IBook
{
    public Guid Id { get; set; }
    public string DefaultAbbreviation { get; set; }
}