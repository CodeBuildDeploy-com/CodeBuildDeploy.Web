using System.Collections.Generic;

using MyWebSite.DataAccess;

namespace MyWebSite.Repositories
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
