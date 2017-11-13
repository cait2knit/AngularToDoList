using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace TimeTracker.Models.Mapping
{
    public class ToDoMap : EntityTypeConfiguration<ToDo>
    {
        public ToDoMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("ToDo");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.IsCompleted).HasColumnName("IsCompleted");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.EndDate).HasColumnName("EndDate");
            this.Property(t => t.MinutesSpent).HasColumnName("MinutesSpent");
            this.Property(t => t.Priority).HasColumnName("Priority");
        }
    }
}
