using LightHTML;
using LightHTML.visitor;

NodeVisitor visitor = new();

LightElementNode node = new("div", "block-level", true);
node.Accept(visitor);
Console.WriteLine(node.CSSClasses.Last());

LightTextNode textNode = new("hello");
textNode.Accept(visitor);
Console.WriteLine(textNode.TextContent);