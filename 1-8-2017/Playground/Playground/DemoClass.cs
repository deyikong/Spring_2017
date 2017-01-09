using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    class MoonCake
    {
        private string _ingre = "";

        public MoonCake(string ingre)
        {
            _ingre = ingre;
        }

        public MoonCake()
        {
            _ingre = "wheat";
            isSweet = true;
        }
      


        /*
        //Comments : // and /* Ctrl+K & Ctrl + C (Comment),Ctrl+K & Ctrl + U (Uncomment) 
        //Region #region regionName  ... #endRegion
        //XML ...
        */

        #region Variables
        int anInt = 1000;
        double aDouble = 999.00;
        string aString = "I am a variable";

        #endregion

        #region Properties
        //Public property for private variables

        //public int Age //Validation, Encapsulation, 
        //{
        //    get
        //    {
        //        return age;
        //    }

        //    set
        //    {
        //        if (value <= 0)
        //            age = 0;
        //        else
        //            age = value;
        //    }
        //}

        private int age;



        //plain property
        public double DistanceInMile
        {
            get;
            set;
        }

        //computed property

        public double DistanceInKM
        {
            get
            {
                return 1.6 * DistanceInMile;
            }

            set
            {
                DistanceInMile = value / 1.6;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }


        #endregion

        #region Methods

        /*
         string
         double 
         int
         float
         char
         bool //boolean
         DateTime
         Array - Generic Type
         */
        private bool isSweet;

        #region Public Methods
        public void SetLayers(int layer)
        {
            switch(layer)
            {
                case 3:
                    MakeThreeLayerMoonCake();
                    break;
                case 6:
                    MakeSixLayerMoonCake();
                    break;
            }
        }

        private void MakeThreeLayerMoonCake()
        {
            //...
        }

        private void MakeSixLayerMoonCake()
        {
            //...
        }

        private int Get3Time4Time5()
        {
            
            int x = Get3Times4();
            if(x>0)
            {
                //return 1;
            }
            else
            {
                //return 2;
            }
            return x * 5;
        }



        private int Get3Times4()
        {
            return 3 * 4;
        }

        private string GetTiltleThroughGender(char gender)
        {
            string returnTitle = "";
            switch (gender)
            {
                case 'm':
                case 'M':
                    returnTitle = "Mr.";
                    break;
                case 'F':
                    returnTitle = "Mrs.";
                    break;
            }
            Console.WriteLine("end");
            return returnTitle;
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
