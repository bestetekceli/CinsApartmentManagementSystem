namespace HowToFixMyCardReader
{
    partial class CinsAptCardReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CinsAptCardReader));
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Access = new AltoControls.AltoButton();
            this.rjCircularPictureBox1 = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.aptno_combobox = new RJCodeAdvance.RJControls.RJComboBox();
            this.txt_name = new RJCodeAdvance.RJControls.RJTextBox();
            this.altoButton1 = new AltoControls.AltoButton();
            this.label1 = new System.Windows.Forms.Label();
            this.altoButton2 = new AltoControls.AltoButton();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbl_Name.Location = new System.Drawing.Point(29, 48);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(65, 23);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name : ";
            // 
            // btn_Access
            // 
            this.btn_Access.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_Access.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Access.BackColor = System.Drawing.Color.Transparent;
            this.btn_Access.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Access.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Access.ForeColor = System.Drawing.Color.Black;
            this.btn_Access.Inactive1 = System.Drawing.Color.Lime;
            this.btn_Access.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Access.Location = new System.Drawing.Point(106, 111);
            this.btn_Access.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Access.Name = "btn_Access";
            this.btn_Access.Radius = 10;
            this.btn_Access.Size = new System.Drawing.Size(140, 29);
            this.btn_Access.Stroke = false;
            this.btn_Access.StrokeColor = System.Drawing.Color.Gray;
            this.btn_Access.TabIndex = 5;
            this.btn_Access.Text = "Enter";
            this.btn_Access.Transparency = false;
            this.btn_Access.Click += new System.EventHandler(this.btn_Access_Click);
            // 
            // rjCircularPictureBox1
            // 
            this.rjCircularPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rjCircularPictureBox1.BackgroundImage")));
            this.rjCircularPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rjCircularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.rjCircularPictureBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rjCircularPictureBox1.BorderColor2 = System.Drawing.Color.SpringGreen;
            this.rjCircularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.rjCircularPictureBox1.BorderSize = 3;
            this.rjCircularPictureBox1.GradientAngle = 50F;
            this.rjCircularPictureBox1.Location = new System.Drawing.Point(253, 41);
            this.rjCircularPictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rjCircularPictureBox1.Name = "rjCircularPictureBox1";
            this.rjCircularPictureBox1.Size = new System.Drawing.Size(81, 81);
            this.rjCircularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rjCircularPictureBox1.TabIndex = 6;
            this.rjCircularPictureBox1.TabStop = false;
            // 
            // aptno_combobox
            // 
            this.aptno_combobox.BackColor = System.Drawing.Color.Ivory;
            this.aptno_combobox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.aptno_combobox.BorderSize = 2;
            this.aptno_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.aptno_combobox.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aptno_combobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aptno_combobox.IconColor = System.Drawing.Color.Cyan;
            this.aptno_combobox.ListBackColor = System.Drawing.Color.Ivory;
            this.aptno_combobox.ListTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aptno_combobox.Location = new System.Drawing.Point(106, 77);
            this.aptno_combobox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.aptno_combobox.MinimumSize = new System.Drawing.Size(140, 18);
            this.aptno_combobox.Name = "aptno_combobox";
            this.aptno_combobox.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.aptno_combobox.Size = new System.Drawing.Size(140, 23);
            this.aptno_combobox.TabIndex = 7;
            this.aptno_combobox.Texts = "";
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.Color.Ivory;
            this.txt_name.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_name.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txt_name.BorderRadius = 0;
            this.txt_name.BorderSize = 2;
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_name.Location = new System.Drawing.Point(106, 45);
            this.txt_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_name.Multiline = false;
            this.txt_name.Name = "txt_name";
            this.txt_name.Padding = new System.Windows.Forms.Padding(7, 4, 7, 4);
            this.txt_name.PasswordChar = false;
            this.txt_name.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_name.PlaceholderText = "";
            this.txt_name.Size = new System.Drawing.Size(140, 25);
            this.txt_name.TabIndex = 8;
            this.txt_name.Texts = "";
            this.txt_name.UnderlinedStyle = false;
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.Lime;
            this.altoButton1.Active2 = System.Drawing.Color.Blue;
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.altoButton1.ForeColor = System.Drawing.Color.Black;
            this.altoButton1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.altoButton1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.altoButton1.Location = new System.Drawing.Point(365, 6);
            this.altoButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(30, 22);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 9;
            this.altoButton1.Text = "X";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Apt No : ";
            // 
            // altoButton2
            // 
            this.altoButton2.Active1 = System.Drawing.Color.Lime;
            this.altoButton2.Active2 = System.Drawing.Color.Blue;
            this.altoButton2.BackColor = System.Drawing.Color.Transparent;
            this.altoButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton2.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.altoButton2.ForeColor = System.Drawing.Color.Black;
            this.altoButton2.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.altoButton2.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.altoButton2.Location = new System.Drawing.Point(328, 6);
            this.altoButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Radius = 10;
            this.altoButton2.Size = new System.Drawing.Size(30, 22);
            this.altoButton2.Stroke = false;
            this.altoButton2.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton2.TabIndex = 11;
            this.altoButton2.Text = "-";
            this.altoButton2.Transparency = false;
            this.altoButton2.Click += new System.EventHandler(this.altoButton2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(75, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 12;
            this.label2.Text = "Cins Outer Gate";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(402, 156);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.altoButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.aptno_combobox);
            this.Controls.Add(this.rjCircularPictureBox1);
            this.Controls.Add(this.btn_Access);
            this.Controls.Add(this.lbl_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CinsAptOuterGate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CinsAptOuterGate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CinsAptOuterGate_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.rjCircularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Name;
        private AltoControls.AltoButton btn_Access;
        private RJCodeAdvance.RJControls.RJCircularPictureBox rjCircularPictureBox1;
        private RJCodeAdvance.RJControls.RJComboBox aptno_combobox;
        private RJCodeAdvance.RJControls.RJTextBox txt_name;
        private AltoControls.AltoButton altoButton1;
        private Label label1;
        private AltoControls.AltoButton altoButton2;
        private Label label2;
    }
}