using System;
using System.Collections.Generic;
using System.Text;

namespace ContentTypes
{
    public class LinkItem
    {
        private long id;
        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        private DateTime dateStart;
        public DateTime DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        private DateTime dateEnd;
        public DateTime DateEnd
        {
            get { return dateEnd; }
            set { dateEnd = value; }
        }

        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
