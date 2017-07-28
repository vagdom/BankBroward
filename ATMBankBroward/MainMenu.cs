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
    public partial class MainMenu : Form
    {
        //Gloabl variables
        string cName = "";
        string cAccNum = "";
        string sAccNum = "";
        double cBal = 0.00;
        double sBal = 0.00;
        string strCardNumber;



        public MainMenu(string cardNumber)
        {
            InitializeComponent();

            //Access CardNumber Information
            using (SqlConnection scBrowardBank =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='BrowardBank';" +
                                          "Integrated Security=Yes"))
            {
                SqlCommand cmdCourseLevels =
                new SqlCommand("SELECT ClientName, CheckingAcc, SavingsAcc, CheckingBalance, Savingsbalance, CardNumber " +
                               "FROM Business.Clients " +
                               "WHERE CardNumber = N'" + cardNumber + "';",
                                scBrowardBank);
                scBrowardBank.Open();

                SqlDataReader sdrCourseLevels = cmdCourseLevels.ExecuteReader();

                while (sdrCourseLevels.Read())
                {
                    String today = DateTime.Now.ToString("             -             dd.MM.yyyy");
                    lblClientInfo.Text = sdrCourseLevels[0].ToString();
                    cName = sdrCourseLevels[0].ToString();
                    cAccNum = sdrCourseLevels[1].ToString();
                    sAccNum = sdrCourseLevels[2].ToString();                    
                    cBal = Convert.ToDouble(sdrCourseLevels[3].ToString());
                    sBal = Convert.ToDouble(sdrCourseLevels[4].ToString());
                    strCardNumber = (sdrCourseLevels[5].ToString());

                    lblClientInfo.Text += today.ToString();                    
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // Variable
            string MessageBoxTitle = "Bank Broward";
            string MessageBoxContent = "Do you want to exit the application?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Empty;
        }

        private void btnBalanceInquiry_Click(object sender, EventArgs e)
        {
            //Get Current balance
            using (SqlConnection scBrowardBank =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='BrowardBank';" +
                                          "Integrated Security=Yes"))
            {
                SqlCommand cmdCourseLevels =
                new SqlCommand("SELECT ClientName, CheckingAcc, SavingsAcc, CheckingBalance, Savingsbalance, CardNumber " +
                               "FROM Business.Clients " +
                               "WHERE CardNumber = N'" + strCardNumber + "';",
                                scBrowardBank);
                scBrowardBank.Open();

                SqlDataReader sdrCourseLevels = cmdCourseLevels.ExecuteReader();

                while (sdrCourseLevels.Read())
                {
                    String today = DateTime.Now.ToString("             -             dd.MM.yyyy");
                    lblClientInfo.Text = sdrCourseLevels[0].ToString();
                    cName = sdrCourseLevels[0].ToString();
                    cAccNum = sdrCourseLevels[1].ToString();
                    sAccNum = sdrCourseLevels[2].ToString();
                    cBal = Convert.ToDouble(sdrCourseLevels[3].ToString());
                    sBal = Convert.ToDouble(sdrCourseLevels[4].ToString());
                    strCardNumber = (sdrCourseLevels[5].ToString());

                    lblClientInfo.Text += today.ToString();
                }
            }

            BalanceInquiry bl = new BalanceInquiry(cName, cAccNum, sAccNum, cBal, sBal);
            bl.Show();
        }

        private void btnSavingsDeposit_Click(object sender, EventArgs e)
        {
            SavingsDeposit sd = new SavingsDeposit(strCardNumber, sBal , 0.00);
            sd.Show();
        }

        private void btnSavingsWithdraw_Click(object sender, EventArgs e)
        {
            SavingsWithdraw sw = new SavingsWithdraw(strCardNumber, sBal, 0.00);
            sw.Show();
        }
    }
}
