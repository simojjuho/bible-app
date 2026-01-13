using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database.Models;

public class BibleContext : DbContext
{
    public DbSet<ITranslation> Translations { get; set; }
    public DbSet<IBook> Books { get; set; }
    public DbSet<IVerse> Verses { get; set; }
    public DbSet<IReference>  References { get; set; }
    public DbSet<IBookName>  BookNames { get; set; }
    public DbSet<IDevotional> Devotionals { get; set; }
    public DbSet<IDevotionalContent> DevotionalContents { get; set; }
    
    
}