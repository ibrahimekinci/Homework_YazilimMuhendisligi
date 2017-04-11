using System.Data.Entity;
using YazilimMuhendisligiProje.Models;

namespace YazilimMuhendisligiProje.Dal
{
    public class AppDbContext : AppDbContextSettings
    {
        public DbSet<TestItemModels> TestItem { get; set; }
    }
}
