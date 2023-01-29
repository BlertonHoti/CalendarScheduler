namespace CountDown
{
    partial class EventFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventFrom));
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.eventTxt = new System.Windows.Forms.TextBox();
            this.dateLbl = new System.Windows.Forms.Label();
            this.eventLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.TopHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.StartingTime = new System.Windows.Forms.ComboBox();
            this.AmOrPm = new System.Windows.Forms.ComboBox();
            this.EndingTime = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTxt
            // 
            this.dateTxt.Location = new System.Drawing.Point(86, 66);
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.ReadOnly = true;
            this.dateTxt.Size = new System.Drawing.Size(255, 29);
            this.dateTxt.TabIndex = 0;
            // 
            // eventTxt
            // 
            this.eventTxt.BackColor = System.Drawing.SystemColors.Control;
            this.eventTxt.Location = new System.Drawing.Point(86, 122);
            this.eventTxt.Name = "eventTxt";
            this.eventTxt.Size = new System.Drawing.Size(255, 29);
            this.eventTxt.TabIndex = 1;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.BackColor = System.Drawing.Color.Transparent;
            this.dateLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLbl.ForeColor = System.Drawing.Color.White;
            this.dateLbl.Location = new System.Drawing.Point(93, 42);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(44, 21);
            this.dateLbl.TabIndex = 2;
            this.dateLbl.Text = "Date";
            // 
            // eventLbl
            // 
            this.eventLbl.AutoSize = true;
            this.eventLbl.BackColor = System.Drawing.Color.Transparent;
            this.eventLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventLbl.ForeColor = System.Drawing.Color.White;
            this.eventLbl.Location = new System.Drawing.Point(90, 98);
            this.eventLbl.Name = "eventLbl";
            this.eventLbl.Size = new System.Drawing.Size(50, 21);
            this.eventLbl.TabIndex = 3;
            this.eventLbl.Text = "Event";
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(259, 240);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(82, 31);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // TopHeader
            // 
            this.TopHeader.BackColor = System.Drawing.Color.White;
            this.TopHeader.Controls.Add(this.pictureBox1);
            this.TopHeader.Controls.Add(this.label10);
            this.TopHeader.Controls.Add(this.CloseBtn);
            this.TopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeader.Location = new System.Drawing.Point(0, 0);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.Size = new System.Drawing.Size(446, 27);
            this.TopHeader.TabIndex = 14;
            this.TopHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopHeader_MouseDown);
            this.TopHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopHeader_MouseMove);
            this.TopHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopHeader_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(416, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Add Event";
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(1113, 2);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(27, 22);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 12;
            this.CloseBtn.TabStop = false;
            // 
            // StartingTime
            // 
            this.StartingTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.StartingTime.FormattingEnabled = true;
            this.StartingTime.Items.AddRange(new object[] {
            "12:00",
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00"});
            this.StartingTime.Location = new System.Drawing.Point(86, 189);
            this.StartingTime.Name = "StartingTime";
            this.StartingTime.Size = new System.Drawing.Size(67, 29);
            this.StartingTime.TabIndex = 15;
            this.StartingTime.SelectedIndexChanged += new System.EventHandler(this.StartingTime_SelectedIndexChanged);
            // 
            // AmOrPm
            // 
            this.AmOrPm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.AmOrPm.FormattingEnabled = true;
            this.AmOrPm.Items.AddRange(new object[] {
            "PM",
            "AM"});
            this.AmOrPm.Location = new System.Drawing.Point(159, 189);
            this.AmOrPm.Name = "AmOrPm";
            this.AmOrPm.Size = new System.Drawing.Size(56, 29);
            this.AmOrPm.TabIndex = 16;
            this.AmOrPm.SelectedIndexChanged += new System.EventHandler(this.AmOrPm_SelectedIndexChanged);
            // 
            // EndingTime
            // 
            this.EndingTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EndingTime.FormattingEnabled = true;
            this.EndingTime.IntegralHeight = false;
            this.EndingTime.Items.AddRange(new object[] {
            "1:00",
            "2:00",
            "3:00",
            "4:00",
            "5:00",
            "6:00",
            "7:00",
            "8:00",
            "9:00",
            "10:00",
            "11:00",
            "12:00"});
            this.EndingTime.Location = new System.Drawing.Point(249, 189);
            this.EndingTime.Name = "EndingTime";
            this.EndingTime.Size = new System.Drawing.Size(92, 29);
            this.EndingTime.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(217, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "To:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(90, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Time";
            // 
            // EventFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(446, 293);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndingTime);
            this.Controls.Add(this.AmOrPm);
            this.Controls.Add(this.StartingTime);
            this.Controls.Add(this.TopHeader);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.eventLbl);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.eventTxt);
            this.Controls.Add(this.dateTxt);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EventFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventFrom";
            this.Load += new System.EventHandler(this.EventFrom_Load);
            this.TopHeader.ResumeLayout(false);
            this.TopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.TextBox eventTxt;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label eventLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Panel TopHeader;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox StartingTime;
        private System.Windows.Forms.ComboBox AmOrPm;
        private System.Windows.Forms.ComboBox EndingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}