using System;

namespace mis321_pa2_ectew1
{
    public class Menu
    {
        public int GetCharacterUC()
        {
            System.Console.WriteLine("\nPlease select which character you'd like to join the fight with. \n1. Jack Sparrow \n2. Davy Jones \n3. Will Turner");
            int characterUC = int.Parse(Console.ReadLine()); //priming read
            while ((characterUC != 1) && (characterUC != 2) && (characterUC !=3))
            {
                System.Console.WriteLine("Sorry, invalid entry. Please try again.");
                characterUC = int.Parse(Console.ReadLine()); //update read
            }
            return characterUC;
        }
    }
}