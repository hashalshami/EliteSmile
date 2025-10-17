using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteSmile.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string FileNo { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Date { get; set; }
        public string TreatmentPlan { get; set; }
    }
}
