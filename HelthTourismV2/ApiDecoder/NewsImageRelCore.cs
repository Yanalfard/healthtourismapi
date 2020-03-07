using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using HelthTourismV2.Models.Dto;
using HelthTourismV2.Models.Regular;

namespace HelthTourismV2.ApiDecoder
{
    public class NewsImageRelCore : ApiController
    {
        private HttpClient _httpClient;

        public NewsImageRelCore()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("api/NewsImageRelCore"));
            _httpClient.BaseAddress = new Uri("#localhost#");
        }
        public async Task<TblNewsImageRel> AddNewsImageRel(TblNewsImageRel newsImageRel)
        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/NewsImageRelCore/AddNewsImageRel", newsImageRel);
            TblNewsImageRel ans = await httpResponseMessage.Content.ReadAsAsync<TblNewsImageRel>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/DeleteNewsImageRel/DeleteNewsImageRel?id={id}", id);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            List<object> newsImageRelAndLogId = new List<object>();
            newsImageRelAndLogId.Add(newsImageRel);
            newsImageRelAndLogId.Add(logId);
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync("api/NewsImageRelCore/UpdateNewsImageRel", newsImageRelAndLogId);
            bool ans = await httpResponseMessage.Content.ReadAsAsync<bool>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.GetAsync("api/NewsImageRelCore/SelectAllNewsImageRels");
            List<DtoTblNewsImageRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<DtoTblNewsImageRel>>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsImageRelCore/SelectNewsImageRelById?id={id}", id);
            DtoTblNewsImageRel ans = await httpResponseMessage.Content.ReadAsAsync<DtoTblNewsImageRel>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsImageRelCore/SelectNewsImageRelsByNewsId?newsId={newsId}", newsId);
            List<TblNewsImageRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<TblNewsImageRel>>();
            return ans;
        }

        {
            HttpResponseMessage httpResponseMessage = await _httpClient.PostAsJsonAsync($"api/NewsImageRelCore/SelectNewsImageRelsByImageId?imageId={imageId}", imageId);
            List<TblNewsImageRel> ans = await httpResponseMessage.Content.ReadAsAsync<List<TblNewsImageRel>>();
            return ans;
        }

    }
}