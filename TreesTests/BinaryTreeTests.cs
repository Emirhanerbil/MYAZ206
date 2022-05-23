using Xunit;
using DataStructures.Trees.BinaryTree;
namespace TreesTests
{
    public class BinaryTreeTests
    {

        private BinaryTree<int> bt;

        public BinaryTreeTests()
        {
            bt= new BinaryTree<int>();
        }
        [Fact]
        public void Insert()
        {
            bt.Insert(1);

            Assert.Equal(1, bt.Root.Value);
        }

        [Fact]
        public void Insert_Check_Left_Node()
        {
            bt.Insert(1);
            bt.Insert(2);

            Assert.Equal(bt.Root.Value, 1);
            Assert.Equal(bt.Root.Left.Value, 2);    
        }
    }
}