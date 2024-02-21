namespace Freelance.Domain.Models;

public partial class CompetenceOffre
{
    public int Id { get; set; }

    public int? IdCompetence { get; set; }

    public int? IdOffre { get; set; }

    public virtual Competence? IdCompetenceNavigation { get; set; }

    public virtual Offre? IdOffreNavigation { get; set; }
}