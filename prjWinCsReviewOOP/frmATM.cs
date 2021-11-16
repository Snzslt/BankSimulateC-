using System;
using System.Windows.Forms;

namespace prjWinCsReviewOOP
{
    public partial class frmATM : Form
    {
        public frmATM()
        {
            InitializeComponent();
        }

        // declaration of global variables
        clsATM myBank;
        clsClient currentClient;
        private void frmATM_Load(object sender, EventArgs e)
        {
            txtDeposit.Visible = false;
            txtWithdraw.Visible = false;
            lblDeposit.Visible = false;
            lblWithdraw.Visible = false;

            this.Height = 164;
            clsListClient clients = clsDatasource.getAllClients();
            myBank = new clsATM("atm-0001", "Toronto Dominion", "Lasalle college", "active", clients, 20000);

        
           
        }

        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            string number = txtNumber.Text.Trim();
             currentClient  =  myBank.Clients.Find(number);
            if (currentClient == null)
            {
                MessageBox.Show("client Not Found, Try again.", "TD: Number identification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
                lblWelcome = ("welcome");
                return;
            }

            this.Height = 251;
        }

        private void btnNextPin_Click(object sender, EventArgs e)
        {
            string pin = txtPin.Text.Trim();
            if (pin != currentClient.Pin)
            {
                MessageBox.Show("Incorrect Pin.", "TD: Pin identification Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtPin.Focus();
                txtPin.Clear();
                return;
            }
            this.Height = 341;
        }

        private void btnNextTransaction_Click(object sender, EventArgs e)
        {
            this.Height = 630;
        }

        private void btnTerminate_Click(object sender, EventArgs e)
        {
            this.Height = 164;
        }

        private void btnNextAccount_Click(object sender, EventArgs e)
        {
            this.Height = 470;
        }

        private void radDeposit_CheckedChanged(object sender, EventArgs e)
        {
            txtDeposit.Visible = lblDeposit.Visible = true;
            txtWithdraw.Visible = lblWithdraw.Visible = false;
            txtDeposit.Focus();
            
        }

        private void radWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible = lblWithdraw.Visible = true;
            txtDeposit.Visible = lblDeposit.Visible = false;
            txtWithdraw.Focus();
        }

        private void radConsult_CheckedChanged(object sender, EventArgs e)
        {
            txtWithdraw.Visible = lblWithdraw.Visible = txtDeposit.Visible = lblDeposit.Visible = false;
        }

        private void txtDeposit_KeyPress(object sender, KeyPressEventArgs e)
        {
          
            if(char.IsDigit(e.KeyChar)==false && char.IsControl(e.KeyChar)==false)
            { 
                e.Handled = true;  // do not allow the caracter to be display on the textbox
            }

        }

        

        private void txtWithdraw_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;  // do not allow the caracter to be display on the textbox
            }

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
