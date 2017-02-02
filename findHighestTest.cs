using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using findTheHighest;
namespace findHighestTest
{
    [TestClass]
    public class findHighestTest
    {
        [TestMethod]
        public void Test_findHighest()
        {  //Arrange
            int expected = 10;
            int [] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
           int actual =  HighestClass.findHighest(nums);
           Assert.AreEqual(expected, actual);
           
            
        }
    }
}
