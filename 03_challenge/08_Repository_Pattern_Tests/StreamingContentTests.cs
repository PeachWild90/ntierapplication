using System;
using _08_Repository_Pattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Repository_Pattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContent_SetTitle_ShouldBeCorrectString()
        {
            //--Arrange
            StreamingContent content = new StreamingContent(); //not defined, so we set it equal to something. Had to initialize it (streamingcontent) with ctrl-. + add a reference
            content.Title = "Jaws";

            //--Act
            var actual = content.Title; //gonna use this all the time var actual = 
            var expected = "Jaws"; //use copy paste as a good habit

            //--Assert
            Assert.AreEqual(expected, actual); //whats expected, and what its actually gonna be

            //now test it!
        }
        [TestMethod]
        public void StreamingContent_SetIsMatureBoolean_ShouldReturnTrue()  //where it's stored + thing + what we get out of it
        {
            //--Arrange
            StreamingContent content = new StreamingContent();
            content.IsMature = true;

            //--Act
            var actual = content.IsMature;
            var expected = true;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StreamingContent_Constructor_ShouldHoldCorrectValues() 
        {
            //--Arrange
            StreamingContent content = new StreamingContent("Star Wars", "Space Adventure", 5, false); //since we are testing constructors, put the properties INSIDE StreamingContent!!!!!!


            //--Act
            var actual = content.Title; //depending on who you talk to, doing multiple asserts 
            var expected = "Star Wars";

            var actualTwo = content.IsMature;
            var expectedTwo = false;

            //--Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expectedTwo, actualTwo);
        }
        [TestMethod]
        public void StreamingContent_Rating_ShouldProvideRating()
        {
            StreamingContent content = new StreamingContent();
            content.Rating = 8;

            var actual = content.Rating;
            var expected = 8;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void StreamingContent_Genre_ShouldHaveGenre()
        {
            StreamingContent content = new StreamingContent();
            content.Genre = "Horror";

            var actual = content.Genre;
            var expected = "Horror";

            Assert.AreEqual(expected, actual);
        }
        //TEST A METHOD
        [TestMethod]
        public void StreamingContentRepository_AddContentToList_ShouldReturnCorrectCount() //WHERE ITS AT + WHAT IT IS + WHATS COMIN OUT. "remember the '.'. ALWAYS GO DOWNSTREAM WHEN TESTING METHODS
        {
            //--Arrange
            StreamingContentRepository contentRepo = new StreamingContentRepository(); //why dont we need the list? because we are using/accessing the list in streamingcontentrepository! 
            var list = contentRepo.GetContentList(); //how does var work? whatever u have opposite of equal sign, becomes var. now its expecting to be a list.  
            StreamingContent content = new StreamingContent(); //so weve now saved the list from teh repository. they are one in the same.
            StreamingContent contentTwo = new StreamingContent();

            //--Act
            contentRepo.AddContentToList(content); //so now we take something of type 'content' and add it to the list. we should expect 1 thing on the list
            list.Add(contentTwo);
            var actual = list.Count; //count is a property of the list, hence the '.' which accesses ALL the properties of the list
            var expected = 2;

            //--Assert
            Assert.AreEqual(expected, actual);
        }
            
    }
}
