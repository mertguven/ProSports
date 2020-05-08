namespace AbstractDPApplication
{
    public abstract class Urun
    {
        public abstract int Fiyat();
        public abstract string UrunAd();
        public abstract bool Profesyonel();
        public abstract string Marka();
        public abstract string Mensei();
        public abstract string Model();
    }
    public class Bone : Urun
    {
        public override int Fiyat()
        {
            return 190;
        }

        public override string Marka()
        {
            return "SPEEDO";
        }

        public override string Mensei()
        {
            return "AVUSTRALYA";
        }

        public override string Model()
        {
            return "FASTSKIN 3";
        }

        public override bool Profesyonel()
        {
            return true;
        }

        public override string UrunAd()
        {
            return "BONE";
        }
    }
    public class Snorkel : Urun
    {
        public override int Fiyat()
        {
            return 140;
        }

        public override string Marka()
        {
            return "NAINJI";
        }

        public override string Mensei()
        {
            return "LILLE,FRANSA";
        }

        public override string Model()
        {
            return "EASYBREATH 500";
        }

        public override bool Profesyonel()
        {
            return false;
        }

        public override string UrunAd()
        {
            return "ŞNORKEL";
        }
    }
    public class Palet : Urun
    {
        public override int Fiyat()
        {
            return 50;
        }

        public override string Marka()
        {
            return "SUBEA";
        }

        public override string Mensei()
        {
            return "TURKIYE";
        }

        public override string Model()
        {
            return "SNK 500";
        }

        public override bool Profesyonel()
        {
            return false;
        }

        public override string UrunAd()
        {
            return "PALET";
        }
    }
    public class Gozluk : Urun
    {
        public override int Fiyat()
        {
            return 554;
        }

        public override string Marka()
        {
            return "SPEEDO";
        }

        public override string Mensei()
        {
            return "AVUSTRALYA";
        }

        public override string Model()
        {
            return "Virtue Mirror";
        }

        public override bool Profesyonel()
        {
            return true;
        }

        public override string UrunAd()
        {
            return "GÖZLÜK";
        }
    }

    public abstract class UrunFactory
    {
        public abstract Urun CreateUrun();
    }
    public class GozlukFactory : UrunFactory
    {
        public override Urun CreateUrun()
        {
            return new Gozluk();
        }
    }
    public class PaletFactory : UrunFactory
    {
        public override Urun CreateUrun()
        {
            return new Palet();
        }
    }
    public class SnorkelFactory : UrunFactory
    {
        public override Urun CreateUrun()
        {
            return new Snorkel();
        }
    }
    public class BoneFactory : UrunFactory
    {
        public override Urun CreateUrun()
        {
            return new Bone();
        }
    }
    public class Factory
    {
        private UrunFactory _urunFactory;
        private Urun _urun;

        public Factory(UrunFactory urunFactory)
        {
            _urunFactory = urunFactory;
            _urun = urunFactory.CreateUrun();
        }
        public Urun Start()
        {
            _urun.Marka();
            _urun.Model();
            _urun.Profesyonel();
            _urun.Mensei();
            _urun.Fiyat();
            return _urun;
        }
    }
}
