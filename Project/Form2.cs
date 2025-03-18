using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;

namespace Project
{
    public partial class Form2 : Form
    {
        private const string videoFilePath = "Video.csv";
        private Timer timer;
        private int totalSavedVideos;
        private int totalDeletedVideos;
        private DateTime lastUpdateDate;

        public Form2()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 15000;
            timer.Tick += Timer1_Tick;
            timer.Start();
            LoadVideoListView();
        }

        private void LoadVideoListView()
        {
            listVideo.Items.Clear();
            string[] videoRecords = File.ReadAllLines(videoFilePath);

            foreach (string record in videoRecords)
            {
                string[] fields = record.Split('|');
                if (fields.Length != 5 || fields[4] == "1") continue;

                string id = fields[0];
                string link = fields[1];
                string dateAdded = fields[2];
                string description = fields[3];

                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(link);
                item.SubItems.Add(dateAdded);
                item.SubItems.Add(description);
                listVideo.Items.Add(item);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            LoadVideoListView();
            UpdateInformationLabel();
        }

        private void UpdateInformationLabel()
        {
            int totalVideos = listVideo.Items.Count;
            totalSavedVideos = totalVideos - totalDeletedVideos;
            lastUpdateDate = DateTime.Now;

            lblInfo.Text = $"There are {totalSavedVideos} saved videos. There are also {totalDeletedVideos} deleted videos. " +
                $"Last update date is {lastUpdateDate:yyyy.MM.dd HH:mm}.";

            lblDate.Text = $"Created Date {lastUpdateDate:yyyy.MM.dd HH:mm}.";
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (form3.ShowDialog() == DialogResult.OK)
            {
                string id = form3.Id;
                string link = form3.Link;
                string description = form3.Description;
                string dateAdded = DateTime.Now.ToString("yyyy.MM.dd HH:mm");

                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(link);
                item.SubItems.Add(dateAdded);
                item.SubItems.Add(description);
                listVideo.Items.Add(item);

                File.AppendAllText(videoFilePath, $"{id}|{link}|{dateAdded}|{description}|0{Environment.NewLine}");
                UpdateInformationLabel();
            }
        }

        private void listVideo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listVideo.SelectedItems.Count > 0)
            {
                string id = listVideo.SelectedItems[0].Text;
                string link = listVideo.SelectedItems[0].SubItems[1].Text;
                string dateAdded = listVideo.SelectedItems[0].SubItems[2].Text;
                string description = listVideo.SelectedItems[0].SubItems[3].Text;
                string videoId = link.Split(new string[] { "v=", "be/" }, StringSplitOptions.None).Last();
                string thumbnailUrl = $"https://img.youtube.com/vi/{videoId}/default.jpg";

                try
                {
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Load(thumbnailUrl);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading image: {ex.Message}");
                }
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (listVideo.SelectedItems.Count > 0)
            {
                string link = listVideo.SelectedItems[0].SubItems[1].Text;
                Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listVideo.SelectedItems.Count > 0)
            {
                string id = listVideo.SelectedItems[0].Text;
                string link = listVideo.SelectedItems[0].SubItems[1].Text;
                string dateAdded = listVideo.SelectedItems[0].SubItems[2].Text;
                string description = listVideo.SelectedItems[0].SubItems[3].Text;

                Form4 form4 = new Form4(id, link, description);
                if (form4.ShowDialog() == DialogResult.OK)
                {
                    string updatedLink = form4.Link;
                    string updatedDescription = form4.Description;

                    UpdateVideoRecord(id, updatedLink, dateAdded, updatedDescription);
                    MessageBox.Show("Video updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listVideo.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to remove this video?", "Confirmation",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string id = listVideo.SelectedItems[0].Text;
                    UpdateVideoDeletedStatus(id, true);
                    totalDeletedVideos++;
                    UpdateInformationLabel();
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (listVideo.SelectedItems.Count > 0)
            {
                string link = listVideo.SelectedItems[0].SubItems[1].Text;
                Process.Start(new ProcessStartInfo(link) { UseShellExecute = true });
            }
        }

        private void UpdateVideoDeletedStatus(string id, bool isDeleted)
        {
            string[] videoRecords = File.ReadAllLines(videoFilePath);

            for (int i = 0; i < videoRecords.Length; i++)
            {
                string[] fields = videoRecords[i].Split('|');
                string currentId = fields[0];
                int deletedStatus;

                if (currentId == id && int.TryParse(fields[4], out deletedStatus))
                {
                    videoRecords[i] = $"{currentId}|{fields[1]}|{fields[2]}|{fields[3]}|{(isDeleted ? 1 : deletedStatus)}";
                }
            }

            File.WriteAllLines(videoFilePath, videoRecords);
        }

        private void UpdateVideoRecord(string id, string link, string dateAdded, string description)
        {
            string[] videoRecords = File.ReadAllLines(videoFilePath);

            for (int i = 0; i < videoRecords.Length; i++)
            {
                string[] fields = videoRecords[i].Split('|');
                string currentId = fields[0];

                if (currentId == id)
                {
                    videoRecords[i] = $"{id}|{link}|{dateAdded}|{description}|0";
                }
            }

            File.WriteAllLines(videoFilePath, videoRecords);
            LoadVideoListView();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
    
        }
    }
}
