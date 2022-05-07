using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Overflow_Post
{
    class Post
    {
        private string _title;
        private DateTime _creationTime = DateTime.Now;
        

        public string Title { get => _title; set { _title = value; _creationTime = DateTime.Now; } }

        public string Description { get; set; }
        public DateTime CreationTime { get { return _creationTime; } }

        public int UpVote { get;  set; }

        public int DownVote { get;  set; }
    }
}
