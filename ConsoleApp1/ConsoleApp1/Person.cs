using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        // Properties
        public string name;
        public float height;
        public float weight;

        // Constructor
        public Person(string name,float height, float weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }

        //Print the information of a person
        public void printInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Height: " + height);
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("BMI: {0:0.00}",getBMI(weight, height));
            Console.WriteLine("Classification: {0} \n", classification(getBMI(weight, height)));
        }

        // Get the BMI of a person
        public double getBMI(float weight, float height)
        {
            return (weight / ((height/100) * (height / 100)));
        }

        // Get the classification of a person
        string classification(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi < 25)
            {
                return "Normal";
            }
            else if (bmi < 30)
            {
                return "Overweight";
            }
            else
            {
                return "Obese";
            }
        }
    }   
}
