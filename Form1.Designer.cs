using System.Windows.Forms;

namespace _12._11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb = new PictureBox();
            btnLoad = new Button();
            btnDelete = new Button();
            btnPrevious = new Button();
            btnNext = new Button();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.Location = new Point(222, 19);
            pb.Name = "pb";
            pb.Size = new Size(225, 216);
            pb.TabIndex = 0;
            pb.TabStop = false;
            pb.Dock = DockStyle.Fill;
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(508, 212);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Добавить изображения";
            btnLoad.Dock = DockStyle.Top;
            btnLoad.Click += BtnLoad_Click;
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(623, 212);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить изображение";
            btnDelete.Dock = DockStyle.Bottom;
            btnDelete.Click += BtnDelete_Click;
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(222, 270);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(75, 23);
            btnPrevious.TabIndex = 3;
            btnPrevious.Text = "<";
            btnPrevious.Dock = DockStyle.Left;
            btnPrevious.Width = 50;
            btnPrevious.Click += BtnPrevious_Click;
            btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(343, 270);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 23);
            btnNext.TabIndex = 4;
            btnNext.Text = ">";
            btnNext.Dock = DockStyle.Right;
            btnNext.Width = 50;
            btnNext.Click += BtnNext_Click;
            btnNext.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnDelete);
            Controls.Add(btnLoad);
            Controls.Add(pb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb;
        private Button btnLoad;
        private Button btnDelete;
        private Button btnPrevious;
        private Button btnNext;
    }
}
