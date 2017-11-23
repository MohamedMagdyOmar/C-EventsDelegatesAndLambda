using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ThreadsAndDelegates
{
    public partial class AsyncGood : Form
    {
        delegate void StartProcessDelegate(int i);

        // this delegate will be responsible for routing data from background thread to main thread.
        delegate void ShowProcessDelegate(int val);
        public AsyncGood()
        {
            InitializeComponent();
        }

        public static void main()
        {
            Application.Run(new AsyncGood());
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            StartProcessDelegate progDel = new StartProcessDelegate(StartProcess);
            progDel.BeginInvoke(100, null, null);
            MessageBox.Show("Done With Operation!!");
        }

        // called async
        private void StartProcess(int max)
        {
            ShowProgress(0);
            for (int i = 0; i <= max; i++)
            {
                Thread.Sleep(10);
                ShowProgress(i);
            }
        }

        //update of controls will takes place here
        private void ShowProgress(int i)
        {
            //1- we need to check if a label needs to be invoked in the GUI thread
            // - you can do that using "InvokeRequired" property
            if(lblOutput.InvokeRequired == true)
            {
                // 2- if true this is hit by a background thread, so route the data from the background thread to the main thread
                // we need to use another delegate and pass the data(i) to the GUI Thread.
                // so we need to integrate another delegate with another async invocation, but this particular delegate
                // will be involved of routing the data from the background thread to main thread.

                // recursive call
                var del = new ShowProcessDelegate(ShowProgress);
                // using the word "this" which represent the "form" (main thread) with "BeginInvoke" will make
                // the main thread to run, so we re call the function and "else" will be hit, because "InvokeRequired" will be false
                this.BeginInvoke(del, new Object[] { i });
            }
            else
            {
                lblOutput.Text = i.ToString();
                pbStatus.Value = i;
            }
        }
    }
}
