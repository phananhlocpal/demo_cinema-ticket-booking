namespace BaitapBonus2
{
    partial class main
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
            this.ckbNormal = new System.Windows.Forms.CheckBox();
            this.ckbVIP = new System.Windows.Forms.CheckBox();
            this.ckbCouple = new System.Windows.Forms.CheckBox();
            this.nudNormal = new System.Windows.Forms.NumericUpDown();
            this.nudVIP = new System.Windows.Forms.NumericUpDown();
            this.nudCouple = new System.Windows.Forms.NumericUpDown();
            this.btnBook = new System.Windows.Forms.Button();
            this.ltvBooked = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCouple)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐẶT VÉ XEM PHIM";
            // 
            // ckbNormal
            // 
            this.ckbNormal.AutoSize = true;
            this.ckbNormal.Location = new System.Drawing.Point(40, 135);
            this.ckbNormal.Name = "ckbNormal";
            this.ckbNormal.Size = new System.Drawing.Size(112, 29);
            this.ckbNormal.TabIndex = 1;
            this.ckbNormal.Text = "Normal";
            this.ckbNormal.UseVisualStyleBackColor = true;
            this.ckbNormal.CheckedChanged += new System.EventHandler(this.ckbNormal_CheckedChanged);
            // 
            // ckbVIP
            // 
            this.ckbVIP.AutoSize = true;
            this.ckbVIP.Location = new System.Drawing.Point(40, 200);
            this.ckbVIP.Name = "ckbVIP";
            this.ckbVIP.Size = new System.Drawing.Size(77, 29);
            this.ckbVIP.TabIndex = 2;
            this.ckbVIP.Text = "VIP";
            this.ckbVIP.UseVisualStyleBackColor = true;
            this.ckbVIP.CheckedChanged += new System.EventHandler(this.ckbVIP_CheckedChanged);
            // 
            // ckbCouple
            // 
            this.ckbCouple.AutoSize = true;
            this.ckbCouple.Location = new System.Drawing.Point(40, 272);
            this.ckbCouple.Name = "ckbCouple";
            this.ckbCouple.Size = new System.Drawing.Size(112, 29);
            this.ckbCouple.TabIndex = 3;
            this.ckbCouple.Text = "Couple";
            this.ckbCouple.UseVisualStyleBackColor = true;
            this.ckbCouple.CheckedChanged += new System.EventHandler(this.ckbCouple_CheckedChanged);
            // 
            // nudNormal
            // 
            this.nudNormal.Location = new System.Drawing.Point(456, 134);
            this.nudNormal.Name = "nudNormal";
            this.nudNormal.Size = new System.Drawing.Size(120, 31);
            this.nudNormal.TabIndex = 4;
            this.nudNormal.ValueChanged += new System.EventHandler(this.nudNormal_ValueChanged);
            // 
            // nudVIP
            // 
            this.nudVIP.Location = new System.Drawing.Point(456, 199);
            this.nudVIP.Name = "nudVIP";
            this.nudVIP.Size = new System.Drawing.Size(120, 31);
            this.nudVIP.TabIndex = 5;
            this.nudVIP.ValueChanged += new System.EventHandler(this.nudVIP_ValueChanged);
            // 
            // nudCouple
            // 
            this.nudCouple.Location = new System.Drawing.Point(456, 271);
            this.nudCouple.Name = "nudCouple";
            this.nudCouple.Size = new System.Drawing.Size(120, 31);
            this.nudCouple.TabIndex = 6;
            this.nudCouple.ValueChanged += new System.EventHandler(this.nudCouple_ValueChanged);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(244, 335);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(112, 57);
            this.btnBook.TabIndex = 7;
            this.btnBook.Text = "Đặt vé";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // ltvBooked
            // 
            this.ltvBooked.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltvBooked.HideSelection = false;
            this.ltvBooked.Location = new System.Drawing.Point(647, 132);
            this.ltvBooked.Name = "ltvBooked";
            this.ltvBooked.Size = new System.Drawing.Size(586, 524);
            this.ltvBooked.TabIndex = 8;
            this.ltvBooked.UseCompatibleStateImageBehavior = false;
            this.ltvBooked.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(880, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vé đã đặt";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 705);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ltvBooked);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.nudCouple);
            this.Controls.Add(this.nudVIP);
            this.Controls.Add(this.nudNormal);
            this.Controls.Add(this.ckbCouple);
            this.Controls.Add(this.ckbVIP);
            this.Controls.Add(this.ckbNormal);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCouple)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbNormal;
        private System.Windows.Forms.CheckBox ckbVIP;
        private System.Windows.Forms.CheckBox ckbCouple;
        private System.Windows.Forms.NumericUpDown nudNormal;
        private System.Windows.Forms.NumericUpDown nudVIP;
        private System.Windows.Forms.NumericUpDown nudCouple;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.ListView ltvBooked;
        private System.Windows.Forms.Label label2;
    }
}