using System;
using System.Collections.Generic;

namespace MementoPattern
{
    // Caretaker
    public class History
    {
        public Stack<EditorState> States { get; set; }

        public History()
        {
            this.States = new Stack<EditorState>();
        }

        public void Push(EditorState editorState)
        {
            this.States.Push(editorState);
        }

        public EditorState Pop()
        {
            if (this.States.Count == 0)
                throw new ArgumentNullException();

            return this.States.Pop();
        }

    }
}
