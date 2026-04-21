using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2d_shapes
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void miExampleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExample frmExample = new FrmExample();
            frmExample.MdiParent = this;
            frmExample.Show();
        }

        private void miRectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRectangulo frmRectangulo = new FrmRectangulo();
            frmRectangulo.MdiParent = this;
            frmRectangulo.Show();
        }

        private void miShapesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTriangulo frmTriangulo= new FrmTriangulo();
            frmTriangulo.MdiParent = this;
            frmTriangulo.Show();
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCirculo frmCirculo = new FrmCirculo();
            frmCirculo.MdiParent = this;
            frmCirculo.Show();
        }
    }
}
