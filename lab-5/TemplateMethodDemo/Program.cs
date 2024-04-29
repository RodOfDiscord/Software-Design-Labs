using LightHTML;

LightElementNode list = new("ul", "block-level", true);
LightElementNode item = new("li", "block-level", true);
list.AddNode(item);
list.RemoveNode(item);