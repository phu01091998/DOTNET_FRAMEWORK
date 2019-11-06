using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppG32019.model
{
    public class LearningHistory
    {
        public String Id { get; set; }
        public int YearFrom { get; set; }
        public int YearEnd { get; set; }
        public String Address { get; set; }
        public String IdStudent { get; set; }
        public Student Student { get; set; }
    }
}
