using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATMBankBroward
{
    public partial class SavingsDeposit : Form
    {
        string strCardNumber;
        public SavingsDeposit(string cardNumber, double currentBalance, double deposit)
        {
            InitializeComponent();

            lblCurrentBalance.Text = currentBalance.ToString();
            lblDeposit.Text = deposit.ToString();
            strCardNumber = cardNumber.ToString();
            
        }

        private void SavingsDeposit_Load(object sender, EventArgs e)
        {
            btnOne.Click += new EventHandler(btn_Click);
            btnTwo.Click += new EventHandler(btn_Click);
            btnThree.Click += new EventHandler(btn_Click);
            btnFour.Click += new EventHandler(btn_Click);
            btnFive.Click += new EventHandler(btn_Click);
            btnSix.Click += new EventHandler(btn_Click);
            btnSeven.Click += new EventHandler(btn_Click);
            btnEight.Click += new EventHandler(btn_Click);
            btnNine.Click += new EventHandler(btn_Click);
            btnZero.Click += new EventHandler(btn_Click);
            btnDot.Click += new EventHandler(btn_Click);

            lblDeposit.Text = "";
        }

        void btn_Click(object sender, EventArgs e)
        {

            

            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                        lblDeposit.Text += "1";
                        break;
                    case "btnTwo":
                        lblDeposit.Text += "2";
                        break;
                    case "btnThree":
                        lblDeposit.Text += "3";
                        break;
                    case "btnFour":
                        lblDeposit.Text += "4";
                        break;
                    case "btnFive":
                        lblDeposit.Text += "5";
                        break;
                    case "btnSix":
                        lblDeposit.Text += "6";
                        break;
                    case "btnSeven":
                        lblDeposit.Text += "7";
                        break;
                    case "btnEight":
                        lblDeposit.Text += "8";
                        break;
                    case "btnNine":
                        lblDeposit.Text += "9";
                        break;
                    case "btnZero":
                        lblDeposit.Text += "0";
                        break;
                    case "btnDot":
                        if (!lblDeposit.Text.Contains("."))
                            lblDeposit.Text += ".";
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry for the inconvenience, Unexpected error occured. Details: " +
                                " Call Broward Bank Emergency Line #999-9999." +
                                ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblDeposit.Text = "";
        }

        private void btnConfirmDeposit_Click(object sender, EventArgs e)
        {

            double tempBalance = Convert.ToDouble(lblCurrentBalance.Text);
            double tempDeposit = Convert.ToDouble(lblDeposit.Text);
            tempBalance = tempBalance + tempDeposit;
            String message = String.Format("Deposit ${0} ?", tempDeposit.ToString());
            DialogResult dr = MessageBox.Show(message,
                      "Broward Bank", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        // update statement goes here            
                        using (SqlConnection cntBrowardBank =
                          new SqlConnection("Data Source=(local);" +
                                            "Database='BrowardBank';Integrated Security=True;"))
                        {
                            SqlCommand cmdDatabase = new SqlCommand("UPDATE Business.Clients " +
                               "SET [SavingsBalance] = N'" + tempBalance + "' " +
                               "WHERE CardNumber = N'" + strCardNumber + "';",
                                                                    cntBrowardBank);

                            cntBrowardBank.Open();
                            cmdDatabase.ExecuteNonQuery();

                            //MessageBox.Show("Testing deposit is OK", "Broward Bank");
                            
                        }

                        


                        MessageBox.Show("Deposit accepted.", "Broward Bank");

                        Close();
                        break;                       
                    }
                case DialogResult.No:
                    {
                        MessageBox.Show("Deposit Cancelled.", "Broward Bank");
                        break;
                    }
            }
        }
    }
}
