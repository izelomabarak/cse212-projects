using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Check the correct operation of the function Enqueue and Dequeue, by whating the following result: Sue, Tim, Bob and run until the queue is empty
    // Expected Result: Sue, Tim, Bob
    // Defect(s) Found: This function have the defect that always like fist element return Tim, I review the doe and I se that the probelm wasin the for and if metods, 
    // the for metod was bad logic and becase of that always ingonre the las elemnt of the queue and the if metod have a small troble in the comparation, I fix that 
    // isues and the test work whtow isues  
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 1);
        var tim = new PriorityItem("Tim", 2);
        var sue = new PriorityItem("Sue", 3);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        PriorityItem[] expectedResult = [sue, tim, bob];

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Check the correct operation of the function Dequeue after adding a new item inmidel fo the realization of the function 
    // result: Sue, Joe, Tim, Bob and run until the queue is empty
    // Expected Result: Sue, Joe, Tim, Bob
    // Defect(s) Found: This function have the defect of the TestPriorityQueue_1, dont read the las item of the queue and the comparetion  in if, ater 
    // fix that trobles in the previus test, this test also works.  
    // isues and the test work whtow isues 
    public void TestPriorityQueue_2()
    {
        var bob = new PriorityItem("Bob", 1);
        var tim = new PriorityItem("Tim", 2);
        var sue = new PriorityItem("Sue", 3);
        var joe = new PriorityItem("Joe", 3);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        PriorityItem[] expectedResult = [sue, joe, tim, bob];

        int i = 0;
        for (; i < 1; i++)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
        }

        priorityQueue.Enqueue(joe.Value, joe.Priority);

        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Check the correct operation of the function Dequeue wen ther more items whit the same priority value, by whating the following 
    // result: Sue, Lia, Tim, Ana, Bob, Joe and run until the queue is empty
    // Expected Result: Sue, Lia, Tim, Ana, Bob, Joe
    // Defect(s) Found: This function have same trobles of the two previsu test, and lso work after fix the firs one, in general the Enqueue functtion has 
    // only trobles in the for and if, afther fix that two, the rest of the test works.
    public void TestPriorityQueue_3()
    {
        var bob = new PriorityItem("Bob", 1);
        var tim = new PriorityItem("Tim", 2);
        var sue = new PriorityItem("Sue", 3);
        var joe = new PriorityItem("Joe", 1);
        var ana = new PriorityItem("Ana", 2);
        var lia = new PriorityItem("Lia", 3);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);
        priorityQueue.Enqueue(joe.Value, joe.Priority);
        priorityQueue.Enqueue(ana.Value, ana.Priority);
        priorityQueue.Enqueue(lia.Value, lia.Priority);

        PriorityItem[] expectedResult = [sue, lia, tim, ana, bob, joe];

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, item);
            i++;
        }
    }

    [TestMethod]
    // Scenario: Try to get the next person from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: Since the fist time works, the logic for detect this error was working rigt.
    public void TestPriorityQueue_4()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }
}