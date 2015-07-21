using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace ContentTypes
{
    [DataContract(Namespace = "http://www.thatindigogirl.com/samples/2006/06")]
    public class LinkItem
    {
        [DataMember(Name = "ID", Order = 0, IsRequired = false)]
        private long id;
        public long ID
        {
            get { return id; }
            set { id = value; }
        }

        [DataMember(Name = "Title", Order = 1, IsRequired = true)]
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        [DataMember(Name = "Description", Order = 2, IsRequired = true)]
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        [DataMember(Name = "DateStart", Order = 3, IsRequired = true)]
        private DateTime dateStart;
        public DateTime DateStart
        {
            get { return dateStart; }
            set { dateStart = value; }
        }

        [DataMember(Name = "DateEnd", Order = 4, IsRequired = false)]
        private DateTime dateEnd;
        public DateTime DateEnd
        {
            get { return dateEnd; }
            set { dateEnd = value; }
        }

        [DataMember(Name = "Url", Order = 5, IsRequired = false)]
        private string url;
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
