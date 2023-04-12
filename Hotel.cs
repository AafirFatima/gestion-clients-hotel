
using System.Collections.Generic;

public class Hotel
{
    public List<Client> Clients { get; set; }

    public Hotel()
    {
        Clients = new List<Client>();
    }

    public void AjouterClient(Client client)
    {
        Clients.Add(client);
    }
}

