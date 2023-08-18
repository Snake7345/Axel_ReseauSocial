using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axel_ReseauSocial.Api.Domains.Commands.Amities
{
    public class DeleteAmitieCommand
    {
        public Guid IdAmitie { get; init; }

        public DeleteAmitieCommand(Guid idAmitie)
        {
            IdAmitie = idAmitie;
        }
    }
}
