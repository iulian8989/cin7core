using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using log4net;
namespace CIN7Core_MFT_EDI.Forms
{
    public partial class frmSettings : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(frmSettings));

        public frmSettings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            log.Info("Loading settings form.");
            loadSettings();
        }
        private void loadSettings()
        {

            txtFTPDirectory.Text = Properties.Settings.Default.FtpTargetDirectory.ToString();
            txtFTPHost.Text = Properties.Settings.Default.FtpURL.ToString();
            txtFTPPassword.Text = Properties.Settings.Default.FtpPassword.ToString();
            txtFTPUsername.Text = Properties.Settings.Default.FtpUsername.ToString();
            txtCin7AccID.Text = Properties.Settings.Default.Cin7AccountId.ToString();
            txtCin7ApiKey.Text = Properties.Settings.Default.Cin7APIKey.ToString();
            txtLogPath.Text = Properties.Settings.Default.LogFilePath.ToString();
        }
        private void unLockControlles()
        {
            txtFTPDirectory.Enabled = true;
            txtFTPHost.Enabled = true;
            txtFTPPassword.Enabled = true;
            txtFTPUsername.Enabled = true;
            txtCin7AccID.Enabled = true;
            txtCin7ApiKey.Enabled = true;
            txtLogPath.Enabled = true;
            btnBrowse.Enabled = true;
            btnsave.Enabled = true;
            btnEdit.Enabled = false;
        }
        private void LockControlles()
        {
            txtFTPDirectory.Enabled = false;
            txtFTPHost.Enabled = false;
            txtFTPPassword.Enabled = false;
            txtFTPUsername.Enabled = false;
            txtCin7AccID.Enabled = false;
            txtCin7ApiKey.Enabled = false;
            txtLogPath.Enabled = false;
            btnBrowse.Enabled = false;
            btnsave.Enabled = false;
            btnEdit.Enabled = true;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            unLockControlles();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                LockControlles();
                Properties.Settings.Default.FtpTargetDirectory = txtFTPDirectory.Text;
                Properties.Settings.Default.FtpURL = txtFTPHost.Text;
                Properties.Settings.Default.FtpPassword = txtFTPPassword.Text;
                Properties.Settings.Default.FtpUsername = txtFTPUsername.Text;
                Properties.Settings.Default.Cin7AccountId = txtCin7AccID.Text;
                Properties.Settings.Default.Cin7APIKey = txtCin7ApiKey.Text;
                Properties.Settings.Default.LogFilePath = txtLogPath.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Settings saved successfully!");
                log.Info("Settings saved successfully.");
            }
            catch (Exception ex)
            {
                log.Error("Error saving settings: ", ex);
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
