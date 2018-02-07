using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace NameSort.Test
{
    /// <summary>
    ///Naming convention => MethodName_StateUnderTest_ExpectedBehavior
    /// </summary>
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void ToString_MatchesFullNameOneGiven_True()
        {
            List<string> given = new List<string>();
            given.Add("John");
            Person testSubject = new Person("Doe",given);
            string expected = "John Doe";

            string actual = testSubject.ToString();

            Assert.AreEqual(actual, expected);

        }//end ToString_MatchesFullNameOneGiven_True

        [TestMethod]
        public void ToString_MatchesFullNameThreeGiven_True()
        {
            List<string> given = new List<string>();
            given.Add("John");
            given.Add("Bruce");
            given.Add("Wayne");
            Person testSubject = new Person("Doe", given);
            string expected = "John Bruce Wayne Doe";

            string actual = testSubject.ToString();

            Assert.AreEqual(actual, expected);

        }//end ToString_MatchesFullNameThreeGiven_True

        [TestMethod]
        public void CompareTo_SortBySurname_ReturnPos()
        {
            List<string> given = new List<string>();
            given.Add("John");
            Person testSubject1 = new Person("Doe", given);
            Person testSubject2 = new Person("A", given);

            int actual = testSubject1.CompareTo(testSubject2);

            Assert.IsTrue(actual > 0);
        }//end CompareTo_SortBySurname_ReturnPos

        [TestMethod]
        public void CompareTo_SortBySurname_ReturnNeg()
        {
            List<string> given = new List<string>();
            given.Add("John");
            Person testSubject1 = new Person("Doe", given);
            Person testSubject2 = new Person("A", given);

            int actual = testSubject2.CompareTo(testSubject1);

            Assert.IsTrue(actual < 0);
        }//end CompareTo_SortBySurname_ReturnNeg

        [TestMethod]
        public void CompareTo_SortByGiven_ReturnPos()
        {
            List<string> given1 = new List<string>();
            given1.Add("John");
            Person testSubject2 = new Person("Doe", given1);
            List<string> given2 = new List<string>();
            given2.Add("Zane");
            Person testSubject1 = new Person("Doe", given2);

            int actual = testSubject1.CompareTo(testSubject2);

            Assert.IsTrue(actual > 0);
        }//end CompareTo_SortByGiven_ReturnPos

        [TestMethod]
        public void CompareTo_SortByGiven_ReturnNeg()
        {
            List<string> given1 = new List<string>();
            given1.Add("Zane");
            Person testSubject2 = new Person("Doe", given1);
            List<string> given2 = new List<string>();
            given2.Add("John");
            Person testSubject1 = new Person("Doe", given2);

            int actual = testSubject1.CompareTo(testSubject2);

            Assert.IsTrue(actual < 0);
        }//end CompareTo_SortByGiven_ReturnNeg



    }//end class PersonTests
}
