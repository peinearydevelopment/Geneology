using Microsoft.EntityFrameworkCore;

namespace Geneology
{
    public partial class GeneologyDbContext : DbContext
    {
        public virtual DbSet<AuditRecord> AuditRecords { get; set; }
        public virtual DbSet<EnglishName> EnglishNames { get; set; }
        public virtual DbSet<HebrewName> HebrewNames { get; set; }
        public virtual DbSet<Individual> Individuals { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<RelationshipEvent> RelationshipEvents { get; set; }
        public virtual DbSet<SignificantEvent> SignificantEvents { get; set; }
        public virtual DbSet<SupportingDocument> SupportingDocuments { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuiler)
        {
            optionsBuiler.UseSqlServer(@"Server=ZACKPEINE\SANDBOX;Database=Genealogy;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Relationship>()
                        .HasKey(r => new { r.Individual1Id, r.Individual2Id });

            modelBuilder.Entity<Relationship>()
                        .HasOne(r => r.Individual1)
                        .WithMany(r => r.Relationships1)
                        .HasForeignKey(r => r.Individual1Id)
                        .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<Relationship>()
                        .HasOne(r => r.Individual2)
                        .WithMany(r => r.Relationships2)
                        .HasForeignKey(r => r.Individual2Id)
                        .OnDelete(Microsoft.EntityFrameworkCore.Metadata.DeleteBehavior.Restrict);

            modelBuilder.Entity<SignificantEventLocation>()
                        .HasKey(sel => new { sel.SignificantEventId, sel.LocationId});

            modelBuilder.Entity<SignificantEventLocation>()
                        .HasOne(sel => sel.SignificantEvent)
                        .WithMany(sel => sel.Locations)
                        .HasForeignKey(sel => sel.SignificantEventId);

            modelBuilder.Entity<SignificantEventLocation>()
                        .HasOne(sel => sel.Location)
                        .WithMany(sel => sel.SignificantEvents)
                        .HasForeignKey(sel => sel.LocationId);

            modelBuilder.Entity<SignificantEventIndividual>()
                        .HasKey(sei => new { sei.SignificantEventId, sei.IndividualId });

            modelBuilder.Entity<SignificantEventIndividual>()
                        .HasOne(sei => sei.SignificantEvent)
                        .WithMany(sei => sei.Individuals)
                        .HasForeignKey(sei => sei.SignificantEventId);

            modelBuilder.Entity<SignificantEventIndividual>()
                        .HasOne(sei => sei.Individual)
                        .WithMany(sei => sei.SignificantEvents)
                        .HasForeignKey(sei => sei.IndividualId);

            modelBuilder.Entity<IndividualLocation>()
                        .HasKey(il => new { il.IndividualId, il.LocationId});

            modelBuilder.Entity<IndividualLocation>()
                        .HasOne(il => il.Individual)
                        .WithMany(il => il.Locations)
                        .HasForeignKey(il => il.IndividualId);

            modelBuilder.Entity<IndividualLocation>()
                        .HasOne(il => il.Location)
                        .WithMany(il => il.Individuals)
                        .HasForeignKey(il => il.LocationId);

            modelBuilder.Entity<EnglishNameSupportingDocument>()
                        .HasKey(ensd => new { ensd.EnglishNameId, ensd.SupportingDocumentId });

            modelBuilder.Entity<EnglishNameSupportingDocument>()
                        .HasOne(ensd => ensd.EnglishName)
                        .WithMany(ensd => ensd.SupportingDocuments)
                        .HasForeignKey(ensd => ensd.EnglishNameId);

            modelBuilder.Entity<EnglishNameSupportingDocument>()
                        .HasOne(ensd => ensd.SupportingDocument)
                        .WithMany(ensd => ensd.EnglishNames)
                        .HasForeignKey(ensd => ensd.SupportingDocumentId);

            modelBuilder.Entity<HebrewNameSupportingDocument>()
                        .HasKey(hnsd => new { hnsd.HebrewNameId, hnsd.SupportingDocumentId });

            modelBuilder.Entity<HebrewNameSupportingDocument>()
                        .HasOne(hnsd => hnsd.HebrewName)
                        .WithMany(hnsd => hnsd.SupportingDocuments)
                        .HasForeignKey(hnsd => hnsd.HebrewNameId);

            modelBuilder.Entity<HebrewNameSupportingDocument>()
                        .HasOne(hnsd => hnsd.SupportingDocument)
                        .WithMany(hnsd => hnsd.HebrewNames)
                        .HasForeignKey(hnsd => hnsd.SupportingDocumentId);

            modelBuilder.Entity<IndividualSupportingDocument>()
                        .HasKey(isd => new { isd.IndividualId, isd.SupportingDocumentId });

            modelBuilder.Entity<IndividualSupportingDocument>()
                        .HasOne(isd => isd.Individual)
                        .WithMany(isd => isd.SupportingDocuments)
                        .HasForeignKey(isd => isd.IndividualId);

            modelBuilder.Entity<IndividualSupportingDocument>()
                        .HasOne(isd => isd.SupportingDocument)
                        .WithMany(isd => isd.Individuals)
                        .HasForeignKey(isd => isd.SupportingDocumentId);

            modelBuilder.Entity<LocationSupportingDocument>()
                        .HasKey(lsd => new { lsd.LocationId, lsd.SupportingDocumentId });

            modelBuilder.Entity<LocationSupportingDocument>()
                        .HasOne(lsd => lsd.Location)
                        .WithMany(lsd => lsd.SupportingDocuments)
                        .HasForeignKey(lsd => lsd.LocationId);

            modelBuilder.Entity<LocationSupportingDocument>()
                        .HasOne(lsd => lsd.SupportingDocument)
                        .WithMany(lsd => lsd.Locations)
                        .HasForeignKey(lsd => lsd.SupportingDocumentId);

            modelBuilder.Entity<SignificantEventSupportingDocument>()
                        .HasKey(sesd => new { sesd.SignificantEventId, sesd.SupportingDocumentId });

            modelBuilder.Entity<SignificantEventSupportingDocument>()
                        .HasOne(sesd => sesd.SignificantEvent)
                        .WithMany(sesd => sesd.SupportingDocuments)
                        .HasForeignKey(sesd => sesd.SignificantEventId);

            modelBuilder.Entity<SignificantEventSupportingDocument>()
                        .HasOne(sesd => sesd.SupportingDocument)
                        .WithMany(sesd => sesd.SignificantEvents)
                        .HasForeignKey(sesd => sesd.SupportingDocumentId);

            modelBuilder.Entity<RelationshipEventSupportingDocument>()
                        .HasKey(resd => new { resd.RelationshipEventId, resd.SupportingDocumentId });

            modelBuilder.Entity<RelationshipEventSupportingDocument>()
                        .HasOne(resd => resd.RelationshipEvent)
                        .WithMany(resd => resd.SupportingDocuments)
                        .HasForeignKey(resd => resd.RelationshipEventId);

            modelBuilder.Entity<RelationshipEventSupportingDocument>()
                        .HasOne(resd => resd.SupportingDocument)
                        .WithMany(resd => resd.RelationshipEvents)
                        .HasForeignKey(resd => resd.SupportingDocumentId);
        }
    }
}
