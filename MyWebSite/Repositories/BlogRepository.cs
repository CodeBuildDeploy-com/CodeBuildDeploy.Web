﻿namespace MyWebSite.Repositories
{
    using System.Collections.Generic;
    using System.Linq;

    using MyWebSite.DataAccess;

    public class BlogRepository : IBlogRepository
    {
        private readonly DAContext _session;

        public BlogRepository(DAContext session)
        {
            _session = session;
        }

        public IList<Category> AllCategories()
        {
            return _session.Categories.Where(c => c.Posts.Any()).ToList();
        }

        public IList<Post> AllPosts()
        {
            return _session.Posts.Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .ToList();
        }

        public IList<Post> Posts(int pageNo, int pageSize)
        {
            return _session.Posts.Where(p => p.Published)
                    .OrderByDescending(p => p.PostedOn)
                    .Skip(pageNo * pageSize)
                    .Take(pageSize)
                    .ToList();
        }

        public int TotalPosts()
        {
            return _session.Posts.Count(p => p.Published);
        }
    }
}