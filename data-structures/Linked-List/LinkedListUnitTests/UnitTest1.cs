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

        //[Fact]
        //public void CanInsertIntoLinkedList()
        //{

        //}

        //[Fact]
        //public void HeadCanPointToFirstNodeOfLinkedList()
        //{

        //}

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

        //}

    }
}
