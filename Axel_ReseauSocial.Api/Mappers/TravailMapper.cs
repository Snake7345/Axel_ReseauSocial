using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class TravailMapper
    {
        internal static TravailDto ToTravailDto(this Travail travail)
        {
            return new TravailDto()
            {
                IdTravail = travail.IdTravail,
                Denomination = travail.Denomination,
            };
        }
        internal static IEnumerable<TravailDto> ToTravailDto(this IEnumerable<Travail> travails)
        {
            List<TravailDto> result = new List<TravailDto>();
            foreach (Travail travail in travails)
            {
                result.Add(travail.ToTravailDto());
            }
            return result;
        }
    }
}
