using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ContentTypes
{
    [DataContract]
    public class LinkItem
    {
        [DataMember]
        private long id;
        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember]
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [DataMember]
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember]
        private DateTime dateStart;
        public DateTime DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        [DataMember]
        private DateTime dateEnd;
        public DateTime DateEnd
        {
            get { return dateEnd; }
            set { dateEnd = value; }
        }

        [DataMember]
        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
