using System.Drawing;
using System.Windows.Forms;

namespace GGTech.QuanLyCoSoGietMo._1.Common
{
    public class GGTechMsg
    {
        private static GGTechMsg instance; // Ctrl + R + E

        public static GGTechMsg Instance
        {
            get
            {
                if (instance == null)
                    instance = new GGTechMsg();
                return GGTechMsg.instance;
            }
            private set { GGTechMsg.instance = value; }
        }

        public void Red(Label label, string msg)
        {
            label.ForeColor = Color.White;
            label.BackColor = Color.Red;
            label.Text = msg;
        }

        public void Green(Label label, string msg)
        {
            label.ForeColor = Color.White;
            label.BackColor = Color.Green;
            label.Text = msg;
        }
    }
}