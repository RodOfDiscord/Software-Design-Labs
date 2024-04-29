using System.Collections;

namespace LightHTML.Iterator
{
    public class Document : IEnumerable<LightNode>
    {
        public IEnumerator<LightNode> Enumerator { get; set; }

        public Document(IEnumerator<LightNode> enumerator)
        {
            Enumerator = enumerator;
        }

        public IEnumerator<LightNode> GetEnumerator()
        {
            return Enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
