namespace NotePad
{
    partial class Form_change
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
            this.lbl_find = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.txt_find = new System.Windows.Forms.TextBox();
            this.txt_change = new System.Windows.Forms.TextBox();
            this.btn_nxt = new System.Windows.Forms.Button();
            this.btn_change = new System.Windows.Forms.Button();
            this.btn_all_change = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.ckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_find
            // 
            this.lbl_find.AutoSize = true;
            this.lbl_find.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_find.Location = new System.Drawing.Point(25, 32);
            this.lbl_find.Name = "lbl_find";
            this.lbl_find.Size = new System.Drawing.Size(82, 15);
            this.lbl_find.TabIndex = 0;
            this.lbl_find.Text = "찾을 내용: ";
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_change.Location = new System.Drawing.Point(25, 79);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(82, 15);
            this.lbl_change.TabIndex = 1;
            this.lbl_change.Text = "바꿀 내용: ";
            // 
            // txt_find
            // 
            this.txt_find.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_find.Location = new System.Drawing.Point(112, 29);
            this.txt_find.Name = "txt_find";
            this.txt_find.Size = new System.Drawing.Size(250, 25);
            this.txt_find.TabIndex = 2;
            // 
            // txt_change
            // 
            this.txt_change.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_change.Location = new System.Drawing.Point(112, 76);
            this.txt_change.Name = "txt_change";
            this.txt_change.Size = new System.Drawing.Size(250, 25);
            this.txt_change.TabIndex = 3;
            // 
            // btn_nxt
            // 
            this.btn_nxt.FlatAppearance.BorderSize = 0;
            this.btn_nxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nxt.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_nxt.Location = new System.Drawing.Point(382, 24);
            this.btn_nxt.Name = "btn_nxt";
            this.btn_nxt.Size = new System.Drawing.Size(100, 30);
            this.btn_nxt.TabIndex = 4;
            this.btn_nxt.Text = "다음 찾기";
            this.btn_nxt.UseVisualStyleBackColor = true;
            // 
            // btn_change
            // 
            this.btn_change.FlatAppearance.BorderSize = 0;
            this.btn_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_change.Location = new System.Drawing.Point(382, 71);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(100, 30);
            this.btn_change.TabIndex = 5;
            this.btn_change.Text = "바꾸기";
            this.btn_change.UseVisualStyleBackColor = true;
            // 
            // btn_all_change
            // 
            this.btn_all_change.FlatAppearance.BorderSize = 0;
            this.btn_all_change.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all_change.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_all_change.Location = new System.Drawing.Point(382, 118);
            this.btn_all_change.Name = "btn_all_change";
            this.btn_all_change.Size = new System.Drawing.Size(100, 30);
            this.btn_all_change.TabIndex = 6;
            this.btn_all_change.Text = "모두 바꾸기";
            this.btn_all_change.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(382, 165);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(100, 30);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // ckbox
            // 
            this.ckbox.AutoSize = true;
            this.ckbox.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbox.Location = new System.Drawing.Point(27, 172);
            this.ckbox.Name = "ckbox";
            this.ckbox.Size = new System.Drawing.Size(149, 19);
            this.ckbox.TabIndex = 8;
            this.ckbox.Text = "대/소문자 구분(C)";
            this.ckbox.UseVisualStyleBackColor = true;
            // 
            // Form_change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 226);
            this.Controls.Add(this.ckbox);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_all_change);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_nxt);
            this.Controls.Add(this.txt_change);
            this.Controls.Add(this.txt_find);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.lbl_find);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "바꾸기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_find;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.TextBox txt_find;
        internal System.Windows.Forms.TextBox txt_change;
        internal System.Windows.Forms.Button btn_nxt;
        internal System.Windows.Forms.Button btn_change;
        internal System.Windows.Forms.Button btn_all_change;
        internal System.Windows.Forms.CheckBox ckbox;
    }
}