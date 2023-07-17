using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class LocaliteMapper
    {
        internal static LocaliteDto ToLocaliteDto(this Localite localite)
        {
            return new LocaliteDto()
            {
                IdLocalite = localite.IdLocalite,
                CP = localite.CP,
                Longitude = localite.Longitude,
                Latitude = localite.Latitude,
                Ville = localite.Ville
            };
        }
        internal static IEnumerable<LocaliteDto> ToLocaliteDto(this IEnumerable<Localite> localites)
        {
            List<LocaliteDto> result = new List<LocaliteDto>();
            foreach (Localite localite in localites)
            {
                result.Add(localite.ToLocaliteDto());
            }
            return result;
        }
    }
}
