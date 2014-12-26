using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace user_define_with_account_transaction
{
    
    public partial class Form1 : Form
    {

        private account accoUnt = null;
        private double amount;
        public Form1()
        {
            InitializeComponent();
        }
       
        
        private void createButton_Click(object sender, EventArgs e)
        {
            accoUnt = new account();
            accoUnt.name = acc_nametextBox.Text;
            accoUnt.number = acc_numbertextBox.Text;
            MessageBox.Show("Your account create done");
        }

        private void dipositeButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(balancetextBox.Text);
            MessageBox.Show(accoUnt.diposite(amount));
        }

        private void withdrewButton_Click(object sender, EventArgs e)
        {
            amount = Convert.ToDouble(balancetextBox.Text);
            MessageBox.Show(accoUnt.withdrew(amount));

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(accoUnt.name + "Your account Number" + accoUnt.number + "And Balance " + accoUnt.balance +
                            "Taka");
        }
    }
}
