using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsReviewOOP
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            string info = "Are you sure you want to quit this program ?";
            string title = "Application Closing";

            if(MessageBox.Show(info,title,MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void mnuATM_Click(object sender, EventArgs e)
        {
            frmATM myAtm = new frmATM();
            
            //indicate to myAtm that it is The child of the current form frmMain (this)
            myAtm.MdiParent = this;

            myAtm.Show();
        }

        private void mnuOOP_Click(object sender, EventArgs e)
        {
            frmClassReview fc = new frmClassReview();
            fc.MdiParent = this;
            fc.Show();

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            clsATM mybank = new clsATM("atm001", "TD", "lasalle college", "active", 200000);

            clsClient cli1 = new clsClient("cl111", "Alireza", "marijuana", "active");
            clsAccount ac1 = new clsAccount("ac111", "chequing", 12, 4, 2002, "active", 30300);
            cli1.Accounts.Add(ac1);
            cli1.Accounts.Add(new clsAccount("ac4311", "Saving", 2, 6, 2012, "active", 17300));

            clsClient cli2 = new clsClient("cl888", "Noah ", "the","active");
            clsAccount ac2 = new clsAccount("ac86", "chequing", 12, 4, 2002, "active", 67300);
            cli2.Accounts.Add(ac2);
            cli2.Accounts.Add(new clsAccount("ac709", "credit", 2, 12, 2000, "active", 300));

            mybank.Clients.Add(cli1);
            mybank.Clients.Add (cli2);

            MessageBox.Show(mybank.Display());

            MessageBox.Show(mybank .Clients.Find("cl888").Display ());
           
          
           
        }



    }
}