using LightHTML;
using LightHTML.command;

LightElementNode node = new("div", "block-level", true);
LightTextNode textNode = new("text");
List<ICommand> commands =
[
    new NodeCommand(() => { node.AddNode(textNode); }, () => { node.RemoveNode(textNode); }),
    new NodeCommand(() => { node.CSSClasses.Add("container"); }, () => { node.CSSClasses.Remove("container"); }),
];

Invoker invoker = new(commands);

invoker.Run();
PrintInfo(node);

invoker.Revert();
PrintInfo(node);

static void PrintInfo(LightElementNode node)
{
    Console.WriteLine("classes: " + string.Join(" ", node.CSSClasses));
    Console.WriteLine("children (amount): " + node.GetNodes().Count);
}