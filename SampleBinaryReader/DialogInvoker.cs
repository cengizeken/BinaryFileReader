using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SampleBinaryReader
{
    public class DialogInvoker
    {
        public OpenFileDialog InvokeDialog;
        private Thread InvokeThread;
        private DialogResult InvokeResult;

        public DialogInvoker()
        {
            InvokeDialog = new OpenFileDialog();
            InvokeThread = new Thread(new ThreadStart(InvokeMethod));
            InvokeThread.SetApartmentState(ApartmentState.STA);
            InvokeResult = DialogResult.None;
        }

        public DialogResult Invoke()
        {
            InvokeThread.Start();
            InvokeThread.Join();
            return InvokeResult;
        }

        private void InvokeMethod()
        {
            InvokeResult = InvokeDialog.ShowDialog();
        }
    }
}
