using System.Collections;

namespace LightHTML.Iterator
{
    public class DepthFirstEnumerator : IEnumerator<LightNode>
    {
        private Stack<LightNode> stack;

        public DepthFirstEnumerator(LightNode root)
        {
            stack = new Stack<LightNode>();
            stack.Push(root);
            Current = root;
        }

        public LightNode Current { get; private set; }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }

            Current = stack.Pop();

            if (Current is LightElementNode elementNode)
            {
                for (int i = elementNode.CountNodes() - 1; i >= 0; i--)
                {
                    stack.Push(elementNode.GetNodes()[i]);
                }
            }

            return true;
        }

        public void Dispose() { }

        public void Reset() { }
    }
}
