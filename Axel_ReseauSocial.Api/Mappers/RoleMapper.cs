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

        internal static UpdateRoleDto ToUpdateRoleDto(this Role role)
        {
            return new UpdateRoleDto()
            {
                Denomination = role.Denomination,
            };
        }

        internal static IEnumerable<UpdateRoleDto> ToUpdateRoleDto(this IEnumerable<Role> roles)
        {
            List<UpdateRoleDto> result = new List<UpdateRoleDto>();
            foreach (Role role in roles)
            {
                result.Add(role.ToUpdateRoleDto());
            }
            return result;
        }
    }
}
