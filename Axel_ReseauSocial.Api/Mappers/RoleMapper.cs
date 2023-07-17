using Axel_ReseauSocial.Api.Dtos;
using Axel_ReseauSocial.Api.Models;

namespace Axel_ReseauSocial.Api.Mappers
{
    static internal class RoleMapper
    {
        internal static RoleDto ToRoleDto(this Role role)
        {
            return new RoleDto()
            {
                IdRole = role.IdRole,
                Denomination = role.Denomination,
            };
        }
        internal static IEnumerable<RoleDto> ToRoleDto(this IEnumerable<Role> roles)
        {
            List<RoleDto> result = new List<RoleDto>();
            foreach (Role role in roles)
            {
                result.Add(role.ToRoleDto());
            }
            return result;
        }
    }
}
