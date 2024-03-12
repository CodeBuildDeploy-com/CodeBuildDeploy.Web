using System.Collections.Generic;
using System.Threading.Tasks;
using CodeBuildDeploy.Models;

namespace CodeBuildDeploy.Repositories
{
    public interface IBlogRepository
    {
        Task<IList<Category>> AllCategoriesAsync();
        Task<IList<Post>> AllPostsAsync();
        Task<IList<Post>> PostsAsync(int pageNo, int pageSize);
        Task<Post> PostByUrlSlugAsync(string urlSlug);
        Task<int> TotalPostsAsync();
    }
}
