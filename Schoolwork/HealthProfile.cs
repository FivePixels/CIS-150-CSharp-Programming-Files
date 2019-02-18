using System;

namespace HealthProfileApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string first = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            string last = Console.ReadLine();
            Console.WriteLine("What is your birth year?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your height in inches");
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("What is your weight in pounds");
            int weight = int.Parse(Console.ReadLine());

            HealthProfile profile = new HealthProfile(first, last, year, height, weight);
            profile.displayResults();
        }
    }
    class HealthProfile
    {
        public string firstName;
        public string lastName;
        public int birthYear;
        public double height;
        public int weight;

        public HealthProfile(string fName, string lName, int bYear, double h, int w)
        {
            firstName = fName;
            lastName = lName;
            birthYear = bYear;
            height = h;
            weight = w;
        }

        public void setFirstName(string name)
        {
            firstName = name;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public void setLastName(string name)
        {
            lastName = name;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setBirthYear(int bYear)
        {
            birthYear = bYear;
        }
        public int getBirthYear()
        {
            return birthYear;
        }
        public void setHeight(double h)
        {
            height = h;
        }
        public double getHeight()
        {
            return height;
        }
        public void setWeight(int w)
        {
            weight = w;
        }
        public int getWeight()
        {
            return weight;
        }
        public int getAge()
        {
            return DateTime.Now.Year - birthYear;
        }
        public int getMaxHeartRate()
        {
            return 220 - getAge();
        }
        public double getMinGoal()
        {
            return getMaxHeartRate() * 0.50;
        }
        public double getMaxGoal()
        {
            return getMaxHeartRate() * 0.85;
        }
        public double getBMI()
        {
            double sqrd = Math.Pow((height * 0.025), 2);
            return ((weight * 0.45) / sqrd);
        }
        public void displayResults()
        {
            Console.WriteLine("{0} {1}", firstName, lastName);
            Console.WriteLine("Age: {0}", getAge());
            Console.WriteLine("Max Heart Rate: {0}", getMaxHeartRate());
            Console.WriteLine("Min Target Heart Rate: {0}", getMinGoal());
            Console.WriteLine("Max Target Heart Rate: {0}", getMaxGoal());
            Console.WriteLine("BMI: {0}", getBMI());
            Console.WriteLine("BMI VALUES");
            Console.WriteLine("Underweight: less than 18.5");
            Console.WriteLine("Normal:      between 18.5 and 24.9");
            Console.WriteLine("Overweight:  between 25 and 29.9");
            Console.WriteLine("Obese:       30 or greater");
        }
    }

}
