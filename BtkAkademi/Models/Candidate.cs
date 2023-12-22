using System.ComponentModel.DataAnnotations;

namespace BtkAkademi.Models
{
    public class Candidate
    {
        public String? email { get; set; } = String.Empty;
        public String? name { get; set; } = String.Empty;
        public String? surname { get; set; } = String.Empty;
        public String? fullname => $"{name} {surname?.ToUpper()}";
        public String selectedCourse { get; set; } = String.Empty;
        public int? age { get; set; }
        public DateTime applyTime { get; set; }


        public Candidate()
        {
            applyTime = DateTime.Now;
        }       

    }
}