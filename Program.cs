using System;
using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\nWelcome to the World's End Battle Game... Let the games begin!");
            
            PlayWith2();

            //generating all of the the random numbers needed & then passing them into the new Character object
            Random randomNum = new Random();
            int randomMaxPower = randomNum.Next(1,101);
            Character newCharacter = new Character(){Name = player1Character, MaxPower = Character.GetMaxPower(), Health = 100, AttackStrength = Character.GetAttackStrength(MaxPower), DefensivePower = Character.GetDefensivePower(newCharacter.MaxPower)};

            //checking myself...
            System.Console.WriteLine($"{newCharacter.Name}\n{newCharacter.MaxPower}\n{newCharacter.Health}\n{newCharacter.AttackStrength}\n{newCharacter.DefensivePower}");

            switch(characterUC)
            {
                case 1:
                    IAttack jack = new DistractBehavior();
                    break;
                case 2:
                    IAttack davy = new CannonBehavior();
                    break;
                case 3:
                    IAttack will = new SwordBehavior();
                    break;
            }
        }

        static void PlayWith2()
        {
            Menu menuChoice = new Menu();
            int characterUC = menuChoice.GetCharacterUC();
            System.Console.WriteLine("First, please enter player 1's name.");
            string player1 = Console.ReadLine();
            int player1Character = menuChoice.GetCharacterUC();
            ConvertCharacterChoice(player1Character);
            MakeCharacter();

            System.Console.WriteLine("Enter player 2's name.");
            string player2 = Console.ReadLine();
            int player2Character = menuChoice.GetCharacterUC();
        }

        static void MakeCharacter()
        {
            Character newCharacter = new Character();
            //newCharacter.Name = 
        }
    }
}
