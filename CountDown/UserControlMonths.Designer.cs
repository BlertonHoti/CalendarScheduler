namespace CountDown
{
    partial class UserControlMonths
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
            this.MonthNameTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MonthNameTxt
            // 
            this.MonthNameTxt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MonthNameTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthNameTxt.ForeColor = System.Drawing.Color.DimGray;
            this.MonthNameTxt.Location = new System.Drawing.Point(3, 19);
            this.MonthNameTxt.Name = "MonthNameTxt";
            this.MonthNameTxt.Size = new System.Drawing.Size(113, 23);
            this.MonthNameTxt.TabIndex = 0;
            this.MonthNameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MonthNameTxt.Click += new System.EventHandler(this.MonthNameTxt_Click);
            this.MonthNameTxt.MouseLeave += new System.EventHandler(this.MonthNameTxt_MouseLeave);
            this.MonthNameTxt.MouseHover += new System.EventHandler(this.MonthNameTxt_MouseHover);
            // 
            // UserControlMonths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.MonthNameTxt);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "UserControlMonths";
            this.Size = new System.Drawing.Size(119, 61);
            this.Load += new System.EventHandler(this.UserControlMonths_Load);
            this.Click += new System.EventHandler(this.UserControlMonths_Click);
            this.MouseLeave += new System.EventHandler(this.UserControlMonths_MouseLeave);
            this.MouseHover += new System.EventHandler(this.UserControlMonths_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MonthNameTxt;
    }
}
