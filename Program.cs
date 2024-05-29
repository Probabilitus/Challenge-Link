using System.Linq;

namespace Challenge_Link
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<Animal> animals = new List<Animal>()
            {
               new Animal(1, "animal1", "Les cougars blancs"),
               new Animal(2, "animal2", "Les cougars blancs"),
               new Animal(3, "animal3", "Les cougars blancs"),
               new Animal(4, "animal4", "Les tigres blancs"),
               new Animal(5, "animal5", "Les tigres blancs"),
               new Animal(6, "animal6", "Les tigres blancs"),
               new Animal(7, "animal7", "Les tigres blancs"),
               new Animal(8, "animal8", "Les tortues albinos"),
               new Animal(9, "animal9", "Les tortues albinos"),
               new Animal(10, "animal10", "Les tortues albinos"),
               new Animal(11, "animal11", "Les tortues albinos"),

            };
            var res1 = animals.Where(a => a.Specie.Contains("Les cougars blancs"));
            Console.WriteLine("Les cougars blancs");
            foreach (var animal in res1)
            {
                Console.WriteLine(animal.Name);
            }
            var res2 = animals.Where(a => a.Specie.Contains("Les tigres blancs"));
            Console.WriteLine("Les tigres blancs");
            foreach (var animal in res2)
            {
                Console.WriteLine(animal.Name);
            }
            var res3 = animals.Where(a => a.Specie.Contains("Les tortues albinos"));
            Console.WriteLine("Les tortues albinos");
            foreach (var animal in res3)
            {
                Console.WriteLine(animal.Name);
            }


        }
    }
    
}
