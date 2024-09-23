using Microsoft.EntityFrameworkCore;

namespace MondayDemo.Api;

public class ChoreContext : DbContext
{
    public DbSet<Chore> Chores { get; set; }

    public ChoreContext(DbContextOptions option) : base(option)
    {
        
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        
        modelBuilder.Entity<Chore>().HasData(
            new Chore { Id = 1, Title = "Do the dishes", Description = "Wash the dishes in the sink", IsDone = false },
            new Chore { Id = 2, Title = "Walk the dog", Description = "Take the dog for a walk around the block", IsDone = false },
            new Chore { Id = 3, Title = "Buy groceries", Description = "Go to the store and buy groceries for the week", IsDone = false }
        );


    }
}
