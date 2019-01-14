using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWork
{
    public class News
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public List<Comment> Comment { get; set; }
        public Client AuthirName { get; set; }
        public Guid AuthorId { get; set; }
    }
}
