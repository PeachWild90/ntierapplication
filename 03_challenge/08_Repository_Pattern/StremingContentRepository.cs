using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Repository_Pattern //CONSOLE COMMANDS STAY OUT OF REPOSITORY ONLY IN UI *************************
{
    public class StreamingContentRepository //this is where we will take our methods and hide them away, make them public plz. 
    {
        //our goal is have our list in our repository, not main
        //if we are going to keep track of all of our streaming content make a list

        List<StreamingContent> _listOfContent = new List<StreamingContent>(); //field = high level variable with an underscore
      
        public void AddContentToList(StreamingContent content)
        {
            _listOfContent.Add(content); //pass in parameter of content
        }

        public List<StreamingContent> GetContentList() //do we have to pass anything into it? NAH DUDE!
        {
            return _listOfContent; //this is the doorway that allows the UI to package/retrieve the list
        }
     
    }
}
