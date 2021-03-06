﻿using System;
using System.Threading.Tasks;
using BasicDomainService.ExternalService.Abstraction;
using BasicDomainService.ExternalService.Connectivity;
using BasicDomainService.ExternalService.Models;

namespace BasicDomainService.ExternalService.Clients
{
    public class FixerClient : ICurrencyClient
    {
        private readonly IApiClient _apiClient;

        public FixerClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public Task<CurrencyModel> GetCurrencyAsync(string currencyIsoName, DateTime dateTimeSnapshot)
        {
            var endpoint = $"{dateTimeSnapshot:yyyy-MM-dd}?base={currencyIsoName}";
            return _apiClient.GetModelAsync<CurrencyModel>(endpoint);
        }
    }
}