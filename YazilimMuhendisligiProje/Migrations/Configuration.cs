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
            AutomaticMigrationsEnabled = true;//Fasle iken true yap�ld�.S�rekli migration ekleme i�ini otomatik yapmak i�in 
            AutomaticMigrationDataLossAllowed = false;
            ContextKey = "YazilimMuhendisligiProje.Dal.AppDbContext";//Context s�n�f�
        }
        protected override void Seed(Dal.AppDbContext db)
        {
            var appSeed = new AppSeed(db);
            base.Seed(db);
        }
    }
}
