namespace ThreadsAndDelegates
{
    partial class BackgroundWorkerDemo
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MyBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(34, 27);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(34, 92);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(98, 39);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(138, 92);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(103, 39);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // MyBackgroundWorker
            // 
            this.MyBackgroundWorker.WorkerReportsProgress = true;
            this.MyBackgroundWorker.WorkerSupportsCancellation = true;
            this.MyBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.MyBackgroundWorker_DoWork);
            this.MyBackgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.MyBackgroundWorker_ProgressChanged);
            this.MyBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.MyBackgroundWorker_RunWorkerCompleted);
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(31, 62);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(42, 17);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "label1";
            // 
            // BackgroundWorkerDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 176);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.progressBar1);
            this.Name = "BackgroundWorkerDemo";
            this.Text = "BackgroundWorkerDemo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button CancelButton;
        private System.ComponentModel.BackgroundWorker MyBackgroundWorker;
        private System.Windows.Forms.Label OutputLabel;
    }
}