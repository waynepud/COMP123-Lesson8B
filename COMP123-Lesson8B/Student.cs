using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson8B
{
    /// <summary>
    /// This is the student class
    /// </summary>
    class Student : Person
    {
        // Private instance variables (fields)
        private string _studentID;

        // Public properties
        public string StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }

        // Constructors
        /// <summary>
        /// This is the constructor for the student class
        /// This takes three arguments - name(string) age(int) studentID(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID) : base(name, age)
        {
            this.StudentID = studentID;
        }

        //Public methods
        /// <summary>
        /// This is the studies method
        /// Enables student to study
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying");
        }
    }
}
