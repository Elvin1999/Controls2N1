using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;

            progressBar1.Maximum = Data;
            progressBar1.Step = Data / Speed;

            toolTip1.SetToolTip(pictureBox1, "Nature Wallpaper");
            toolTip1.SetToolTip(progressBar1, "It is progresbar");

        }
        public int Data { get; set; } = 1000;
        public int Speed { get; set; } = 10;
        private void Timer_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar1.PerformStep();
            progressBar1.PerformStep();
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer.Stop();
                MessageBox.Show("Downloading Ended");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label1.Font = new Font("Comic Sans MS", int.Parse(numericUpDown1.Value.ToString()), FontStyle.Bold);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar4.Value);
        }

        private void deepPinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepPink;
        }

        private void deepSkyBlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DeepSkyBlue;

        }
    }
}
