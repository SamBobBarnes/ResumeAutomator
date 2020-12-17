using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeAutomator
{
    class ResumeData
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public String Phone { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Site { get; set; }
        public List<String> Jobs { get; set; }
    }
}
