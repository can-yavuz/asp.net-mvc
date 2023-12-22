namespace BtkAkademi.Models
{
    public static class Repository
    {
        private static new List<Candidate> applications = new();
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate){

            applications.Add(candidate);

        }
    }
}