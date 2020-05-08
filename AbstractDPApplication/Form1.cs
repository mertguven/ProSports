using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace AbstractDPApplication
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public Form1()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
        }
        int sayac = 1;
        Bitmap foto;
        public static PictureBox pictureBox;
        public static RadioButton gozluk;
        public static RadioButton palet;
        public static RadioButton snorkel;
        public static RadioButton bone;


        private void bunifuFlatButton1_Click(object sender, System.EventArgs e)
        {
            if (gozlukRBtn.Checked || paletRBtn.Checked || snorkelRBtn.Checked || boneRBtn.Checked)
            {
                leftBtn.Visible = true;
                rightBtn.Visible = true;
            }
            if (gozlukRBtn.Checked)
            {
                foto = Properties.Resources.gozluk1;
                Factory factory = new Factory(new GozlukFactory());
                listele(factory, foto);
            }
            if (paletRBtn.Checked)
            {
                foto = Properties.Resources.palet1;
                Factory factory = new Factory(new PaletFactory());
                listele(factory, foto);
            }
            if (snorkelRBtn.Checked)
            {
                foto = Properties.Resources.snorkel1;
                Factory factory = new Factory(new SnorkelFactory());
                listele(factory, foto);
            }
            if (boneRBtn.Checked)
            {
                foto = Properties.Resources.bone1;
                Factory factory = new Factory(new BoneFactory());
                listele(factory, foto);
            }
        }
        public void listele(Factory factory, Bitmap foto)
        {
            pictureBox1.Image = foto;
            urunTxt.Text = factory.Start().UrunAd();
            markaTxt.Text = factory.Start().Marka();
            modelTxt.Text = factory.Start().Model();
            if (factory.Start().Profesyonel() == true)
            {
                profesyonelTxt.Text = "S+";
            }
            else
            {
                profesyonelTxt.Text = "B-";
            }
            menseiTxt.Text = factory.Start().Mensei();
            fiyatTxt.Text = factory.Start().Fiyat().ToString() + " TL";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rightBtn_Click(object sender, EventArgs e)
        {
            sayac++;
            if (sayac >= 3)
            {
                sayac = 3;
            }
            PhotoChange pht = new PhotoChange();
            if (gozlukRBtn.Checked)
            {
                pht.degistir(sayac);
            }
            if (paletRBtn.Checked)
            {
                pht.degistir(sayac);
            }
            if (snorkelRBtn.Checked)
            {
                pht.degistir(sayac);
            }
            if (boneRBtn.Checked)
            {
                pht.degistir(sayac);
            }
        }

        private void leftBtn_Click(object sender, EventArgs e)
        {
            sayac--;
            if (sayac <= 0)
            {
                sayac = 0;
            }
            PhotoChange pht = new PhotoChange();
            if (gozlukRBtn.Checked)
            {
                pht.degistir(sayac);
            }
            if (paletRBtn.Checked)
            {
                pht.degistir(sayac);
            }
            if (snorkelRBtn.Checked)
            {
                pht.degistir(sayac);
            }
            if (boneRBtn.Checked)
            {
                pht.degistir(sayac);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox = pictureBox1;
            gozluk = gozlukRBtn;
            palet = paletRBtn;
            snorkel = snorkelRBtn;
            bone = boneRBtn;
            leftBtn.Visible = false;
            rightBtn.Visible = false;
        }
    }
}
