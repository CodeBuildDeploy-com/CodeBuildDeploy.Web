using System.Collections.Generic;

using CodeBuildDeploy.DataAccess;
using CodeBuildDeploy.Repositories;

namespace CodeBuildDeploy.Models
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