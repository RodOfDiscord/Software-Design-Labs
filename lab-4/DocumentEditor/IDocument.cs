namespace DocumentEditor
{
    public interface IDocument
    {
        IDocumentSnapshot Save();
    }
}
