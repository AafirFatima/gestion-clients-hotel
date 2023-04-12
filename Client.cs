public class Client
{
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public string Courriel { get; set; }
    public string CarteCredit { get; set; }
    public int NumeroChambre { get; set; }

    public Client(string nom, string prenom, string courriel, string carteCredit, int numeroChambre)
    {
        Nom = nom;
        Prenom = prenom;
        Courriel = courriel;
        CarteCredit = carteCredit;
        NumeroChambre = numeroChambre;
    }
    // Ajout d'une méthode pour modifier une propriété
    public void ModifierNom(string nouveauNom)
    {
        Nom = nouveauNom;
        
  
    }
}
