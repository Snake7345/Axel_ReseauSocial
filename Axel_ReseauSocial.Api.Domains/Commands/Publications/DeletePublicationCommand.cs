using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools.Cqs.Commands;

namespace Axel_ReseauSocial.Api.Domains.Commands.Publications
{
    public class DeletePublicationCommand : ICommand
    {
        public Guid IdPublication { get; init; }

        public DeletePublicationCommand(Guid idPublication)
        {
            IdPublication = idPublication;
        }
    }
}
