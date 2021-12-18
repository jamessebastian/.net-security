using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Security.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionName { get; set; }

        public DateTime DatePosted { get; set; }
        public int CategoryID { get; set; }

        public Category Category { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
}
