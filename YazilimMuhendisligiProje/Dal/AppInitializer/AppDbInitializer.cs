using System.Data.Entity;

namespace YazilimMuhendisligiProje.Dal
{
    public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
    {
        public override void InitializeDatabase(AppDbContext db)
        {
            base.InitializeDatabase(db);
        }
        protected override void Seed(AppDbContext db)
        {
            var appSeed = new AppSeed(db);
            base.Seed(db);
        }
    }
}