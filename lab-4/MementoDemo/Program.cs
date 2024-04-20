using DocumentEditor;

TextDocument document = new TextDocument("Unknown", "Ivan");
TextEditor editor = new TextEditor();

document.Write("1234");
editor.SaveSnapshot(document.Save());

document.Write(" hello");
editor.SaveSnapshot(document.Save());

document.Write(" how are u ?");
Console.WriteLine(document);

editor.Undo();
Console.WriteLine(document);

editor.Undo();
Console.WriteLine(document);
