using System.Collections;
using System.Collections.Generic;

namespace ASPNETCoreMVC_PS.Models
{
    public interface IPieRepository
    {
        IEnumerable<Pie> GetAllPies();
        Pie GetPieById(int pieId);
    }
}