namespace DPI_BLOCKER
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label5 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            checkBox1 = new CheckBox();
            label8 = new Label();
            button3 = new Button();
            label6 = new Label();
            label7 = new Label();
            tabPage2 = new TabPage();
            label1 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            label9 = new Label();
            numericUpDown1 = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(8, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(453, 303);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(445, 275);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Başlat / Durdur";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(6, 3);
            label5.Name = "label5";
            label5.Size = new Size(182, 21);
            label5.TabIndex = 3;
            label5.Text = "DPI Blocker - Anasayfa";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(checkBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(6, 30);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 239);
            panel2.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label11.Location = new Point(9, 208);
            label11.Name = "label11";
            label11.Size = new Size(277, 17);
            label11.TabIndex = 9;
            label11.Text = "Servisi durdurmadan uygulamayı kapatmayınız";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            checkBox1.Location = new Point(12, 96);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(314, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Başlatılırken DNS Önbelleği Temizlensin (Önerilir!)";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label8.Location = new Point(8, 185);
            label8.Name = "label8";
            label8.Size = new Size(421, 17);
            label8.TabIndex = 7;
            label8.Text = "DNS Önbelleği temizlenirken kısa süreli bir internet kesintisi yaşanabilir.";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            button3.Location = new Point(123, 26);
            button3.Name = "button3";
            button3.Size = new Size(184, 56);
            button3.TabIndex = 6;
            button3.Text = "Başlat";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label6.Location = new Point(8, 127);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 5;
            label6.Text = "Durum: Kapalı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label7.Location = new Point(8, 159);
            label7.Name = "label7";
            label7.Size = new Size(288, 17);
            label7.TabIndex = 4;
            label7.Text = "DPI Blocker'ı etkinleştirmek için Başlat'a tıklayınız.\r\n";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(panel1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(445, 275);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Ayarlar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(11, 7);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 1;
            label1.Text = "Otomatik Ayar Bulucu";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(numericUpDown1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(7, 34);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 179);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label10.Location = new Point(3, 155);
            label10.Name = "label10";
            label10.Size = new Size(375, 17);
            label10.TabIndex = 8;
            label10.Text = "İnternet bağlantınız yavaş ise timeout değerini yükseltebilirsiniz.";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label9.Location = new Point(1, 72);
            label9.Name = "label9";
            label9.Size = new Size(70, 21);
            label9.TabIndex = 7;
            label9.Text = "Timeout:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(75, 72);
            numericUpDown1.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 3, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 6;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(2, 103);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 5;
            label4.Text = "Durum: Boşta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(3, 137);
            label3.Name = "label3";
            label3.Size = new Size(340, 17);
            label3.TabIndex = 4;
            label3.Text = "Bu modül girdiğiniz url için uygun bir DPI ayarı bulacaktır.";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(259, 72);
            button1.Name = "button1";
            button1.Size = new Size(123, 27);
            button1.TabIndex = 3;
            button1.Text = "Ayar Bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(391, 21);
            label2.TabIndex = 2;
            label2.Text = "Erişim Engelli Bir Url Giriniz: (Örn: https://discord.com/)";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(4, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(402, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(173, 309);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 15);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.nokersoft.com";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(473, 329);
            Controls.Add(linkLabel1);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "DPI BLOCKER";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private Label label4;
        private Label label5;
        private Panel panel2;
        private Label label6;
        private Label label7;
        private Button button3;
        private Label label8;
        private Label label9;
        private NumericUpDown numericUpDown1;
        private Label label10;
        private CheckBox checkBox1;
        private LinkLabel linkLabel1;
        private Label label11;
    }
}
