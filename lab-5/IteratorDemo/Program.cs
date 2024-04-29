using LightHTML.Iterator;
using LightHTML;

LightElementNode root = new("html", "element", true);
LightElementNode body = new("body", "element", true);
LightElementNode list = new("ul", "block-level", true);

for (int i = 1; i < 7; i++)
{
    LightElementNode item = new("li", "block-level", true);
    LightElementNode p = new("p", "element", true);
    LightTextNode text = new(i.ToString());
    p.AddNode(text);
    item.AddNode(p);
    list.AddNode(item);
}

body.AddNode(list);
root.AddNode(body);

Document html = new Document(new BreadthFirstEnumerator(root));
printNodes(html);

html = new Document(new DepthFirstEnumerator(root));
printNodes(html);

static void printNodes(Document document)
{
    foreach (var node in document)
    {
        Console.WriteLine(node.GetOuterHTML());
    }
}