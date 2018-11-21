using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Collections_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Wylie";
            List<string> listOfStrings = new List<string>();

            List<Pet> listOfPets = new List<Pet>();  /*it's a new list, theres nothing in it*/
            Pet firstPet = new Pet("Neko", 4, "Feral", true);
            Pet secondPet = new Pet("Miesh", 4, "Feral", true);
            Pet thirdPet = new Pet("Sancho", 4, "Lab", false);
          //type

            listOfPets.Add(firstPet); //0 We want to pass any one of our pets into the list
            listOfPets.Add(secondPet);//1
            listOfPets.Add(thirdPet);//2
            listOfPets.Add(firstPet);//3
            listOfPets.Add(secondPet);//4

            //listOfPets.RemoveAt(4);
            //listOfPets.Remove(firstPet);

            //a loop that is super useful for collections are 'foreach'(for each item of this type do this code) loops
            //
                  //(Type name     in CollectionOfType)
            foreach (Pet pet in listOfPets)
            {
                Console.WriteLine(pet.Name); //for each pet in my list of pets, write out the pet name
            }
            

            Console.ReadLine();
        }
    }
}
