namespace CSharp_Practice.OOPs.ClassAndObjects.PartialClass
{
    public partial class PartialEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " Gender: " + Gender + " Salary: " + Salary;
        }
    }
}