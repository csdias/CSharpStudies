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
        public void Reverse()
        {
            //Assert.Pass();

            LinkedList linkedList = new LinkedList();
            for(int j = 1; j < 4; j++){
                linkedList.Add(j);
            }

            linkedList.Reverse();

            Node current = linkedList.Head;

            Console.WriteLine(current.Value);

            while(current.Next != null){
                Assert.AreEqual(3, current.Value);
                current = current.Next;
            }
        }


        private void ThrowNullReferenceException_prep(){
         
        }

        [Test]
        public void ThrowNullReferenceException()
        {
            var ex = Assert.Throws<NullReferenceException>(() => { ThrowNullReferenceException_prep(); });
            Assert.That(ex.Message, Is.EqualTo("Null reference Exception."));
        }        

    }
}