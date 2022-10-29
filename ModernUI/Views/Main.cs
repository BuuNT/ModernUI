using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ModernUI.Views
{
    public partial class Main : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        //Constructor
        public Main()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            pnlMenu.Controls.Add(leftBorderBtn);
            //Main Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //Caption color
            Dwmapi.ChangeColor(Handle, 35, pnlTitle.BackColor);
        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //Methods
        private void ActiveButton(object sender, Color color)
        {
            ResetToDefault();
            if (sender != null)
            {
                //Current button
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //Left border button
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Size = new Size(5, currentBtn.Size.Height);
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon current child form
                icnCurrentChildForm.IconChar = currentBtn.IconChar;
                icnCurrentChildForm.IconColor = currentBtn.IconColor;
                //Label current child form
                lblCurrentChildForm.Text = currentBtn.Text;
                lblCurrentChildForm.ForeColor = currentBtn.ForeColor;
                //Horizontal line
                pnlHorizontalLine.BackColor = color;
            }
        }

        private void ResetToDefault()
        {
            if (currentBtn != null)
            {
                //Current button
                currentBtn.BackColor = pnlMenu.BackColor;
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                //Left border button
                leftBorderBtn.Visible = false;
                //Icon current child form
                icnCurrentChildForm.IconChar = IconChar.Home;
                icnCurrentChildForm.IconColor = Color.Gainsboro;
                //Label current child form
                lblCurrentChildForm.Text = "Home";
                lblCurrentChildForm.ForeColor = Color.Gainsboro;
                //Horizontal line
                pnlHorizontalLine.BackColor = Color.Gainsboro;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            CloseChildForm();
            currentChildForm = childForm;
            currentChildForm.TopLevel = false;
            currentChildForm.Dock = DockStyle.Fill;
            currentChildForm.FormBorderStyle = FormBorderStyle.None;
            pnlDesktop.Controls.Add(currentChildForm);
            lblCurrentChildForm.Text = currentChildForm.Text;
            currentChildForm.BringToFront();
            currentChildForm.Show();

        }

        private void CloseChildForm()
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            User32.DragDrop(this.Handle);
        }

        private void pteLogo_Click(object sender, EventArgs e)
        {
            ResetToDefault();
            CloseChildForm();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized:
                    btnMaximize.Image = Properties.Resources.white_maximize_32;
                    this.WindowState = FormWindowState.Normal; break;
                case FormWindowState.Normal:
                    btnMaximize.Image = Properties.Resources.white_normal_32;
                    this.WindowState = FormWindowState.Maximized; break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.color1);
            OpenChildForm(new DashBoard());
        }
    }
}
