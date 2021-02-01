using System;
using ActorFactory;

public class Main
{
    private FixedActor _actor1;
    private MobileActor _actor2;

    // Constructor

    public static void Main()
    {
        // Créer les personnages dans la salle

        ActorFactory mobile = new Salle();
        Client world = new Client(mobile);

        // Créer les personnages dans la cuisine

        ActorFactory fixactor = new Cuisine();
        world = new Client(fixactor);

        // Wait for user input

        Console.ReadKey();
    }

    public Main(ActorFactory factory)
    {
        _actor2 = factory.CreateMobileActor();
        _actor1 = factory.CreateFixedActor();
    }
}
