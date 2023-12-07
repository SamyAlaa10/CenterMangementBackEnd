using CenterMangement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Services
{
    public interface ITokenService
    {
        string CreateTokenAsync(User user);
    }
}
