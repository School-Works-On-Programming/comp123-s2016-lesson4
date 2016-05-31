using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{

    /**
     * <summary>
     * The teacher is derived from the person class
     * </summary>
     * 
     * @class Teacher 
     * @extends Person 
     * 
     */
    class Teacher:Person
    {
        //PRIVATE INSTANCE VARIABLES +++++++++++++++++++++++++++++++++
        private string _employeeID;

        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++
        public string EmployeeID
        {
            get
            {
                return this._employeeID; 
            }
            set
            {
                this._employeeID = value; 
            }
        }


        // CONSTRUCTORE +++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This construcotr mathod takes three parameters: name, age, and emploueeID
         * </summary>
         * 
         * @constructor Teacher 
         * @param {string} name 
         * @param {int} age
         * @param {string} employeeID
         * 
         */ 
        public Teacher(string name, int age, string employeeID)
            :base(name, age)
        {
            this.EmployeeID = employeeID;
        }

        /**
         * <summary>
         * This method enables the teacher behaviour for the Teacher class 
         * </summary>
         * 
         * @method Teaches
         * @returns {void}
         */
        public void Teaches()
        {
            Console.WriteLine(this.Name + " teaches.");       
        }
    }
}
