using CommunicationBetweenControls.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationBetweenControls
{
   public class JobChangedEventArgs : System.EventArgs
    {
        public Job Job { get; set; }
    }
}
