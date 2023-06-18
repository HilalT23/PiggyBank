using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace piggybank {
    public partial class Form1 : Form {
        Kumbara kumbara = new Kumbara();
        double fazlaHacimRandom = 0;
        double fazlaHacim25 = 0;
        bool isFirst = false;
        public Form1() {
            InitializeComponent();
            kumbara.MaxHacim = 1000;
            lblH.Text = kumbara.MaxHacim.ToString("N6");
        }
        //public static List<Kumbara> yenieklenenpara = new List<Kumbara>();
        //public static List<Kumbara> mevcutpara = new List<Kumbara>();

        public static List<Para> parasBanknot = new List<Para>() {
            new Para { ParaAdi= "beş tl", ParaMiktarı =5 },
            new Para { ParaAdi= "on tl", ParaMiktarı = 10},
            new Para { ParaAdi= "yirmi tl", ParaMiktarı =20},
            new Para { ParaAdi= "elli tl", ParaMiktarı =50},
            new Para { ParaAdi= "yüz tl", ParaMiktarı =100},
            new Para { ParaAdi= "iki yüz tl", ParaMiktarı =200},
        };
        public static List<Para> parasMadeni = new List<Para>()
        {
            new Para { ParaAdi= "bir kuruş", ParaMiktarı =0.01 },
            new Para { ParaAdi= "beş kuruş", ParaMiktarı =0.05},
            new Para { ParaAdi= "on kuruş", ParaMiktarı =0.1 },
            new Para { ParaAdi= "yirmi beş kuruş", ParaMiktarı =0.25 },
            new Para { ParaAdi= "elli kuruş", ParaMiktarı =0.5 },
            new Para { ParaAdi= "bir tl", ParaMiktarı =1},
        };
        public Dictionary<double, (double, double, double)> Banknot = new Dictionary<double, (double, double, double)>
        {
                  { 5.00, (64, 130, 0.25) },
                  { 10.00, (64, 136, 0.25) },
                  { 20.00, (68, 142, 0.25) },
                  { 50.00, (68, 148, 0.25) },
                  { 100.00, (72, 154, 0.25) },
                  { 200.00, (72, 160, 0.25) }
        };
        public Dictionary<double, (double, double)> Coin = new Dictionary<double, (double, double)>
        {
                  {0.01, (16.50,0.25)},
                  {0.05, (17.50,0.25)},
                  {0.10, (18.50,0.25)},
                  {0.25, (20.50,0.25)},
                  {0.50, (23.85,0.25)},
                  {1.00, (26.15,0.25)},
        };
        private void btnKır_Click( object sender, EventArgs e ) {

            if ( !kumbara.isBroken ) {
                kumbara.isBroken = true;
                txtTotal.Text = kumbara.toplamPara.ToString( "n2" );
                kumbara.toplamPara = 0;
                kumbara.CurrentHacim = 0;
            }
            else {
                throw new Kumbara.PiggyBankException( "Kumbara Daha Önce Kırılmış" );
            }

        }

        private void btnParaekle_Click( object sender, EventArgs e ) {
            try {
                if ( !kumbara.isBroken ) {
                    double degerHacim = 0;
                    Kumbara yenipara = new Kumbara();
                    if ( ( Para )comboBox1.SelectedItem != null ) {
                        yenipara.SeciliPara = ( Para )comboBox1.SelectedItem;


                        double rast = Random();
                        kumbara.CurrentHacim += rast;
                        fazlaHacimRandom += rast;
                        if ( rast > 0.25 ) {
                            fazlaHacim25 = rast - 0.25;
                        }
                        //Coin
                        foreach ( var item in Coin ) {
                            double deger = item.Key;
                            double radius = item.Value.Item1;
                            double height = item.Value.Item2;
                            double pi = 3.14;
                            if ( deger == yenipara.SeciliPara.ParaMiktarı ) {
                                degerHacim = ( radius * radius ) * height * pi;
                            }
                        }
                        //banknot
                        foreach ( var item in Banknot ) {
                            double deger = item.Key;
                            double boy = item.Value.Item1;
                            double en = item.Value.Item2;
                            double yükseklik = item.Value.Item2;
                            if ( deger == yenipara.SeciliPara.ParaMiktarı ) {
                                degerHacim = boy * ( en * 0.25 ) * ( yükseklik * 4 );
                            }
                        }
                        double hesaplananHacim = degerHacim * 0.00001;
                        if ( kumbara.MaxHacim <= kumbara.CurrentHacim + hesaplananHacim ) {
                            throw new Kumbara.PiggyBankException( "Kumbara Doldu." );
                        }
                        else {
                            kumbara.SeciliPara = yenipara.SeciliPara;
                            kumbara.Hesapla();
                            kumbara.CurrentHacim += hesaplananHacim;
                            lblKMH.Text = kumbara.CurrentHacim.ToString( "N6" );
                            MessageBox.Show( "para eklendi" );
                            isFirst = true;
                        }
                    }
                    else {
                        MessageBox.Show( "Para Seçmediniz." );
                    }
                }
                else {
                    MessageBox.Show( "Kumbara Kırık. Para Ekleyemezsiniz." );
                }
            }
            catch ( Kumbara.PiggyBankException ) {
                throw;
            }
        }
        public double Random() {
            Random random = new Random();
            double rast = ( double )random.Next( 25, 75 ) / 100;
            return rast;
        }
        private void Shake( object sender, EventArgs e ) {
            if ( isFirst ) {
                kumbara.CurrentHacim -= fazlaHacim25;
                lblKMH.Text = kumbara.CurrentHacim.ToString( "N6" ); 
                isFirst = false;
            }
            else {
                MessageBox.Show( "Kumbaraya Yeni Bir Para Eklenmedi." );
            }
        }

        private void KumbarayıYapıstir( object sender, EventArgs e ) {
            if ( kumbara.KırılmaSayısı < 1 ) {
                kumbara.Repair(); 
            }
            else {
                throw new Kumbara.PiggyBankException( "Kumbara 2 kez yapıştırılamaz." );
            }
            txtTotal.Clear();
            MessageBox.Show( "Kumbara Yapıştırıldı. Artık Para Ekleyebilirsiniz." );
        }
        private void rbBanknot_CheckedChanged( object sender, EventArgs e ) {
            RadioButton rb = sender as RadioButton;
            if ( rb.Checked ) {
                comboBox1.Items.AddRange( parasBanknot.ToArray() );
            }
            else {
                comboBox1.Items.Clear();
            }
        }

        private void rbMadeni_CheckedChanged( object sender, EventArgs e ) {
            RadioButton rb = sender as RadioButton;
            if ( rb.Checked ) {
                comboBox1.Items.AddRange( parasMadeni.ToArray() );
            }
            else {
                comboBox1.Items.Clear();
            }
        }
    }
}
