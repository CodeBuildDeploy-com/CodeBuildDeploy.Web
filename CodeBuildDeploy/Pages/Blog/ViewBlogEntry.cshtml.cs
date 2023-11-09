﻿using System.Collections.Generic;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using CodeBuildDeploy.DataAccess;
using CodeBuildDeploy.Repositories;

namespace CodeBuildDeploy.Pages.Blog;

public class ViewBlogEntryModel : PageModel
{
    private readonly ILogger<ViewBlogEntryModel> _logger;

    private readonly IBlogRepository _blogsRepository;

    [ViewData]
    public string Title { get; private set; } = "";

    [ViewData]
    public string Message { get; private set; }

    [BindProperty(SupportsGet = true)]
    public Post? Post { get; set; }

    public ViewBlogEntryModel(ILogger<ViewBlogEntryModel> logger, IBlogRepository blogsRepository)
    {
        _logger = logger;
        _blogsRepository = blogsRepository;
    }

    public void OnGet(string urlSlug)
    {
        Post = _blogsRepository.PostByUrlSlug(urlSlug);

        Title = Post.Title;
        Message = Post.Description;

        _logger.LogInformation("Viewing Blog: '{0}'", Post.Title);
    }
}
