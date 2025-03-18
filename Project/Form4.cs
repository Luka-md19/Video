using System;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Form4 : Form
    {
        private string videoId;
        private string videoLink;
        private string videoDescription;

        public string Id { get { return txtId.Text; } }
        public string Link { get { return txtLink3.Text; } }
        public string Description { get { return txtDesc.Text; } }

        public Form4(string id, string link, string description)
        {
            InitializeComponent();
            videoId = id;
            videoLink = link;
            videoDescription = description;

            txtId.Text = videoId;
            txtLink3.Text = videoLink;
            txtDesc.Text = videoDescription;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtLink3.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtId.Text.Contains("|") || txtLink3.Text.Contains("|") || txtDesc.Text.Contains("|"))
            {
                MessageBox.Show("Fields cannot contain the '|' character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] videoRecords = File.ReadAllLines("video.csv");
                for (int i = 0; i < videoRecords.Length; i++)
                {
                    string[] fields = videoRecords[i].Split('|');
                    string currentId = fields[0];

                    if (currentId == videoId)
                    {
                        videoRecords[i] = $"{txtId.Text}|{txtLink3.Text}|{fields[2]}|{txtDesc.Text}|0"; // Keep original date
                        break;
                    }
                }

                File.WriteAllLines("video.csv", videoRecords);

                MessageBox.Show("Video updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelVideo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
