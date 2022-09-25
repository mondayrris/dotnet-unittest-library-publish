// The template source code created by the unit test template does the following:
// It imports the Microsoft.VisualStudio.TestTools.UnitTesting namespace, which contains the types used for unit testing.
// It applies the TestClassAttribute attribute to the UnitTest1 class.
// It applies the TestMethodAttribute attribute to TestMethod1.
// Each method tagged with[TestMethod] in a test class tagged with[TestClass] is executed automatically when the unit test is run.

//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;

//namespace StringLibraryTest;
//[TestClass]
//public class UnitTest1
//{
//    [TestMethod]
//    public void TestMethod1()
//    {
//    }
//}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;

// The test of uppercase characters in the TestStartsWithUpper method includes the Greek capital letter alpha (U+0391) and the Cyrillic capital letter EM (U+041C).
// The test of lowercase characters in the TestDoesNotStartWithUpper method includes the Greek small letter alpha (U+03B1) and the Cyrillic small letter Ghe (U+0433).

// **On the menu bar, select File > Save As. In the dialog, make sure that Encoding is set to Unicode (UTF-8)
// If you fail to save your source code as a UTF8-encoded file, Visual Studio may save it as an ASCII file.
// When that happens, the runtime doesn't accurately decode the UTF8 characters outside of the ASCII range, and the test results won't be correct.
namespace StringLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStartsWithUpper()
        {
            // Tests that we expect to return true.
            string[] words = { "Alphabet", "Zebra", "ABC", "Αθήνα", "Москва" };
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsTrue(result,
                       string.Format("Expected for '{0}': true; Actual: {1}",
                                     word, result));
            }
        }

        [TestMethod]
        public void TestDoesNotStartWithUpper()
        {
            // Tests that we expect to return false.
            string[] words = { "alphabet", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
                                "1234", ".", ";", " " };

            // Reverse comment for demonstration of TDD.
            //string[] words = { "alphabet", "Error", "zebra", "abc", "αυτοκινητοβιομηχανία", "государство",
            //       "1234", ".", ";", " " };
         
            foreach (var word in words)
            {
                bool result = word.StartsWithUpper();
                Assert.IsFalse(result,
                       string.Format("Expected for '{0}': false; Actual: {1}",
                                     word, result));
            }
        }

        [TestMethod]
        public void DirectCallWithNullOrEmpty()
        {
            // Tests that we expect to return false.
            string?[] words = { string.Empty, null };
            foreach (var word in words)
            {
                bool result = StringLibrary.StartsWithUpper(word ?? string.Empty);
                Assert.IsFalse(result,
                       string.Format("Expected for '{0}': false; Actual: {1}",
                                     word == null ? "<null>" : word, result));
            }
        }
    }
}