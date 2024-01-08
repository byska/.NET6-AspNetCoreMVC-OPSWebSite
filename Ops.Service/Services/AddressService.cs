using Ops.Core.Entities;
using Ops.Core.Services;
using Ops.Core.VMs.Create;
using Ops.Core.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ops.Core.UnitOfWorks;
using AutoMapper;
using RestSharp;
using Newtonsoft.Json;

namespace Ops.Service.Services
{
    public class AddressService : Service<Address, AddressCreateVM, AddressVM>, IAddressService
    {
        public AddressService(IUnitOfWork uow, IMapper mapper) : base(uow, mapper)
        {
        }

        public async Task<List<City>> GetCities()
        {
            var url = "https://turkiyeapi.dev";
            var client = new RestClient(url);
            var request =new RestRequest("/api/v1/provinces", Method.Get);
            RestResponse response = await client.ExecuteAsync(request);
           
            if(response.IsSuccessful)
            {
                var jsonData = JsonConvert.DeserializeObject<RootObject>(response.Content);
                if(jsonData != null && jsonData.Status=="OK")
                {
                    return jsonData.Data;
                  
                }
                else
                {
                    Console.WriteLine("API'den geçerli veri alınamadı.");
                    return null;
                }
               
            }
            else
            {
                Console.WriteLine("Hata: " + response.ErrorMessage);
                return null;
            }

        }

    public Task<List<string>> GetCountries(int id)
    {
        throw new NotImplementedException();
    }
}
}
