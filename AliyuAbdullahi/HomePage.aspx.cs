using AliyuAbdullahi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AliyuAbdullahi
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            BlogContext context = new BlogContext();
            List<Blog> blogs = context.Blogs.ToList();
            Label1.Text = blogs.FirstOrDefault().Title;

            //Comment comment = new Comment { Text = "How are your", PostId = 1 };
            //context.Comments.Add(comment);
            //context.SaveChanges();
            GridView1.DataSource = blogs.FirstOrDefault().Posts.FirstOrDefault().Comments;
            GridView1.DataBind();
        }
    }
}