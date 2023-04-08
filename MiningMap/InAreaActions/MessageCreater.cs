using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Text;
using System.Windows.Forms;

namespace MiningMap
{
    /// <summary>
    /// Класс, создающий диалоговое окно при попадании маркера в особую зону
    /// </summary>
    public class MessageCreater : IAreaAction
    {
        public void DoAction(GMarkerGoogle gMapMarker, GMapControl gMapControl)
        {
            var builder = new StringBuilder(64);
            builder.Append("Маркер, отвечающий за отображение следующей единицы техники '");
            builder.Append(gMapMarker.ToolTipText).Append(", ID ").Append(gMapMarker.Tag);
            builder.Append("' переместился в особую (выделенную зону)");
            MessageBox.Show(builder.ToString(), "Заезд маркера в особую зону", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
