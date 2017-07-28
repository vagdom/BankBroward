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
    public partial class SavingsWithdraw : Form
    {
        string strCardNumber;
        public SavingsWithdraw(string cardNumber, double currentBalance, double withdraw)
        {
            InitializeComponent();
            lblCurrentBalance.Text = currentBalance.ToString();
            lblWithdraw.Text = withdraw.ToString();
            strCardNumber = cardNumber.ToString();
        }

       
        void btn_Click(object sender, EventArgs e)
        {



            try
            {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btnOne":
                        lblWithdraw.Text += "1";
                        break;
                    case "btnTwo":
                        lblWithdraw.Text += "2";
                        break;
                    case "btnThree":
                        lblWithdraw.Text += "3";
                        break;
                    case "btnFour":
                        lblWithdraw.Text += "4";
                        break;
                    case "btnFive":
                        lblWithdraw.Text += "5";
                        break;
                    case "btnSix":
                        lblWithdraw.Text += "6";
                        break;
                    case "btnSeven":
                        lblWithdraw.Text += "7";
                        break;
                    case "btnEight":
                        lblWithdraw.Text += "8";
                        break;
                    case "btnNine":
                        lblWithdraw.Text += "9";
                        break;
                    case "btnZero":
                        lblWithdraw.Text += "0";
                        break;
                    case "btnDot":
                        if (!lblWithdraw.Text.Contains("."))
                            lblWithdraw.Text += ".";
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
            lblWithdraw.Text = "";
        }

        private void btnConfirmWithdraw_Click(object sender, EventArgs e)
        {
            double tempBalance = Convert.ToDouble(lblCurrentBalance.Text);
            double tempWithdraw = Convert.ToDouble(lblWithdraw.Text);
            tempBalance = tempBalance - tempWithdraw;
            String message = String.Format("Withdraw ${0} ?", tempWithdraw.ToString());
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

                        }




                        MessageBox.Show("Withdraw complete.", "Broward Bank");

                        Close();
                        break;
                    }
                case DialogResult.No:
                    {
                        MessageBox.Show("Withdraw Cancelled.", "Broward Bank");
                        break;
                    }
            }
        }

        private void SavingsWithdraw_Load_1(object sender, EventArgs e)
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

            lblWithdraw.Text = "";
        }
    }
}
