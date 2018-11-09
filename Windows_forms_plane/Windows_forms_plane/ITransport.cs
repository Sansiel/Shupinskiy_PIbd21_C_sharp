using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Windows_forms_plane
{
    public interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);
        void MoveTransport(Direction direction);
        void DrawPlane(Graphics g);
        void SetMainColor(Color color);
    }
}
