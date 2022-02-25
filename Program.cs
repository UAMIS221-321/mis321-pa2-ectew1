//using Internal;
using System;
using mis321_pa2_ectew1.Interfaces;

namespace mis321_pa2_ectew1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("\nWelcome to the World's End Battle Game...");
            
            // Character jack = new JackSparrow();
            // Character davy = new DavyJones();
            // Character will = new WillTurner();

            Character player1 = new Character();
            Character player2 = new Character();

            player1 = SetUpPlayer(player1); //setting up player 1

            player2 = SetUpPlayer(player2); //setting up player 2

            System.Console.WriteLine("Let the battle begin!");

            Console.ReadKey();
            System.Console.WriteLine($"\nCharacter: {player1.CharacterName}\nMaxPower: {player1.MaxPower}\nHealth: {player1.Health}\nAttackStrength: {player1.AttackStrength}\nDefensivePower: {player1.DefensivePower}\nAttackBehavior: {player1.attackBehavior}");
            System.Console.WriteLine($"\nCharacter: {player2.CharacterName}\nMaxPower: {player2.MaxPower}\nHealth: {player2.Health}\nAttackStrength: {player2.AttackStrength}\nDefensivePower: {player2.DefensivePower}\nAttackBehavior: {player2.attackBehavior}");
            Console.ReadKey();
        }

        static Character SetUpPlayer(Character temp)
        {
            System.Console.WriteLine("\nEnter the player's name.");
            string playerName = Console.ReadLine();
            Menu menuChoice = new Menu();
            int characterUC = menuChoice.GetCharacterUC();
            Player newPlayer = new Player(){PlayerName = playerName};

            Random randomNum = new Random();
            int randomMaxPower = Character.GetMaxPower();

            switch(characterUC)
            {
                case 1:
                    temp = new JackSparrow(){CharacterName = "Jack Sparrow", MaxPower = randomMaxPower, Health = 100, AttackStrength = Character.GetAttackStrength(randomMaxPower), DefensivePower = Character.GetDefensivePower(randomMaxPower)};
                    break;
                case 2:
                    temp = new DavyJones(){CharacterName = "Davy Jones", MaxPower = randomMaxPower, Health = 100, AttackStrength = Character.GetAttackStrength(randomMaxPower), DefensivePower = Character.GetDefensivePower(randomMaxPower)};
                    break;
                case 3:
                    temp = new WillTurner(){CharacterName = "Will Turner", MaxPower = randomMaxPower, Health = 100, AttackStrength = Character.GetAttackStrength(randomMaxPower), DefensivePower = Character.GetDefensivePower(randomMaxPower)};
                    break;
            }
            return temp;

        }

        // static void MakeCharacter(int characterUC, Character temp)
        // {
        //     //Character temp = new Character();

        //     Random randomNum = new Random();
        //     int randomMaxPower = randomNum.Next(1,101);
        //     int randomAttackStrength = randomNum.Next(1, randomMaxPower);
        //     int randomDefensivePower = randomNum.Next(1, randomMaxPower);
        //     //to check myself...
        //     //System.Console.WriteLine($"{randomMaxPower}\t{randomAttackStrength}\t{randomDefensivePower}");


        //     switch(characterUC)
        //     {
        //         case 1:
        //             temp = MakeAJackSparrow(temp, randomMaxPower, randomAttackStrength, randomDefensivePower);
        //             break;
        //         case 2:
        //             temp = MakeADavyJones(randomMaxPower, randomAttackStrength, randomDefensivePower);
        //             break;
        //         case 3:
        //             temp = MakeAWillTurner(randomMaxPower, randomAttackStrength, randomDefensivePower);
        //             break;
        //     }
        // }

        // public static Character MakeAJackSparrow(Character temp, int randomMaxPower, int randomAttackStrength, int randomDefensivePower)
        // {
        //     Character newCharacter = new Character(){CharacterName = "Jack Sparrow", MaxPower = randomMaxPower, Health = 100, AttackStrength = randomAttackStrength, DefensivePower = randomDefensivePower};
        //     //temp.SetAttackBehavior(new JackSparrow());
        //     return newCharacter;
        // }

        // public static Character MakeADavyJones(int randomMaxPower, int randomAttackStrength, int randomDefensivePower)
        // {
        //     Character newCharacter = new DavyJones(){CharacterName = "Davy Jones", MaxPower = randomMaxPower, Health = 100, AttackStrength = randomAttackStrength, DefensivePower = randomDefensivePower};
        //     return newCharacter;
        // }

        // public static Character MakeAWillTurner(int randomMaxPower, int randomAttackStrength, int randomDefensivePower)
        // {
        //     Character newCharacter = new WillTurner(){CharacterName = "Will Turner", MaxPower = randomMaxPower, Health = 100, AttackStrength = randomAttackStrength, DefensivePower = randomDefensivePower};
        //     return newCharacter;
        // }
    }
}
