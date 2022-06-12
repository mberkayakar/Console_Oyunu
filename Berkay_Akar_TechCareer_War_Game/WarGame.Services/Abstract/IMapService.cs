using System.Collections.Generic;
using WarGame.Core.Abstract;
using WarGame.Core.Concrete;
using WarGame.Entities.Concrete;

namespace WarGame.Services.Abstract
{
    public interface IMapService
    {
        void SavasaBasla(User user, MapRepository map);

        MapRepository GetMapİnformation(MapRepository Map);
        
    }
}
