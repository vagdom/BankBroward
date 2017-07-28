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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCardNumber.Text = "";
            txtPin.Text = "";
        }

        private void CreateDatabase()
        {
            // Main script to create and populate Broward Bank Database
            using (SqlConnection cntBrowardBank =
            new SqlConnection("Data Source=(local);Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("IF  EXISTS ( " +
                                                        "      SELECT name " +
                                                        "		FROM sys.databases " +
                                                        "		WHERE name = N'BrowardBank' " +
                                                        ")" +
                                                        "DROP DATABASE BrowardBank; " +
                                                        "CREATE DATABASE BrowardBank;",
                                   cntBrowardBank);

                cntBrowardBank.Open();
                cmdDatabase.ExecuteNonQuery();

                MessageBox.Show("The BrowardBank database has been created.",
                                "Broward Bank",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Create Schema
            using (SqlConnection cntBrowardBank =
            new SqlConnection("Data Source=(local);" +
                              "Database='BrowardBank';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE SCHEMA Business;", cntBrowardBank);

                cntBrowardBank.Open();
                cmdDatabase.ExecuteNonQuery();
            }

            //Create Clients Table
            using (SqlConnection cntBrowardBank =
            new SqlConnection("Data Source=(local);" +
                              "Database='BrowardBank';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("CREATE TABLE Business.Clients " +
                                                        "( " +
                                                        "    ClientID	      int identity(1, 1), " +
                                                        "    CardNumber       nvarchar(16) not null, " +
                                                        "    CheckingAcc      nvarchar(12) not null, " +
                                                        "    SavingsAcc       nvarchar(12) not null, " +
                                                        "    Pin              nvarchar(10) not null, " +
                                                        "    ClientName       nvarchar(25), " +                                                       
                                                        "    SSN              nvarchar(20), " +
                                                        "    Address          nvarchar(80), " +
                                                        "    Email            nvarchar(50), " +
                                                        "    CheckingBalance  money, " +
                                                        "    SavingsBalance   money, " +
                                                        "    Constraint PK_Clients Primary Key(CardNumber) " +
                                                        ");", cntBrowardBank);

                cntBrowardBank.Open();
                cmdDatabase.ExecuteNonQuery();
            }

            ///
            /// Generate Database Data
            ///


            //Populate Clients table
            using (SqlConnection cntBrowardBank =
                            new SqlConnection("Data Source=(local);" +
                                              "Database='BrowardBank';Integrated Security=True;"))
            {
                SqlCommand cmdDatabase = new SqlCommand("INSERT INTO Business.Clients(CardNumber, CheckingAcc, SavingsAcc, Pin, ClientName, Address, Email, SSN, CheckingBalance, SavingsBalance) " +
                                                        "VALUES(N'1234567890123456', N'144074832348', N'221834823902', N'3944', N'Jon Doe', N'1923 NE 13th St. 99854', N'JonDoe@gmail.com', N'111-22-3333', 25.00, 0.00), " +
                                                        "      (N'1234567890123457', N'144858376262', N'221392817383', N'1192', N'John Doe', N'2038 SW 57th Ct. 28377', N'JohnDoe@gmail.com', N'111-22-3334', 1000000.00, 2500000.00), " +
                                                        "      (N'1234567890123458', N'144937826182', N'221393747646', N'9927', N'Jahn Doe', N'1022 SE 32nd Blvd. #104 99854', N'JahnDoe@gmail.com', N'111-22-3335', 100.00, 10000.00), " +
                                                        "      (N'1234567890123459', N'144022847362', N'221378457362', N'8374', N'Jon Doh', N'3304 NW 11th Ter. #245 88734', N'JonDoh@gmail.com', N'111-22-3336', 1925.00, 25000.00), " +
                                                        "      (N'1234567890123460', N'144827163894', N'221392382723', N'9273', N'Jessica Dohnuht', N'2093 SE 77th Way 990234', N'JessicaDohnuht', N'111-22-3337', -333.33, 1293.57); ",
                                                        cntBrowardBank);

                cntBrowardBank.Open();
                cmdDatabase.ExecuteNonQuery();

                MessageBox.Show("Clients table has been created and populated.",
                                "Broward Bank",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            //Validate Card Number and Pin
            if (!(string.IsNullOrEmpty(txtCardNumber.Text)))
            {
                using (SqlConnection scBrowardBank =
                        new SqlConnection("Data Source=(local);" +
                                          "Database='BrowardBank';" +
                                          "Integrated Security=Yes"))
                {
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) CardNumber FROM Business.Clients WHERE CardNumber='" + txtCardNumber.Text + "' AND Pin='" + txtPin.Text + "'", scBrowardBank);
                    DataTable dt = new DataTable(); //this is creating a virtual table  
                    sda.Fill(dt);
                                       
                    if (dt.Rows[0][0].ToString() == "1")
                        {
                        /*MessageBox.Show("No Error - Implement main menu here ",
                                        "Broward Bank",                                        
                                         MessageBoxButtons.OK, MessageBoxIcon.Information); */

                        //BankAccount tmpBankAcc = new BankAccount("", "", "", "", "", "", "", "", 0, 0);
                        
                        MainMenu mm = new MainMenu(txtCardNumber.Text);
                        mm.Show();
                    }
                    else
                        {
                        MessageBox.Show("Error 02 - Invalid Card Number and/or pin, please try it again.",
                                        "Broward Bank",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtPin.Focus();
                    }                    
                }
            } else
            {
                MessageBox.Show("Error 01 - Invalid Card Number, please try it again.",
                               "Broward Bank",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCardNumber.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           this.TransparencyKey = Color.Empty;
           CreateDatabase();

        }
    }
}
