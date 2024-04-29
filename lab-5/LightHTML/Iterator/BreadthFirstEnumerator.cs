using System.Collections;

namespace LightHTML.Iterator
{
    public class BreadthFirstEnumerator : IEnumerator<LightNode>
    {
        private Queue<LightNode> queue;

        public BreadthFirstEnumerator(LightNode root)
        {
            queue = new Queue<LightNode>();
            queue.Enqueue(root);
            Current = root;
        }

        public LightNode Current { get; private set; }

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            if (queue.Count == 0)
            {
                return false;
            }

            Current = queue.Dequeue();

            if (Current is LightElementNode elementNode)
            {               
                foreach (var child in elementNode.GetNodes())
                {
                    queue.Enqueue(child);
                }
            }

            return true;
        }

        public void Dispose() { }

        public void Reset() { }
    }
}
