using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandlingIe
{
    public partial class Form1 : Form
    {
        private IeManager _ieYahoo;
        private IeManager _ieGoogle;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnOpenYahoo_Click(object sender, EventArgs e)
        {
            if (_ieYahoo != null)
            {
                _ieYahoo.Dispose();
            }
            _ieYahoo = new IeManager(@"https://www.yahoo.co.jp/");
            this.lblCloseParentYahoo.Text = _ieYahoo.IsParentClosed.ToString();
            _ieYahoo.onQuitParentAction = () =>
            {
                Invoke(new Action<int>(SetLabelMsg),0);
            };
        }
        public void SetLabelMsg(int flg)
        {
            if (flg == 0)
            {
                this.lblCloseParentYahoo.Text = _ieYahoo.IsParentClosed.ToString();
            }
            else
            {
                lblCloseParentGoogle.Text = _ieYahoo.IsParentClosed.ToString();
            }
            
        }
        private void btnYahooCloseLastOpenWindow_Click(object sender, EventArgs e)
        {
            _ieYahoo?.CloseLastChildIe();
        }

        private void btnYahooCloseAll_Click(object sender, EventArgs e)
        {
            if (_ieYahoo != null)
            {
                _ieYahoo.Dispose();
                this.lblCloseParentYahoo.Text = _ieYahoo.IsParentClosed.ToString();
            }
        }

        private void btnOpenGoogle_Click(object sender, EventArgs e)
        {
            if (_ieGoogle != null)
            {
                _ieGoogle.Dispose();
            }
            _ieGoogle = new IeManager(@"https://www.google.com/");
            lblCloseParentGoogle.Text = _ieYahoo.IsParentClosed.ToString();
            _ieGoogle.onQuitParentAction = () =>
            {
                Invoke(new Action<int>(SetLabelMsg), 1);
            };
        }

        private void btnGoogleCloseLastOpenWindow_Click(object sender, EventArgs e)
        {
            _ieGoogle?.CloseLastChildIe();
        }

        private void btnGoogleCloseAll_Click(object sender, EventArgs e)
        {
            if (_ieGoogle != null)
            {
                _ieGoogle.Dispose();
                lblCloseParentGoogle.Text = _ieYahoo.IsParentClosed.ToString();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ieYahoo?.Dispose();
            _ieGoogle?.Dispose();
        }
    }
}
