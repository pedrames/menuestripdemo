using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menuestripdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is an example", "about", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearColor()
        {
            blackToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
             redToolStripMenuItem.Checked = false;
            }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Black;
            blackToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Blue;
            blueToolStripMenuItem.Checked = true;
        }
        private void clearFont()
        {
            timesNewRomanToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
            comicSansToolStripMenuItem.Checked = false;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearColor();
            label1.ForeColor = Color.Red;
            redToolStripMenuItem.Checked = true;

        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("Courier", 14, label1.Font.Style);
            courierToolStripMenuItem.Checked = true;
        }

        private void comicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clearFont();
            label1.Font = new Font("comic Sans Ms", 14, label1.Font.Style);
            comicSansToolStripMenuItem.Checked = true;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked = !italicToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);

        }
    }
}
