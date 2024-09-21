namespace ShutgunGame
{

    public class Player
    {
        public int Bullets { get; set; }
        public Player()
        {
            Bullets = 0;
        }
        public void Reload()
        {
            Bullets++;
        }
        public void Shoot()
        {
            Bullets--;
        }
        public bool CanShoot()
        {
            if (Bullets <= 0) return false;
            if (Bullets > 0) return true;
            else
            {
                return false;
            }
        }
    }
}
