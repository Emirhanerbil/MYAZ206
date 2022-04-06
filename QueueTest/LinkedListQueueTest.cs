using Queue;
using System;
using Xunit;

namespace LinkedListQueueTest
{
    public class QueueLinked_Test
    {
        private LinkedListQueue<int> _queue;
        public QueueLinked_Test()
        {
            _queue = new LinkedListQueue<int>(new int[] { 10, 20, 30 });
        }

        [Fact]
        public void Count_Test()
        {
            //act 
            var count = _queue.Count;

            //assert
            Assert.Equal(3, count);
        }
        [Theory]
        [InlineData(76)]
        [InlineData(43)]
        [InlineData(32)]
        [InlineData(12)]
        public void EnQueueTest(int value)
        {
            //act
            _queue.EnQueue(value);

            //assert
            Assert.Collection(_queue,
                item => Assert.Equal(10, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(value, item));
        }
        [Fact]
        public void DeQueueTest()
        {
            //act
            var dequeue = _queue.DeQueue();

            //assert
            Assert.Collection(_queue,
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item));
        }

        [Fact]
        public void Peek_Test()
        {
            //act
            var peek = _queue.Peek();

            //assert
            Assert.Equal(10, peek);
        }

        [Fact]
        public void Queue_Empty_Test()
        {
            //act
            _queue.DeQueue();
            _queue.DeQueue();
            _queue.DeQueue();
            
            //assert
            Assert.Throws<EmptyQueueException>(() => _queue.DeQueue());
        }
    }
}