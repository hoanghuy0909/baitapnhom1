using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace baitapnhom
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void chiTiếtThuêSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmchitietthuesach frm = new frmchitietthuesach();
            frm.Show();
        }

        private void sáchTruyệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmsachtruyen1 frm = new frmsachtruyen1();
            frm.Show();
        }
    }
}
