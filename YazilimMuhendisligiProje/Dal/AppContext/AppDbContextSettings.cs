using System.Data.Entity;
using YazilimMuhendisligiProje.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Data.Entity.Infrastructure;

namespace YazilimMuhendisligiProje.Dal
{
    public class AppDbContextSettings : IdentityDbContext<ApplicationUser>
    {
        //static AppDbContextSettings()
        //{
        //    Database.SetInitializer<AppDbContext>(new DropCreateDatabaseAlways<AppDbContext>());
        //}
        //identity Başla
        public AppDbContextSettings() : base(AppConnection.DefaultConnection.Value, throwIfV1Schema: false)
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<AppDbContext>());
            Database.SetInitializer(new AppDbInitializer());
        }
        public static AppDbContext Create() { return new AppDbContext(); }

        //veri tabanında oluşturulan tabloların sonuna otomatik gelen "s" takısının eklenmesini engeller
        // protected override void OnModelCreating(DbModelBuilder modelBuilder) { modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>(); }
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                .SelectMany(x => x.ValidationErrors)
                .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new System.Data.Entity.Validation.DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
        /////save 
    }
}
