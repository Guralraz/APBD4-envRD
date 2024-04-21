namespace APBD4_envRD;

public class Visit
{
    public int Id { get; set; }
    public DateTime VisitDate { get; set; }
    public int AnimalId { get; set; }
    public string Description { get; set; }
    public decimal Cost { get; set; }

    // Relacja z Animal - opcjonalnie, jeśli używasz ORM jak Entity Framework
    public Animal Animal { get; set; }
}