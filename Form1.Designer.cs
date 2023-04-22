namespace WinFormsApp1
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
            this.color_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.save_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.size_bar = new System.Windows.Forms.TrackBar();
            this.test_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.erase_btn = new System.Windows.Forms.Button();
            this.rectangle_btn = new System.Windows.Forms.Button();
            this.elipse_btn = new System.Windows.Forms.Button();
            this.pencil_btn = new System.Windows.Forms.Button();
            this.fill_btn = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.undo_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // color_btn
            // 
            this.color_btn.Location = new System.Drawing.Point(292, 3);
            this.color_btn.Name = "color_btn";
            this.color_btn.Size = new System.Drawing.Size(65, 45);
            this.color_btn.TabIndex = 3;
            this.color_btn.Text = "Color";
            this.color_btn.UseVisualStyleBackColor = true;
            this.color_btn.Click += new System.EventHandler(this.color_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.undo_btn);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.size_bar);
            this.panel1.Controls.Add(this.test_btn);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.erase_btn);
            this.panel1.Controls.Add(this.rectangle_btn);
            this.panel1.Controls.Add(this.elipse_btn);
            this.panel1.Controls.Add(this.pencil_btn);
            this.panel1.Controls.Add(this.fill_btn);
            this.panel1.Controls.Add(this.color_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 68);
            this.panel1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(633, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(47, 16);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "Ctrl + C";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(750, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 16);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Ctrl + S";
            // 
            // save_btn
            // 
            this.save_btn.Location = new System.Drawing.Point(732, 3);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(65, 45);
            this.save_btn.TabIndex = 14;
            this.save_btn.Text = "Save";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(367, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 16);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Size";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // size_bar
            // 
            this.size_bar.Location = new System.Drawing.Point(363, 3);
            this.size_bar.Maximum = 30;
            this.size_bar.Minimum = 1;
            this.size_bar.Name = "size_bar";
            this.size_bar.Size = new System.Drawing.Size(104, 45);
            this.size_bar.TabIndex = 12;
            this.size_bar.Value = 1;
            this.size_bar.Scroll += new System.EventHandler(this.size_bar_Scroll);
            // 
            // test_btn
            // 
            this.test_btn.Location = new System.Drawing.Point(473, 3);
            this.test_btn.Name = "test_btn";
            this.test_btn.Size = new System.Drawing.Size(65, 45);
            this.test_btn.TabIndex = 11;
            this.test_btn.Text = "test";
            this.test_btn.UseVisualStyleBackColor = true;
            this.test_btn.Click += new System.EventHandler(this.test_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 46);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 19);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Shapes filled";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(615, 3);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(65, 45);
            this.clear_btn.TabIndex = 9;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // erase_btn
            // 
            this.erase_btn.Location = new System.Drawing.Point(544, 3);
            this.erase_btn.Name = "erase_btn";
            this.erase_btn.Size = new System.Drawing.Size(65, 45);
            this.erase_btn.TabIndex = 8;
            this.erase_btn.Text = "Erase";
            this.erase_btn.UseVisualStyleBackColor = true;
            this.erase_btn.Click += new System.EventHandler(this.erase_btn_Click);
            // 
            // rectangle_btn
            // 
            this.rectangle_btn.Location = new System.Drawing.Point(74, 3);
            this.rectangle_btn.Name = "rectangle_btn";
            this.rectangle_btn.Size = new System.Drawing.Size(70, 45);
            this.rectangle_btn.TabIndex = 7;
            this.rectangle_btn.Text = "Rectangle";
            this.rectangle_btn.UseVisualStyleBackColor = true;
            this.rectangle_btn.Click += new System.EventHandler(this.rectangle_btn_Click);
            // 
            // elipse_btn
            // 
            this.elipse_btn.Location = new System.Drawing.Point(3, 3);
            this.elipse_btn.Name = "elipse_btn";
            this.elipse_btn.Size = new System.Drawing.Size(65, 45);
            this.elipse_btn.TabIndex = 6;
            this.elipse_btn.Text = "Elipse";
            this.elipse_btn.UseVisualStyleBackColor = true;
            this.elipse_btn.Click += new System.EventHandler(this.elipse_btn_Click);
            // 
            // pencil_btn
            // 
            this.pencil_btn.Location = new System.Drawing.Point(150, 3);
            this.pencil_btn.Name = "pencil_btn";
            this.pencil_btn.Size = new System.Drawing.Size(65, 45);
            this.pencil_btn.TabIndex = 5;
            this.pencil_btn.Text = "Pencil";
            this.pencil_btn.UseVisualStyleBackColor = true;
            this.pencil_btn.Click += new System.EventHandler(this.pencil_btn_Click);
            // 
            // fill_btn
            // 
            this.fill_btn.Location = new System.Drawing.Point(221, 3);
            this.fill_btn.Name = "fill_btn";
            this.fill_btn.Size = new System.Drawing.Size(65, 45);
            this.fill_btn.TabIndex = 4;
            this.fill_btn.Text = "Fill";
            this.fill_btn.UseVisualStyleBackColor = true;
            this.fill_btn.Click += new System.EventHandler(this.fill_btn_Click);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(800, 450);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // undo_btn
            // 
            this.undo_btn.Location = new System.Drawing.Point(676, 3);
            this.undo_btn.Name = "undo_btn";
            this.undo_btn.Size = new System.Drawing.Size(59, 45);
            this.undo_btn.TabIndex = 17;
            this.undo_btn.Text = "Undo";
            this.undo_btn.UseVisualStyleBackColor = true;
            this.undo_btn.Click += new System.EventHandler(this.undo_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = " ";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.size_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button color_btn;
        private Panel panel1;
        private Button fill_btn;
        private Button elipse_btn;
        private Button pencil_btn;
        private PictureBox pic;
        private Button rectangle_btn;
        private Button erase_btn;
        private Button clear_btn;
        private CheckBox checkBox1;
        private Button test_btn;
        private TextBox textBox1;
        private TrackBar size_bar;
        private Button save_btn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button undo_btn;
    }
}