namespace ManagementApp.Forms
{
    partial class FormTasks
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
            this.btnCadastrar = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.chkStuacao = new System.Windows.Forms.CheckBox();
            this.lstTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.dateTask = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCadastrar.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnCadastrar.IconColor = System.Drawing.Color.Black;
            this.btnCadastrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastrar.IconSize = 35;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(37, 265);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCadastrar.Rotation = 0D;
            this.btnCadastrar.Size = new System.Drawing.Size(261, 43);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarefa";
            // 
            // txtTask
            // 
            this.txtTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTask.Location = new System.Drawing.Point(37, 70);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(261, 20);
            this.txtTask.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(34, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionário";
            // 
            // cmbUser
            // 
            this.cmbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "Gui"});
            this.cmbUser.Location = new System.Drawing.Point(37, 121);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(261, 21);
            this.cmbUser.TabIndex = 4;
            // 
            // chkStuacao
            // 
            this.chkStuacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkStuacao.AutoSize = true;
            this.chkStuacao.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chkStuacao.Location = new System.Drawing.Point(37, 216);
            this.chkStuacao.Name = "chkStuacao";
            this.chkStuacao.Size = new System.Drawing.Size(107, 17);
            this.chkStuacao.TabIndex = 5;
            this.chkStuacao.Text = "Tarefa Finalizada";
            this.chkStuacao.UseVisualStyleBackColor = true;
            this.chkStuacao.CheckedChanged += new System.EventHandler(this.chkFg_CheckedChanged);
            // 
            // lstTasks
            // 
            this.lstTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lstTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstTasks.GridLines = true;
            this.lstTasks.HideSelection = false;
            this.lstTasks.Location = new System.Drawing.Point(358, 54);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(420, 373);
            this.lstTasks.TabIndex = 6;
            this.lstTasks.UseCompatibleStateImageBehavior = false;
            this.lstTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descrição Tarefa";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Funcionário";
            this.columnHeader2.Width = 117;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Situação";
            this.columnHeader4.Width = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Data de Entrga";
            // 
            // dateTask
            // 
            this.dateTask.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTask.Location = new System.Drawing.Point(37, 177);
            this.dateTask.Name = "dateTask";
            this.dateTask.Size = new System.Drawing.Size(200, 20);
            this.dateTask.TabIndex = 7;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.Black;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.IconSize = 35;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(37, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Rotation = 0D;
            this.btnDelete.Size = new System.Drawing.Size(261, 43);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Excluir";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 460);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTask);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.chkStuacao);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "FormTasks";
            this.Text = "Tarefas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnCadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.CheckBox chkStuacao;
        private System.Windows.Forms.ListView lstTasks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTask;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private FontAwesome.Sharp.IconButton btnDelete;
    }
}