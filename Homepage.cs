namespace Mohamed_Mahfouz_Inventory_System
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
            HomepageInitialize();
        }


        public void HomepageInitialize()
        {
            Inventory.ExistingItems();

            var boundPart = new BindingSource();
            boundPart.DataSource = Inventory.Parts;
            partsTable.DataSource = boundPart;

            partsTable.Columns["partID"].HeaderText = "Part ID";
            partsTable.Columns["partName"].HeaderText = "Name";
            partsTable.Columns["partInv"].HeaderText = "Inventory";
            partsTable.Columns["partPrice"].HeaderText = "Price";
            partsTable.Columns["partMin"].HeaderText = "Min";
            partsTable.Columns["partMax"].HeaderText = "Max";

            var boundProd = new BindingSource();
            boundProd.DataSource = Inventory.Products;
            prodTable.DataSource = boundProd;

            prodTable.Columns["prodID"].HeaderText = "Product ID";
            prodTable.Columns["prodName"].HeaderText = "Name";
            prodTable.Columns["prodInv"].HeaderText = "Inventory";
            prodTable.Columns["prodPrice"].HeaderText = "Price";
            prodTable.Columns["prodMin"].HeaderText = "Min";
            prodTable.Columns["prodMax"].HeaderText = "Max";

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}