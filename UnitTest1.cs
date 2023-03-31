namespace LinkedListLab
{
    public class Tests
    {
        private LinkedList sll;

        [SetUp]
        public void Setup()
        {
            this.sll = new LinkedList();
        }

        [Test]
        public void TestPrePending()
        {
            string name = "Joe Blow";

            sll.AddFirst(name);

            // Assert that it was added or the SLL is bigger
            Assert.IsNotNull(sll.Head);

            Assert.AreEqual(1, sll.Count);

            Assert.AreNotEqual(0, sll.Count);

            // Assert that the first node value is "Joe Blow"
            Node first = sll.Head;

            string value = first.Value;

            Assert.AreEqual(name, value);


            // Assert that there is no next of first node
            Node headNext = sll.Head.Next;

            Assert.IsNull(headNext);
        }
        [Test]
        public void TestApPending()
        {
            string name = "Dave Daverson";
            //sll.AddFirst("Joe Blow");
            sll.AddLast(name);

            // Check the list is bigger
            Assert.AreEqual(1, sll.Count);

            //test the last node value
            Node first = sll.Head;


            Node tempNode = first;

            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }

            Assert.AreEqual(name, tempNode.Value);
        }

        [Test]
        public void TestRemoveFirst()
        {
            sll.AddLast("Joe Blow");
            sll.AddLast("Joe Schmoe");
            sll.AddLast("John Smith");


            Assert.AreEqual(3, sll.Count);

            sll.RemoveFirst();

            // Test number of node is 2
            Assert.AreEqual(2, sll.Count);

            // Test first node is Joe Schmoe
            Node head = sll.Head;
            string headValue = head.Value;
            Node firstNode = head.Next;
            string firstValue = firstNode.Value;
            Assert.AreEqual("Joe Schmoe", firstNode.Value);
        }

        [Test]
        //Check remove node from empty list
        public void TestRemoveLast()
        {
            try
            {
                sll.RemoveLast();
                Assert.Fail();
            }
            catch (CanNotRemoveException)
            {

                Assert.Pass();
            }


            //Check last value is correct
            sll.AddLast("Joe Blow");
            sll.AddLast("Joe Schmoe");
            sll.AddLast("John Smith");
            sll.RemoveLast();

            Node first = sll.Head;


            Node tempNode = first;

            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }
            Assert.AreEqual("Joe Schmoe",tempNode.Value);

        }

        [Test]
        public void TestValueOfIndex()
        {
            sll.AddLast("Joe Blow");
            sll.AddLast("Joe Schmoe");
            sll.AddLast("John Smith");
            sll.AddLast("Jane Doe");
            sll.AddLast("Bob Bobberson");
            sll.AddLast("Dave Daverson");

            Assert.AreEqual("Joe Blow",sll.RetrivingValuleAtIndex(1));

            Assert.AreEqual("Dave Daverson", sll.RetrivingValuleAtIndex(6));

        }
    }
}