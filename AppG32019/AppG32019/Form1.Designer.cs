namespace AppG32019
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(474, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bài tập đầu tiên của tôi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(28, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(28, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoThuNhat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoThuNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoThuNhat.Location = new System.Drawing.Point(127, 119);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(377, 26);
            this.txtSoThuNhat.TabIndex = 0;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.BackColor = System.Drawing.SystemColors.Info;
            this.txtSoThuHai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSoThuHai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoThuHai.Location = new System.Drawing.Point(127, 167);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(377, 26);
            this.txtSoThuHai.TabIndex = 1;
            // 
            // btnCong
            // 
            this.btnCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCong.Location = new System.Drawing.Point(31, 213);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(110, 48);
            this.btnCong.TabIndex = 2;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTru.Location = new System.Drawing.Point(159, 213);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(105, 48);
            this.btnTru.TabIndex = 3;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            // 
            // btnNhan
            // 
            this.btnNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNhan.Location = new System.Drawing.Point(284, 213);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(102, 48);
            this.btnNhan.TabIndex = 4;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChia.Location = new System.Drawing.Point(403, 213);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(101, 48);
            this.btnChia.TabIndex = 5;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.button4_Click);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 285);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.txtSoThuHai);
            this.Controls.Add(this.txtSoThuNhat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Bài số 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.ErrorProvider errProvider;
    }
}

