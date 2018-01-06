using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sample
{
    public partial class Form1 : Form
    {
        string myPath;
        string picPath;

        public Form1()
        {
            InitializeComponent();
            myPath = System.Environment.CurrentDirectory;
            picPath = myPath + "\\pic.jpg";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetPicture(picPath);
        }

        /// <summary>
        /// Give the picture to ImageBox
        /// </summary>
        /// <param name="picPath">file path of the picture</param>
        private void GetPicture(string picPath)
        {
            //How to use ImageClass.ImageBox
            //that is quite easy
            //All you have to do is giving the file path of the picture
            imageBox1.Image = Image.FromFile(picPath);
        }

        private void rToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetPicture(picPath);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string help = "How to use ?"+"\r\n" + "\r\n";
            help += "This ImageBox control allows you to browse, zoom and move pictures." + "\r\n" + "\r\n";
            help += "You can move the right mouse button to make a screenshot.";
            MessageBox.Show(help,"help");
        }
    }
}
