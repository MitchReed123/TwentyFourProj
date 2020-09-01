using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourProj.Data;

namespace TwentyFourProj.Models
{
    public class CommentItem
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public User Auther { get; set; }
    }
}
