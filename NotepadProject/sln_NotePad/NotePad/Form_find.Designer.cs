namespace NotePad
{
    partial class Form_find
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
            this.lblWord = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.chOption = new System.Windows.Forms.CheckBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.rdb_up = new System.Windows.Forms.RadioButton();
            this.rdb_down = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Font = new System.Drawing.Font("굴림", 10F);
            this.lblWord.Location = new System.Drawing.Point(12, 28);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(68, 14);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "찾을 내용";
            // 
            // txtWord
            // 
            this.txtWord.Location = new System.Drawing.Point(90, 25);
            this.txtWord.Name = "txtWord";
            this.txtWord.Size = new System.Drawing.Size(300, 21);
            this.txtWord.TabIndex = 1;
            this.txtWord.TextChanged += new System.EventHandler(this.txtWord_TextChanged);
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("굴림", 10F);
            this.btnOk.Location = new System.Drawing.Point(410, 25);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "다음 찾기";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 10F);
            this.btnCancel.Location = new System.Drawing.Point(410, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // chOption
            // 
            this.chOption.AutoSize = true;
            this.chOption.Font = new System.Drawing.Font("굴림", 10F);
            this.chOption.Location = new System.Drawing.Point(35, 100);
            this.chOption.Name = "chOption";
            this.chOption.Size = new System.Drawing.Size(121, 18);
            this.chOption.TabIndex = 4;
            this.chOption.Text = "대/소문자 구분";
            this.chOption.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.rdb_down);
            this.groupBox.Controls.Add(this.rdb_up);
            this.groupBox.Font = new System.Drawing.Font("굴림", 10F);
            this.groupBox.Location = new System.Drawing.Point(190, 82);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(200, 50);
            this.groupBox.TabIndex = 5;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "방향";
            // 
            // rdb_up
            // 
            this.rdb_up.AutoSize = true;
            this.rdb_up.Location = new System.Drawing.Point(32, 20);
            this.rdb_up.Name = "rdb_up";
            this.rdb_up.Size = new System.Drawing.Size(53, 18);
            this.rdb_up.TabIndex = 0;
            this.rdb_up.Text = "위쪽";
            this.rdb_up.UseVisualStyleBackColor = true;
            // 
            // rdb_down
            // 
            this.rdb_down.AutoSize = true;
            this.rdb_down.Checked = true;
            this.rdb_down.Location = new System.Drawing.Point(104, 20);
            this.rdb_down.Name = "rdb_down";
            this.rdb_down.Size = new System.Drawing.Size(67, 18);
            this.rdb_down.TabIndex = 1;
            this.rdb_down.TabStop = true;
            this.rdb_down.Text = "아래쪽";
            this.rdb_down.UseVisualStyleBackColor = true;
            // 
            // Form_find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 161);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.chOption);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.lblWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_find";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "찾기";
            this.TopMost = true;
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        internal System.Windows.Forms.TextBox txtWord;
        internal System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.CheckBox chOption;
        private System.Windows.Forms.GroupBox groupBox;
        internal System.Windows.Forms.RadioButton rdb_up;
        internal System.Windows.Forms.RadioButton rdb_down;
    }
}