using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Page34Exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            void printObjectValuesAndProperties(object userSelectedObject)
            {
                Type objectType = userSelectedObject.GetType();

                Console.WriteLine("You have chosen to instantiate the " + objectType.Name + " class.");


                IList<PropertyInfo> props = new List<PropertyInfo>(objectType.GetProperties());

                foreach (PropertyInfo prop in props)
                {
                    object propValue = prop.GetValue(userSelectedObject, null);
                    Console.WriteLine("The " + prop.Name + " property has a value of " + propValue.ToString());
                }
            }


            Console.WriteLine("Which class do you want to instantiate? Tornado Report(1), SnowStorm Report(2), or Hurricane Report(3)?");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    TornadoReport tornadoReport = new TornadoReport();
                    tornadoReport.maxWindSpeed = "100mph";
                    tornadoReport.damageCost = "50000 dollars";
                    printObjectValuesAndProperties(tornadoReport);
                    break;
                case "2":
                    SnowstormReport snowStormReport = new SnowstormReport();
                    snowStormReport.inchesOfSnow = 7;
                    snowStormReport.numberOfAccidents = 12;
                    printObjectValuesAndProperties(snowStormReport);
                    break;
                case "3":
                    HurricaneReport hurricaneReport = new HurricaneReport();
                    hurricaneReport.wasMajorHurricane = false;
                    hurricaneReport.heightOfWaves = "12 feet";
                    printObjectValuesAndProperties(hurricaneReport);
                    break;
                default:
                    Console.WriteLine("You chose an option that is not available");
                    break;
            }


            Console.ReadLine();
        }
    }
}
