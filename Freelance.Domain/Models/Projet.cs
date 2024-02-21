namespace Freelance.Domain.Models;

public partial class Projet
{
    public int Id { get; set; }

    public string? Nom { get; set; }

    public string? Description { get; set; }

    public int? IdCondidat { get; set; }

    public virtual Candidat? IdCondidatNavigation { get; set; }
}