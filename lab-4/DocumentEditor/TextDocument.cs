namespace DocumentEditor
{
    public class TextDocument : IDocument //originator
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AmountLetters { get; private set; }
        public int AmountSheets {  get; private set; }
        private string content;

        public TextDocument(string title, string author, int amountLetters = 0, int amountSheets = 1)
        {
            Title = title;
            Author = author;
            AmountLetters = amountLetters;
            AmountSheets = amountSheets;
            content = string.Empty;
        }

        public class DocumentSnapshot : IDocumentSnapshot // memento
        {
            private readonly string content;

            private readonly TextDocument originalDocument;

            public DocumentSnapshot(TextDocument textDocument)
            {
                content = textDocument.content;
                originalDocument = textDocument;
            }

            public void Restore()
            {
                originalDocument.content = content; 
            }
        }

        public IDocumentSnapshot Save()
        {
            return new DocumentSnapshot(this);
        }

        public void Write(string content)
        {
            this.content += content;  
        }

        public override string ToString()
        {
            return $"{Title}: {content}";
        }
    }
}
