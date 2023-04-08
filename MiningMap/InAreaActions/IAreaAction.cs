using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MiningMap
{
    /// <summary>
    /// Интерфейс для классов, совершающих какое дибо действие при заеде маркера в выделенную область
    /// </summary>
    public interface IAreaAction
    {
        /// <summary>
        /// Выполнить какое-либо действие (возможно с маркером)
        /// </summary>
        /// <param name="gMapMarker">Маркер, перемещение которого вызвало совершение даного действия</param>
        void DoAction(GMarkerGoogle gMapMarker, GMapControl gMapControl);
    }
}
