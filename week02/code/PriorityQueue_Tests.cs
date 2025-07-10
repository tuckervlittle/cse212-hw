using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and priority: Bob (2), Tim (5), Sue (3)
    // Run until the queue is empty
    // Expected Result: Tim, Sue, Bob
    // Defect(s) Found: 
    //  - Not removing people from queue
    //  - Starting at queue count (-1) so when queue was down to two people it wouldn't see the second
    public void TestPriorityQueue_Standard()
    {
        string[] expectedResult = ["Tim", "Sue", "Bob"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 3);

        Console.WriteLine(priorityQueue);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have run out of items by now");
            }
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
            i++;
        }
    }

    [TestMethod]
    // Scenario:  Create a queue with the following people and priority: Sue (3), Bob (2), Tim (5), Taylor (3)
    // Run until the queue is empty
    // Expected Result: Tim, Sue, Taylor, Bob
    // Defect(s) Found: Taylor was being dequeued first because the function was checking if the priority was
    //    >= to the others
    public void TestPriorityQueue_MultiplePriority()
    {
        string[] expectedResult = ["Tim", "Sue", "Taylor", "Bob"];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Sue", 3);
        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Taylor", 3);

        int i = 0;
        while (priorityQueue.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have run out of items by now");
            }
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
            i++;
        }
    }


    [TestMethod]
    // Scenario: Try to get the next item from an empty queue
    // Expected Result: Exception should be thrown with appropriate error message.
    // Defect(s) Found: None
    public void TestPriorityQueue_Empty()
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
    // Add more test cases as needed below.
}