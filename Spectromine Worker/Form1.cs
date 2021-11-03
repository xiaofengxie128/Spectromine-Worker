using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spectromine_Worker
{

    public partial class Form1 : Form
    {
        BackgroundWorker backgroundWorker1 = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();
            workerip.Text = GetIPAddress();
            workername.Text = "worker_" + Gethostname();
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;  //Tell the user how the process went
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true; //Allow for the process to be cancelled

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    Title = "Browse Spectromine.exe Files",

                    CheckFileExists = true,
                    CheckPathExists = true,
                    DefaultExt = "exe",
                    Filter = "exe files (*.exe)|*.exe|All files (*.*)|*.*",
                    RestoreDirectory = true,

                };

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    workpath.Text = openFileDialog1.FileName;
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private string GetIPAddress()
        {
            StringBuilder sb = new StringBuilder();
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            IPHostEntry ipHostEntry = Dns.GetHostEntry(strHostName);
            IPAddress[] address = ipHostEntry.AddressList;
            sb.Append(address[4].ToString());
            sb.AppendLine();
            return sb.ToString();
        }

        private string Gethostname()
        {
            StringBuilder sb = new StringBuilder();
            String strHostName = string.Empty;
            strHostName = Dns.GetHostName();
            return strHostName.ToString();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
            output.AppendText(Environment.NewLine + "Worker started");
        }





        private void button2_Click(object sender, EventArgs e)
        {
            //stop the thread.
            //Check if background worker is doing anything and send a cancellation if it is
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }
            output.AppendText(Environment.NewLine + "Worker stopped");

        }
        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(1000);
                backgroundWorker1.ReportProgress(i);

                //Check if there is a request to cancel the process
                if (backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                    backgroundWorker1.ReportProgress(0);
                    return;
                }
            }
            //If the process exits the loop, ensure that progress is set to 100%
            //Remember in the loop we set i < 100 so in theory the process will complete at 99%
            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                output.AppendText(Environment.NewLine + "Process was cancelled");
            }
            else if (e.Error != null)
            {
                output.AppendText(Environment.NewLine + "There was an error running the process. The thread aborted");
            }
            else
            {
                output.AppendText(Environment.NewLine + "Process was completed");
            }
        }



    }
}
