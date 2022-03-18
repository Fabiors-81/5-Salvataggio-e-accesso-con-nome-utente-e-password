namespace Salvataggio_e_accesso_con_user_e_pwd
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
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.btn_Invio = new System.Windows.Forms.Button();
            this.btn_Registrati = new System.Windows.Forms.Button();
            this.btl_LeggiTesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(1205, 251);
            this.label_Password.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(143, 41);
            this.label_Password.TabIndex = 9;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label_Username.Location = new System.Drawing.Point(495, 251);
            this.label_Username.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(152, 41);
            this.label_Username.TabIndex = 8;
            this.label_Username.Text = "Username";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(1071, 301);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(395, 47);
            this.txt_Password.TabIndex = 7;
            this.txt_Password.TextChanged += new System.EventHandler(this.txt_ChangeColor);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(398, 301);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(366, 47);
            this.txt_Username.TabIndex = 6;
            this.txt_Username.TextChanged += new System.EventHandler(this.txt_ChangeColor);
            // 
            // btn_Invio
            // 
            this.btn_Invio.Location = new System.Drawing.Point(1205, 541);
            this.btn_Invio.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_Invio.Name = "btn_Invio";
            this.btn_Invio.Size = new System.Drawing.Size(182, 63);
            this.btn_Invio.TabIndex = 5;
            this.btn_Invio.Text = "Accedi";
            this.btn_Invio.UseVisualStyleBackColor = true;
            this.btn_Invio.Click += new System.EventHandler(this.btn_Invio_Click);
            // 
            // btn_Registrati
            // 
            this.btn_Registrati.Location = new System.Drawing.Point(495, 541);
            this.btn_Registrati.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btn_Registrati.Name = "btn_Registrati";
            this.btn_Registrati.Size = new System.Drawing.Size(182, 63);
            this.btn_Registrati.TabIndex = 10;
            this.btn_Registrati.Text = "Registrati";
            this.btn_Registrati.UseVisualStyleBackColor = true;
            this.btn_Registrati.Click += new System.EventHandler(this.btn_Registrati_Click);
            // 
            // btl_LeggiTesto
            // 
            this.btl_LeggiTesto.Location = new System.Drawing.Point(848, 768);
            this.btl_LeggiTesto.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btl_LeggiTesto.Name = "btl_LeggiTesto";
            this.btl_LeggiTesto.Size = new System.Drawing.Size(182, 63);
            this.btl_LeggiTesto.TabIndex = 11;
            this.btl_LeggiTesto.Text = "Leggi Testo";
            this.btl_LeggiTesto.UseVisualStyleBackColor = true;
            this.btl_LeggiTesto.Click += new System.EventHandler(this.btl_LeggiTesto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1943, 1230);
            this.Controls.Add(this.btl_LeggiTesto);
            this.Controls.Add(this.btn_Registrati);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_Invio);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "ACCESSO UTENTE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Password;
        private Label label_Username;
        private TextBox txt_Password;
        private TextBox txt_Username;
        private Button btn_Invio;
        private Button btn_Registrati;
        private Button btl_LeggiTesto;
    }
}