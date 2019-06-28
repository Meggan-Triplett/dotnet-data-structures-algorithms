using System;
using Xunit;
using LinkedList.Classes;

namespace LinkedListUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanInstantiateEmptyLinkedList()
        {
            LinkList linkedList = new LinkList();

            Assert.Null(linkedList.Head);
        }

        [Fact]
        public void CanInsertIntoLinkedList()
        {
            LinkList linkedList = new LinkList();
            linkedList.Insert(42);
            string testResult = Convert.ToString(linkedList.Head.Value);

            Assert.Equal("42", testResult);
        }

        [Fact]
        public void HeadCanPointToFirstNodeOfLinkedList()
        {
            LinkList linkedList = new LinkList(67);
            linkedList.Insert(42);
            string testResult = Convert.ToString(linkedList.Head.Value);

            Assert.Equal("42", testResult);
        }

        [Fact]
        public void CanInsertMultipleNodesIntoLinkedList()
        {
            LinkList linkedList = new LinkList();
            linkedList.Insert(42);
            linkedList.Insert(36);
            linkedList.Insert(99);
            string testResult = Convert.ToString(linkedList.Head.Value);

            Assert.Equal("99", testResult);
        }

        [Fact]
        public void WillReturnTrueIfCertainValueExistsInLinkedList()
        {
            LinkList linkedList = new LinkList(67);
            linkedList.Insert(42);
            bool testResult= linkedList.Includes(42);

            Assert.True(testResult);
        }

        [Fact]
        public void WillReturnFalseIfCertainValueDoesNotExistInLinkedList()
        {
            LinkList linkedList = new LinkList(67);
            linkedList.Insert(42);
            bool testResult = linkedList.Includes(99);

            Assert.False(testResult);
        }

        //[Fact]
        public void CanReturnCollectionOfAllValuesThatExistInLinkedList()
        {
            //Lab document requested a print method at the time of initial creation
        }

    }
}
