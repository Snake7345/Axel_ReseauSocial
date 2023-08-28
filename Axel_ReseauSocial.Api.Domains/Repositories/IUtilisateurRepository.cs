using Axel_ReseauSocial.Api.Domains.Commands.Utilisateurs;
using Axel_ReseauSocial.Api.Domains.Queries.Utilisateurs;
using Axel_ReseauSocial.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Repositories
{
    public interface IUtilisateurRepository : ICommandHandler<RegisterUtilisateurCommand>,
        IQueryHandler<GetAllUtilisateursQuery,IEnumerable<Utilisateur>>,
        IQueryHandler<GetOneUtilisateurQuery,Utilisateur?>,
        IQueryHandler<GetUtilisateurByEmailAndPasswordQuery, Utilisateur?>,
        IQueryHandler<GetGenderCountQuery, IEnumerable<GenderCount>>,
        ICommandHandler<UpdateUtilisateurCommand>
    {
    }
}
