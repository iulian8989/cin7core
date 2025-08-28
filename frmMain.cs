using CIN7Core_MFT_EDI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIN7Core_MFT_EDI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            loadform(new frmSettings());
        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            loadform(new frmOrders()); //creating a new instance of frmOrders and passing it to the loadform method
        }
        public void loadform(object Form) //a method that takes an object named Form as parameter
        {
            if (this.panelMain.Controls.Count > 0)
                this.panelMain.Controls.RemoveAt(0); //checks if any existing forms are loaded, it removes them
            Form f = Form as Form; //configures new form 'f'
            f.TopLevel = false; //new form will nest inside another one
            f.Dock = DockStyle.Fill; //fills up the entire area of panelMain
            this.panelMain.Controls.Add(f); //adds form f to control collection of panelMain
            this.panelMain.Tag = f; //holds reference to form f
            f.Show(); //makes the form f visible

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
