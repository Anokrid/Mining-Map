using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiningMap
{
    /// <summary>
    /// Класс, создающий маркер в случайном месте видимой области карты
    /// </summary>
    public class RandomMarkerCreator : IAreaAction
    {
        public void DoAction(GMarkerGoogle gMapMarker, GMapControl gMapControl)
        {
            var topLeft = gMapControl.FromLocalToLatLng(0, 0);
            var botRight = gMapControl.FromLocalToLatLng(gMapControl.Width, gMapControl.Height);

            /// Если бы пришлось сохранять новый маркер в БД, то имело бы смысл присвоить ему уникальный Id
            /// Так как такой задачи не стояло, поэтому Id присваивается просто так, чтобы маркеры не путались
            int freeMachinaryId = 0;
            for (int i = 0; i < gMapControl.Overlays[1].Markers.Count; i++)
            {
                int id = (int)gMapControl.Overlays[1].Markers[i].Tag;
                freeMachinaryId = Math.Max(freeMachinaryId, id);
            }
            freeMachinaryId++;

            GMarkerGoogle newMarker = MarkerCreator.CreateMarkerAtRandomSpot(topLeft, botRight, freeMachinaryId);
            gMapControl.Overlays[1].Markers.Add(newMarker);
            gMapControl.Update();
        }
    }
}
