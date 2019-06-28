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

        //[Fact]
        //public void CanInsertMultipleNodesIntoLinkedList()
        //{

        //}

        //[Fact]
        //public void WillReturnTrueIfCertainValueExistsInLinkedList()
        //{

        //}

        //[Fact]
        //public void WillReturnFalseIfCertainValueDoesNotExistInLinkedList()
        //{

        //}

        //[Fact]
        //public void CanReturnCollectionOfAllValuesThatExistInLinkedList()
        //{
        //Lab document requested a print method at the time of initial creation
        //}

    }
}
