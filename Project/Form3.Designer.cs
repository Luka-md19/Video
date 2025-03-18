namespace Project
{
    partial class Form3
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lblYouId = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblYouLink = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtLink2 = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Teal;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(302, 356);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 26);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblYouId
            // 
            this.lblYouId.AutoSize = true;
            this.lblYouId.ForeColor = System.Drawing.Color.Teal;
            this.lblYouId.Location = new System.Drawing.Point(109, 195);
            this.lblYouId.Name = "lblYouId";
            this.lblYouId.Size = new System.Drawing.Size(74, 17);
            this.lblYouId.TabIndex = 7;
            this.lblYouId.Text = "Youtube id";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.ForeColor = System.Drawing.Color.Teal;
            this.lblDesc.Location = new System.Drawing.Point(82, 309);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(113, 17);
            this.lblDesc.TabIndex = 8;
            this.lblDesc.Text = "Video Description";
            // 
            // lblYouLink
            // 
            this.lblYouLink.AutoSize = true;
            this.lblYouLink.ForeColor = System.Drawing.Color.Teal;
            this.lblYouLink.Location = new System.Drawing.Point(100, 250);
            this.lblYouLink.Name = "lblYouLink";
            this.lblYouLink.Size = new System.Drawing.Size(83, 17);
            this.lblYouLink.TabIndex = 9;
            this.lblYouLink.Text = "Youtube link";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.ForeColor = System.Drawing.Color.Teal;
            this.txtId.Location = new System.Drawing.Point(210, 192);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(396, 36);
            this.txtId.TabIndex = 10;
            // 
            // txtLink2
            // 
            this.txtLink2.BackColor = System.Drawing.Color.White;
            this.txtLink2.ForeColor = System.Drawing.Color.Teal;
            this.txtLink2.Location = new System.Drawing.Point(210, 247);
            this.txtLink2.Multiline = true;
            this.txtLink2.Name = "txtLink2";
            this.txtLink2.Size = new System.Drawing.Size(396, 36);
            this.txtLink2.TabIndex = 11;
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.ForeColor = System.Drawing.Color.Teal;
            this.txtDesc.Location = new System.Drawing.Point(210, 306);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(396, 37);
            this.txtDesc.TabIndex = 12;
            // 
            // lblAdmin
            // 
            this.lblAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdmin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Teal;
            this.lblAdmin.Location = new System.Drawing.Point(306, 126);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(177, 42);
            this.lblAdmin.TabIndex = 14;
            this.lblAdmin.Text = "Video Admin";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 451);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtLink2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblYouLink);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblYouId);
            this.Controls.Add(this.btnSave);
            this.Name = "Form3";
            this.Text = "Add New Video ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblYouId;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblYouLink;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtLink2;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblAdmin;
    }
}