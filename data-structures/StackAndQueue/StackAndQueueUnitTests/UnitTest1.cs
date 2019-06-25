using System;
using Xunit;
using StackAndQueue.Classes;

namespace StackAndQueueUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanPushOntoStack()
        {
            Stack testStack = new Stack(42);

            Assert.Equal(42, testStack.Top.Value);
        }

        //[Fact]
        public void CanPushMultipleValuesOntoStack()
        {
            Stack testStack = new Stack(42);
            testStack.Push(34);
            testStack.Push(26);
         
                
            
        }

        //[Fact]
        public void CanPopOffStack()
        {

        }

        //[Fact]
        public void CanEmptyStackAfterMultiplePops()
        {

        }

        //[Fact]
        public void CanPeekNextItemOnStack()
        {

        }

        [Fact]
        public void CanInstantiateEmptyStack()
        {
            Stack stack = new Stack();

            Assert.Null(stack.Top);
        }

        [Fact]
        public void CanEnqueueIntoQueue()
        {
            Queue testQueue = new Queue(42);

            Assert.NotNull(testQueue.Front);
        }

        //[Fact]
        public void CanEnqueueMultipleValuesIntoQueue()
        {

        }

        //[Fact]
        public void CanDequeueOutOfQueueExpectedValue()
        {

        }

        //[Fact]
        public void CanPeekIntoQueueExpectedValue()
        {

        }

        //[Fact]
        public void CanEmptyQueueAfterMultipleDequeues()
        {

        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            Queue testQueue = new Queue();

            Assert.Null(testQueue.Front);
        }

    }
}