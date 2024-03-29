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

        [Fact]
        public void CanPushMultipleValuesOntoStack()
        {
            Stack testStack = new Stack(42);
            testStack.Push(34);
            testStack.Push(26);

            Assert.Equal(26, testStack.Top.Value);   
        }

        [Fact]
        public void CanPopOffStack()
        {
            Stack testStack = new Stack(42);
            testStack.Push(34);
            testStack.Push(26);
            testStack.Pop();

            Assert.Equal(34, testStack.Top.Value);
        }

        [Fact]
        public void CanEmptyStackAfterMultiplePops()
        {
            Stack testStack = new Stack();
            testStack.Push(34);
            testStack.Push(26);
            testStack.Pop();
            testStack.Pop();

            Assert.Null(testStack.Top);
        }

        [Fact]
        public void CanPeekNextItemOnStack()
        {
            Stack testStack = new Stack(42);
            testStack.Push(34);
            testStack.Push(26);

            Assert.Equal(34, testStack.Top.Next.Value);
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

        [Fact]
        public void CanEnqueueMultipleValuesIntoQueue()
        {
            Queue testQueue = new Queue(42);
            testQueue.Enqueue(34);
            testQueue.Enqueue(26);

            Assert.Equal(26, testQueue.Rear.Value);
        }

        [Fact]
        public void CanDequeueOutOfQueueExpectedValue()
        {
            Queue testQueue = new Queue(42);
            testQueue.Enqueue(34);
            testQueue.Enqueue(26);
            int removedNodeValue = testQueue.Dequeue();

            Assert.Equal(42, removedNodeValue);
        }

        [Fact]
        public void CanPeekIntoQueueExpectedValue()
        {
            Queue testQueue = new Queue(42);
            int peekedFrontValue = testQueue.Peek();

            Assert.Equal(42, peekedFrontValue);

        }

        //[Fact]
        public void CanEmptyQueueAfterMultipleDequeues()
        {
            Queue testQueue = new Queue();
            testQueue.Enqueue(34);
            testQueue.Enqueue(26);
            testQueue.Dequeue();
            testQueue.Dequeue();

            Assert.Null(testQueue.Front);
        }

        [Fact]
        public void CanInstantiateEmptyQueue()
        {
            Queue testQueue = new Queue();

            Assert.Null(testQueue.Front);
        }

    }
}
