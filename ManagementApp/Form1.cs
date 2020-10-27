using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementApp
{
    
    public partial class FormMainMenu : Form
    {
        FormMainMenu form1;
        private IconButton currentButton;
        private Panel leftBorderBtn;

        //Constructors
        public FormMainMenu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 38);
            panelMenu.Controls.Add(leftBorderBtn);
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
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentButton = (IconButton)senderBtn;
                currentButton.BackColor = Color.FromArgb(37, 36, 81);
                currentButton.ForeColor = color;
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = color;
                currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(31, 30, 68);
                currentButton.ForeColor = Color.Gainsboro;
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.Gainsboro;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            //Stock stock = new Stock();
            //stock.Show();
            form1 = new FormMainMenu();
            form1.Close();
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            Accounts accounts = new Accounts();
            accounts.Show();
            form1 = new FormMainMenu();
            form1.Close();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            Tasks tasks = new Tasks();
            tasks.Show();
            form1 = new FormMainMenu();
            form1.Close();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
        }

        private void btnTask_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
        }

        private void btnAccounts_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color6);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
        }
    }
}
