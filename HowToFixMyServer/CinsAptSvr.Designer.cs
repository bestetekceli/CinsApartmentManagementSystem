using System.ComponentModel;
using System.ComponentModel.Design;

namespace HowToFixMyServer
{
    partial class CinsAptSvr
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
            this.components = new System.ComponentModel.Container();
            this.lbl_value3 = new AltoControls.AltoSlidingLabel();
            this.lbl_value2 = new AltoControls.AltoSlidingLabel();
            this.lbl_value1 = new AltoControls.AltoSlidingLabel();
            this.lbl_daynight = new AltoControls.AltoSlidingLabel();
            this.lbl_Dolar = new System.Windows.Forms.Label();
            this.lbl_Euro = new System.Windows.Forms.Label();
            this.lbl_Gold = new System.Windows.Forms.Label();
            this.lbl_statusV = new System.Windows.Forms.Label();
            this.lbl_degree = new System.Windows.Forms.Label();
            this.lbl_CityV = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_City = new System.Windows.Forms.Label();
            this.altoButton1 = new AltoControls.AltoButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ChatText = new RJCodeAdvance.RJControls.RJTextBox();
            this.txt_OuterGateText = new RJCodeAdvance.RJControls.RJTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.altoButton2 = new AltoControls.AltoButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lstbx_chat = new System.Windows.Forms.ListBox();
            this.lstbx_entry = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_value3
            // 
            this.lbl_value3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_value3.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_value3.Location = new System.Drawing.Point(369, 472);
            this.lbl_value3.Name = "lbl_value3";
            this.lbl_value3.Size = new System.Drawing.Size(80, 21);
            this.lbl_value3.Slide = false;
            this.lbl_value3.TabIndex = 49;
            this.lbl_value3.Text = "dolar_value";
            // 
            // lbl_value2
            // 
            this.lbl_value2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_value2.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_value2.Location = new System.Drawing.Point(369, 432);
            this.lbl_value2.Name = "lbl_value2";
            this.lbl_value2.Size = new System.Drawing.Size(77, 21);
            this.lbl_value2.Slide = false;
            this.lbl_value2.TabIndex = 48;
            this.lbl_value2.Text = "euro_value";
            // 
            // lbl_value1
            // 
            this.lbl_value1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_value1.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_value1.Location = new System.Drawing.Point(369, 391);
            this.lbl_value1.Name = "lbl_value1";
            this.lbl_value1.Size = new System.Drawing.Size(74, 21);
            this.lbl_value1.Slide = false;
            this.lbl_value1.TabIndex = 47;
            this.lbl_value1.Text = "euro_value";
            // 
            // lbl_daynight
            // 
            this.lbl_daynight.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_daynight.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_daynight.Location = new System.Drawing.Point(49, 472);
            this.lbl_daynight.Name = "lbl_daynight";
            this.lbl_daynight.Size = new System.Drawing.Size(189, 21);
            this.lbl_daynight.Slide = false;
            this.lbl_daynight.TabIndex = 46;
            this.lbl_daynight.Text = "day_degreeeeeeeee_nightdegreeeeeeeeeeee";
            // 
            // lbl_Dolar
            // 
            this.lbl_Dolar.AutoSize = true;
            this.lbl_Dolar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Dolar.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Dolar.Location = new System.Drawing.Point(279, 468);
            this.lbl_Dolar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Dolar.Name = "lbl_Dolar";
            this.lbl_Dolar.Size = new System.Drawing.Size(57, 19);
            this.lbl_Dolar.TabIndex = 45;
            this.lbl_Dolar.Text = "Dolar :";
            // 
            // lbl_Euro
            // 
            this.lbl_Euro.AutoSize = true;
            this.lbl_Euro.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Euro.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Euro.Location = new System.Drawing.Point(288, 426);
            this.lbl_Euro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Euro.Name = "lbl_Euro";
            this.lbl_Euro.Size = new System.Drawing.Size(51, 19);
            this.lbl_Euro.TabIndex = 44;
            this.lbl_Euro.Text = "Euro :";
            // 
            // lbl_Gold
            // 
            this.lbl_Gold.AutoSize = true;
            this.lbl_Gold.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Gold.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_Gold.Location = new System.Drawing.Point(289, 383);
            this.lbl_Gold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Gold.Name = "lbl_Gold";
            this.lbl_Gold.Size = new System.Drawing.Size(50, 19);
            this.lbl_Gold.TabIndex = 43;
            this.lbl_Gold.Text = "Gold :";
            // 
            // lbl_statusV
            // 
            this.lbl_statusV.AutoSize = true;
            this.lbl_statusV.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_statusV.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_statusV.Location = new System.Drawing.Point(127, 430);
            this.lbl_statusV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_statusV.Name = "lbl_statusV";
            this.lbl_statusV.Size = new System.Drawing.Size(38, 19);
            this.lbl_statusV.TabIndex = 42;
            this.lbl_statusV.Text = "cond";
            // 
            // lbl_degree
            // 
            this.lbl_degree.AutoSize = true;
            this.lbl_degree.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_degree.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_degree.Location = new System.Drawing.Point(188, 383);
            this.lbl_degree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_degree.Name = "lbl_degree";
            this.lbl_degree.Size = new System.Drawing.Size(47, 19);
            this.lbl_degree.TabIndex = 41;
            this.lbl_degree.Text = "degre";
            // 
            // lbl_CityV
            // 
            this.lbl_CityV.AutoSize = true;
            this.lbl_CityV.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_CityV.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_CityV.Location = new System.Drawing.Point(110, 382);
            this.lbl_CityV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_CityV.Name = "lbl_CityV";
            this.lbl_CityV.Size = new System.Drawing.Size(44, 19);
            this.lbl_CityV.TabIndex = 40;
            this.lbl_CityV.Text = "CityV";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_status.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_status.Location = new System.Drawing.Point(33, 429);
            this.lbl_status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(67, 19);
            this.lbl_status.TabIndex = 39;
            this.lbl_status.Text = "Status :";
            // 
            // lbl_City
            // 
            this.lbl_City.AutoSize = true;
            this.lbl_City.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_City.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_City.Location = new System.Drawing.Point(33, 382);
            this.lbl_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_City.Name = "lbl_City";
            this.lbl_City.Size = new System.Drawing.Size(49, 19);
            this.lbl_City.TabIndex = 38;
            this.lbl_City.Text = "City :";
            // 
            // altoButton1
            // 
            this.altoButton1.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.altoButton1.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.altoButton1.BackColor = System.Drawing.Color.Transparent;
            this.altoButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton1.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.altoButton1.ForeColor = System.Drawing.Color.DarkRed;
            this.altoButton1.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.altoButton1.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.altoButton1.Location = new System.Drawing.Point(781, 8);
            this.altoButton1.Name = "altoButton1";
            this.altoButton1.Radius = 10;
            this.altoButton1.Size = new System.Drawing.Size(48, 38);
            this.altoButton1.Stroke = false;
            this.altoButton1.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton1.TabIndex = 53;
            this.altoButton1.Text = "X";
            this.altoButton1.Transparency = false;
            this.altoButton1.Click += new System.EventHandler(this.altoButton1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(221, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(261, 31);
            this.label3.TabIndex = 54;
            this.label3.Text = "Cins Apartment Server";
            // 
            // txt_ChatText
            // 
            this.txt_ChatText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.txt_ChatText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_ChatText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_ChatText.BorderRadius = 20;
            this.txt_ChatText.BorderSize = 2;
            this.txt_ChatText.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_ChatText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_ChatText.Location = new System.Drawing.Point(486, 365);
            this.txt_ChatText.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ChatText.Multiline = true;
            this.txt_ChatText.Name = "txt_ChatText";
            this.txt_ChatText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_ChatText.PasswordChar = false;
            this.txt_ChatText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_ChatText.PlaceholderText = "";
            this.txt_ChatText.Size = new System.Drawing.Size(319, 132);
            this.txt_ChatText.TabIndex = 55;
            this.txt_ChatText.Texts = "";
            this.txt_ChatText.UnderlinedStyle = false;
            // 
            // txt_OuterGateText
            // 
            this.txt_OuterGateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.txt_OuterGateText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_OuterGateText.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_OuterGateText.BorderRadius = 20;
            this.txt_OuterGateText.BorderSize = 2;
            this.txt_OuterGateText.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_OuterGateText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_OuterGateText.Location = new System.Drawing.Point(33, 88);
            this.txt_OuterGateText.Margin = new System.Windows.Forms.Padding(4);
            this.txt_OuterGateText.Multiline = true;
            this.txt_OuterGateText.Name = "txt_OuterGateText";
            this.txt_OuterGateText.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txt_OuterGateText.PasswordChar = false;
            this.txt_OuterGateText.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txt_OuterGateText.PlaceholderText = "";
            this.txt_OuterGateText.Size = new System.Drawing.Size(773, 267);
            this.txt_OuterGateText.TabIndex = 56;
            this.txt_OuterGateText.Texts = "";
            this.txt_OuterGateText.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(453, 467);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 19);
            this.label1.TabIndex = 59;
            this.label1.Text = "$";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(453, 431);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 19);
            this.label2.TabIndex = 58;
            this.label2.Text = "€";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(453, 386);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "gr";
            // 
            // altoButton2
            // 
            this.altoButton2.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.altoButton2.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.altoButton2.BackColor = System.Drawing.Color.Transparent;
            this.altoButton2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.altoButton2.Font = new System.Drawing.Font("Consolas", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.altoButton2.ForeColor = System.Drawing.Color.DarkRed;
            this.altoButton2.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.altoButton2.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.altoButton2.Location = new System.Drawing.Point(726, 8);
            this.altoButton2.Name = "altoButton2";
            this.altoButton2.Radius = 10;
            this.altoButton2.Size = new System.Drawing.Size(48, 38);
            this.altoButton2.Stroke = false;
            this.altoButton2.StrokeColor = System.Drawing.Color.Gray;
            this.altoButton2.TabIndex = 60;
            this.altoButton2.Text = "-";
            this.altoButton2.Transparency = false;
            this.altoButton2.Click += new System.EventHandler(this.altoButton2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lstbx_chat
            // 
            this.lstbx_chat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.lstbx_chat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbx_chat.FormattingEnabled = true;
            this.lstbx_chat.HorizontalScrollbar = true;
            this.lstbx_chat.ItemHeight = 17;
            this.lstbx_chat.Location = new System.Drawing.Point(40, 99);
            this.lstbx_chat.Name = "lstbx_chat";
            this.lstbx_chat.Size = new System.Drawing.Size(753, 238);
            this.lstbx_chat.TabIndex = 61;
            // 
            // lstbx_entry
            // 
            this.lstbx_entry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(240)))), ((int)(((byte)(234)))));
            this.lstbx_entry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbx_entry.FormattingEnabled = true;
            this.lstbx_entry.HorizontalScrollbar = true;
            this.lstbx_entry.ItemHeight = 17;
            this.lstbx_entry.Location = new System.Drawing.Point(499, 373);
            this.lstbx_entry.Name = "lstbx_entry";
            this.lstbx_entry.Size = new System.Drawing.Size(294, 119);
            this.lstbx_entry.TabIndex = 65;
            // 
            // CinsAptSvr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(841, 526);
            this.Controls.Add(this.lstbx_entry);
            this.Controls.Add(this.lstbx_chat);
            this.Controls.Add(this.altoButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_OuterGateText);
            this.Controls.Add(this.txt_ChatText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.altoButton1);
            this.Controls.Add(this.lbl_value3);
            this.Controls.Add(this.lbl_value2);
            this.Controls.Add(this.lbl_value1);
            this.Controls.Add(this.lbl_daynight);
            this.Controls.Add(this.lbl_Dolar);
            this.Controls.Add(this.lbl_Euro);
            this.Controls.Add(this.lbl_Gold);
            this.Controls.Add(this.lbl_statusV);
            this.Controls.Add(this.lbl_degree);
            this.Controls.Add(this.lbl_CityV);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_City);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CinsAptSvr";
            this.Text = "cinsserver";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CinsAptCli_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CinsAptSvr_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CinsAptCli_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private AltoControls.AltoSlidingLabel lbl_value3;
        private AltoControls.AltoSlidingLabel lbl_value2;
        private AltoControls.AltoSlidingLabel lbl_value1;
        private AltoControls.AltoSlidingLabel lbl_daynight;
        private Label lbl_Dolar;
        private Label lbl_Euro;
        private Label lbl_Gold;
        private Label lbl_statusV;
        private Label lbl_degree;
        private Label lbl_CityV;
        private Label lbl_status;
        private Label lbl_City;
        private AltoControls.AltoButton altoButton1;
        private Label label3;
        private RJCodeAdvance.RJControls.RJTextBox txt_ChatText;
        private RJCodeAdvance.RJControls.RJTextBox txt_OuterGateText;
        private Label label1;
        private Label label2;
        private Label label4;
        private AltoControls.AltoButton altoButton2;
        private System.Windows.Forms.Timer timer1;
        private ListBox lstbx_chat;
        private ListBox lstbx_entry;
    }
}