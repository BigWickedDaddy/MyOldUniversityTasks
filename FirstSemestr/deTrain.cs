using System;

namespace Train
{
    class Train
    {
        private string number;
        private string endStation;
        private string arrivaltime;
        private string departuretime;
        private int way1;
        private string way;

        public string this[string propname]
        {
            get
            {
                switch (propname)
                {
                    case "number": return number;
                    case "endStation": return endStation;
                    case "arrivaltime": return arrivaltime;
                    case "departuretime": return departuretime;
                    case "way" : return way;
                    default: return null;
                }

            }
            set
            {
                switch (propname)
                {
                    case "number":
                        Console.WriteLine("Введите через пробел названия ваших вагонов");
                        number = Console.ReadLine();
                        number = number + "\n Кол-во ваших вагонов : " + value;
                        break;
                    case "endStation":
                        endStation = value;
                        break;
                    case "arrivaltime":
                        arrivaltime = value;
                        break;
                    case "departureltime":
                        departuretime = value;
                        break;
                    case "way":
                        Console.WriteLine("Введите время прибытия одной цифрой еще раз :");
                        arrivaltime = Console.ReadLine();
                        Console.WriteLine("Введите время выезда одной цифрой еще раз :");
                        departuretime = Console.ReadLine();
                        way1 = Convert.ToInt32(arrivaltime)-Convert.ToInt32(departuretime);
                        way = "" + way1;
                        break;
                }

                

            }
        }

        
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Train tom = new Train();
            Console.WriteLine("Введите название вагона:");
            tom["number"] = Console.ReadLine();
            Console.WriteLine("Введите конечную станцию");
            tom["endStation"] = Console.ReadLine();
            Console.WriteLine("Введите время прибытия одной цифрой");
            tom["arrivaltime"] = Console.ReadLine();
            Console.WriteLine("Введите время выезда одной цифрой");
            tom["departuretime"] = Console.ReadLine();
            Console.WriteLine("");
            tom["way"] = "15";
            Console.WriteLine("");
            Console.WriteLine(tom["way"]);

            Console.ReadKey();
        }
    }
}
