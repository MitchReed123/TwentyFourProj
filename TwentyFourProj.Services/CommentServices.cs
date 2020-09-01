using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwentyFourProj.Data;
using TwentyFourProj.Models;

namespace TwentyFourProj.Services
{
    public class CommentServices
    {
        private readonly Guid _userid;

        public CommentServices(Guid userId)
        {
            _userid = userId;
        }

        //public async Task<bool> CreateCommentAsync(CommentCreate model)
        //{
        //    var entity = new Comment()
        //    {

        //    }
        //}
    }
}
