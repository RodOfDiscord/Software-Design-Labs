using LightHTML;

LightElementNode list = new LightElementNode("li", "block-level", true);

for (int i = 1; i < 7; i++)
{
    var ul = new LightElementNode("ul", "block-level", true);
    ul.AddNode(new LightTextNode(i.ToString()));
    list.AddNode(ul);
}

Console.WriteLine(list.GetOuterHTML());