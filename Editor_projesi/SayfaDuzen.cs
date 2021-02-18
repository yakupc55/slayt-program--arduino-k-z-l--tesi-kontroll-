using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Editor_projesi
{
    class SayfaDuzen
    {
        public SayfaDuzen()
        {

        }
        public Bitmap SayfaResmiDondur(int Sayfa_id)
        {
            Bitmap resim = new Bitmap(144, 96);
            Graphics gh = Graphics.FromImage(resim);
            Color color = Color.FromArgb(200, 200, 200);
            Color color2 = Color.FromArgb(0,0,0);
            gh.Clear(color);
            Font yazi = new Font("Georgia", 18, FontStyle.Italic);
            Brush firca = new SolidBrush(color2);
            gh.DrawString(Sayfa_id.ToString(), yazi, firca, new Point(0, 0));
            return resim;
        }
    }
}
