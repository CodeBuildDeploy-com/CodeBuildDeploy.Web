using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

using CodeBuildDeploy.DataAccess;

namespace CodeBuildDeploy.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly DAContext _session;

        public BlogRepository(DAContext session)
        {
            _session = session;
        }

        public IList<Category> AllCategories()
        {
            return _session.Categories
                    .Include(c => c.Posts)
                    .Where(c => c.Posts.Any()).ToList();
        }

        public IList<Post> AllPosts()
        {
            return _session.Posts.Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .ToList();
        }

        public IList<Post> Posts(int pageNo, int pageSize)
        {
            return _session.Posts
                    .Include(p => p.Category)
                    .Include(p => p.PostTags)
                    .ThenInclude(pt => pt.Tag)
                    .Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .Skip(pageNo * pageSize)
                    .Take(pageSize)
                    .ToList();
        }

        public Post PostByUrlSlug(string urlSlug)
        {
            return _session.Posts
                    .Include(p => p.Category)
                    .Include(p => p.PostTags)
                    .ThenInclude(pt => pt.Tag)
                    .SingleOrDefault(p => p.UrlSlug.ToLower().Equals(urlSlug.ToLower()));
        }

        public int TotalPosts()
        {
            return _session.Posts.Count(p => p.Published);
        }
    }
}