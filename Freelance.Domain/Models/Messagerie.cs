namespace Freelance.Domain.Models;

public partial class Messagerie
{
    public int Id { get; set; }

    public int? ExpediteurId { get; set; }

    public int? DestinataireId { get; set; }

    public string? Msg { get; set; }

    public DateTime? DateMsg { get; set; }

    public virtual Candidat? Expediteur { get; set; }

    public virtual Entreprise? ExpediteurNavigation { get; set; }
}