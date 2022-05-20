using HazardGame;

Random random = new Random();
double odds = 0.75;
Guy player = new Guy() { Name = "Gracz", Cash = 100 };

Console.WriteLine($"Witaj w kasynie! Prawdopodobieństwo przegranej: {odds}");
Console.WriteLine("Aby wyjść i zachować pieniądze, wciśnij Enter");

while (player.Cash > 0)
{
    
    player.WriteMyInfo();
    Console.Write("Stawiana kwota: ");
    string howMuch = Console.ReadLine();

    if (howMuch == "") return;

    if (int.TryParse(howMuch, out int amount))
    {
        int pot = 2 * amount;
        double chance = random.NextDouble();

        if ( chance > odds)
        {
            player.Cash += pot;
            Console.WriteLine($"Gratulacje! Wygrałeś {pot} złotych!");
        }
        else
        {
            player.Cash -= int.Parse(howMuch);
            Console.WriteLine($"Niestety przegrałeś swoje {howMuch} zł");
        }
    }
    else
    {
        Console.WriteLine("Wpisz poprawną kwotę.");
    }

}
Console.WriteLine("Niestety przegrałeś.");
Console.WriteLine("Kasyno zawsze wygrywa.");

    


