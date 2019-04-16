namespace EkranNotDefteri
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gösterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 44);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(233, 198);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.richTextBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bugün";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(135, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Yarın";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 275);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.monthCalendar1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 446);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bugün Günlerden ";
            this.label1.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pazartesi";
            this.label2.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(166, 459);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "27.07.2018";
            this.label3.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(166, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarih";
            this.label4.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(169, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "İleri";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(12, 482);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Geri";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.button4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tarihe Not Düşün";
            this.label5.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(168, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "27.07.2018";
            this.label6.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.label6.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(188, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Seçili Tarih";
            this.label7.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.label7.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Not Defteri";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gösterToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 48);
            // 
            // gösterToolStripMenuItem
            // 
            this.gösterToolStripMenuItem.Name = "gösterToolStripMenuItem";
            this.gösterToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.gösterToolStripMenuItem.Text = "Göster";
            this.gösterToolStripMenuItem.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.gösterToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            this.çıkışToolStripMenuItem.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.çıkışToolStripMenuItem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 511);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 30);
            this.button5.TabIndex = 13;
            this.button5.Text = "Gelişmiş Seçenekler";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.MouseLeave += new System.EventHandler(this.richTextBox1_MouseLeave);
            this.button5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.monthCalendar1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(260, 553);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ekran Not Defteri";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gösterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Button button5;
    }
}

