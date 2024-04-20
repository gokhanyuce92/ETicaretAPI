using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Application.Features.Queries.TCValidator;
using KPSPublicServiceReference;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Infrastructure.Services
{
    public class TCValidatorService : ITCValidatorService
    {
        public async Task<bool> Verify(long TCKimlikNo, string Ad, string Soyad, int DogumYili)
        {
            using (var svc = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap))
            {
                var cmd = await svc.TCKimlikNoDogrulaAsync(TCKimlikNo, Ad, Soyad, DogumYili);

                return cmd.Body.TCKimlikNoDogrulaResult;
            }
        }
    }
}
