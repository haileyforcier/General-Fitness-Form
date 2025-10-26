using System.Windows.Forms;

namespace TestAssignment2
{
    public class User
    {
        public string Name { get; }
        public decimal Weight { get; }
        public decimal Height { get; }
        public int Age { get; }
        public string Gender { get; }
        public decimal? Waist { get; }
        public decimal? Wrist { get; }
        public decimal? Hip { get; }
        public decimal? Forearm { get; }
        public decimal RMR { get; }
        public decimal AMR { get; }
        public int ActivityLevel { get; }
        public decimal? BodyFatPercentage { get; }

        public User(string name, decimal weight, decimal height, int age, string gender, decimal? waist, decimal? wrist, decimal? hip, decimal? forearm, int activityLevel)
        {
            Name = name;
            Weight = weight;
            Height = height;
            Age = age;
            Gender = gender;
            Waist = waist;
            Wrist = wrist;
            Hip = hip;
            Forearm = forearm;
            ActivityLevel = activityLevel;
            RMR = CalculateRMR();
            AMR = CalculateAMR(activityLevel);
            BodyFatPercentage = CalculateBodyFat();
        }

        private decimal CalculateRMR()
        {
            return Gender == "Male"
                ? 88.4m + (13.4m * Weight * 0.453592m) + (4.8m * Height * 2.54m) - (5.68m * Age)
                : 447.6m + (9.25m * Weight * 0.453592m) + (3.1m * Height * 2.54m) - (4.33m * Age);
        }

        private decimal CalculateAMR(int activityLevel)
        {
            decimal[] multipliers = { 1.2m, 1.3m, 1.4m, 1.5m, 1.6m, 1.7m, 1.8m };
            if (activityLevel < 0 || activityLevel >= multipliers.Length)
            {
                MessageBox.Show("Invalid activity level selection. Please select a valid activity level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return RMR;
            }
            return RMR * multipliers[activityLevel];
        }

        private decimal? CalculateBodyFat()
        {
            if (Gender == "Male")
            {
                return Waist.HasValue ? (Weight - ((Weight * 1.082m) + 94.42m - Waist.Value * 4.15m)) * 100 / Weight : null;
            }
            else
            {
                return (Waist.HasValue && Wrist.HasValue && Hip.HasValue && Forearm.HasValue) ?
                    (Weight - ((Weight * 0.732m) + 8.987m + Wrist.Value / 3.140m - Waist.Value * 0.157m - Hip.Value * 0.249m + Forearm.Value * 0.434m)) * 100 / Weight : null;
            }
        }
    }
}

