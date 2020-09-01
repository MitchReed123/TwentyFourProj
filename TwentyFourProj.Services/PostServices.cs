using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using TwentyFourProj.Data;
using TwentyFourProj.Models;

namespace TwentyFourProj.Services
{
    public class PostServices
    {
        private readonly Guid _userId;

        public PostServices(Guid userId)
        {
            _userId = userId;
        }
        
        public bool CreatePost(PostCreate model)
        {
            var entity = new Post()
            {
                UserId = _userId,
                Title = model.Title,
                Text = model.Text,
                Id = model.Id,
                //Author = model.Author,
            };

            using(var ctx = new ApplicationDbContext())
            {
                ctx.Posts.Add(entity);
                return ctx.SaveChanges() == 0;
            }
        }

        public IEnumerable<PostItem> GetPosts()
        {
            using(var ctx = new ApplicationDbContext())
            {
                var query = ctx.Posts.Where(e => e.UserId == _userId).Select(
                    e =>
                    new PostItem
                    {
                        PostId = e.Id,
                        Title = e.Title,
                        Text = e.Text,
                    }
                    );
                return query.ToArray();
            }
        }

        public bool UpdatePost(PostEdit model)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Posts.Single(e => e.Id == model.Id && e.UserId == _userId);
                entity.Title = model.Title;
                entity.Text = model.Text;

                return ctx.SaveChanges() == 1;
            }
        }

        public bool DeletePost(int postId)
        {
            using(var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx.Posts.Single(e => e.Id == postId && e.UserId == _userId);
                ctx.Posts.Remove(entity);

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
