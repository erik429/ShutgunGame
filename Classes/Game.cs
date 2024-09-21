using System.Text;

namespace ShutgunGame
{
    public class Game
    {
        GameResult result = new GameResult();
        Player player = new Player();
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
                    LostRound = true;
                    LostGame = true;
                    gameResult.AppendLine("AI shot, and you reloaded. YOU LOST THE GAME");
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
                LostGame = true;
                return "Computer got shotgun. You lost";
                
            }
            else
            {
                if (CanShotgun() && playerchoice == 4)
                {
                    coinflipped = true;
                    Random coinflip = new Random();
                    int coin = coinflip.Next(1,3);
                    if(coin == 1)
                    {
                        WonGame = true;
                        return "You won the coinflip!";
                    }
                    LostGame = true;
                    return "You lost the coinflip!";
                    
                }
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
