using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge1
{
    [TestClass]
    public class Challenge1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string mylastname = "Mallem Louda";
            string myfirstname = "Amel";
            int myage = 27;
            Console.WriteLine(mylastname+"\n "+myfirstname+" \n"+myage);
        }
        [TestMethod]
        public void MyTestMethod2()

        {
            string[] favoritemovies = { "Holidate", "jurassic park", "jumaji", "El camino" } ;
            foreach(string i in favoritemovies)
            Console.WriteLine(i);
        }
        [TestMethod]
        public void MyTestMethod3()
        {
            List<DateTime> date= new List<DateTime>();
            DateTime adate = new DateTime(2005, 10, 12);
            DateTime justDate = new DateTime(2002, 10, 18);
            DateTime today = DateTime.Now;
            date.Add(today);
            date.Add(adate);
            date.Add(justDate);
            foreach(DateTime dateTime in date)
                Console.WriteLine(dateTime);
        }
       
        [TestMethod]
        public void MyTestMethod4()
        {
            int myAge = 27;
            int numTwo = 7;
            int sum = myAge + numTwo;
            Console.WriteLine(sum);
        }
        [TestMethod]
        public void MyTestMethod5()
        {
            int hoursOfSleep= 8;

            if (hoursOfSleep >= 10)

            {
                Console.WriteLine("Wow that's a lot of sleep");
            }

            else if (hoursOfSleep > 8 && hoursOfSleep < 10)
            {
                Console.WriteLine("You should be pretty rested");
            }
            else if (hoursOfSleep > 4 && hoursOfSleep < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man,get some seep"  );
            }
          
        }
        [TestMethod]
        public void MyTestMethod6()
        {
            string daymood = "Great";

            switch(daymood)
            {
                case "Great":
                    Console.WriteLine("GREAT");
                    break;
                case "GOOD":
                    Console.WriteLine("Good");
                    break;
                case "Okay":
                    Console.WriteLine("Okay");
                    break;
                case "Bad":
                    Console.WriteLine("Bad");
                    break;

            }

                


                
        }
    }

}
