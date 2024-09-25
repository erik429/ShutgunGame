using ShutgunGame.Classes;
using System.Text;

namespace ShutgunGame
{
    public class Game
    {
        Player player = new Player();
        public Inventory inventory;
        Computer computer;
        public bool LostGame { get; set; }
        public bool WonGame { get; set; }
        public bool LostRound { get; set; }
        public int AIchoice { get; set; }
        public int Round { get; set; }
        public bool ShotGunReady { get; set; }
        public bool coinflipped { get; set; }
        public Game()
        {
            inventory = new Inventory();
            computer = new Computer(player);
            Round = 0;
        }
        public void NewGame()
        {
            Round = 0;
            WonGame = false;
            coinflipped = false;
            LostGame = false;
            LostRound = false;
            ShotGunReady = false;
            AIchoice = 0;
            player.Bullets = 0;
            computer.AIBullets = 0;
        }
        public bool CanShotgun()
        {
            if (computer.AIBullets == 3) return true;
            return false;
        }
        public bool CheckArmor()
        {
            if (inventory.HasItem("Armor"))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public bool CheckShotgun()
        {
            if (inventory.HasItem("Shotgun"))
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public void RemoveArmor()
        {
            inventory.removeItem("Armor");
        }
        public string PlayGame(int playerchoice)
        {
            if (computer.CanShotgun())
            {
                ShotGunReady = true;
                if (player.Bullets < 3)
                {
                    LostGame = true;
                }
            }
            StringBuilder gameResult = new StringBuilder();
            AIchoice = computer.AIChoice();
            if (playerchoice == 1)
            {
                if (player.CanShoot() == true)
                {
                    if (AIchoice == 1)
                    {
                        player.Shoot();
                        computer.Shoot();
                        LostRound = false;
                        gameResult.AppendLine("You both shot and lost 1 bullet.");
                    }
                    if (AIchoice == 2)
                    {
                        LostRound = false;
                        WonGame = true;
                    }
                    if (AIchoice == 3)
                    {
                        player.Shoot();
                        LostRound = true;
                        gameResult.AppendLine("You shot and AI blocked, you lost 1 bullet.");
                    }
                }
                else
                {
                    gameResult.AppendLine("You can't shoot. You have no bullets.");
                }
            }
            if (playerchoice == 2)
            {
                if (AIchoice == 1)
                {
                    if (inventory.HasItem("Armor"))
                    {
                        gameResult.AppendLine("AI shot, and you reloaded. But you had Armor! \n -1 Armor");
                    }
                    else
                    {
                        LostRound = true;
                        LostGame = true;
                        gameResult.AppendLine("AI shot, and you reloaded. YOU LOST THE GAME");
                    }

                }
                if (AIchoice == 2)
                {
                    computer.Reload();
                    player.Reload();
                    LostRound = false;
                    gameResult.AppendLine("You both reloaded, you both gained 1 bullet.");
                }
                if (AIchoice == 3)
                {
                    player.Reload();
                    LostRound = false;
                    gameResult.AppendLine("You reloaded, AI blocked. You gained 1 bullet.");
                }

            }
            if (playerchoice == 3)
            {
                if (AIchoice == 1)
                {
                    LostRound = false;
                    gameResult.AppendLine("You blocked, and AI shot. AI lost 1 bullet.");
                    computer.Shoot();
                }
                if (AIchoice == 2)
                {
                    LostRound = true;
                    gameResult.AppendLine("You blocked, and AI reloaded. AI gained 1 bullet.");
                    computer.Reload();
                }
                if (AIchoice == 3)
                {
                    LostRound = false;
                    gameResult.AppendLine("You both blocked, nothing happens.");
                }
            }
            Round++;
            if (CanShotgun() && playerchoice != 4 && player.Bullets != 3)
            {
                if (!CheckShotgun())
                {
                    LostGame = true;
                    inventory.RemoveAllItems();
                    return "AI got shotgun. You lost";
                }
                else
                {
                    computer.AIBullets -= 1;
                    inventory.removeItem("Shotgun");
                    return "AI got shotgun! \n But you had shotgun item. AI lost 1 bullet!";
                }

                
            }
            else if(CanShotgun() && playerchoice == 4)
                {
                    coinflipped = true;
                    Random coinflip = new Random();
                    int coin = coinflip.Next(1,3);
                    if(coin == 1)
                    {
                        WonGame = true;
                        return "You won the coinflip!";
                    }
                    else
                    {
                    if (!CheckShotgun())
                    {
                        LostGame = true;
                        inventory.RemoveAllItems();
                        return "You lost the coinflip!";
                    }
                    else
                    {
                        WonGame = true;
                        inventory.removeItem("Shotgun");
                        return "You lost the coinflip! \n But you had shotgun item. AI lost 1 bullet";
                    }
                    }  
                }
            else if (playerchoice == 4)
            {
                WonGame = true; 
                return "You got the Shotgun!";
            }
            return gameResult.ToString();
        }
        public string GetBullet()
        {
            return player.Bullets.ToString();
        }
        public string GetComputer()
        {
            return computer.AIBullets.ToString();
        }
    }
}
