using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.None;
        }

        bool mousePressed = false;
        Point mouseDownPos;

        private void buttonClose_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void buttonRollUp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnOstPlat_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnOstPlat.Height;
            SidePanel.Top = BtnOstPlat.Top;
            fristUserControl1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SidePanel.Height = button1.Height;
            SidePanel.Top = button1.Top;
            userCustomControl1.BringToFront();
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Focus();
            mousePressed = true;
            mouseDownPos = new Point(f1.Location.X + e.Location.X, f1.Location.Y
                + e.Location.Y + SystemInformation.CaptionHeight);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousePressed)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Left = Cursor.Position.X - mouseDownPos.X;
                    Top = Cursor.Position.Y - mouseDownPos.Y + 22;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //mousePressed = false;
        }
    }
}
