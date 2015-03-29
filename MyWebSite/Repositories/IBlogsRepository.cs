namespace MyWebSite.Repositories
{
    using System.Collections.Generic;
    using MyWebSite.DataAccess;

    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNo, int pageSize);
        int TotalPosts();
    }

}
