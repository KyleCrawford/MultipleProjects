namespace Modeless_Dialoges_and_Delegates
{
    partial class Form_MainForm
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
            this.Lbl_In = new System.Windows.Forms.Label();
            this.Lbl_Out = new System.Windows.Forms.Label();
            this.TxtBox_In = new System.Windows.Forms.TextBox();
            this.TxtBox_Out = new System.Windows.Forms.TextBox();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_Pull = new System.Windows.Forms.Button();
            this.Btn_toGet = new System.Windows.Forms.Button();
            this.Btn_SetIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_In
            // 
            this.Lbl_In.AutoSize = true;
            this.Lbl_In.Location = new System.Drawing.Point(207, 147);
            this.Lbl_In.Name = "Lbl_In";
            this.Lbl_In.Size = new System.Drawing.Size(74, 13);
            this.Lbl_In.TabIndex = 0;
            this.Lbl_In.Text = "Text Comes in";
            // 
            // Lbl_Out
            // 
            this.Lbl_Out.AutoSize = true;
            this.Lbl_Out.Location = new System.Drawing.Point(431, 147);
            this.Lbl_Out.Name = "Lbl_Out";
            this.Lbl_Out.Size = new System.Drawing.Size(74, 13);
            this.Lbl_Out.TabIndex = 1;
            this.Lbl_Out.Text = "Text Goes out";
            // 
            // TxtBox_In
            // 
            this.TxtBox_In.Location = new System.Drawing.Point(210, 179);
            this.TxtBox_In.Name = "TxtBox_In";
            this.TxtBox_In.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_In.TabIndex = 2;
            // 
            // TxtBox_Out
            // 
            this.TxtBox_Out.Location = new System.Drawing.Point(434, 179);
            this.TxtBox_Out.Name = "TxtBox_Out";
            this.TxtBox_Out.Size = new System.Drawing.Size(100, 20);
            this.TxtBox_Out.TabIndex = 3;
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(430, 223);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(75, 23);
            this.Btn_Send.TabIndex = 12;
            this.Btn_Send.Text = "Send it out";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_Pull
            // 
            this.Btn_Pull.Location = new System.Drawing.Point(206, 223);
            this.Btn_Pull.Name = "Btn_Pull";
            this.Btn_Pull.Size = new System.Drawing.Size(75, 23);
            this.Btn_Pull.TabIndex = 11;
            this.Btn_Pull.Text = "Bring it in";
            this.Btn_Pull.UseVisualStyleBackColor = true;
            this.Btn_Pull.Click += new System.EventHandler(this.Btn_Pull_Click);
            // 
            // Btn_toGet
            // 
            this.Btn_toGet.Location = new System.Drawing.Point(430, 295);
            this.Btn_toGet.Name = "Btn_toGet";
            this.Btn_toGet.Size = new System.Drawing.Size(75, 23);
            this.Btn_toGet.TabIndex = 14;
            this.Btn_toGet.Text = "Go toGet?";
            this.Btn_toGet.UseVisualStyleBackColor = true;
            this.Btn_toGet.Click += new System.EventHandler(this.Btn_toGet_Click);
            // 
            // Btn_SetIn
            // 
            this.Btn_SetIn.Location = new System.Drawing.Point(206, 295);
            this.Btn_SetIn.Name = "Btn_SetIn";
            this.Btn_SetIn.Size = new System.Drawing.Size(75, 23);
            this.Btn_SetIn.TabIndex = 13;
            this.Btn_SetIn.Text = "Set Inbox";
            this.Btn_SetIn.UseVisualStyleBackColor = true;
            this.Btn_SetIn.Click += new System.EventHandler(this.Btn_SetIn_Click);
            // 
            // Form_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_toGet);
            this.Controls.Add(this.Btn_SetIn);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Btn_Pull);
            this.Controls.Add(this.TxtBox_Out);
            this.Controls.Add(this.TxtBox_In);
            this.Controls.Add(this.Lbl_Out);
            this.Controls.Add(this.Lbl_In);
            this.Name = "Form_MainForm";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_In;
        private System.Windows.Forms.Label Lbl_Out;
        private System.Windows.Forms.TextBox TxtBox_In;
        private System.Windows.Forms.TextBox TxtBox_Out;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_Pull;
        private System.Windows.Forms.Button Btn_toGet;
        private System.Windows.Forms.Button Btn_SetIn;
    }
}

