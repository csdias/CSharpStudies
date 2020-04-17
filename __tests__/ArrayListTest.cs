using NUnit.Framework;
using System;
using Collections;

namespace __tests__
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ExpandedToFour()
        {
            //Assert.Pass();

            ArrayList<int> list = new ArrayList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);

            Assert.AreEqual(4, list.Length);
        }

        [Test]
        public void ExpandedToEight()
        {
            //Assert.Pass();

            ArrayList<int> list = new ArrayList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);

            Assert.AreEqual(8, list.Length);
        }

        [Test]
        public void ExpandedToEightAfterInsertion()
        {
            ArrayList<int> list = new ArrayList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);            

            list.Insert(200, 2);
            
            Assert.AreEqual(200, list[2]);
            Assert.AreEqual(6, list[3]);
        }

        private void ThrowIndexOutOfRange_prep(){

            ArrayList<int> list = new ArrayList<int>();
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list[5] = 7;            
        }

        [Test]
        public void ThrowIndexOutOfRangeException()
        {
            var ex = Assert.Throws<IndexOutOfRangeException>(() => { ThrowIndexOutOfRange_prep(); });
            Assert.That(ex.Message, Is.EqualTo("Index was outside the bounds of the array."));
        }       

    }
}