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

            Character player1 = new Character();
            Character player2 = new Character();

            player1 = SetUpPlayer(); //setting up player 1

            player2 = SetUpPlayer(); //setting up player 2

            //to check myself...
            System.Console.WriteLine("\nHere are the players' starting stats...");
            System.Console.WriteLine($"\nPlayer: {player1.PlayerName}\nCharacter: {player1.CharacterName}\nMaxPower: {player1.MaxPower}\nHealth: {player1.Health}\nAttackStrength: {player1.AttackStrength}\nDefensivePower: {player1.DefensivePower}\nAttackBehavior: {player1.attackBehavior}");
            System.Console.WriteLine($"\nPlayer: {player2.PlayerName}\nCharacter: {player2.CharacterName}\nMaxPower: {player2.MaxPower}\nHealth: {player2.Health}\nAttackStrength: {player2.AttackStrength}\nDefensivePower: {player2.DefensivePower}\nAttackBehavior: {player2.attackBehavior}");
            
            bool p1First = GetFirstTurn();
            System.Console.WriteLine("\nLet the battle begin!");
            System.Threading.Thread.Sleep(2000);
            GamePlay(p1First, player1, player2);
            DisplayWinner(player1, player2);
        }

        static Character SetUpPlayer()
        {
            Character temp = new Character();
            
            System.Console.WriteLine("\nEnter the player's name.");
            string playerName = Console.ReadLine();
            Menu menuChoice = new Menu();
            int characterUC = menuChoice.GetCharacterUC();
            
            Random randomNum = new Random();
            int randomMaxPower = Character.GetMaxPower();

            switch(characterUC)
            {
                case 1:
                    temp = new JackSparrow(){PlayerName = playerName, CharacterName = "Jack Sparrow", MaxPower = randomMaxPower, Health = 100, AttackStrength = Character.GetAttackStrength(randomMaxPower), DefensivePower = Character.GetDefensivePower(randomMaxPower)};
                    break;
                case 2:
                    temp = new DavyJones(){PlayerName = playerName, CharacterName = "Davy Jones", MaxPower = randomMaxPower, Health = 100, AttackStrength = Character.GetAttackStrength(randomMaxPower), DefensivePower = Character.GetDefensivePower(randomMaxPower)};
                    break;
                case 3:
                    temp = new WillTurner(){PlayerName = playerName, CharacterName = "Will Turner", MaxPower = randomMaxPower, Health = 100, AttackStrength = Character.GetAttackStrength(randomMaxPower), DefensivePower = Character.GetDefensivePower(randomMaxPower)};
                    break;
            }
            return temp;
        }

        public static bool GetFirstTurn()
        {
            System.Console.WriteLine("\nNow, a dice will roll to decide which player gets to go first. \nIf the roll is even, player 1 will go first, but if the roll is odd, player 2 will go first.");
            Random randomNum = new Random();
            int firstTurn = randomNum.Next(1,7);
            System.Console.WriteLine("\nRolling...");
            System.Threading.Thread.Sleep(2000);
            string[] diceDisplay = {"___________________\n| \t \t  | \n| .\t \t  | \n| \t \t  | \n| \t \t  | \n| \t \t  | \n| \t \t  | \n|_________________|","___________________\n| \t \t  | \n| .\t \t  | \n| \t \t  | \n| \t \t  | \n| \t \t  | \n| \t \t. | \n|_________________|","___________________\n| \t \t  | \n| .\t \t  | \n| \t \t  | \n| \t. \t  | \n| \t \t  | \n| \t \t. | \n|_________________|", "___________________\n| \t \t  | \n| .\t \t. | \n| \t \t  | \n| \t \t  | \n| \t \t  | \n| .\t \t. | \n|_________________|","___________________\n| \t \t  | \n| .\t \t. | \n| \t \t  | \n| \t.\t  | \n| \t \t  | \n| .\t \t. | \n|_________________|","___________________\n| \t \t  | \n| .\t \t. | \n| \t \t  | \n| .\t \t. | \n| \t \t  | \n| .\t \t. | \n|_________________|"};
            int countDiceDisplay = 6;
            for (int i = 0; i < countDiceDisplay; i++)
            {
                if (i+1 == firstTurn)
                {
                    System.Console.WriteLine(diceDisplay[i]);
                }
            }
            bool p1First = false;
            if((firstTurn == 2) || (firstTurn == 4) || (firstTurn == 6))
            {
                p1First = true;
                System.Console.WriteLine("\nPlayer 1 will go first.");
            }
            else
            {
                System.Console.WriteLine("\nPlayer 2 will go first.");
            }
            return p1First;
        }

        public static void GamePlay(bool p1First, Character player1, Character player2)
        {
            //continous loop for game play until one player runs out of health
            while((player1.Health > 0) && (player2.Health > 0))
            {
                System.Threading.Thread.Sleep(2000);
                if(p1First == true)
                {
                    player1.attackBehavior.Attack();
                    //player2.defendBehavior.Defend();
                    DamageControl(p1First, player1, player2);
                    p1First = false; //to let player2 go first next time
                }
                else
                {
                    player2.attackBehavior.Attack();
                    //player1.defendBehavior.Defend();
                    DamageControl(p1First, player1, player2);
                    p1First = true; //to let player1 go first next time
                }
                //re-setting the players' attack strength & defensive power for each turn, but max power for whole round stays the same
                player1.AttackStrength = Character.GetAttackStrength(player1.MaxPower);
                player2.AttackStrength = Character.GetAttackStrength(player2.MaxPower);
                player1.DefensivePower = Character.GetDefensivePower(player1.MaxPower);
                player2.DefensivePower = Character.GetDefensivePower(player2.MaxPower);
                // System.Console.WriteLine($"\nHere is the new stats for the next battle round. \nPlayer 1 \nAttack Strength: {player1.AttackStrength} \nDefensive Power: {player1.DefensivePower}");
                // System.Console.WriteLine($"\nPlayer 2 \nAttack Strength: {player2.AttackStrength} \nDefensive Power: {player2.DefensivePower}");
            }
        }

        public static void DamageControl(bool p1First, Character player1, Character player2)
        {
            double typeBonus = 1;
            if(p1First == true)
            {
                if(((player1.CharacterName == "Jack Sparrow") && (player2.CharacterName == "Will Turner")) || ((player1.PlayerName == "Will Turner") && (player2.PlayerName == "Davy Jones")) || ((player1.PlayerName == "Davy Jones") && (player2.PlayerName == "Jack Sparrow")))
                {
                    System.Console.WriteLine($"{player1.CharacterName}'s attack was 20% more effective!");
                    typeBonus = 1.2;
                }
                double damageDealt = ((player1.AttackStrength - player2.DefensivePower) * (typeBonus));
                if(damageDealt > 0)
                {
                    player2.Health -= damageDealt;
                    System.Console.WriteLine($"Player 2's damage: -{Math.Round(damageDealt, 2)}");
                }
                else if(damageDealt < 0)
                {
                    System.Console.WriteLine("Oop, looks like Player 2 fenced off this round of attack. Let's move on.");
                }
            }
            else
            {
                if(((player2.CharacterName == "Jack Sparrow") && (player1.CharacterName == "Will Turner")) || ((player2.PlayerName == "Will Turner") && (player1.PlayerName == "Davy Jones")) || ((player2.PlayerName == "Davy Jones") && (player1.PlayerName == "Jack Sparrow")))
                {
                    System.Console.WriteLine($"{player2.CharacterName}'s attack was 20% more effective!");
                    typeBonus = 1.2;
                }
                double damageDealt = ((player1.AttackStrength - player2.DefensivePower) * (typeBonus));
                if(damageDealt > 0)
                {
                    player1.Health -= damageDealt;
                    System.Console.WriteLine($"Player 1's damage: -{Math.Round(damageDealt, 2)}");
                }
                else if(damageDealt < 0)
                {
                    System.Console.WriteLine("Oop, looks like Player 1 fenced off this round of attack. Let's move on.");
                }
            }
            ViewStats(player1, player2);
        }

        public static void ViewStats(Character player1, Character player2)
        {
            System.Console.WriteLine("\nCalibrating the stats...");
            System.Threading.Thread.Sleep(2000);
            System.Console.WriteLine($"\nP1: {player1.PlayerName} & {player1.CharacterName}\nHealth: {Math.Round(player1.Health, 2)}");
            System.Console.WriteLine($"\nP2: {player2.PlayerName} & {player2.CharacterName}\nHealth: {Math.Round(player2.Health, 2)}");
        }

        public static void DisplayWinner(Character player1, Character player2)
        {
            System.Console.WriteLine("\nAnd the winner is...");
            System.Threading.Thread.Sleep(2000);
            if(player1.Health > 0)
            {
                System.Console.WriteLine($"\nPlayer 1 Wins!!! Congrats {player1.PlayerName} & {player1.CharacterName}!\n");
            }
            else if(player2.Health > 0)
            {
                System.Console.WriteLine($"Player 2 Wins!!! Congrats {player2.PlayerName} & {player2.CharacterName}!\n");
            }
        }
    }
}
