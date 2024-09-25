namespace ShutgunGame.Classes
{
    public partial class Shop : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        int armorCost = 3000;
        int shotgunCost = 5000;
        public int money;
        Inventory inventory = new Inventory();
        public Shop(Inventory gameInventory, ref int playerMoney)
        {
            inventory = gameInventory;
            money = playerMoney;
            InitializeComponent();
            label5.Text = "Money: " + playerMoney + " $";
        }
        private void PlaySound(string sound)
        {
            player.URL = sound;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= armorCost)
            {
                inventory.AddItem(("Armor"));
                money -= armorCost;
                label5.Text = "Money: " + money + " $";
                PlaySound(@"C:\Demo\equiparmor.mp3");
            }
            else
            {
                MessageBox.Show("You can't afford this item");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (money >= shotgunCost)
            {
                inventory.AddItem(("Shotgun"));
                money -= shotgunCost;
                label5.Text = "Money: " + money + " $";
                PlaySound(@"C:\Demo\shotgunreload.mp3");
            }
            else
            {
                MessageBox.Show("You can't afford this item");
            }
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
    }
}
