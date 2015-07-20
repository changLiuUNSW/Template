using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using MyNgApp.Data.Models;

namespace MyNgApp.Data.DbContexts
{
    public class ResourceManagerEntities:DbContext
    {
        public ResourceManagerEntities() : base("DefaultConnection")
        {

        }

        public virtual DbSet<Holiday> Holidays { get; set; }
    }

    public class ResourceManagerDbInitializer : DropCreateDatabaseIfModelChanges<ResourceManagerEntities>
    {
        protected override void Seed(ResourceManagerEntities context)
        {
            try
            {
                context.Holidays.AddOrUpdate(l => l.Description, new Holiday
                {
                    Description = "Australia Day",
                    Date = new DateTime(2014, 1, 27)
                });
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (DbEntityValidationResult eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (DbValidationError ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Value: \"{1}\", Error: \"{2}\"",
                            ve.PropertyName,
                            eve.Entry.CurrentValues.GetValue<object>(ve.PropertyName),
                            ve.ErrorMessage);
                    }
                }
                throw;
            }
         
        }
    }
}
