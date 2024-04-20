using EventListenerLightHTML;

LightTextNode textNode = new("text");
textNode.OnClick += (sender, eventArgs) => { textNode.TextContent = "changed text"; };

Console.WriteLine(textNode.GetOuterHTML());

textNode.Click();

Console.WriteLine(textNode.GetOuterHTML());