using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            panelSide.Height = btnTrangChu.Height;
            panelSide.Top = btnTrangChu.Top;
            homeSide.BringToFront();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnTrangChu.Height;
            panelSide.Top = btnTrangChu.Top;
            homeSide.BringToFront();
        }

        private void btnQlbh_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnQlbh.Height;
            panelSide.Top = btnQlbh.Top;
            qlbhSide.BringToFront();
        }

        private void btnKmtv_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnKmtv.Height;
            panelSide.Top = btnKmtv.Top;
            kmtvSide.BringToFront();
        }

        private void btnTct_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnTct.Height;
            panelSide.Top = btnTct.Top;
            tctSide.BringToFront();
        }

        private void btnQlmh_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnQlmh.Height;
            panelSide.Top = btnQlmh.Top;
            qlmhSide.BringToFront();
        }

        private void btnQltk_Click(object sender, EventArgs e)
        {
            panelSide.Height = btnQltk.Height;
            panelSide.Top = btnQltk.Top;
            qltkSide.BringToFront();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            //DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát !", "Thoát", MessageBoxButtons.YesNo);
            //if(dialog == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            dialogShutDown dialog = new dialogShutDown();
            dialog.Show();
        }
    }
}
