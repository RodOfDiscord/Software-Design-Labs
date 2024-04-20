namespace DocumentEditor
{
    public class TextEditor // caretaker
    {
        List<IDocumentSnapshot> history;

        public TextEditor()
        {
            history = [];
        }

        public void SaveSnapshot(IDocumentSnapshot snapshot)
        {
            history.Add(snapshot);
        }

        public void Undo()
        {
            var snapshot = history.LastOrDefault();
            if (snapshot == null) return;
            
            snapshot.Restore();
            history.Remove(snapshot);
        }
    }
}
