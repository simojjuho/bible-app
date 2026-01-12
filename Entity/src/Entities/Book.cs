using Entities.Interfaces;

namespace Entities.Entities;

public class Book : IBook
{
    public Guid Id { get; set; }
    public string DefaultAbbreviation { get; set; }
}