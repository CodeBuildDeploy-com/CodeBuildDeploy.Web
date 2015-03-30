namespace MyWebSite.Repositories
{
    using System.Collections.Generic;
    using MyWebSite.DataAccess;

    public interface IBlogRepository
    {
        IList<Category> AllCategories();
        IList<Post> AllPosts();
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }
}
