using ETicaretAPI.Application.Features.Queries.TCValidator;
using MediatR;

namespace ETicaretAPI.Application.Features.Queries.TCValidator
{
    public class TCValidatorQueryRequest : IRequest<TCValidatorQueryResponse>
    {
        public long TCKimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
    }
}