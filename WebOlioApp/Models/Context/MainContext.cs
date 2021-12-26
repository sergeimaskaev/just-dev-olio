using WebOlioApp.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace WebOlioApp.Models.Context
{
    public class MainContext : DbContext
    {
        public DbSet<TextRecord> TextRecords { get; }

        public MainContext(DbContextOptions<MainContext> options)
            : base(options)
        {
            TextRecords = Set<TextRecord>();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var textRecordBuilder = builder.Entity<TextRecord>();
            textRecordBuilder.ToTable("TextRecords");
            textRecordBuilder.HasKey(x => x.Id);
        }
    }
}
