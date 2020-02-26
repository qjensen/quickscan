/*
 * Created by SharpDevelop.
 * User: Quint
 * Date: 11/1/2013
 * Time: 4:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using WinForm = System.Windows.Forms.Form; //disambiguate the Windows forms from the Sharepoint forms
using Microsoft.SharePoint.Client;

namespace QuickScan
{
    /// <summary>
    /// Description of ConfigForm.
    /// </summary>
    public partial class ConfigForm : WinForm
    {
        public QuickScanConfig config;
        
        public ConfigForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            this.config = ConfigManager.getConfig();
            
            txtSpUrl.DataBindings.Add("Text", config, "sharepointUrl");
            txtUser.DataBindings.Add("Text", config, "username");
            txtPasswd.DataBindings.Add("Text",config, "password");
            txtDomain.DataBindings.Add("Text",config, "domain");
            txtFolderIn.DataBindings.Add("Text", config, "watchPath");
        }
        
        void BtnDirectorySelectClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbDlg = new FolderBrowserDialog();
            fbDlg.Description = "Select the folder that holds incoming scanned documents";
            fbDlg.ShowNewFolderButton = true;
            DialogResult result = fbDlg.ShowDialog();
            if( result == DialogResult.OK )
            {
                this.config.watchPath = fbDlg.SelectedPath;
                //databinding isn't 2 way
                this.txtFolderIn.Text = this.config.watchPath;
            }
        }
        
        
        void Button1Click(object sender, EventArgs e)
        {
            ConfigManager.saveConfig();
            this.Close();
        }
        
        void CancelConfigClick(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
