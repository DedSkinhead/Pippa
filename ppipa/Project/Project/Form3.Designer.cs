
namespace Project
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Knopka_Registra = new System.Windows.Forms.Button();
            this.Knopka_Voqti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваш индификационный номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Добро пожаловать в программу EF! ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваш пароль";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(325, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(325, 179);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(325, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(118, 19);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Запомнить меня";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Knopka_Registra
            // 
            this.Knopka_Registra.Location = new System.Drawing.Point(188, 285);
            this.Knopka_Registra.Name = "Knopka_Registra";
            this.Knopka_Registra.Size = new System.Drawing.Size(141, 23);
            this.Knopka_Registra.TabIndex = 6;
            this.Knopka_Registra.Text = "Зарегестрироваться";
            this.Knopka_Registra.UseVisualStyleBackColor = true;
            this.Knopka_Registra.Click += new System.EventHandler(this.Knopka_Registra_Click);
            // 
            // Knopka_Voqti
            // 
            this.Knopka_Voqti.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Knopka_Voqti.Location = new System.Drawing.Point(457, 285);
            this.Knopka_Voqti.Name = "Knopka_Voqti";
            this.Knopka_Voqti.Size = new System.Drawing.Size(75, 23);
            this.Knopka_Voqti.TabIndex = 7;
            this.Knopka_Voqti.Text = "Войти";
            this.Knopka_Voqti.UseVisualStyleBackColor = false;
            this.Knopka_Voqti.Click += new System.EventHandler(this.Knopka_Voqti_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(735, 420);
            this.Controls.Add(this.Knopka_Voqti);
            this.Controls.Add(this.Knopka_Registra);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button Knopka_Registra;
        private System.Windows.Forms.Button Knopka_Voqti;
    }
}