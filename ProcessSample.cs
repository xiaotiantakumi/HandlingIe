using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandlingIe
{
    public partial class ProcessSample : Form
    {
        private List<Process> pList = new List<Process>();

        public ProcessSample()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var p = Process.Start("IExplore.exe", "https://www.yahoo.co.jp/");
            pList.Add(p);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            var p = pList.Last();
            p.CloseMainWindow();
        }

        private void btnKill_Click(object sender, EventArgs e)
        {
            var p = pList.Last();
            p.Kill();
        }
    }
}
