namespace CSharp_Practice.Collections.Generic.List.Sorting.Sorting_IComparer
{
    public class SortingUsingIComparer : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
           if(x.Salary > y.Salary) //a - b  > 0
            {
                return 1;
            }
           else if (x.Salary < y.Salary) //a - b < 0
            {
                return -1;
            }
            else
            {
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}