using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {

            List<Car> list = GetFromFile();
      
            while(true)
            {
                Console.WriteLine("1. Skapa ny bil");
                Console.WriteLine("2. ta bort bil");
                Console.WriteLine("3. Avsluta programmet");
                string val = Console.ReadLine();

                switch (val)
                {
                    case "1":
                        {
                            Car car = AddCar();
                            list.Add(car);
                            break;
                        }

                    case "2":
                        {
                            int i = 0;
                            foreach(Car car in list)
                            {
                                Console.WriteLine($"{car} Id: {i}");
                                i++;
                            }
                            Console.WriteLine("Ange id för vilken bil du vill ta bort");
                            int id = int.Parse(Console.ReadLine());
                            list.RemoveAt(id);
    
                            break;
                        }

                    case "3":
                        {
                            SaveAllCars(list);
                            break;
                        }
                }
            }
        }
        public List<Car> GetFromFile()
        {
            string fileContent = File.ReadAllText("carsinjson.txt");
            List<Car> list = JsonConvert.DeserializeObject<List<Car>>(fileContent);
            return list;
        }
        public void SaveAllCars(List<Car> cars)
        {
            string data = JsonConvert.SerializeObject(cars);
            File.WriteAllText("carsinjson.txt", data);
        }
        public Car AddCar()
        {             
            Console.WriteLine("Ange märke");
            string name = Console.ReadLine();
            Console.WriteLine("Ange model");
            string model = Console.ReadLine();
            Console.WriteLine("Ange årsmodell");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange pris");
            int price = int.Parse(Console.ReadLine()); 

            var car = new Car() { Name = name, Model = model, Year = year, Price = price};

            return car;
        }
    }
    public class Car
    {
        public string Name { get; set; }    
        public string Model { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return "Name: " + Name + "  Model:  " + Model + "   Year: " + Year + "   Price " + Price ;
        }

    }
}
