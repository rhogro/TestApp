using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Problem
    {
        public int ProblemId { get; set; }
        public string Question { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
    }
}
