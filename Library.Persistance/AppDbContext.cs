using Library.Domain.Entities;
using Library.Persistance.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Library.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BookEntity> Book { get; set; }
        public DbSet<AuthorEntity> Author { get; set; }
        public DbSet<ReaderEntity> Reader { get; set; }
        public DbSet<LibrarianEntity> Libraryan { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AuthorEntityConfiguration());
            builder.ApplyConfiguration(new BookEntityConfiguration());
            builder.ApplyConfiguration(new LibrarianEntityConfiguration());
            builder.ApplyConfiguration(new ReaderEntityConfiguration());

        }

    }
}