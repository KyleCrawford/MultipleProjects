namespace Modeless_Dialoges_and_Delegates
{
    partial class Form_Secondary
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
            this.TxtBox_OutB = new System.Windows.Forms.TextBox();
            this.TxtBox_InB = new System.Windows.Forms.TextBox();
            this.Lbl_OutB = new System.Windows.Forms.Label();
            this.Lbl_InB = new System.Windows.Forms.Label();
            this.Lbl_B = new System.Windows.Forms.Label();
            this.Btn_PullB = new System.Windows.Forms.Button();
            this.Btn_SendB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_OutB
            // 
            this.TxtBox_OutB.Location = new System.Drawing.Point(423, 211);
            this.TxtBox_OutB.Name = "TxtBox_OutB";
            this.TxtBox_OutB.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_OutB.TabIndex = 7;
            // 
            // TxtBox_InB
            // 
            this.TxtBox_InB.Location = new System.Drawing.Point(199, 211);
            this.TxtBox_InB.Name = "TxtBox_InB";
            this.TxtBox_InB.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_InB.TabIndex = 6;
            // 
            // Lbl_OutB
            // 
            this.Lbl_OutB.AutoSize = true;
            this.Lbl_OutB.Location = new System.Drawing.Point(420, 179);
            this.Lbl_OutB.Name = "Lbl_OutB";
            this.Lbl_OutB.Size = new System.Drawing.Size(74, 13);
            this.Lbl_OutB.TabIndex = 5;
            this.Lbl_OutB.Text = "Text Goes out";
            // 
            // Lbl_InB
            // 
            this.Lbl_InB.AutoSize = true;
            this.Lbl_InB.Location = new System.Drawing.Point(196, 179);
            this.Lbl_InB.Name = "Lbl_InB";
            this.Lbl_InB.Size = new System.Drawing.Size(74, 13);
            this.Lbl_InB.TabIndex = 4;
            this.Lbl_InB.Text = "Text Comes in";
            // 
            // Lbl_B
            // 
            this.Lbl_B.AutoSize = true;
            this.Lbl_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_B.Location = new System.Drawing.Point(337, 139);
            this.Lbl_B.Name = "Lbl_B";
            this.Lbl_B.Size = new System.Drawing.Size(40, 39);
            this.Lbl_B.TabIndex = 8;
            this.Lbl_B.Text = "B";
            // 
            // Btn_PullB
            // 
            this.Btn_PullB.Location = new System.Drawing.Point(199, 255);
            this.Btn_PullB.Name = "Btn_PullB";
            this.Btn_PullB.Size = new System.Drawing.Size(75, 23);
            this.Btn_PullB.TabIndex = 9;
            this.Btn_PullB.Text = "Bring it in";
            this.Btn_PullB.UseVisualStyleBackColor = true;
            this.Btn_PullB.Click += new System.EventHandler(this.Btn_PullB_Click);
            // 
            // Btn_SendB
            // 
            this.Btn_SendB.Location = new System.Drawing.Point(423, 255);
            this.Btn_SendB.Name = "Btn_SendB";
            this.Btn_SendB.Size = new System.Drawing.Size(75, 23);
            this.Btn_SendB.TabIndex = 10;
            this.Btn_SendB.Text = "Send it out";
            this.Btn_SendB.UseVisualStyleBackColor = true;
            this.Btn_SendB.Click += new System.EventHandler(this.Btn_SendB_Click);
            // 
            // Form_Secondary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_SendB);
            this.Controls.Add(this.Btn_PullB);
            this.Controls.Add(this.Lbl_B);
            this.Controls.Add(this.TxtBox_OutB);
            this.Controls.Add(this.TxtBox_InB);
            this.Controls.Add(this.Lbl_OutB);
            this.Controls.Add(this.Lbl_InB);
            this.Name = "Form_Secondary";
            this.Text = "Form_Secondary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_OutB;
        private System.Windows.Forms.TextBox TxtBox_InB;
        private System.Windows.Forms.Label Lbl_OutB;
        private System.Windows.Forms.Label Lbl_InB;
        private System.Windows.Forms.Label Lbl_B;
        private System.Windows.Forms.Button Btn_PullB;
        private System.Windows.Forms.Button Btn_SendB;
    }
}