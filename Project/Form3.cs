using System;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Form3 : Form
    {
        public string Id { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }

        public Form3()
        {
            InitializeComponent();
        }

        public Form3(string id, string link, string description) : this()
        {
            Id = id;
            Link = link;
            Description = description;
        }

        private void btnCancelVideo_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtLink2.Text) || string.IsNullOrWhiteSpace(txtDesc.Text))
            {
                MessageBox.Show("Please fill in all the fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtId.Text.Contains("|") || txtLink2.Text.Contains("|") || txtDesc.Text.Contains("|"))
            {
                MessageBox.Show("Fields cannot contain the '|' character.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string videoFilePath = "video.csv";
                string newRecord = $"{txtId.Text}|{txtLink2.Text}|{DateTime.Now:yyyy.MM.dd HH:mm}|{txtDesc.Text}|0";

                using (StreamWriter writer = new StreamWriter(videoFilePath, true))
                {
                    writer.WriteLine(newRecord);
                }

                MessageBox.Show("Video added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while adding the video: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}