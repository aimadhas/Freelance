namespace Freelance.Domain.Models;

public partial class ConsultaionProfil
{
    public int Id { get; set; }

    public int? IdCondidat { get; set; }

    public int? IdEntreprise { get; set; }

    public DateTime? DateConsultation { get; set; }

    public virtual Candidat? IdCondidatNavigation { get; set; }

    public virtual Entreprise? IdEntrepriseNavigation { get; set; }
}