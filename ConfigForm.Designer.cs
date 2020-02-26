/*
 * Created by SharpDevelop.
 * User: Quint
 * Date: 11/1/2013
 * Time: 4:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace QuickScan
{
    partial class ConfigForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        
        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSpUrl = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPasswd = new System.Windows.Forms.TextBox();
            this.txtDomain = new System.Windows.Forms.TextBox();
            this.txtFolderIn = new System.Windows.Forms.TextBox();
            this.btnDirectorySelect = new System.Windows.Forms.Button();
            this.saveConfig = new System.Windows.Forms.Button();
            this.cancelConfig = new System.Windows.Forms.Button();
            this.lblSpUrl = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.lblDomain = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSpUrl
            // 
            this.txtSpUrl.Location = new System.Drawing.Point(157, 35);
            this.txtSpUrl.Name = "txtSpUrl";
            this.txtSpUrl.Size = new System.Drawing.Size(214, 20);
            this.txtSpUrl.TabIndex = 0;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(157, 82);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(214, 20);
            this.txtUser.TabIndex = 1;
            // 
            // txtPasswd
            // 
            this.txtPasswd.Location = new System.Drawing.Point(157, 138);
            this.txtPasswd.Name = "txtPasswd";
            this.txtPasswd.Size = new System.Drawing.Size(214, 20);
            this.txtPasswd.TabIndex = 2;
            // 
            // txtDomain
            // 
            this.txtDomain.Location = new System.Drawing.Point(157, 193);
            this.txtDomain.Name = "txtDomain";
            this.txtDomain.Size = new System.Drawing.Size(214, 20);
            this.txtDomain.TabIndex = 3;
            // 
            // txtFolderIn
            // 
            this.txtFolderIn.Location = new System.Drawing.Point(157, 247);
            this.txtFolderIn.Name = "txtFolderIn";
            this.txtFolderIn.Size = new System.Drawing.Size(214, 20);
            this.txtFolderIn.TabIndex = 4;
            // 
            // btnDirectorySelect
            // 
            this.btnDirectorySelect.Location = new System.Drawing.Point(58, 245);
            this.btnDirectorySelect.Name = "btnDirectorySelect";
            this.btnDirectorySelect.Size = new System.Drawing.Size(75, 23);
            this.btnDirectorySelect.TabIndex = 5;
            this.btnDirectorySelect.Text = "Directory...";
            this.btnDirectorySelect.UseVisualStyleBackColor = true;
            this.btnDirectorySelect.Click += new System.EventHandler(this.BtnDirectorySelectClick);
            // 
            // saveConfig
            // 
            this.saveConfig.Location = new System.Drawing.Point(77, 302);
            this.saveConfig.Name = "saveConfig";
            this.saveConfig.Size = new System.Drawing.Size(81, 32);
            this.saveConfig.TabIndex = 6;
            this.saveConfig.Text = "OK";
            this.saveConfig.UseVisualStyleBackColor = true;
            this.saveConfig.Click += new System.EventHandler(this.Button1Click);
            // 
            // cancelConfig
            // 
            this.cancelConfig.Location = new System.Drawing.Point(268, 302);
            this.cancelConfig.Name = "cancelConfig";
            this.cancelConfig.Size = new System.Drawing.Size(75, 32);
            this.cancelConfig.TabIndex = 7;
            this.cancelConfig.Text = "Cancel";
            this.cancelConfig.UseVisualStyleBackColor = true;
            this.cancelConfig.Click += new System.EventHandler(this.CancelConfigClick);
            // 
            // lblSpUrl
            // 
            this.lblSpUrl.Location = new System.Drawing.Point(56, 35);
            this.lblSpUrl.Name = "lblSpUrl";
            this.lblSpUrl.Size = new System.Drawing.Size(95, 23);
            this.lblSpUrl.TabIndex = 8;
            this.lblSpUrl.Text = "Sharepoint URL";
            // 
            // lblUser
            // 
            this.lblUser.Location = new System.Drawing.Point(56, 78);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(77, 23);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "Username";
            // 
            // lblPasswd
            // 
            this.lblPasswd.Location = new System.Drawing.Point(57, 135);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(82, 23);
            this.lblPasswd.TabIndex = 10;
            this.lblPasswd.Text = "Password";
            // 
            // lblDomain
            // 
            this.lblDomain.Location = new System.Drawing.Point(56, 193);
            this.lblDomain.Name = "lblDomain";
            this.lblDomain.Size = new System.Drawing.Size(83, 23);
            this.lblDomain.TabIndex = 11;
            this.lblDomain.Text = "Domain";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 346);
            this.Controls.Add(this.lblDomain);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblSpUrl);
            this.Controls.Add(this.cancelConfig);
            this.Controls.Add(this.saveConfig);
            this.Controls.Add(this.btnDirectorySelect);
            this.Controls.Add(this.txtFolderIn);
            this.Controls.Add(this.txtDomain);
            this.Controls.Add(this.txtPasswd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtSpUrl);
            this.Name = "ConfigForm";
            this.Text = "ConfigForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private System.Windows.Forms.Label lblDomain;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblSpUrl;
        private System.Windows.Forms.Button cancelConfig;
        private System.Windows.Forms.Button saveConfig;
        private System.Windows.Forms.Button btnDirectorySelect;
        private System.Windows.Forms.TextBox txtFolderIn;
        private System.Windows.Forms.TextBox txtDomain;
        private System.Windows.Forms.TextBox txtPasswd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtSpUrl;
    }
}
