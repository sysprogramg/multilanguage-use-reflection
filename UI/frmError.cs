using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmError : Form
    {
        public frmError(string error, string title)
        {
            InitializeComponent();
            lblTitleError.Text = title.ToUpper();
            lblError.Text = error;
            int totalWidth = lblTitleError.Width + 46;
            picError.Left = (Width - totalWidth) / 2;
            lblTitleError.Left = picError.Left + 46;
        }

        private void frmError_KeyPress(object sender, KeyPressEventArgs e)
        {
            Close();
        }
    }
}
