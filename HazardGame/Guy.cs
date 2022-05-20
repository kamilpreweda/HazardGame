namespace HazardGame
{
    public class Guy
    {
        public string Name;
        public int Cash;

        public void WriteMyInfo()
        {
            Console.WriteLine($"{Name} ma {Cash} zł");
        }

        /// <summary>
        /// Przekazuje pieniądze i usuwa je z portfela ( lub wyświetla w konsoli komunikat o braku środków).
        /// </summary>
        /// <param name="amount">Przekazywana kwota.</param>
        /// <returns>Ilość pieniędzy wyjmowanych z portfela lub 0, jeśli dostępne środki są za małe (lub parametr amount jest nieprawidłowy.</returns>
        public int GiveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} mówi: {amount} nie jest poprawną kwotą.");
                return 0;
            }
            if (amount > Cash)
            {
                Console.WriteLine($"{Name} mówi: nie mam wystarczających środków, aby dać ci {amount} zł.");
                return 0;
            }
            Cash -= amount;
            return amount;
        }
        /// <summary>
        /// Przyjmuje pieniądze i dodaje je do portfela (lub wyświetla w konsoli komunikat o nieprawidłowej kwocie).
        /// </summary>
        /// <param name="amount">Przyjmowana kwota.</param>
        public void RecieveCash(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"{Name} mówi: nie przyjmę {amount} zł");
            }
            else
            {
                Cash += amount;
            }
        }
    }

}
