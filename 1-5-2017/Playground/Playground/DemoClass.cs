using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class DemoClass
    {
        /*
        //Comments : // and /* Ctrl+K & Ctrl + C (Comment),Ctrl+K & Ctrl + U (Uncomment) 
        //Region #Region regionName  ... #endRegion
        //XML ...
        */

        #region Variables
        int anInt = 1000;
        double aDouble = 999.999;
        string aString = "I am a variable";
        
        #endregion

        #region Properties
        string aProperty;

        public string AProperty
        {
            get
            {
                return aProperty;
            }

            set
            {
                aProperty = value;
            }
        }
        #endregion

        #region Methods

        #region Public Methods
        public string APublicMethod()
        {
            #region Expressions and Statements
            /*
            Expression
            Statements
            Assignment
            Increment and Decrement
            if Statement/if...else...//nested if...else...
            Comparison operators: < > <= >= ++ !=,  && ||
            Switch statement
            Iteration Statement
                foreach
                for
                while and do
                break out of a loop
            */
            int valueReturnedFromAPrivateMethod = this.APrivateMethod();

            /*
             y = x + 1;
             
            {

             }

             if(0>1)
             {
             ...
             }

            do {} while();
            while() {};

             3.14 -- literal value

            */

            int x; //declaration 
            x = 1;//assginment 
            x++;

            return "This is returned by a public class method.";
            #endregion
        }
        #endregion

        #region Private Methods
        private int APrivateMethod()
        {
            return 100;
        }
        #endregion

        #endregion
    }
}
