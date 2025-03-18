namespace Project
{
    partial class Form4
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

        private void InitializeComponent()
        {
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.txtLink3 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblYouLink = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblYouId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelVideo = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.ForeColor = System.Drawing.Color.Teal;
            this.txtDesc.Location = new System.Drawing.Point(242, 260);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(396, 37);
            this.txtDesc.TabIndex = 22;
            // 
            // txtLink3
            // 
            this.txtLink3.BackColor = System.Drawing.Color.White;
            this.txtLink3.ForeColor = System.Drawing.Color.Teal;
            this.txtLink3.Location = new System.Drawing.Point(242, 205);
            this.txtLink3.Multiline = true;
            this.txtLink3.Name = "txtLink3";
            this.txtLink3.Size = new System.Drawing.Size(396, 36);
            this.txtLink3.TabIndex = 21;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.ForeColor = System.Drawing.Color.Teal;
            this.txtId.Location = new System.Drawing.Point(242, 154);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(396, 36);
            this.txtId.TabIndex = 20;
            // 
            // lblYouLink
            // 
            this.lblYouLink.AutoSize = true;
            this.lblYouLink.ForeColor = System.Drawing.Color.Teal;
            this.lblYouLink.Location = new System.Drawing.Point(123, 208);
            this.lblYouLink.Name = "lblYouLink";
            this.lblYouLink.Size = new System.Drawing.Size(83, 17);
            this.lblYouLink.TabIndex = 19;
            this.lblYouLink.Text = "Youtube link";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.Teal;
            this.lblDesc.Location = new System.Drawing.Point(110, 263);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(113, 17);
            this.lblDesc.TabIndex = 18;
            this.lblDesc.Text = "Video Description";
            // 
            // lblYouId
            // 
            this.lblYouId.AutoSize = true;
            this.lblYouId.ForeColor = System.Drawing.Color.Teal;
            this.lblYouId.Location = new System.Drawing.Point(123, 159);
            this.lblYouId.Name = "lblYouId";
            this.lblYouId.Size = new System.Drawing.Size(74, 17);
            this.lblYouId.TabIndex = 17;
            this.lblYouId.Text = "Youtube id";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(256, 318);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 26);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancelVideo
            // 
            this.btnCancelVideo.BackColor = System.Drawing.Color.Teal;
            this.btnCancelVideo.ForeColor = System.Drawing.Color.White;
            this.btnCancelVideo.Location = new System.Drawing.Point(439, 318);
            this.btnCancelVideo.Name = "btnCancelVideo";
            this.btnCancelVideo.Size = new System.Drawing.Size(149, 26);
            this.btnCancelVideo.TabIndex = 14;
            this.btnCancelVideo.Text = "Cancel";
            this.btnCancelVideo.UseVisualStyleBackColor = false;
            this.btnCancelVideo.Click += new System.EventHandler(this.btnCancelVideo_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdmin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Teal;
            this.lblAdmin.Location = new System.Drawing.Point(326, 79);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(177, 42);
            this.lblAdmin.TabIndex = 23;
            this.lblAdmin.Text = "Video Admin";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtLink3);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblYouLink);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblYouId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancelVideo);
            this.Name = "Form4";
            this.Text = "Update Video";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.TextBox txtLink3;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblYouLink;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblYouId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelVideo;
        private System.Windows.Forms.Label lblAdmin;
    }
}