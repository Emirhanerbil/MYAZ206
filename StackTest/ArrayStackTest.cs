using Xunit;
using Stack.Interfaces;

namespace StackTest
{
    public class ArrayStackTest
    {
        private readonly IStack<char> _stack;

        public ArrayStackTest()
        {
            _stack = new DataStructures.Stack.
                ArrayStack<char>(new char[] {'s','e','l','a','m'});
            

        }

        [Fact]
        public void Count()
        {
            //act
            var count = _stack.Count;

            //assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void PopTest()
        {
            //act
            var pop = _stack.Pop();
            //assert
            Assert.Equal('m',pop);

        }
        [Theory]
        [InlineData('m')]
        [InlineData('e')]
        [InlineData('r')]
        [InlineData('h')]
        [InlineData('a')]
        [InlineData('b')]
        [InlineData('a')]
        public void Push(char value)
        {
            //act 
            _stack.Push(value);

            //assert
            Assert.Equal(value, _stack.Pop());
        }

    }
}