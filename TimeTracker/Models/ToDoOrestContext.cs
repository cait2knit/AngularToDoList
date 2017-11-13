using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using TimeTracker.Models.Mapping;

namespace TimeTracker.Models
{
    public partial class ToDoOrestContext : DbContext
    {
        static ToDoOrestContext()
        {
            Database.SetInitializer<ToDoOrestContext>(null);
        }

        public ToDoOrestContext()
            : base("Name=ToDoOrestContext")
        {
        }

        public DbSet<ToDo> ToDoes { get; set; } //This is our table ToDo in sql database. 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ToDoMap());
        }
    }
}
