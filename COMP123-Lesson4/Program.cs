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
            //create a new instance of the Person class
            Person Sarah = new Person();
            Sarah.Name = "Sarah";
            Sarah.Age = 29;
            Sarah.SaysHello();
            Sarah.ShowAge();

            Console.WriteLine("-----------------------------");

            Person Chris = new Person("Tom");
            Chris.Age = 23;
            Chris.SaysHello();
            Chris.ShowAge();

            Console.WriteLine("-----------------------------");

            Person mark = new Person(30);
            mark.Name = "Mark";
            mark.SaysHello();
            mark.ShowAge();

            Console.WriteLine("-----------------------------");

            Person Joanne = new Person("Joanne", 25);
            Joanne.SaysHello();
            Joanne.ShowAge();


            Console.WriteLine("-----------------------------");

            Person Jing = new Person("Jing", 35);
            Jing.SaysHello();
            Jing.ShowAge();


            Console.WriteLine("-----------------------------");

            Person Kent = new Person("Kent", 29);
            Kent.SaysHello();
            Kent.ShowAge();

        }
    }
}