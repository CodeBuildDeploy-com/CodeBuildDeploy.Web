using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

using CodeBuildDeploy.Models;

namespace CodeBuildDeploy.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        public const string ClientName = nameof(BlogRepository);

        private readonly IHttpClientFactory _httpClientFactory;

        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public BlogRepository(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
            _jsonSerializerOptions = new JsonSerializerOptions();
            _jsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            _jsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
        }

        public async Task<IList<Category>> AllCategoriesAsync()
        {
            var uri = "api/Blog/GetAllCategories";
            using var responseMessage = await CallBlogsService(uri);
            if (responseMessage.IsSuccessStatusCode)
            {
                return await Deserialize<IList<Category>>(await responseMessage.Content.ReadAsStreamAsync());
            }
            throw new HttpRequestException($"Error calling {uri}, Status Code {responseMessage.StatusCode}");
        }

        public async Task<IList<Post>> AllPostsAsync()
        {
            var uri = "api/Blog/GetAllPosts";
            using var responseMessage = await CallBlogsService(uri);
            if (responseMessage.IsSuccessStatusCode)
            {
                return await Deserialize<IList<Post>>(await responseMessage.Content.ReadAsStreamAsync());
            }
            throw new HttpRequestException($"Error calling {uri}, Status Code {responseMessage.StatusCode}");
        }

        public async Task<IList<Post>> PostsAsync(int pageNo, int pageSize)
        {
            var uri = $"api/Blog/GetPosts?pageNo={pageNo}&pageSize={pageSize}";
            using var responseMessage = await CallBlogsService(uri);
            if (responseMessage.IsSuccessStatusCode)
            {
                return await Deserialize<IList<Post>>(await responseMessage.Content.ReadAsStreamAsync());
            }
            throw new HttpRequestException($"Error calling {uri}, Status Code {responseMessage.StatusCode}");
        }

        public async Task<Post> PostByUrlSlugAsync(string urlSlug)
        {
            var uri = $"api/Blog/GetPostByUrlSlug?urlSlug={urlSlug}";
            using var responseMessage = await CallBlogsService(uri);
            if (responseMessage.IsSuccessStatusCode)
            {
                return await Deserialize<Post>(await responseMessage.Content.ReadAsStreamAsync());
            }
            throw new HttpRequestException($"Error calling {uri}, Status Code {responseMessage.StatusCode}");
        }

        public async Task<int> TotalPostsAsync()
        {
            var uri = "api/Blog/GetTotalPosts";
            using var responseMessage = await CallBlogsService(uri);
            if (responseMessage.IsSuccessStatusCode)
            {
                return await Deserialize<int>(await responseMessage.Content.ReadAsStreamAsync());
            }
            throw new HttpRequestException($"Error calling {uri}, Status Code {responseMessage.StatusCode}");
        }

        private async Task<HttpResponseMessage> CallBlogsService(
            string endpointUri)
        {
            using var client = _httpClientFactory.CreateClient(ClientName);

            return await client.GetAsync(endpointUri);
        }

        private async ValueTask<TResponse> Deserialize<TResponse>(
            Stream utf8Json)
        {
            var response = await JsonSerializer.DeserializeAsync<TResponse>(utf8Json, _jsonSerializerOptions);

            if (response != null)
            {
                return response;
            }

            throw new InvalidOperationException($"Unexpected null for type {typeof(TResponse).FullName}.");
        }
    }
}