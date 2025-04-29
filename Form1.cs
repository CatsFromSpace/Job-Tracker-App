using System.Data;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace JobTrackerApp
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:7139")
        };

        public Form1()
        {
            InitializeComponent();
            dvgJobs.DataBindingComplete += DvgJobs_DataBindingComplete;
            this.Load += Form1_Load; // Doesn't let me await RefreshGrid() in the constructor for some reason
        }

        // Add job to the list
        private async void btnAddJob_ClickAsync(object sender, EventArgs e)
        {
            var job = new JobApplication
            {
                Id = Guid.NewGuid(),
                CompanyName = txtCompany.Text,
                Position = txtPosition.Text,
                Location = txtLocation.Text,
                Status = cmbStatus.SelectedItem.ToString(),
                DateApplied = dateTimePicker1.Value,
                DateInterviewed = dateTimePicker2.Value,
                Notes = txtNotes.Text
            };

            await client.PostAsJsonAsync("/api/job", job); // API call

            await RefreshGrid();
        }

        // Delete selected job
        private async void btnDelete_ClickAsync(object sender, EventArgs e)
        {
            if (dvgJobs.CurrentRow?.DataBoundItem is JobApplication selectedJob)
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this job?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    var response = await client.DeleteAsync($"/api/job/{selectedJob.Id}"); // API call

                    if (response.IsSuccessStatusCode)
                    {
                        await RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting job.");
                    }
                }
            }
        }

        // Delete all jobs
        private async void btnDeleteAll_ClickAsync(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete all jobs?", "Confirm Delete All", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                var jobs = await GetJobsFromApi();

                foreach (var job in jobs)
                {
                    var response = await client.DeleteAsync($"/api/job/{job.Id}"); // API call
                    if (!response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Error deleting jobs.");
                    }
                }

                await RefreshGrid();
            }
        }

        // Refresh the Data View Grid
        private async Task RefreshGrid()
        {
            // Sort jobs by interview date
            var jobList = await GetJobsFromApi();

            var jobListSorted = jobList
                .OrderBy(j => j.DateInterviewed ?? DateTime.MaxValue)
                .ToList();

            dvgJobs.DataSource = null;
            dvgJobs.DataSource = jobListSorted;

            // Hide ID Column
            if (dvgJobs.Columns["Id"] != null)
            {
                dvgJobs.Columns["Id"].Visible = false;
            }

            // Rename Column Headers
            if (dvgJobs.Columns["CompanyName"] != null)
            {
                dvgJobs.Columns["CompanyName"].HeaderText = "Company";
            }

            if (dvgJobs.Columns["DateApplied"] != null)
            {
                dvgJobs.Columns["DateApplied"].HeaderText = "Date Applied";
            }

            if (dvgJobs.Columns["DateInterviewed"] != null)
            {
                dvgJobs.Columns["DateInterviewed"].HeaderText = "Interview Date";
            }
        }

        // Hightlight interviews in grid
        private void Highlight()
        {
            foreach (DataGridViewRow row in dvgJobs.Rows)
            {
                if (row.DataBoundItem is JobApplication job && job.DateInterviewed.HasValue)
                {
                    var daysUntil = (job.DateInterviewed.Value - DateTime.Now).TotalDays;
                    if (daysUntil >= 0 && daysUntil <= 7)
                    {
                        row.DefaultCellStyle.BackColor = Color.Yellow; // Highlight in yellow
                    }
                    else if (daysUntil < 0)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red; // Highlight in red for past interviews
                    }
                }
            }
        }

        // Load form and refresh grid
        private async void Form1_Load(object sender, EventArgs e)
        {
            await RefreshGrid();
        }

        // wait for data binding before highlighing
        private void DvgJobs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Highlight();
        }

        // API Connection
        private async Task<List<JobApplication>> GetJobsFromApi()
        {
            var response = await client.GetAsync("/api/job");
            if (response.IsSuccessStatusCode)
            {
                var jobs = await response.Content.ReadFromJsonAsync<List<JobApplication>>();
                return jobs ?? new List<JobApplication>();
            }
            else
            {
                MessageBox.Show("Error fetching data from API.");
                return new List<JobApplication>();
            }
        }
    }
}
