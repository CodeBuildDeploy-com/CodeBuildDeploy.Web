using System.Collections.Generic;

using CodeBuildDeploy.DataAccess;

namespace CodeBuildDeploy.Repositories
{
    public interface IBlogRepository
    {
        IList<Category> AllCategories();
        IList<Post> AllPosts();
        IList<Post> Posts(int pageNo, int pageSize);
        Post PostByUrlSlug(string urlSlug);
        int TotalPosts();
    }
}
