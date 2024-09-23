namespace ShutgunGame.Classes
{
    public partial class Shop : Form
    {
        int armorCost = 4000;
        int shotgunCost = 8000;
        public int money;
        Inventory inventory = new Inventory();
        public Shop(Inventory gameInventory, ref int playerMoney)
        {
            inventory = gameInventory;
            money = playerMoney;
            InitializeComponent();
            label5.Text = "Money: " + playerMoney + " $";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (money >= armorCost)
            {
                inventory.AddItem(("Armor"));
                money -= armorCost;
                MessageBox.Show("You bought armor");
            }
            else
            {
                MessageBox.Show("You don't have the money...");
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
            MessageBox.Show("Do you want to buy Shotgun?");
        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
    }
}
