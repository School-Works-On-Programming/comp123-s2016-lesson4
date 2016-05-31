using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Christopher Ritchil 
 * Date created: May 27 2016
 * Date Modified: May 27 2016
 * Student ID: 300702644
 * 
 * Description: This program demonstrate creating Person class in seperate file, private instances for the class, public property, 
 *              show age & say hello methods for the Person class, and finally Person object in the driver class. 
 * 
 * Version: 0.1.0 
 */



namespace COMP123_Lesson4
{

    /**
     * This class is the driver class for our Program
     */


    public class Program
    {
        /**
         *the main method for our driver class Program
         * 
         * 
         * @method Main 
         * @param {string} args 
         */
        public static void Main(string[] args)
        {
            // Create instance of the Student class
            Student tommy = new Student("Tommy", 20, "300700600");

            tommy.Age = 20;
            tommy.Name = "Tommy";
            tommy.SaysHello();

            Console.WriteLine();

            tommy.studies();

            Console.WriteLine("-------------------------------------"); 
            // Create instance of the Teacher class
            Teacher tom = new Teacher("Tom", 50, "T12345678");

            tom.SaysHello();

            Console.WriteLine();
            tom.Teaches();
            tom.ShowAge(); 
             
        }
    }
}