﻿using System.Drawing;
using System.Windows.Forms;

namespace Vectors1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Create a Graphics object to draw on the form
            Graphics g = e.Graphics;

            // Create a Pen and a Brush for drawing
            Pen pen = new Pen(Color.Blue, 2);
            Brush brush = new SolidBrush(Color.Red);

            // Draw a rectangle
            g.DrawArc(pen, 100, 100, 100, 100, 0, 360);
            g.DrawLine(pen, 100, -150, -100, 150);
            // Dispose of the Pen and Brush
            pen.Dispose();
            brush.Dispose();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}

