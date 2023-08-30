using Axel_ReseauSocial.Api.Domains.Commands.Amities;
using Axel_ReseauSocial.Api.Domains.Queries.Amities;
using Axel_ReseauSocial.Api.Models;
using Tools.Cqs.Commands;
using Tools.Cqs.Queries;

namespace Axel_ReseauSocial.Api.Domains.Repositories
{
    public interface IAmitieRepository : IQueryHandler<GetAllAmitiesQuery, IEnumerable<Amitie>>,
        IQueryHandler<GetOneAmitieQuery, Amitie?>,
        ICommandHandler<CreateAmitieCommand>,
        ICommandHandler<DeleteAmitieCommand>
    {
    }
}
