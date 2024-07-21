
using webapi.Models;

namespace webapi.Repository.Interfaces
{
    public interface IEnviroment
    {
        public Task<EnviromentModel> CreateEnviromentState(float temperature, float humidity);
    }

}