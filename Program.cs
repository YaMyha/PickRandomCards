using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();
            if (int.TryParse(line, out int numberOfCards))
            {
                // этот блок выполняется в том случае, если строка МОЖЕТ БЫТЬ преобразована в int
                // значение, сохраняемое в новой переменной, называется numberOfCards
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                // этот блок выполняется, если строка НЕ МОЖЕТ БЫТЬ преобразована в int
                Console.WriteLine("Число недействительно.");
            }
            

        }
    }
}
