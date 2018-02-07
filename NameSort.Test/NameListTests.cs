using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NameSort.Test
{
    /// <summary>
    ///Naming convention => MethodName_StateUnderTest_ExpectedBehavior
    ///
    ///Arrange
    ///Act
    ///Assert
    /// </summary>
    [TestClass]
    public class NameListTests
    {

        [TestMethod]
        public void AddPersonToList_PersonAdded_True()
        {
            //too trivial to test

        }//end AddPersonToList_PersonAdded_True

        [TestMethod]
        public void ReadTxtFileToList_TxtLineReadCorrectly_True()
        {
            NameList.ReadTxtFileToList("./unsorted-names-list-test.txt");
            string expected = "Janet Parsons";

            string actual = NameList.GetPersonFromListByIndex(0).ToString();

            Assert.AreEqual(actual, expected);
        }//end ReadTxtFileToList_TxtLineRead_True

    }//end class NameListTests
}
