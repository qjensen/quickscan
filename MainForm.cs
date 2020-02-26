/*
 * Created by SharpDevelop.
 * User: Quint
 * Date: 11/1/2013
 * Time: 4:23 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace QuickScan
{
    /// <summary>
    /// QuickScan main gui. Mostly a text box with status
    /// information on the FileSystemWatcher
    /// </summary>
    public partial class MainForm : Form
    {
        private QuickScanManager qsm;
        
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            
        }
        
        void PreferencesToolStripMenuItemClick(object sender, EventArgs e)
        {
            ConfigForm configEditor = new ConfigForm();
            configEditor.Show();
        }
        
        void QuitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        void BtnBeginClick(object sender, EventArgs e)
        {
            BackgroundWorker bw = new BackgroundWorker();
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;
            bw.ProgressChanged += new EventHandler<QuickScanEventArgs>(bw_ReportProgress);
        }
        
        public void bw_ReportProgress(object sender, QuickScanEventArgs e){
            if ((this.txtQsMessage != null)) {
                this.txtQsMessage.AppendText(e.Message + Environment.NewLine);
            }
        }
    }
}
