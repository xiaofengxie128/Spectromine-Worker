
namespace Spectromine_Worker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.output = new System.Windows.Forms.RichTextBox();
            this.hostip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.workpath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.workername = new System.Windows.Forms.TextBox();
            this.workerstatus = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lastupdate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.currentjob = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Start = new System.Windows.Forms.Button();
            this.workerip = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Info;
            this.output.Location = new System.Drawing.Point(447, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.output.Size = new System.Drawing.Size(341, 426);
            this.output.TabIndex = 0;
            this.output.Text = "";
            // 
            // hostip
            // 
            this.hostip.Location = new System.Drawing.Point(125, 26);
            this.hostip.Name = "hostip";
            this.hostip.Size = new System.Drawing.Size(226, 20);
            this.hostip.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Server IP/Hostname:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Worker Name:";
            // 
            // workpath
            // 
            this.workpath.Location = new System.Drawing.Point(15, 149);
            this.workpath.Name = "workpath";
            this.workpath.Size = new System.Drawing.Size(426, 20);
            this.workpath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Spectromine file location";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // workername
            // 
            this.workername.Location = new System.Drawing.Point(125, 57);
            this.workername.Name = "workername";
            this.workername.Size = new System.Drawing.Size(226, 20);
            this.workername.TabIndex = 1;
            // 
            // workerstatus
            // 
            this.workerstatus.Location = new System.Drawing.Point(115, 184);
            this.workerstatus.Name = "workerstatus";
            this.workerstatus.Size = new System.Drawing.Size(236, 20);
            this.workerstatus.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Worker status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Task Percentage:";
            // 
            // lastupdate
            // 
            this.lastupdate.Location = new System.Drawing.Point(115, 269);
            this.lastupdate.Name = "lastupdate";
            this.lastupdate.Size = new System.Drawing.Size(236, 20);
            this.lastupdate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Last update:";
            // 
            // currentjob
            // 
            this.currentjob.Location = new System.Drawing.Point(97, 313);
            this.currentjob.Name = "currentjob";
            this.currentjob.Size = new System.Drawing.Size(294, 20);
            this.currentjob.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Current Job:";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(25, 359);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(109, 48);
            this.Start.TabIndex = 7;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // workerip
            // 
            this.workerip.Location = new System.Drawing.Point(125, 83);
            this.workerip.Name = "workerip";
            this.workerip.Size = new System.Drawing.Size(226, 20);
            this.workerip.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Worker ip:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(242, 359);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(109, 48);
            this.stop.TabIndex = 8;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(116, 225);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(226, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.workpath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentjob);
            this.Controls.Add(this.lastupdate);
            this.Controls.Add(this.workerstatus);
            this.Controls.Add(this.workerip);
            this.Controls.Add(this.workername);
            this.Controls.Add(this.hostip);
            this.Controls.Add(this.output);
            this.Name = "Form1";
            this.Text = "Spectromine Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.TextBox hostip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox workpath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox workername;
        private System.Windows.Forms.TextBox workerstatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lastupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox currentjob;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.TextBox workerip;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

