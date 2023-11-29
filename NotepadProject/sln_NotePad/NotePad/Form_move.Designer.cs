namespace NotePad
{
    partial class Form_move
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
            this.lbl_line = new System.Windows.Forms.Label();
            this.txt_line = new System.Windows.Forms.TextBox();
            this.btn_move = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_line
            // 
            this.lbl_line.AutoSize = true;
            this.lbl_line.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl_line.Location = new System.Drawing.Point(15, 20);
            this.lbl_line.Name = "lbl_line";
            this.lbl_line.Size = new System.Drawing.Size(67, 15);
            this.lbl_line.TabIndex = 0;
            this.lbl_line.Text = "줄 번호: ";
            // 
            // txt_line
            // 
            this.txt_line.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt_line.Location = new System.Drawing.Point(18, 45);
            this.txt_line.Name = "txt_line";
            this.txt_line.Size = new System.Drawing.Size(250, 25);
            this.txt_line.TabIndex = 1;
            this.txt_line.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_line_KeyPress);
            // 
            // btn_move
            // 
            this.btn_move.FlatAppearance.BorderSize = 0;
            this.btn_move.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_move.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_move.Location = new System.Drawing.Point(98, 85);
            this.btn_move.Name = "btn_move";
            this.btn_move.Size = new System.Drawing.Size(80, 30);
            this.btn_move.TabIndex = 2;
            this.btn_move.Text = "이동";
            this.btn_move.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_cancel.Location = new System.Drawing.Point(188, 85);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 30);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "취소";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_move);
            this.Controls.Add(this.txt_line);
            this.Controls.Add(this.lbl_line);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_move";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "줄 이동";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_line;
        private System.Windows.Forms.Button btn_cancel;
        internal System.Windows.Forms.TextBox txt_line;
        internal System.Windows.Forms.Button btn_move;
    }
}