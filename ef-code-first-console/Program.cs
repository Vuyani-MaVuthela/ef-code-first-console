using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ef_code_first_console
{
    public class Post
    {
        public int PostID { get; set; }
        public System.DateTime DatePublished { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public class PostsDbContext : DbContext //database api
    {
        public DbSet<Post> Posts { get; set; } //database table
    }

    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
