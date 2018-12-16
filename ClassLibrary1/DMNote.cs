using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class DMNote
    {
        public int ID { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public DMNote(int id) => ID = id;
        public DMNote(int id, string text) : this(id) => Text = text;
        public DMNote(int id, string text, string title) : this(id, text) => Title = title;
    }
}
