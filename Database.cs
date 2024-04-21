namespace APBD4_envRD;

public static class Database
{
    public static List<Animal> Animals { get; set; } = new List<Animal>();
    public static List<Visit> Visits { get; set; } = new List<Visit>();

    static Database()
    {
        // Dodaj kilka przykładowych zwierząt
        Animals.Add(new Animal { Id = 1, Name = "Max", Category = "Pies", Weight = 30.5, FurColor = "Czarny" });
        Animals.Add(new Animal { Id = 2, Name = "Mia", Category = "Kot", Weight = 5.2, FurColor = "Biały" });

        // Dodaj kilka przykładowych wizyt
        Visits.Add(new Visit { Id = 1, AnimalId = 1, VisitDate = DateTime.Now, Description = "Szczepienie", Cost = 150.00m });
        Visits.Add(new Visit { Id = 2, AnimalId = 2, VisitDate = DateTime.Now.AddDays(-1), Description = "Kontrola", Cost = 100.00m });
    }
}