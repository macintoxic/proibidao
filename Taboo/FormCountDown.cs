using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taboo
{
    public partial class FormCountDown : Form
    {
        private int start = 5;
        public FormCountDown()
        {
            InitializeComponent();
        }

        private void FormCountDown_Load(object sender, EventArgs e)
        {
            lblCountDown.Text = start.ToString();
            tmrCountDown.Start();
            Application.DoEvents();
        }

        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            start--;
            lblCountDown.Text = start.ToString();
            Application.DoEvents();
            
            if (start == 0)
            {
                Close();
            }
        }
    }
}
