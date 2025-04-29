using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobTrackerApp
{
    class JobApplication // App model
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public DateTime DateApplied { get; set; }
        public DateTime? DateInterviewed { get; set; }
        public string Notes { get; set; }
    }
}
