namespace MatchMaker
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.lblFile = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.txtPathFile = new System.Windows.Forms.TextBox();
            this.txtNbMinute = new System.Windows.Forms.TextBox();
            this.cmdPathFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(52, 43);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(38, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "Fichier";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(52, 115);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "Temps limite";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Location = new System.Drawing.Point(204, 115);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(44, 13);
            this.lblMinute.TabIndex = 2;
            this.lblMinute.Text = "Minutes";
            // 
            // txtPathFile
            // 
            this.txtPathFile.Location = new System.Drawing.Point(130, 43);
            this.txtPathFile.Name = "txtPathFile";
            this.txtPathFile.Size = new System.Drawing.Size(320, 20);
            this.txtPathFile.TabIndex = 3;
            // 
            // txtNbMinute
            // 
            this.txtNbMinute.Location = new System.Drawing.Point(154, 112);
            this.txtNbMinute.Name = "txtNbMinute";
            this.txtNbMinute.Size = new System.Drawing.Size(44, 20);
            this.txtNbMinute.TabIndex = 4;
            // 
            // cmdPathFile
            // 
            this.cmdPathFile.Location = new System.Drawing.Point(509, 41);
            this.cmdPathFile.Name = "cmdPathFile";
            this.cmdPathFile.Size = new System.Drawing.Size(75, 23);
            this.cmdPathFile.TabIndex = 5;
            this.cmdPathFile.Text = "Accepter";
            this.cmdPathFile.UseVisualStyleBackColor = true;

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdPathFile);
            this.Controls.Add(this.txtNbMinute);
            this.Controls.Add(this.txtPathFile);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblFile);
            this.Name = "Form1";
            this.Text = "MatchMaker";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.TextBox txtNbMinute;
        private System.Windows.Forms.TextBox txtPathFile;
        private System.Windows.Forms.Button cmdPathFile;
    }
}

