using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Generics.Model;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { brand = "Fiat", model = "Uno" };
            House house = new House() { city = "Brasilia", address = "QSQ 400"};
            User user = new User() { name = "Maria", email = "maria@gmail.com", password = "123456" };

            Serializer.Serialize(car);
            Serializer.Serialize(house);
            Serializer.Serialize(user);

            Car car2 = Serializer.Deserialize<Car>();
            House house2 = Serializer.Deserialize<House>();
            User user2 = Serializer.Deserialize<User>();

            Console.WriteLine("Car 2: " + car2.brand + " - " +car2.model);
            Console.WriteLine("House 2: " + house2.city + " - " + house2.address);
            Console.WriteLine("User 2: " + user2.name + " - " + user2.email);

            Console.ReadKey();
        }
    }
}
