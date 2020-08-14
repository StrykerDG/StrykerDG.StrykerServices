using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace StrykerDG.StrykerServices.Interfaces
{
    public interface IStrykerService
    {
        Task<StrykerServiceResponse> Get(string endpoint);
        Task<StrykerServiceResponse> Post(string endpoint, object payload);
        Task<StrykerServiceResponse> Patch(string endpoint, object payload);
        Task<StrykerServiceResponse> Delete(string endpoint, object payload);
    }
}
