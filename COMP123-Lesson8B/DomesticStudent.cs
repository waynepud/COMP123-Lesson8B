﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_Lesson8B
{
    public class DomesticStudent : Student
    {
        //Public properties -----------
        public string DomesticAddress { get; private set; } //Read only

        //Constructors
        /// <summary>
        /// This is the constructor - takes three arguments - name(string) - age(int) - studentID(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public DomesticStudent(string name, int age, string studentID) : base(name, age, studentID)
        {
            
        }

        //public methods
        /// <summary>
        /// This method sets the domestic address property
        /// </summary>
        /// <param name="address"></param>
        public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }

    }
}