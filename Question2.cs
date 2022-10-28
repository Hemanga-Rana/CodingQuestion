using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string name;
        int price;
        int tot;
        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                name = "Fried Rice";
                int qty = int.Parse(numericUpDown1.Text);
                price = 23;
                 tot = qty * price;
                 this.dataGridView1.Rows.Add(name, price, qty, tot);
 
            }
            if (checkBox2.Checked)
            {
                name = "Chicken";
                int qty = int.Parse(numericUpDown2.Text);
                 price = 15;
                 tot = qty * price;
                 this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
 
            
 
            if (checkBox3.Checked)
            {
                name = "Fish";
                int qty = int.Parse(numericUpDown3.Text);
               price = 25;
               tot = qty * price;
               this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
 
 
            if (checkBox4.Checked)
            {
                name = "Orange Juice";
                int qty = int.Parse(numericUpDown6.Text);
                price = 35;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
 
 
            if (checkBox5.Checked)
            {
                name = "Coffee";
                int qty = int.Parse(numericUpDown5.Text);
                price = 50;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
 
            if (checkBox6.Checked)
            {
                name = "Tea";
                int qty = int.Parse(numericUpDown4.Text);
                price = 10;
                tot = qty * price;
                this.dataGridView1.Rows.Add(name, price, qty, tot);
            }
 
 
 
            int sum = 0;
 
            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }
 
            txtsum.Text = sum.ToString();
        }
    }
}