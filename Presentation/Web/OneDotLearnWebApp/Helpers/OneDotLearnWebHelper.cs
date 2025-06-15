using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Caching.Memory;
using OneDotLearnCore.Essential;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace OneDotLearnWebApp.Helpers
{
    public static class StringExtensions
    {
        public static string RemoveTrailingSlash(this string source)
        {
            if (string.IsNullOrWhiteSpace(source)) return null;
            return source.EndsWith("/") ? source.Substring(0, source.Length - 1) : source;
        }
    }

    public class OneDotLearnWebHelper
    {
        #region Data Members
        private ILogger<OneDotLearnWebHelper> _logger;
        private IConfiguration _config;
        private readonly IHttpClientFactory _httpClientFactory;
        private LoggerHelper _logHlpr;
        #endregion

        #region Constructors
        public OneDotLearnWebHelper(IMemoryCache memCache, ILogger<OneDotLearnWebHelper> logger, IConfiguration config,
                                        IHttpClientFactory httpClntFcty, LoggerHelper logHlp)
        {
            MemCache = memCache;

            _config = config; _httpClientFactory = httpClntFcty;
        }
        #endregion

        #region Properties
        public IMemoryCache MemCache { get; set; }
        public List<Country> Countries
        {
            get
            {
                return MemCache.TryGetValue("Countries", out List<Country> ctrs) ? ctrs : null;
            }
            set
            {
                MemCache.Set("Countries", value);

                var ctrsLst = new List<SelectListItem>() { new SelectListItem("(Select)", "0") };
                ctrsLst.AddRange(value.Select(ctr => new SelectListItem(ctr.Name, $"{ctr.Id}")));
                MemCache.Set("CountriesList", ctrsLst);
            }
        }
        public List<SelectListItem> CountriesList =>
            MemCache.TryGetValue("CountriesList", out List<SelectListItem> ctrsLst) ? ctrsLst : null;
        #endregion

        #region Methods
        public async Task<T> GetAsync<T>(string uri)
        {
            try
            {
                //_logger.LogInformation($"Into GetAsync");

                using var httpClnt = _httpClientFactory.CreateClient();

                var msg = await httpClnt.GetAsync(uri);

                if (msg.IsSuccessStatusCode)
                {
                    if (msg.Content != null)
                    {
                        var msgCnt = msg.Content;
                        var strCnt = await msgCnt.ReadAsStringAsync();

                        //_logger.LogInformation($"Got content: '{strCnt}' | {strCnt.Length}");

                        return strCnt.Length > 0 ? await msgCnt.ReadFromJsonAsync<T>() : default;
                    }
                    else
                    {
                        _logger.LogInformation($"Content is NULL");
                        return default;
                    }
                }
                else
                    return default;

                //{
                //    return await msg.Content.ReadFromJsonAsync<T>();
                //    //var rslt = await httpClnt.GetFromJsonAsync(uri, typeof(T));
                //    //return rslt != null ? (T)rslt : default;
                //}
                //else
                //    return default;
                //await LogDebugAsync($"Into Get<T> -- {uri}...");

                //_logger.LogInformation($"[GlbGetAsync - 2] {uri}");

            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<OpResult> PostAsync<T>(T payload, string uri)
        {
            try
            {
                using var httpClnt = _httpClientFactory.CreateClient();

                //_logger.LogInformation("Into Post...");

                var msg = await httpClnt.PostAsJsonAsync(uri, payload);

                //_logger.LogInformation($"Post - 2");

                if (msg.Content != null && msg.IsSuccessStatusCode)
                {
                    var rtCnt = await msg.Content.ReadAsStringAsync();

                    //_logger.LogInformation($"[POST] Received '{rtCnt}'");

                    return Deserialize<OpResult>(rtCnt);// await msg.Content.ReadAsStringAsync());
                }
                else
                {
                    var strErr = $"{msg.StatusCode} | {await msg.Content.ReadAsStringAsync()}";

                    _logger.LogInformation($"[POST] Error '{strErr}'");

                    return new OpResult()
                    {
                        IsSuccessful = false,
                        Error = strErr
                    };
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"ERROR from Glob Post");

                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public async Task<OpResult> PutAsync<T>(T payload, string uri)
        {
            try
            {
                //var jsonPhrm = new List<string>() { System.Text.Json.JsonSerializer.Serialize(obj,
                //            new System.Text.Json.JsonSerializerOptions() { IgnoreNullValues = true }) };

                using var httpClnt = _httpClientFactory.CreateClient();

                var msg = await httpClnt.PutAsJsonAsync(uri, payload);

                if (msg.Content != null && msg.IsSuccessStatusCode)
                    return Deserialize<OpResult>(await msg.Content.ReadAsStringAsync());
                else
                    return null;
            }
            catch (Exception ex)
            {
                await _logHlpr.LogErrorAsync(ex);
                throw;
            }
        }

        public T Deserialize<T>(string jsonStr)
        {
            try
            {
                return JsonSerializer.Deserialize<T>(
                            jsonStr,
                            new JsonSerializerOptions()
                            {
                                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
                                PropertyNameCaseInsensitive = true
                            });
            }
            catch (Exception ex)
            {
                _logHlpr.LogError(ex);
                throw;
            }
        }
        #endregion
    }
}
