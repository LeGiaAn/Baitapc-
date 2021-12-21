using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPPP
{
        class subject
    {
        private string name;
        private float theoryMark;
        private float practiceMark;

             public subject(string name, float theoryMark, float practiceMark)
        {
            this.name = name;
            this.theoryMark = theoryMark;
            this.practiceMark = practiceMark;
        }

        public float markAverage()
        {
            Console.WriteLine("name: {0}", name);
            Console.WriteLine("theoryMark: {0}", theoryMark);
            Console.WriteLine("practiceMark: {0}", practiceMark);
            return (theoryMark + practiceMark) / 2;
        }
    }
}
