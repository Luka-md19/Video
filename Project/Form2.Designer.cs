using System;
using System.Windows.Forms;

namespace Project
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
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.lblList2 = new System.Windows.Forms.Label();
            this.listVideoSelected = new System.Windows.Forms.GroupBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.Video = new System.Windows.Forms.ColumnHeader();
            this.Date = new System.Windows.Forms.ColumnHeader();
            this.DescriptionColumn = new System.Windows.Forms.ColumnHeader();
            this.listVideo = new System.Windows.Forms.ListView();
            this.listVideoSelected.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.BackColor = System.Drawing.Color.Teal;
            this.btnAddVideo.ForeColor = System.Drawing.Color.White;
            this.btnAddVideo.Location = new System.Drawing.Point(533, 308);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(149, 26);
            this.btnAddVideo.TabIndex = 3;
            this.btnAddVideo.Text = "Add New Video";
            this.btnAddVideo.UseVisualStyleBackColor = false;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // lblList2
            // 
            this.lblList2.AutoSize = true;
            this.lblList2.ForeColor = System.Drawing.Color.Teal;
            this.lblList2.Location = new System.Drawing.Point(16, 177);
            this.lblList2.Name = "lblList2";
            this.lblList2.Size = new System.Drawing.Size(92, 17);
            this.lblList2.TabIndex = 4;
            this.lblList2.Text = "Video ListView";
            // 
            // listVideoSelected
            // 
            this.listVideoSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listVideoSelected.Controls.Add(this.pictureBox);
            this.listVideoSelected.Controls.Add(this.lblDate);
            this.listVideoSelected.Controls.Add(this.btnDelete);
            this.listVideoSelected.Controls.Add(this.btnUpdate);
            this.listVideoSelected.Controls.Add(this.btnOpen);
            this.listVideoSelected.Controls.Add(this.btnAddVideo);
            this.listVideoSelected.ForeColor = System.Drawing.Color.Teal;
            this.listVideoSelected.Location = new System.Drawing.Point(859, 206);
            this.listVideoSelected.Name = "listVideoSelected";
            this.listVideoSelected.Size = new System.Drawing.Size(938, 361);
            this.listVideoSelected.TabIndex = 6;
            this.listVideoSelected.TabStop = false;
            this.listVideoSelected.Text = "Selected Video Information";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.pictureBox.Location = new System.Drawing.Point(240, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(466, 232);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.Teal;
            this.lblDate.Location = new System.Drawing.Point(688, 313);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(94, 17);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Created Date:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Teal;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(353, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(149, 26);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Teal;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(175, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 26);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Teal;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(0, 308);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(149, 26);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.ForeColor = System.Drawing.Color.Teal;
            this.lblInfo.Location = new System.Drawing.Point(881, 596);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(381, 17);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.Text = "There are saved videos (  ) . There are also deleted videos ( )";
            // 
            // lblAdmin
            // 
            this.lblAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right));
            this.lblAdmin.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblAdmin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.ForeColor = System.Drawing.Color.Teal;
            this.lblAdmin.Location = new System.Drawing.Point(610, 111);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(609, 70);
            this.lblAdmin.TabIndex = 10;
            this.lblAdmin.Text = "Video Admin";
            this.lblAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.Width = 150;
            // 
            // Video
            // 
            this.Video.Text = "Video Name";
            this.Video.Width = 300;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 150;
            // 
            // DescriptionColumn
            // 
            this.DescriptionColumn.Text = "Description";
            this.DescriptionColumn.Width = 300;
            // 
            // listVideo
            // 
            this.listVideo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Video,
            this.Date,
            this.DescriptionColumn});
            this.listVideo.HideSelection = false;
            this.listVideo.Location = new System.Drawing.Point(12, 195);
            this.listVideo.Name = "listVideo";
            this.listVideo.Size = new System.Drawing.Size(812, 651);
            this.listVideo.TabIndex = 9;
            this.listVideo.UseCompatibleStateImageBehavior = false;
            this.listVideo.View = System.Windows.Forms.View.Details;
            this.listVideo.SelectedIndexChanged += new System.EventHandler(this.listVideo_SelectedIndexChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1877, 886);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.listVideo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.listVideoSelected);
            this.Controls.Add(this.lblList2);
            this.Name = "Form2";
            this.Text = "Admin panel";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.listVideoSelected.ResumeLayout(false);
            this.listVideoSelected.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Label lblList2;
        private System.Windows.Forms.GroupBox listVideoSelected;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Video;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader DescriptionColumn;
        private System.Windows.Forms.ListView listVideo;
    }
}