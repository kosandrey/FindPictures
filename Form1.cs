#define TEST
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindPic
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
        private void button1_Click(object sender, EventArgs e)
        {
            #if TEST
               FindPicDemo.SelectedPath = "D:\\Andrey\\Картинки"; 
            #endif

            FindPicDemo.SearchIm();
            PicturesPanel.RowStyles[0].Height = PicturesPanel.ColumnStyles[0].Width;
            int TotalAmount = 0;
            foreach (string p in FindPicDemo.Pictures)
            {
                PictureBox _PictureBox = new PictureBox();
                _PictureBox.Image = Image.FromFile(p);
                _PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                _PictureBox.Dock = DockStyle.Fill;
                PicturesPanel.Controls.Add(_PictureBox);
                TotalAmount++;
            }
            if(TotalAmount != 0)
                label.Text = "Total Amount: " + TotalAmount;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                FindPicDemo.SelectedPath = FBD.SelectedPath;
                Folder.AppendText(FindPicDemo.SelectedPath);               
            }
            
        }
        private void Folder_TextChanged(object sender, EventArgs e)
        {
            FindPicDemo.SelectedPath = Folder.Text;
        }
    }
}
