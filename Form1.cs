using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace _12._11
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>();
        private int currentIndex = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.Text = "Image Gallery";
            this.Size = new Size(800, 600);
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Multiselect = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                    imagePaths.Add(fileName);

                if (currentIndex == -1 && imagePaths.Count > 0)
                {
                    currentIndex = 0;
                    ShowImage();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                imagePaths.RemoveAt(currentIndex);
                if (currentIndex >= imagePaths.Count)currentIndex--;
                ShowImage();
            }
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                currentIndex = (currentIndex - 1 + imagePaths.Count) % imagePaths.Count;
                ShowImage();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                currentIndex = (currentIndex + 1) % imagePaths.Count;
                ShowImage();
            }
        }

        private void ShowImage()
        {
            PictureBox pictureBox = (PictureBox)this.Controls["pb"];
            if (currentIndex >= 0 && currentIndex < imagePaths.Count)pictureBox.Image = Image.FromFile(imagePaths[currentIndex]);
            else pictureBox.Image = null;
        }
    }
}
