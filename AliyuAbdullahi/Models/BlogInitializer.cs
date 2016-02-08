using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AliyuAbdullahi.Models
{
    public class BlogInitializer : DropCreateDatabaseIfModelChanges<BlogContext>
    {

        protected override void Seed(BlogContext context)
        {
            Blog blog = new Blog();
            blog.Title = "First blog";
            List<Post> posts = getPosts();
          
            posts.ForEach(p => p.Comments = getCommets());
            blog.Posts = posts;
            context.Blogs.Add(blog);
            context.SaveChanges();
        }

        private static List<Comment> getCommets ()
        {
            List<Comment> comments = new List<Comment>
            {
                new Comment
                {
                    PostId = 1,
                    Text = "Hello and how are you?"
                },
                new Comment
                {
                    PostId = 2,
                    Text = "Android is awesome!"
                },
                new Comment
                {
                    PostId = 1,
                    Text = "C# is much better!"
                }


            };
            return comments;
        }


        private static List<Post> getPosts ()
        {
            List<Post> posts = new List<Post>
            {
                new Post
                {
                    Id = 1,
                    Title = "Game of thrones",
                    Date = DateTime.Now
                   
                },
                new Post
                {
                    Id = 2,
                    Title = "Person of Interest",
                    Date = DateTime.Now
                }
            };
            return posts;
        }
    }
}
