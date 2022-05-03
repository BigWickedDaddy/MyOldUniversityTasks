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
        private string k;
        private string variable;

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
                        Console.WriteLine("Названия вагонов через enter");
                        k = Console.ReadLine();
                        string[] arr = new string[Convert.ToInt32(k)];
                        for(int i=0; i < arr.Length; i++)
                        {
                            arr[i] = Console.ReadLine();
                        }
                        variable = Console.ReadLine();
                        number =arr[Convert.ToInt32(variable)]  + "\n Кол-во ваших вагонов : " + k;
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
