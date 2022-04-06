using Queue;
using System;
using Xunit;

namespace ArrayQueueTest
{
    public class Queue_Test
    {
        private ArrayQueue<int> _queue;
        public Queue_Test()
        {
            _queue = new ArrayQueue<int>(new int[] {10,20,30,40} );
        }

        [Fact]
        public void Count_Test()
        {
            //act 
            var count = _queue.Count;

            //assert
            Assert.Equal(4, count);
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
                item =>Assert.Equal(10,item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(40, item),
                item => Assert.Equal(value, item));
        }
        [Fact]
        public void DeQueueTest()
        {
            //act
             _queue.DeQueue();
            _queue.DeQueue();

            //assert
            Assert.Equal(30, _queue.Peek());
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
            for (int i = 0; i < _queue.Count; )
            {
                _queue.DeQueue();
            }
            //assert
            Assert.Throws<EmptyQueueException>(() => _queue.DeQueue());
        }
    }
}