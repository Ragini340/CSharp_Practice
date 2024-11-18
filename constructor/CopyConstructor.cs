using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice.constructor
{
    public class CopyConstructor
    {
        private string month;
        private int year;

        //Copy constructor declaration
        public CopyConstructor(CopyConstructor copyConstructor)
        {
            month = copyConstructor.month;
            year = copyConstructor.year;
        }

        //Instace constructor
        public CopyConstructor(string month, int year)
        {
            this.month = month;
            this.year = year;
        }

        //Property
        public string Details
        {
            get
            {
                return "Month: " + month + "\nYear: " + year.ToString();
            }
        }

    }
}
