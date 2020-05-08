using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AbstractDPApplication
{
    class PhotoChange
    {
        public void degistir(int sayac)
        {
            if (Form1.gozluk.Checked)
            {
                if (sayac >= 2)
                {
                    sayac = 2;
                }
                switch (sayac)
                {
                    case 1:
                        Form1.pictureBox.Image = Properties.Resources.gozluk1;
                        break;
                    case 2:
                        Form1.pictureBox.Image = Properties.Resources.gozluk2;
                        break;
                }
            }

            if (Form1.palet.Checked)
            {
                switch (sayac)
                {
                    case 1:
                        Form1.pictureBox.Image = Properties.Resources.palet1;
                        break;
                    case 2:
                        Form1.pictureBox.Image = Properties.Resources.palet2;
                        break;
                    case 3:
                        Form1.pictureBox.Image = Properties.Resources.palet3;
                        break;
                }
            }

            if (Form1.snorkel.Checked)
            {
                switch (sayac)
                {
                    case 1:
                        Form1.pictureBox.Image = Properties.Resources.snorkel1;
                        break;
                    case 2:
                        Form1.pictureBox.Image = Properties.Resources.snorkel2;
                        break;
                    case 3:
                        Form1.pictureBox.Image = Properties.Resources.snorkel3;
                        break;
                }
            }

            if (Form1.bone.Checked)
            {
                switch (sayac)
                {
                    case 1:
                        Form1.pictureBox.Image = Properties.Resources.bone1;
                        break;
                    case 2:
                        Form1.pictureBox.Image = Properties.Resources.bone2;
                        break;
                    case 3:
                        Form1.pictureBox.Image = Properties.Resources.bone3;
                        break;
                }
            }
        }
    }
}
