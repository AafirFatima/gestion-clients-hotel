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
    public void ModifierPrenom(string nouveauPrenom)
    {
        Prenom = nouveauPrenom;
    }
    public void ModifierCourriel(string nouveauCourriel)
    {
        Courriel = nouveauCourriel;
    }
    public void AfficherInfosClient()
    {
        Console.WriteLine($"Nom: {Nom}, Prénom: {Prenom}, Courriel: {Courriel}, Carte de crédit: {CarteCredit}, Numéro de chambre: {NumeroChambre}");
    }


}
