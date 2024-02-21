using Freelance.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Freelance.Infrastructure;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        //SeedRoles(modelBuilder);
       
    }

    public virtual DbSet<Competence> Competences { get; set; }

    public virtual DbSet<CompetenceOffre> CompetenceOffres { get; set; }

    public virtual DbSet<ComptenceDmExpertise> ComptenceDmExpertises { get; set; }
    public virtual DbSet<Candidat> Condidats { get; set; }

    public virtual DbSet<CondidatComp> CondidatComps { get; set; }

    public virtual DbSet<ConsultaionProfil> ConsultaionProfils { get; set; }

    public virtual DbSet<DomaineExpertise> DomaineExpertises { get; set; }

    public virtual DbSet<Entreprise> Entreprises { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<Formation> Formations { get; set; }

    public virtual DbSet<Messagerie> Messageries { get; set; }

    public virtual DbSet<Offre> Offres { get; set; }
    public virtual DbSet<Projet> Projets { get; set; }

    private static void SeedRoles(ModelBuilder builder)
    {
        builder.Entity<IdentityRole>().HasData
            (
            new IdentityRole() { Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "ADMIN" },
            new IdentityRole() { Name = "Candidat", ConcurrencyStamp = "2", NormalizedName = "CANDIDAT" },
            new IdentityRole() { Name = "Entreprise", ConcurrencyStamp = "3", NormalizedName = "ENTREPRISE" }
            );
    }
}
