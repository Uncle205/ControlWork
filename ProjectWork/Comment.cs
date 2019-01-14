using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork
{
    public class Comment:News
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Body { get; set; }
    }
}
