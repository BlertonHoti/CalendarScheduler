namespace CountDown
{
    partial class Event
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.EventName = new System.Windows.Forms.Label();
            this.TimeLbl = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.SelectDesign = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // EventName
            // 
            this.EventName.BackColor = System.Drawing.Color.Transparent;
            this.EventName.ForeColor = System.Drawing.Color.White;
            this.EventName.Location = new System.Drawing.Point(0, 0);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(78, 37);
            this.EventName.TabIndex = 0;
            this.EventName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EventName.Click += new System.EventHandler(this.EventName_Click);
            this.EventName.Leave += new System.EventHandler(this.EventName_Leave);
            // 
            // TimeLbl
            // 
            this.TimeLbl.ForeColor = System.Drawing.Color.White;
            this.TimeLbl.Location = new System.Drawing.Point(84, 0);
            this.TimeLbl.Name = "TimeLbl";
            this.TimeLbl.Size = new System.Drawing.Size(99, 37);
            this.TimeLbl.TabIndex = 1;
            this.TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TimeLbl.Click += new System.EventHandler(this.TimeLbl_Click);
            this.TimeLbl.Leave += new System.EventHandler(this.TimeLbl_Leave);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // SelectDesign
            // 
            this.SelectDesign.Location = new System.Drawing.Point(-5, 32);
            this.SelectDesign.Name = "SelectDesign";
            this.SelectDesign.Size = new System.Drawing.Size(187, 10);
            this.SelectDesign.TabIndex = 2;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.SelectDesign);
            this.Controls.Add(this.TimeLbl);
            this.Controls.Add(this.EventName);
            this.Name = "Event";
            this.Size = new System.Drawing.Size(183, 37);
            this.Load += new System.EventHandler(this.Event_Load);
            this.Click += new System.EventHandler(this.Event_Click);
            this.Leave += new System.EventHandler(this.Event_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label EventName;
        private System.Windows.Forms.Label TimeLbl;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel SelectDesign;
    }
}
