using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppLifecycleFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            sr.WriteLine("1 - MOVE event");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sr.WriteLine("2 - LOAD event");
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            sr.WriteLine("3 - VisibleChanged event");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            sr.WriteLine("4 - ACTIVATED event");
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            sr.WriteLine("5 - SHOWN event");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            sr.WriteLine("6 - PAINT event");
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            sr.WriteLine("7 - DEACTIVATE event");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sr.WriteLine("8 - FormClosing event");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            sr.WriteLine("9 - FormCLOSED event");
        }

        
    }
}
