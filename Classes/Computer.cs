namespace ShutgunGame
{

    public class Computer
    {
        private Player player;
        public int AIBullets { get; set; }
        public Computer(Player player2)
        {
            player = player2;
            AIBullets = 0;
        }
        public void Reload()
        {
            AIBullets++;
        }
        public void Shoot()
        {
            AIBullets--;
        }
        public bool CanShoot()
        {
            if (AIBullets <= 0) return false;
            if (AIBullets > 0) return true;
            else
            {
                return false;
            }
        }
        public bool CanShotgun()
        {
            if(AIBullets == 3) return true;
            return false;
        }
        public int AIChoice()
        {
            if (player.Bullets == 0 && AIBullets == 0)
            {
                return 2;
            }
            else
            {
                Random choice = new Random();
                if (CanShoot() == true)
                {
                    int result = choice.Next(1, 4);
                    return result;

                }
                else if(AIBullets >= 1)
                {
                    int result = choice.Next(1, 3);
                    return result;
                } 
                else
                {
                    int result = choice.Next(2, 4);
                    return result;
                }
            }
        }
    }
}
