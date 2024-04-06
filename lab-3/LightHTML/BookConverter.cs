namespace LightHTML
{
    public static class BookConverter
    {
        public static List<LightNode> Convert(string filepath)
        {
            using StreamReader reader = new(filepath);
            string[] lines = reader.ReadToEnd().Split("\r\n");

            List<LightNode> convertedLines = new List<LightNode>();

            LightElementNode header = new LightElementNode("h1", "block-level", true);
            header.AddNode(new LightTextNode(lines[0]));
            convertedLines.Add(header);

            for (int i = 1; i < lines.Length; i++)
            {
                LightElementNode node;

                if (lines[i].Length < 20)
                {
                    node = new("h2", "block-level", true);
                }
                else if (lines[i][0] == ' ')
                {
                    node = new("blockquote", "block-level", true);
                }
                else
                {
                    node = new("p", "block-level", true);
                }

                node.AddNode(new LightTextNode(lines[i]));
                convertedLines.Add(node);
            }

            return convertedLines;
        }
    }
}
