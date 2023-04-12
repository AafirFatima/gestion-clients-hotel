using System;

class Program
{
    static void Main()
    {
        Hotel hotel = new Hotel();

        Client client1 = new Client("Doe", "John", "john.doe@email.com", "1234 5678 9012 3456", 101);
        hotel.AjouterClient(client1);

        Client client2 = new Client("Smith", "Jane", "jane.smith@email.com", "2345 6789 0123 4567", 102);
        hotel.AjouterClient(client2);

        foreach (Client client in hotel.Clients)
        {
            Console.WriteLine($"Nom : {client.Nom}, Prénom : {client.Prenom}, Courriel : {client.Courriel}, Carte de crédit : {client.CarteCredit}, Numéro de chambre : {client.NumeroChambre}");
        }
    }
}

