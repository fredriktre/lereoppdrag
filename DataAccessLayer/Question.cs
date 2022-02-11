using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    public class Question
    {
        public string QuestionText { get; set; }
        public List<Answer> Answers { get; set; }

    }

}