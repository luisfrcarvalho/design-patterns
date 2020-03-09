namespace MementoPattern
{
    // Originator
    public class Editor
    {
        public string Content { get; set; }

        public EditorState CreateState()
        {
            return new EditorState(this.Content);
        }

        public void Restore(EditorState previousState)
        {
            if (previousState == null)
                return;

            this.Content = previousState.Content;
        }
    }
}
