namespace AppG32019
{
    partial class Form2
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
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.cbbPhepToan = new System.Windows.Forms.ComboBox();
            this.btnTinh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoThuHai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoThuHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoThuHai.Location = new System.Drawing.Point(126, 190);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(377, 26);
            this.txtSoThuHai.TabIndex = 2;
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoThuNhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoThuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoThuNhat.Location = new System.Drawing.Point(126, 147);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(377, 26);
            this.txtSoThuNhat.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(27, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số thứ hai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(27, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số thứ nhất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(100, 5, 100, 5);
            this.label1.Size = new System.Drawing.Size(452, 62);
            this.label1.TabIndex = 8;
            this.label1.Text = "Bài tập số 2";
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(27, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phép toán";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbbPhepToan
            // 
            this.cbbPhepToan.FormattingEnabled = true;
            this.cbbPhepToan.Items.AddRange(new object[] {
            "Cộng",
            "Trừ",
            "Nhân",
            "Chia"});
            this.cbbPhepToan.Location = new System.Drawing.Point(126, 105);
            this.cbbPhepToan.Name = "cbbPhepToan";
            this.cbbPhepToan.Size = new System.Drawing.Size(175, 21);
            this.cbbPhepToan.TabIndex = 0;
            this.cbbPhepToan.Text = "Chọn phép tính";
            // 
            // btnTinh
            // 
            this.btnTinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTinh.Location = new System.Drawing.Point(126, 233);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 30);
            this.btnTinh.TabIndex = 3;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 284);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.cbbPhepToan);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Bài số 2";
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.ComboBox cbbPhepToan;
    }
}