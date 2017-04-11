namespace YazilimMuhendisligiProje.Migrations
{
    using Dal;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<YazilimMuhendisligiProje.Dal.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;//Fasle iken true yapýldý.Sürekli migration ekleme iþini otomatik yapmak için 
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "YazilimMuhendisligiProje.Dal.AppDbContext";//Context sýnýfý
        }
        protected override void Seed(Dal.AppDbContext db)
        {
            var appSeed = new AppSeed(db);
            base.Seed(db);
        }
    }
}
