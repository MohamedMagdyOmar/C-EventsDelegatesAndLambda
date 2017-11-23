using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class AsyncBad : Form
    {
        // 2-
        delegate void UpdateProgressDelegate (int val);
        //public AsyncBad()
        //{
        //    InitializeComponent();
        //}

        //public static void main()
        //{
        //    //Application.Run(new AsyncBad());
        //}

        private void StartButton_Click(object sender, EventArgs e)
        {
            //1- i need when i click on start button, we need to create a delegate and invoke it asynchronously
            //3- we need to create instance of the above delegate and invoke it
            var progDel = new UpdateProgressDelegate(StartProgress);

            //4- BeginInvoke will create a seperate thread, to make this delegate call "StartProgress" in the background (async process)
            progDel.BeginInvoke(100, null, null);
            MessageBox.Show("Done with Operation");
        }

        // 5- this method will be called async
        // this is bad because "helper" thread is updating UI Components(lblOutput.Text) directly that is on the GUI Thread,
        // so it will fire exception!!! because "Secondry" thread SHOULD NOT touch the GUI Thread
        // System.InvalidOperationException: 
        // 'Cross-thread operation not valid: Control 'lblOutput' accessed from a thread other than the thread it was created on.'
        public void StartProgress(int max)
        {
            this.pbStatus.Maximum = max;
            for(int i = 0; i <= max; i++)
            {           
                Thread.Sleep(10);
                lblOutput.Text = i.ToString();
                this.pbStatus.Value = i;
            }
        }
    }
}
