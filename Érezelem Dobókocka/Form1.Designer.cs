namespace Érezelem_Dobókocka
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_general = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Részletes_alapérzelmek = new System.Windows.Forms.RadioButton();
            this.radioButton_egyszerű_alapérzelmek = new System.Windows.Forms.RadioButton();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(307, 29);
            this.textBox1.TabIndex = 0;
            // 
            // button_general
            // 
            this.button_general.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_general.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_general.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_general.Location = new System.Drawing.Point(98, 105);
            this.button_general.Name = "button_general";
            this.button_general.Size = new System.Drawing.Size(133, 60);
            this.button_general.TabIndex = 1;
            this.button_general.Text = "Pörgetés";
            this.button_general.UseVisualStyleBackColor = true;
            this.button_general.Click += new System.EventHandler(this.button_general_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 172);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(339, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(272, 17);
            this.toolStripStatusLabel1.Text = "©2020, Dr. Devosa Iván - Dr. Tiszai Luca - Freeware";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Részletes_alapérzelmek);
            this.groupBox1.Controls.Add(this.radioButton_egyszerű_alapérzelmek);
            this.groupBox1.Location = new System.Drawing.Point(12, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 43);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nehézségi szint";
            // 
            // radioButton_Részletes_alapérzelmek
            // 
            this.radioButton_Részletes_alapérzelmek.AutoSize = true;
            this.radioButton_Részletes_alapérzelmek.Location = new System.Drawing.Point(164, 19);
            this.radioButton_Részletes_alapérzelmek.Name = "radioButton_Részletes_alapérzelmek";
            this.radioButton_Részletes_alapérzelmek.Size = new System.Drawing.Size(136, 17);
            this.radioButton_Részletes_alapérzelmek.TabIndex = 3;
            this.radioButton_Részletes_alapérzelmek.Text = "Részletes alapérzelmek";
            this.radioButton_Részletes_alapérzelmek.UseVisualStyleBackColor = true;
            // 
            // radioButton_egyszerű_alapérzelmek
            // 
            this.radioButton_egyszerű_alapérzelmek.AutoSize = true;
            this.radioButton_egyszerű_alapérzelmek.Checked = true;
            this.radioButton_egyszerű_alapérzelmek.Location = new System.Drawing.Point(6, 19);
            this.radioButton_egyszerű_alapérzelmek.Name = "radioButton_egyszerű_alapérzelmek";
            this.radioButton_egyszerű_alapérzelmek.Size = new System.Drawing.Size(133, 17);
            this.radioButton_egyszerű_alapérzelmek.TabIndex = 2;
            this.radioButton_egyszerű_alapérzelmek.TabStop = true;
            this.radioButton_egyszerű_alapérzelmek.Text = "Egyszerű alapérzelmek";
            this.radioButton_egyszerű_alapérzelmek.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button_general;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.button_general;
            this.ClientSize = new System.Drawing.Size(339, 194);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_general);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Érzelem Dobókocka 1.1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_general;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Részletes_alapérzelmek;
        private System.Windows.Forms.RadioButton radioButton_egyszerű_alapérzelmek;
    }
}

