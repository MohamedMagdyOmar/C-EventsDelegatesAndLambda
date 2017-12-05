namespace ThreadsAndDelegates
{
    partial class UsingAThread
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
            this.StartButton = new System.Windows.Forms.Button();
            this.pbStatus = new System.Windows.Forms.ProgressBar();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(39, 40);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(119, 50);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
   
            // 
            // pbStatus
            // 
            this.pbStatus.Location = new System.Drawing.Point(39, 154);
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(208, 35);
            this.pbStatus.TabIndex = 1;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(39, 114);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 17);
            this.lblOutput.TabIndex = 5;
            // 
            // UsingAThread
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pbStatus);
            this.Controls.Add(this.StartButton);
            this.Name = "UsingAThread";
            this.Text = "UsingAThread";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.ProgressBar pbStatus;
        private System.Windows.Forms.Label lblOutput;
    }
}