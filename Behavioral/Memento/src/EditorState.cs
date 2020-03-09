namespace MementoPattern
{
    // Memento
    public class EditorState
    {
        public string Content { get; }

        public EditorState(string content)
        {
            this.Content = content;
        }
    }
}
