using System.Collections.Generic;

using MyWebSite.DataAccess;
using MyWebSite.Repositories;

namespace MyWebSite.Models
{
    public class BlogsViewModel
    {
        public BlogsViewModel(IBlogRepository blogRepository, int p)
        {
            Posts = blogRepository.Posts(p - 1, 10);
            TotalPosts = blogRepository.TotalPosts();
        }
 
        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }
    }
}