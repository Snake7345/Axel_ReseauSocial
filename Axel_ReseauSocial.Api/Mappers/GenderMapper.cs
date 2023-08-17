using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class GenderMapper
    {
        internal static GenderCountDto ToGenderCountDto(this GenderCount genderCount)
        {
            return new GenderCountDto()
            {
                Sexe = genderCount.Sexe,
                Count = genderCount.Count,
            };
        }
        internal static IEnumerable<GenderCountDto> ToGenderCountDto(this IEnumerable<GenderCount> gendercounts)
        {
            List<GenderCountDto> result = new List<GenderCountDto>();
            foreach (GenderCount gendercount in gendercounts)
            {
                result.Add(gendercount.ToGenderCountDto());
            }
            return result;
        }
    }
}
