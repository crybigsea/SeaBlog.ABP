﻿using Microsoft.AspNetCore.Components;
using SeaBlog.Blazor.Admin.Api.IApis;
using SeaBlog.Blazor.Admin.Models;
using SeaBlog.Blazor.Admin.Models.Base;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace SeaBlog.Blazor.Admin.Api.Apis
{
    public class CategoryApi : ICategoryApi
    {
        private readonly HttpClient httpClient;

        public CategoryApi(HttpClient _httpClient)
        {
            httpClient = _httpClient;
        }

        public async Task<ListResult<CategoryDetail>> GetListAsync()
        {
            ListResult<CategoryDetail> result = new ListResult<CategoryDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<ListResult<CategoryDetail>>($"{Config.ApiUrl}/api/services/app/Category/GetAll");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        public async Task<ListResult<CategoryDetail>> GetPageAsync(SearchParameters searchParameters)
        {
            ListResult<CategoryDetail> result = new ListResult<CategoryDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<ListResult<CategoryDetail>>(Config.BuildApiUrlWithParams("api/services/app/Category/GetAll", searchParameters));
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        public async Task<EntityResult<CategoryDetail>> GetDetailAsync(string id)
        {
            EntityResult<CategoryDetail> result = new EntityResult<CategoryDetail>();
            try
            {
                result = await httpClient.GetJsonAsync<EntityResult<CategoryDetail>>($"{Config.ApiUrl}/api/services/app/Category/Get?id={id}");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        public async Task<EntityResult<CategoryDetail>> CreateAsync(CategoryDetail categoryDetail)
        {
            EntityResult<CategoryDetail> result = new EntityResult<CategoryDetail>();
            try
            {
                result = await httpClient.PostJsonAsync<EntityResult<CategoryDetail>>($"{Config.ApiUrl}/api/services/app/Category/Create", categoryDetail);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }

        public async Task<EntityResult<CategoryDetail>> UpdateAsync(CategoryDetail categoryDetail)
        {
            EntityResult<CategoryDetail> result = new EntityResult<CategoryDetail>();
            try
            {
                result = await httpClient.PutJsonAsync<EntityResult<CategoryDetail>>($"{Config.ApiUrl}/api/services/app/Category/Update", categoryDetail);
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Error = ex.Message;
            }
            return result;
        }
    }
}
