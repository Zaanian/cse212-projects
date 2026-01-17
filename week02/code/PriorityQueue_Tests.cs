using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: create a queue with the following persons and priority: bob 3, katy 1, tim 5, mike 4, and tom 5. 
    //Then find the highest priority from the queue.
    // Expected Result: tim
    // Defect(s) Found: dequeue did not remove the item after finding it.
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("bob", 3);
        var katy = new PriorityItem("katy", 1);
        var mike = new PriorityItem("mike", 4);
        var tim = new PriorityItem("tim", 5);
        var tom = new PriorityItem("tom", 5);

        string expected = "tim";


        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(katy.Value, katy.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(mike.Value, mike.Priority);
        priorityQueue.Enqueue(tom.Value, tom.Priority);

        Console.WriteLine(priorityQueue);

        var high = priorityQueue.Dequeue();

        Assert.AreEqual(expected, high);

    }

    [TestMethod]
    // Scenario: empty queue
    // Expected Result: empty queue should throw an error exception.
    // Defect(s) Found: dequeue did not remove the item after finding it.
    public void TestPriorityQueue_2()
    {
        var mike = new PriorityItem("mike", 4);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(mike.Value, mike.Priority);
        priorityQueue.Dequeue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }

    }

    // Add more test cases as needed below.
}