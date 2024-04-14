using ETicaretAPI.Application.Abstractions.Services;
using MediatR;
using KPSPublicServiceReference;

namespace ETicaretAPI.Application.Features.Queries.TCValidator
{
    public class TCValidatorQueryHandler : IRequestHandler<TCValidatorQueryRequest, TCValidatorQueryResponse>
    {   
        private readonly ITCValidatorService _validatorService;
        public TCValidatorQueryHandler(ITCValidatorService validatorService)
        {
            _validatorService = validatorService;
        }

        public async Task<TCValidatorQueryResponse> Handle(TCValidatorQueryRequest request, CancellationToken cancellationToken)
        {
            var response = await _validatorService.Verify(request.TCKimlikNo, request.Ad, request.Soyad, request.DogumYili);
            return new TCValidatorQueryResponse { TCKimlikNoDogrulaResult = response };
        }
    }
}
