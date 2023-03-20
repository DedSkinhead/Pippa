
namespace Project
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
            this.Knopka_vixod = new System.Windows.Forms.Button();
            this.knopka_set = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.knopka_polzovatel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Knopka_vixod
            // 
            this.Knopka_vixod.Location = new System.Drawing.Point(1846, 891);
            this.Knopka_vixod.Name = "Knopka_vixod";
            this.Knopka_vixod.Size = new System.Drawing.Size(93, 37);
            this.Knopka_vixod.TabIndex = 1;
            this.Knopka_vixod.Text = "Выход";
            this.Knopka_vixod.UseVisualStyleBackColor = true;
            this.Knopka_vixod.Click += new System.EventHandler(this.Knopka_vixod_Click);
            // 
            // knopka_set
            // 
            this.knopka_set.Location = new System.Drawing.Point(40, 898);
            this.knopka_set.Name = "knopka_set";
            this.knopka_set.Size = new System.Drawing.Size(147, 30);
            this.knopka_set.TabIndex = 2;
            this.knopka_set.Text = "Выйти в сеть";
            this.knopka_set.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1995, 718);
            this.dataGridView1.TabIndex = 3;
            // 
            // knopka_polzovatel
            // 
            this.knopka_polzovatel.Location = new System.Drawing.Point(921, 898);
            this.knopka_polzovatel.Name = "knopka_polzovatel";
            this.knopka_polzovatel.Size = new System.Drawing.Size(205, 30);
            this.knopka_polzovatel.TabIndex = 4;
            this.knopka_polzovatel.Text = "Сменить пользователя";
            this.knopka_polzovatel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(921, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(103, 0, 103, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Добро пожаловать в EF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(921, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Вывод полной статистики";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2062, 993);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.knopka_polzovatel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.knopka_set);
            this.Controls.Add(this.Knopka_vixod);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Knopka_vixod;
        private System.Windows.Forms.Button knopka_set;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button knopka_polzovatel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

