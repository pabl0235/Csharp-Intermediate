using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2Exercises.Exercise2
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        private int _voteValue = 0;

        public Post()
        {
            CreationDate = DateTime.Now;
        }
        public Post(string title, string description)
            : this()
        {
            Title = title;
            Description = description;
        }
        public void UpVote()
        {
            _voteValue++;
        }
        public void DownVote()
        {
            _voteValue--;
        }
        public int VoteValue
        {
            get { return _voteValue; }
        }
    }
}
