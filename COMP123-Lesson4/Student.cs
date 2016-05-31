using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_Lesson4
{
    /**
     * <summary>
     * This is student class. it is derived from Person class. 
     * </summary>
     * 
     * @class Student
     * @extends Person
     * 
     */
    
    class Student : Person
    {
        // PRIVATE INSTANCE VARIABLE HERE +++++++++++++++++++++++++++++++
        private string _studentID;

        // PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++++++

            /**
             * <summary>
             * 
             * </summary>
             * 
             * 
             * 
             */


        public string StudentID {
            get
            {
                return this._studentID; 
            }
            set
            {
                this._studentID = value; 
            }
        }

        /**
         * <summary>
         * This constructor take three parameters name, age, and studentID
         * </summary>
         * 
         * @constructor Student
         * @extends Person
         * @param {string} name
         * @param {int} age
         * @param {string} studentID
         */
        public Student(string name, int age, string studentID)
            :base(name, age)
        {
            this.StudentID = studentID; 
        }

        // PUBLIC METHOD +++++++++++++++++++++++++++++++++++++++++++++++++++

            /**
             * <summary>
             * This method enables the studies behaviour for the student
             * </summary>
             * 
             * @method Studies
             * Wreturns {void}
             * 
             */
        public void studies()
        {
            Console.WriteLine(this.Name + " studies."); 
        }
    }
}
