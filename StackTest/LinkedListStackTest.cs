using Stack;
using Stack.Interfaces;
using Xunit;



namespace StackTest
{
    public class LinkedListStackTest
    {
        private readonly IStack<char> _stack;

        public LinkedListStackTest()
        {
            _stack = new LinkedListStack<char>(new char[] { 's', 'e', 'l', 'a', 'm' });


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
            Assert.Equal('m', pop);

            Assert.Collection(_stack,
                item => Assert.Equal('a', item),
                item => Assert.Equal('l', item),
                item => Assert.Equal('e', item),
                item => Assert.Equal('s', item));
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
