﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    class Person
    {
        private int age;
        private string? fName;
        private string? lName;
        private double height;
        private double weight;

        public int Age
        {
            get { return age; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Age must be greater than zero.");
                }
                else
                {
                    age = value;
                }
            }
        }

        public string? FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException("First name must not be less than 2 characters or greater than 10 sign.");
                }
                else
                {

                }
                fName = value;
            }
        }

        public string? LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException("Last name must not be less than 3 characters or greater than 15 sign.");
                }
                else
                {
                    lName = value;
                }
            }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }

}
