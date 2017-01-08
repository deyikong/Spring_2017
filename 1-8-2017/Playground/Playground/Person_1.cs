using System;

namespace Playground
{
    class Person_1
    {

        public string FirstName { get; set; }
        public int Age { get; set; }

        

        public void SetAddress(string city)
        {
            SetAddress(city, "FL");
        }
        //Don't Repeat Yourself: DRY
        public void SetAddress(string city, string state)
        {
            Console.WriteLine("The City is " + city + ", The State is " + state);
        }
    }
}
