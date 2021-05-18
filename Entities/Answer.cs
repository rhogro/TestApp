using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Answer
    {
        public int AnswerId { get; set; }
        public int ProblemId { get; set; }
        public string AnswerString { get; set; }
        public bool IsCorrect { get; set; }
    }
}
