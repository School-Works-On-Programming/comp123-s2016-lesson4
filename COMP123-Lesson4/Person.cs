using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    /**
     * This class defines a generic Person
     * 
     * @class Perosn
     * @field {string} _name 
     * @field {int} _age
     */
    public class Person
    {
        //Private instance variables/fields ++++++++++++++++++++++++++++++++++++++++++++++
        private string _name;
        private int _age;


        //Public properties ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /**
         * 
         * <summary> 
         * This is a public property for our _name field
         * </summary>
         * 
         * @property {string} Name
         */
        public string Name
        {
            get
            {
                return this._name;
            }

            set
            {
                this._name = value;
            }
        }


        /**
         * <summary>
         * This is a public property for our _age field
         * </summary>
         * 
         * @property {int} age
         */
        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }

        /**
         * <summary>
         * This is the default empty constructor for the Person class
         * </summary>
         * 
         * @constructor Person
         */
        public Person()
        {
            this._initialize();
        }


        /**
         * <summary>
         * This is a constructor that takes name as a parameter and 
         * passes t to the _name private instance variable
         * </summary>
         * 
         * @constructor Person
         * @param {string} 
         */
        public Person(string name)
        {
            this._initialize();
            this.Name = name;
        }

        /**
         * <summary>
         * This is a constructor that takes age as a parameter and 
         * passes it to the _age private instance variable
         * </summary>
         * 
         * @constructor Person
         * @param {int} age
         * 
         */

        public Person(int age)
        {
            this._initialize();
            this.Age = age;
        }


        /**
         * <summary>
         * This is a constructor that takes name and age as parameters.  
         * It assigns the local name value to the name property. 
         * It assigns the local age value to the age property. 
         * </summary>
         * 
         * @constructor Person
         * @param {string} name
         * @param {int} age
         * 
         */
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        //Private method ++++++++++++++++++++++++++++++++++++++++++++++++++++++


        /**
         * <summary>
         * This method initializes the public properties Name and Age
         * </summary>
         * 
         * @private
         * @method _initialize
         * @returns {void}
         * 
         * 
         */
        private void _initialize()
        {
            // Initialize public properties with some values
            this.Name = "unknown name!";
            this.Age = 0;
        }


        //Public method ++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This method outputs the _name value with " says Hello!!" to the console. 
         * </summary>
         * 
         * @method _SaysHello
         * @return {void}
         * 
         */
        public void SaysHello()
        {
            Console.WriteLine(this.Name + " says Hello!!");
        }


        /**
         * <summary>
         * This method outputs the _name and _age value in the following
         * format: _name + " is " + _age + " years old."
         * </summary>
         * 
         * @method ShowAge
         * @return {void}
         */

        public void ShowAge()
        {
            Console.WriteLine(this.Name + " is " + this.Age + " years old.");
        }
    }
}
