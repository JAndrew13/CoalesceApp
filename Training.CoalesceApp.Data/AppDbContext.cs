using Microsoft.EntityFrameworkCore;
using Training.CoalesceApp.Data.Models;

namespace Training.CoalesceApp.Data;

[Coalesce]
public class AppDbContext : DbContext
{
    public DbSet<ApplicationUser> ApplicationUsers => Set<ApplicationUser>();
    public DbSet<Organization> Organizations => Set<Organization>();
    public DbSet<Event> Events => Set<Event>();
    public DbSet<TriviaQuestion> TriviaQuestions => Set<TriviaQuestion>();
    public DbSet<TriviaAnswer> TriviaAnswers => Set<TriviaAnswer>();
    public DbSet<TriviaTag> TriviaTags => Set<TriviaTag>();
    public DbSet<TriviaQuestionTag> TriviaQuestionTags => Set<TriviaQuestionTag>();
    public DbSet<TriviaGuess> TriviaGuesses => Set<TriviaGuess>();

    public AppDbContext() { }

    public AppDbContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Remove cascading deletes.
        foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
        {
            relationship.DeleteBehavior = DeleteBehavior.Restrict;
        }
    }
}
