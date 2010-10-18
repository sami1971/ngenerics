/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.Tests.Util;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.MinPriorityQueueHeapTests
{
    [TestFixture]
    public class Serialization : MinPriorityQueueTest
    {
        [Test]
        public void Simple()
        {
            var priorityQueue = GetTestPriorityQueue();
            var newQ = SerializeUtil.BinarySerializeDeserialize(priorityQueue);

            Assert.AreNotSame(priorityQueue, newQ);
            Assert.AreEqual(priorityQueue.Count, newQ.Count);

            while (priorityQueue.Count > 0)
            {
                Assert.AreEqual(priorityQueue.Dequeue(), newQ.Dequeue());
            }
        }
    }
}