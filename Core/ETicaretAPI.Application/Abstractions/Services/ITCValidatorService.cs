using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Abstractions.Services
{
    public interface ITCValidatorService
    {
        Task<bool> Verify(long TCKimlikNo, string Ad, string Soyad, int DogumYili);
    }
}
