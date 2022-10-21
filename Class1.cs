using Newtonsoft.Json;

namespace Övningar
{
    internal class Class1
    {
        public void Go()
        {
            List<Dog> list = GetFromFile();

            while(true)
            {
                Console.WriteLine("1. Registrera hund, 2. Läs ut hundar baserat på svansLängd, 3. Ta bort hund, 4. Avlsuta programmet");
                switch(Console.ReadLine())
                    {

                    case "1":
                        Dog dog = CreateDog();
                        list.Add(dog);
                        break;
                    
                    case "2":
                        Console.WriteLine("Enter minimum tale length");
                        int length = Convert.ToInt32(Console.ReadLine());
                        foreach(Dog d in list)
                        {
                            if(d.TaleLength >= (double)length)
                            {
                                Console.WriteLine(d);
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Enter name of dog that will be deleted");
                        string name = Console.ReadLine();
                        bool deleted = false;
                        foreach(Dog d in list.ToList())
                        {
                            if (d.Name == name)
                            {
                                list.Remove(d);
                                deleted = true;
                            }
                        }
                        if (!deleted)
                            Console.WriteLine($"A dog with the name {name} could not be found in the list");

                        break;

                    case "4":
                        SaveAllDogs(list);
                        break;

                }
            }
        }
        public void SaveAllDogs(List<Dog> list)
        {
            string content = JsonConvert.SerializeObject(list);
            File.WriteAllText("TextFile1.json", content);
        }
        public List<Dog> GetFromFile()
        {
            var list = new List<Dog>();
            string content = File.ReadAllText("TextFile1.json");
            list = JsonConvert.DeserializeObject<List<Dog>>(content);
            return list;
        }
        public Dog CreateDog()
        {
            Console.WriteLine("Enter DogName");
            string name = Console.ReadLine();
            Console.WriteLine("Enter DogRace");
            string race = Console.ReadLine();
            Console.WriteLine("Enter DogAge");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter DogWeight");
            int weight = Convert.ToInt32(Console.ReadLine());
            Dog dog = new Dog(name, race, age, weight);
            return dog;
        }
    }
    public class Dog
    {
        private string _name;
        private string _race;
        private int _age;
        private int _weight;
        private double _taleLength;

        public Dog(string name, string race, int age, int weight)
        {
            _name = name;
            _race = race;
            _age = age;
            _weight = weight;
            if (race != "tax")
                _taleLength = (age * weight) / 10;
            else _taleLength = 3.7;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public double TaleLength { get { return _taleLength; } set { _taleLength = value; } } 
        public string Race { get  { return _race; } set { _race = value; } }
        public int Weight { get { return _weight; } set { _weight = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public override string ToString()
        {
            return $"Namn: {_name}, Ras: {_race}, Ålder: {_age}, Vikt: {_weight}, SvansLängd: {_taleLength}";
        }

    }
   
}
