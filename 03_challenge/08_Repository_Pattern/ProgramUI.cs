using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Repository_Pattern  //UI IS THE INTERMEDIARY BETWEEN USER AND REPOSITORY. 
{
    public class ProgramUI //WE WANT AN INSTANCE OF THE REPOSITORY, BC WE WANNA USE IT A LOT
    {
        StreamingContentRepository _contentRepo = new StreamingContentRepository(); //note the field

        public void Run() //Run method that calls a Run Menu Method
        {
            RunMenu(); //use "ctrl - ." :D
        }

        private void RunMenu() //use while loops for menus, dont forget booleans 
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Create an action:" +
                    "\n1. Create new show" +
                    "\n2. See current list" +
                    "\n3. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input) //USE TAB-TAB FOR DANKNESS. Then give it an input, in this case Int
                {
                    case 1:     //create new show and add it to list **ITS GONNA BE A METHOD** Private 
                        CreateShow();
                        break;
                    case 2:     //show current list
                        PrintContentList();
                        break;
                    case 3:     //exit **start on exit first**
                        isRunning = false;
                        Console.WriteLine("Seeya");
                        break;
                    default:
                        Console.WriteLine("ya done screwed up");
                        break;
                }
            }
        }

        private void CreateShow() //with this we need to create streamingcontent and add it to a list
        {
            StreamingContent newContent = new StreamingContent(); //initialized blank slate, so now we give it values
            Console.WriteLine("What is the title?");
            newContent.Title = Console.ReadLine();

            Console.WriteLine("\nWhat is the genre?");
            newContent.Genre = Console.ReadLine();

            Console.WriteLine("\nHow would you rate this? 1-5");
            newContent.Rating = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIs this R Rated?"); //we need a bool here, bro
            string response = Console.ReadLine().ToLower(); //no matter what we type all of it will come back lower case ;)
            if (response == "y")
            {
                newContent.IsMature = true;
            }
            else
            {
                newContent.IsMature = false;
            }
            _contentRepo.AddContentToList(newContent); //passing DOWN to repository, we dont have direct contact to list, but have a method that lets us access the repository
        }

        //we want a method that shows the current list. PRIVATE bc we are not gonna use it outside this file! its NOT gonna return (void)
        private void PrintContentList()
        {
            List<StreamingContent> contentList = _contentRepo.GetContentList(); //get this list from this method, SAVE IT, then use it later. GetContentList is from our REPOSITORY
            foreach (StreamingContent content in contentList) //for each whatever item inside the thing we do this. We are IMMEDIATELY plugging it into to foreach
            {
                Console.WriteLine(content.Title);
                Console.WriteLine(content.Genre);//its passing through streaming content types, and foreach item, we are doing the same chunk of code for each thing, instead of saying "grab the first one and do something, the second etc" instead "run a for each loop, bro"
            }
        }
    }
}

