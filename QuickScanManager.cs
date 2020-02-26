/*
 * Created by SharpDevelop.
 * User: Quint
 * Date: 11/29/2013
 * Time: 1:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.IO;

namespace QuickScan
{
    /// <summary>
    /// Description of QuickScanManager.
    /// </summary>
    public class QuickScanManager
    {
        private FileSystemWatcher watcher;
        private QuickScanConfig config;
        public QuickScanManager()
        {

        }
        
        public void StartWatcher() {
            QuickScanStartupArgs args = new QuickScanStartupArgs();
            
            try {
                this.config = ConfigManager.getConfig();
                watcher = new FileSystemWatcher();
                watcher.Path = config.watchPath;
                watcher.Filter = "*.*"; //watch for any file and filter at the event
                watcher.Created += new FileSystemEventHandler(OnFileCreated);
                // Begin watching.
                watcher.EnableRaisingEvents = true;
            }
            catch(Exception ex) {
                watcher.EnableRaisingEvents = false;
                args.Success = false;
                args.Message = "Starting the file system watcher failed : " + ex.Message;
                OnQuickScanStartup(args);
            }
        }
        
        private void OnFileCreated(FileSystemEventArgs args){
            
        }
        
        //*********** Events for consumers *************//
        protected virtual void OnQuickScanUpdate(QuickScanEventArgs e)
        {
            EventHandler<QuickScanEventArgs> handler = QuickScanUpdate;
            if (handler != null) {
                handler(this, e);
            }
        }
        
        protected virtual void OnQuickScanStartup(QuickScanStartupArgs e){
            
        }

        public event EventHandler<QuickScanEventArgs> QuickScanUpdate;
        public event EventHandler<QuickScanStartupArgs> QuickScanStartup;
    }
    
    /// <summary>
    /// Event args for passing processing status to listeners.
    /// </summary>
    public class QuickScanEventArgs : EventArgs
    {
        public bool isError {get; set;}
        public int Level {get; set;}
        public string Message {get; set;}
        
        public QuickScanEventArgs()
        {
        }
        
        public QuickScanEventArgs(bool isError, int level, string message)
        {
            this.isError = isError;
            this.Level = level;
            this.Message = message;
        }
    }
    
    ///<summary>
    /// Event args for passing startup info to listeners
    /// </summary>
    public class QuickScanStartupArgs : EventArgs 
    {
        public bool Success {get; set;}
        public string Message {get; set;}
        
        public QuickScanStartupArgs(){
            
        }
    }
}
