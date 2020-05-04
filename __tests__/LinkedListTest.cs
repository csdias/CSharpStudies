using NUnit.Framework;
using System;
using Collections;

namespace __tests__
{
    public class LinkedListTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ReverseIteratively()
        {
            //Assert.Pass();

            LinkedList linkedList = new LinkedList();
            for(int j = 1; j < 4; j++){
                linkedList.Add(j);
            }

            linkedList.ReverseIteratively();

            Node current = linkedList.Head;

            Assert.AreEqual(3, current.Value);
        }

        [Test]
        public void ReverseReursively()
        {
            //Assert.Pass();

            LinkedList linkedList = new LinkedList();
            for(int j = 1; j < 4; j++){
                linkedList.Add(j);
            }

            linkedList.ReverseRecursively();

            Node current = linkedList.Head;

            Assert.AreEqual(3, current.Value);
        }

        private void ThrowNullReferenceException_prep(){

            LinkedList linkedList = new LinkedList();
            for(int j = 1; j < 4; j++){
                linkedList.Add(j);
            }

            linkedList.ReverseIteratively();

            Node current = linkedList.Head;

            while(current != null){
                current = current.Next;
            }

            current = current.Next;

            Assert.AreEqual(3, current.Next);
         
        }

        [Test]
        public void ThrowNullReferenceException()
        {
            var ex = Assert.Throws<NullReferenceException>(() => { ThrowNullReferenceException_prep(); });
            Assert.That(ex.Message, Is.EqualTo("Object reference not set to an instance of an object."));
        }        

    }
}