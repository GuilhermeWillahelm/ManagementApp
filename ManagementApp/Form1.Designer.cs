namespace ManagementApp
{
    partial class FormMainMenu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnAccounts = new FontAwesome.Sharp.IconButton();
            this.btnTask = new FontAwesome.Sharp.IconButton();
            this.btnProducts = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.btnDash = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.lblChildTittle = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnAccounts);
            this.panelMenu.Controls.Add(this.btnTask);
            this.panelMenu.Controls.Add(this.btnProducts);
            this.panelMenu.Controls.Add(this.btnSales);
            this.panelMenu.Controls.Add(this.btnDash);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 450);
            this.panelMenu.TabIndex = 3;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 352);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSettings.Rotation = 0D;
            this.btnSettings.Size = new System.Drawing.Size(220, 38);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Configuração";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAccounts
            // 
            this.btnAccounts.FlatAppearance.BorderSize = 0;
            this.btnAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccounts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAccounts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnAccounts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnAccounts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAccounts.IconSize = 32;
            this.btnAccounts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.Location = new System.Drawing.Point(0, 308);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAccounts.Rotation = 0D;
            this.btnAccounts.Size = new System.Drawing.Size(220, 38);
            this.btnAccounts.TabIndex = 5;
            this.btnAccounts.Text = "Contas";
            this.btnAccounts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccounts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click_1);
            // 
            // btnTask
            // 
            this.btnTask.FlatAppearance.BorderSize = 0;
            this.btnTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTask.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTask.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTask.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnTask.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTask.IconSize = 32;
            this.btnTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.Location = new System.Drawing.Point(0, 267);
            this.btnTask.Name = "btnTask";
            this.btnTask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTask.Rotation = 0D;
            this.btnTask.Size = new System.Drawing.Size(220, 38);
            this.btnTask.TabIndex = 4;
            this.btnTask.Text = "Tarefas";
            this.btnTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.btnProducts.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProducts.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProducts.IconSize = 32;
            this.btnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Location = new System.Drawing.Point(0, 223);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnProducts.Rotation = 0D;
            this.btnProducts.Size = new System.Drawing.Size(220, 38);
            this.btnProducts.TabIndex = 3;
            this.btnProducts.Text = "Produtos";
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnSales
            // 
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSales.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnSales.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.IconSize = 32;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 181);
            this.btnSales.Name = "btnSales";
            this.btnSales.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSales.Rotation = 0D;
            this.btnSales.Size = new System.Drawing.Size(220, 38);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnDash
            // 
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDash.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDash.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.btnDash.IconColor = System.Drawing.Color.Gainsboro;
            this.btnDash.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDash.IconSize = 32;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.Location = new System.Drawing.Point(0, 136);
            this.btnDash.Name = "btnDash";
            this.btnDash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDash.Rotation = 0D;
            this.btnDash.Size = new System.Drawing.Size(220, 38);
            this.btnDash.TabIndex = 1;
            this.btnDash.Text = "Dashboard";
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 130);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::ManagementApp.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(12, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(193, 84);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.lblChildTittle);
            this.panel1.Controls.Add(this.iconHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 75);
            this.panel1.TabIndex = 4;
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconHome.IconColor = System.Drawing.Color.Gainsboro;
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.Location = new System.Drawing.Point(23, 32);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(32, 32);
            this.iconHome.TabIndex = 0;
            this.iconHome.TabStop = false;
            // 
            // lblChildTittle
            // 
            this.lblChildTittle.AutoSize = true;
            this.lblChildTittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblChildTittle.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChildTittle.Location = new System.Drawing.Point(61, 38);
            this.lblChildTittle.Name = "lblChildTittle";
            this.lblChildTittle.Size = new System.Drawing.Size(71, 26);
            this.lblChildTittle.TabIndex = 1;
            this.lblChildTittle.Text = "Home";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "FormMainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnAccounts;
        private FontAwesome.Sharp.IconButton btnTask;
        private FontAwesome.Sharp.IconButton btnProducts;
        private FontAwesome.Sharp.IconButton btnSales;
        private FontAwesome.Sharp.IconButton btnDash;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconHome;
        private System.Windows.Forms.Label lblChildTittle;
    }
}

