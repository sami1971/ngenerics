/*  
 Copyright 2009 The NGenerics Team
 (http://www.codeplex.com/NGenerics/Wiki/View.aspx?title=Team)

 This program is licensed under the Microsoft Permissive License (Ms-PL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.codeplex.com/NGenerics/Project/License.aspx.
*/


using System.Collections.Generic;
using NGenerics.Sorting;
using NUnit.Framework;

namespace ExampleLibraryCSharp.Sorting
{
    [TestFixture]
    public class RadixSorterExamples
    {
        #region Sort
        [Test]
        public void SortExample()
        {
            var sorter = new RadixSorter();

            var list = new List<int> {13, 5, 77, 9, 12};

            sorter.Sort(list);

            Assert.AreEqual(5, list[0]);
            Assert.AreEqual(9, list[1]);
            Assert.AreEqual(12, list[2]);
            Assert.AreEqual(13, list[3]);
            Assert.AreEqual(77, list[4]);
        }
        #endregion
    }
}