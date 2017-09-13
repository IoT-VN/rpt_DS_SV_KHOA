namespace Report
{
    partial class frmCrystalReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_MaKhoa = new System.Windows.Forms.ComboBox();
            this.bt_Xuat_Report = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn Khoa : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cb_MaKhoa
            // 
            this.cb_MaKhoa.FormattingEnabled = true;
            this.cb_MaKhoa.Location = new System.Drawing.Point(107, 6);
            this.cb_MaKhoa.Name = "cb_MaKhoa";
            this.cb_MaKhoa.Size = new System.Drawing.Size(161, 21);
            this.cb_MaKhoa.TabIndex = 1;
            // 
            // bt_Xuat_Report
            // 
            this.bt_Xuat_Report.Location = new System.Drawing.Point(274, 3);
            this.bt_Xuat_Report.Name = "bt_Xuat_Report";
            this.bt_Xuat_Report.Size = new System.Drawing.Size(92, 27);
            this.bt_Xuat_Report.TabIndex = 2;
            this.bt_Xuat_Report.Text = "Xuất Report";
            this.bt_Xuat_Report.UseVisualStyleBackColor = true;
            this.bt_Xuat_Report.Click += new System.EventHandler(this.bt_Xuat_Report_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 38);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1049, 442);
            this.crystalReportViewer1.TabIndex = 4;
            // 
            // frmCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 492);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_Xuat_Report);
            this.Controls.Add(this.cb_MaKhoa);
            this.Controls.Add(this.label1);
            this.Name = "frmCrystalReport";
            this.Text = "Danh Sách Khoa";
            this.Load += new System.EventHandler(this.frmCrystalReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_MaKhoa;
        private System.Windows.Forms.Button bt_Xuat_Report;
        private System.Windows.Forms.Button button2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}

