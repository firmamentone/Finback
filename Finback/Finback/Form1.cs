//JAN 19 2020 T.I. Created this file

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Finback
{
    public partial class Form1 : Form
    {

 
        perfDrawing x1=new perfDrawing();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            pictureBox1.Image = x1.draw24x30();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
