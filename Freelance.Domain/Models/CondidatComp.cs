namespace Freelance.Domain.Models;

public partial class CondidatComp
{
    public int Id { get; set; }

    public string? Niveau { get; set; }

    public int? IdComp { get; set; }

    public int? IdCond { get; set; }

    public virtual Competence? IdCompNavigation { get; set; }

    public virtual Candidat? IdCondNavigation { get; set; }
}