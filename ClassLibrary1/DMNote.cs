using System;
using System.Collections.Generic;
using System.Text;

namespace Logic
{
    public class DMNote
    {
        public int ID { get; set; }
        public int CampaignID { get; set; }
        public string Text { get; set; }
        public string Title { get; set; }

        public DMNote(int id, int campID)
        {
            ID = id;
            CampaignID = campID;
        }

        public DMNote(int id, int campID, string text) : this(id, campID) => Text = text;
        public DMNote(int id, int campID, string text, string title) : this(id, campID, text) => Title = title;
    }
}
