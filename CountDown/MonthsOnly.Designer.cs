namespace CountDown
{
    partial class MonthsOnly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonthsOnly));
            this.LogoContainerRadius = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LogoContainer = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DelEventBtn = new System.Windows.Forms.Button();
            this.EditEventBtn = new System.Windows.Forms.Button();
            this.EventNameLbl = new System.Windows.Forms.Label();
            this.EventSelected = new System.Windows.Forms.Label();
            this.EventContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.SelectedEvents = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TopHeader = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.RadiusCloseBtn = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RadiusCalculatorContainer = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CalculatorContainer = new System.Windows.Forms.Panel();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.previousBtn = new System.Windows.Forms.PictureBox();
            this.MonthContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.RadiusEventContainer = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LogoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SelectedEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.TopHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.CalculatorContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoContainerRadius
            // 
            this.LogoContainerRadius.BorderRadius = 12;
            this.LogoContainerRadius.TargetControl = this.LogoContainer;
            // 
            // LogoContainer
            // 
            this.LogoContainer.BackColor = System.Drawing.Color.White;
            this.LogoContainer.Controls.Add(this.label11);
            this.LogoContainer.Controls.Add(this.pictureBox1);
            this.LogoContainer.Location = new System.Drawing.Point(15, 43);
            this.LogoContainer.Name = "LogoContainer";
            this.LogoContainer.Size = new System.Drawing.Size(304, 154);
            this.LogoContainer.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Teal;
            this.label11.Location = new System.Drawing.Point(59, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Calendar Scheduler";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // DelEventBtn
            // 
            this.DelEventBtn.BackColor = System.Drawing.Color.White;
            this.DelEventBtn.ForeColor = System.Drawing.Color.Teal;
            this.DelEventBtn.Location = new System.Drawing.Point(219, 327);
            this.DelEventBtn.Name = "DelEventBtn";
            this.DelEventBtn.Size = new System.Drawing.Size(75, 28);
            this.DelEventBtn.TabIndex = 6;
            this.DelEventBtn.Text = "Delete";
            this.DelEventBtn.UseVisualStyleBackColor = false;
            // 
            // EditEventBtn
            // 
            this.EditEventBtn.ForeColor = System.Drawing.Color.Teal;
            this.EditEventBtn.Location = new System.Drawing.Point(124, 327);
            this.EditEventBtn.Name = "EditEventBtn";
            this.EditEventBtn.Size = new System.Drawing.Size(75, 28);
            this.EditEventBtn.TabIndex = 5;
            this.EditEventBtn.Text = "Edit";
            this.EditEventBtn.UseVisualStyleBackColor = true;
            // 
            // EventNameLbl
            // 
            this.EventNameLbl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EventNameLbl.ForeColor = System.Drawing.Color.Teal;
            this.EventNameLbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EventNameLbl.Location = new System.Drawing.Point(17, 31);
            this.EventNameLbl.Name = "EventNameLbl";
            this.EventNameLbl.Size = new System.Drawing.Size(127, 21);
            this.EventNameLbl.TabIndex = 4;
            this.EventNameLbl.Text = "Event Name";
            this.EventNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventSelected
            // 
            this.EventSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EventSelected.ForeColor = System.Drawing.Color.Teal;
            this.EventSelected.Location = new System.Drawing.Point(152, 31);
            this.EventSelected.Name = "EventSelected";
            this.EventSelected.Size = new System.Drawing.Size(131, 21);
            this.EventSelected.TabIndex = 3;
            this.EventSelected.Text = "Date";
            this.EventSelected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EventContainer
            // 
            this.EventContainer.AutoScroll = true;
            this.EventContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EventContainer.Location = new System.Drawing.Point(11, 62);
            this.EventContainer.Name = "EventContainer";
            this.EventContainer.Size = new System.Drawing.Size(283, 259);
            this.EventContainer.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label9.ForeColor = System.Drawing.Color.Teal;
            this.label9.Location = new System.Drawing.Point(128, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 21);
            this.label9.TabIndex = 0;
            this.label9.Text = "Events";
            // 
            // SelectedEvents
            // 
            this.SelectedEvents.BackColor = System.Drawing.Color.White;
            this.SelectedEvents.Controls.Add(this.DelEventBtn);
            this.SelectedEvents.Controls.Add(this.EditEventBtn);
            this.SelectedEvents.Controls.Add(this.EventNameLbl);
            this.SelectedEvents.Controls.Add(this.EventSelected);
            this.SelectedEvents.Controls.Add(this.EventContainer);
            this.SelectedEvents.Controls.Add(this.label9);
            this.SelectedEvents.Location = new System.Drawing.Point(15, 213);
            this.SelectedEvents.Name = "SelectedEvents";
            this.SelectedEvents.Size = new System.Drawing.Size(304, 363);
            this.SelectedEvents.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Calendar Scheduler";
            // 
            // TopHeader
            // 
            this.TopHeader.BackColor = System.Drawing.Color.White;
            this.TopHeader.Controls.Add(this.pictureBox2);
            this.TopHeader.Controls.Add(this.label10);
            this.TopHeader.Controls.Add(this.CloseBtn);
            this.TopHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopHeader.Location = new System.Drawing.Point(0, 0);
            this.TopHeader.Name = "TopHeader";
            this.TopHeader.Size = new System.Drawing.Size(1152, 27);
            this.TopHeader.TabIndex = 17;
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
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // RadiusCloseBtn
            // 
            this.RadiusCloseBtn.BorderRadius = 3;
            this.RadiusCloseBtn.TargetControl = this.CloseBtn;
            // 
            // RadiusCalculatorContainer
            // 
            this.RadiusCalculatorContainer.BorderRadius = 12;
            this.RadiusCalculatorContainer.TargetControl = this.CalculatorContainer;
            // 
            // CalculatorContainer
            // 
            this.CalculatorContainer.BackColor = System.Drawing.Color.White;
            this.CalculatorContainer.Controls.Add(this.nextBtn);
            this.CalculatorContainer.Controls.Add(this.previousBtn);
            this.CalculatorContainer.Controls.Add(this.MonthContainer);
            this.CalculatorContainer.Controls.Add(this.lblDate);
            this.CalculatorContainer.Location = new System.Drawing.Point(335, 43);
            this.CalculatorContainer.Name = "CalculatorContainer";
            this.CalculatorContainer.Size = new System.Drawing.Size(802, 535);
            this.CalculatorContainer.TabIndex = 16;
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.Location = new System.Drawing.Point(536, 27);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(33, 27);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBtn.TabIndex = 13;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.previousBtn.Image = ((System.Drawing.Image)(resources.GetObject("previousBtn.Image")));
            this.previousBtn.Location = new System.Drawing.Point(227, 27);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(29, 27);
            this.previousBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.previousBtn.TabIndex = 0;
            this.previousBtn.TabStop = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // MonthContainer
            // 
            this.MonthContainer.Location = new System.Drawing.Point(26, 92);
            this.MonthContainer.Margin = new System.Windows.Forms.Padding(1);
            this.MonthContainer.Name = "MonthContainer";
            this.MonthContainer.Size = new System.Drawing.Size(753, 440);
            this.MonthContainer.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(294, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(207, 31);
            this.lblDate.TabIndex = 10;
            this.lblDate.Text = "YEAR";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDate.Click += new System.EventHandler(this.lblDate_Click);
            this.lblDate.MouseLeave += new System.EventHandler(this.lblDate_MouseLeave);
            this.lblDate.MouseHover += new System.EventHandler(this.lblDate_MouseHover);
            // 
            // RadiusEventContainer
            // 
            this.RadiusEventContainer.BorderRadius = 12;
            this.RadiusEventContainer.TargetControl = this.SelectedEvents;
            // 
            // MonthsOnly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1152, 591);
            this.Controls.Add(this.SelectedEvents);
            this.Controls.Add(this.LogoContainer);
            this.Controls.Add(this.TopHeader);
            this.Controls.Add(this.CalculatorContainer);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MonthsOnly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthsOnly";
            this.Load += new System.EventHandler(this.MonthsOnly_Load);
            this.LogoContainer.ResumeLayout(false);
            this.LogoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SelectedEvents.ResumeLayout(false);
            this.SelectedEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.TopHeader.ResumeLayout(false);
            this.TopHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.CalculatorContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previousBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse LogoContainerRadius;
        private System.Windows.Forms.Panel LogoContainer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DelEventBtn;
        private System.Windows.Forms.Button EditEventBtn;
        private System.Windows.Forms.Label EventNameLbl;
        private System.Windows.Forms.Label EventSelected;
        private System.Windows.Forms.FlowLayoutPanel EventContainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel SelectedEvents;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel TopHeader;
        private System.Windows.Forms.PictureBox CloseBtn;
        private Guna.UI2.WinForms.Guna2Elipse RadiusCloseBtn;
        private Guna.UI2.WinForms.Guna2Elipse RadiusCalculatorContainer;
        private System.Windows.Forms.Panel CalculatorContainer;
        private System.Windows.Forms.PictureBox nextBtn;
        private System.Windows.Forms.PictureBox previousBtn;
        private System.Windows.Forms.FlowLayoutPanel MonthContainer;
        private System.Windows.Forms.Label lblDate;
        private Guna.UI2.WinForms.Guna2Elipse RadiusEventContainer;
    }
}