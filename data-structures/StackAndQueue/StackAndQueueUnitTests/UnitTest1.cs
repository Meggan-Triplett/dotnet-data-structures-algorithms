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
            Stack stack = new Stack(42);

            Assert.NotNull(stack.Top);
        }

        //[Fact]
        public void CanPushMultipleValuesOntoStack()
        {

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

        //[Fact]
        public void CanEnqueueIntoQueue()
        {

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
            Queue queue = new Queue();

            Assert.Null(queue.Front);
        }

    }
}
