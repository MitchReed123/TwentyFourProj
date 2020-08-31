using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourProj.Data;

namespace TwentyFourProj.Models
{
    public class PostCreate
    {
        public User user { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
