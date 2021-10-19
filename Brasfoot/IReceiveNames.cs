using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Brasfoot
{
    public interface IReceiveNames
    {
        [Get("/portuguese-brazil/male")]
        Task<Squad> GetAdressAsync();
    }
}
