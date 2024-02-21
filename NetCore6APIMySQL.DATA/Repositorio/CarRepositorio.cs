using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore6APIMySQL.Data.repositorio
{
    public interface CarRepositorio
    {
        Task<Ienumerable><Car>> Getallcars();

    }

}
