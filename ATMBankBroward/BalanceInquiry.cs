using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATMBankBroward
{
    public partial class BalanceInquiry : Form
    {
        public BalanceInquiry(string cName, string cAccNum, string sAccNum, double cBalance, double sBalance)
        {
            InitializeComponent();

            //Initialize controls
            lblClientName.Text = cName;
            lblCheckingAccNumber.Text = cAccNum;
            lblSavingsAccNumber.Text = sAccNum;
            lblCheckingBalance.Text = cBalance.ToString("c");
            lblSavingsBalance.Text = sBalance.ToString("c");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
