
namespace LeetCode.CSharp._0000_0999._0200_0299
{
    public class StackUsingQueue
    {
        LinkedList<int> queue;
        public StackUsingQueue()
        {
            queue = new LinkedList<int>();
        }

        public static void Process()
        {

        }

        public void Push(int x)
        {
            queue.AddLast(x);
        }

        public int Pop()
        {
            var last = queue.LastOrDefault();
            queue.RemoveLast();

            return last;
        }

        public int Top()
        {
            return queue.LastOrDefault();
        }

        public bool Empty()
        {
            return !queue.Any();
        }
    }
}
