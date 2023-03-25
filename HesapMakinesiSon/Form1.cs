using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


//PROJE HAKKINDA GENEL DURUM YAZISI

//Standar hesap makinesi ve bilimsel hesap makinesinin çoğunluğunu yaptım,sol üst kısımdaki menü butonunu yaptım.
//TreeView ve paneller kullanarak seçeneklerin açılmasını sağladım.
//Dönüşümler kısmında BASINÇ kısmını tam anlamıyla yaptım ve %90 oranında çalışıyor.
//Daha fazla vakit ayırabilsem grafik oluşturma ve programlayıcı kısmı hariç geri kalanların hepsini yapabileceğimi düşünüyorum.
//Proje beni oldukça geliştirdi.

namespace HesapMakinesiSon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool operatorDurum = false; 
        double sonuc = 0;
        string opt = "";

        //Hesap makinesinde paneller kullandım. İlk olarak bu panelleri false yaptım. Ayrıca txt değerlerini de 0 yaptım.
        private void Form1_Load(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            txtBasinc1.Text = "0";
            txtBasinc2.Text = "0";
            txtAci1.Text = "0";
            treeViewBasinc1.Visible = false;
            treeViewBasinc2.Visible = false;
            treeViewAci1.Visible = false;
            treeViewAci2.Visible = false;
            treeView1.Visible = false;
            pnlBilimsel.Visible = false;
            pnlGrafik.Visible = false;
            pnlProgramlayıcı.Visible = false;
            pnlTarihHesaplama.Visible = false;
            pnlParaBirimi.Visible = false;
            pnlHacim.Visible = false;
            pnlUzunluk.Visible = false;
            pnlAgirlik.Visible = false;
            pnlSicaklik.Visible = false;
            pnlEnerji.Visible = false;
            pnlAlan.Visible = false;
            pnlHiz.Visible = false;
            pnlZaman.Visible = false;
            pnlGuc.Visible = false;
            pnlVeri.Visible = false;
            pnlBasinc.Visible = false;
            pnlAci.Visible = false;
        }
        //sol kısımda çıkan menünün açılıp kapanmasını sağladım
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (treeView1.Visible == true)
            {
                treeView1.Visible = false;
            }
            if (treeView1.Visible == false)
            {
                treeView1.Visible = true;
            }

        }
        //Sol üst kısımdan seçtiğim seçeneklerin açılıp kapanmasını sağladım
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "standart")
            {
                lblModlar.Text = "Standart";
                treeView1.Visible = false;
                pnlStandart.Visible = true;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "bilimsel")
            {
                lblModlar.Text = "Bilimsel";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = true;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "grafikOluşturucu")
            {
                lblModlar.Text = "Grafik Oluşturma";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = true;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "programlayici")
            {
                lblModlar.Text = "Programlayıcı";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = true;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "tarihHesaplama")
            {
                lblModlar.Text = "Tarih Hesaplama";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = true;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "paraBirimi")
            {
                lblModlar.Text = "Para Birimi";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = true;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "hacim")
            {
                lblModlar.Text = "Hacim";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = true;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "uzunluk")
            {
                lblModlar.Text = "Uzunluk";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = true;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "agirlikVeKutle")
            {
                lblModlar.Text = "Ağırlık ve Kütle";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = true;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "sicaklik")
            {
                lblModlar.Text = "Sıcaklık";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = true;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "enerji")
            {
                lblModlar.Text = "Enerji";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = true;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "alan")
            {
                lblModlar.Text = "Alan";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = true;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "hiz")
            {
                lblModlar.Text = "Hız";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = true;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "zaman")
            {
                lblModlar.Text = "Zaman";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = true;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "guc")
            {
                lblModlar.Text = "Güç";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = true;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "veri")
            {
                lblModlar.Text = "Veri";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = true;
                pnlBasinc.Visible = false;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "basinc")
            {
                lblModlar.Text = "Basınç";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = true;
                pnlAci.Visible = false;
            }
            if (e.Node.Name == "aci")
            {
                lblModlar.Text = "Açı";
                treeView1.Visible = false;
                pnlStandart.Visible = false;
                pnlBilimsel.Visible = false;
                pnlGrafik.Visible = false;
                pnlProgramlayıcı.Visible = false;
                pnlTarihHesaplama.Visible = false;
                pnlParaBirimi.Visible = false;
                pnlHacim.Visible = false;
                pnlUzunluk.Visible = false;
                pnlAgirlik.Visible = false;
                pnlSicaklik.Visible = false;
                pnlEnerji.Visible = false;
                pnlAlan.Visible = false;
                pnlHiz.Visible = false;
                pnlZaman.Visible = false;
                pnlGuc.Visible = false;
                pnlVeri.Visible = false;
                pnlBasinc.Visible = false;
                pnlAci.Visible = true;
            }
        }
        //STANDART HESAP MAKİNESİ BAŞLANGIÇ


        //Tüm rakamları ctrl ile seçip click olayına girdim.
        private void RakamClick(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0" || operatorDurum == true)
            {
                txtSonuc.Clear();
            }
            operatorDurum = false;
            Button btn = (Button)sender;
            txtSonuc.Text = txtSonuc.Text + btn.Text;

        }


        //Operatör işlemlerini(+,-,*,/) ctrl ile seçip click olayına kodumu yazdım
        private void Operatorİslem(object sender, EventArgs e)
        {
            operatorDurum = true;
            Button btn = (Button)sender;
            string yeniOptBilgisi = btn.Text;

            lbSonuc.Text = lbSonuc.Text + " " + txtSonuc.Text + " " + yeniOptBilgisi;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;

            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = yeniOptBilgisi;
        }

        private void btnCStandart_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
        }

        private void btnCEStandart_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";
            lbSonuc.Text = "";
            opt = "0";
            sonuc = 0;
            operatorDurum = false;
        }

        private void btnEsitStandart_Click(object sender, EventArgs e)
        {
            lbSonuc.Text = " ";
            operatorDurum = true;
            switch (opt)
            {
                case "+": txtSonuc.Text = (sonuc + double.Parse(txtSonuc.Text)).ToString(); break;
                case "-": txtSonuc.Text = (sonuc - double.Parse(txtSonuc.Text)).ToString(); break;
                case "/": txtSonuc.Text = (sonuc / double.Parse(txtSonuc.Text)).ToString(); break;
                case "*": txtSonuc.Text = (sonuc * double.Parse(txtSonuc.Text)).ToString(); break;

            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtSonuc.Text = sonuc.ToString();
            opt = "";

        }

        private void btnVirgulStandart_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = "0";
            }
            else if (operatorDurum == true)
            {
                txtSonuc.Text = "0";
            }

            if (!txtSonuc.Text.Contains(","))
            {
                txtSonuc.Text = txtSonuc.Text + ",";
            }
            operatorDurum = false;
        }

        private void btnKareStandart_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            sayi = sayi * sayi;
            txtSonuc.Text = Convert.ToString(sayi);
        }

        private void btnKokStandart_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            sayi = Math.Sqrt(sayi);
            txtSonuc.Text = Convert.ToString(sayi);
        }

        private void btnBirBoluXStandart_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtSonuc.Text);
            sayi = 1 / (sayi);
            txtSonuc.Text = Convert.ToString(sayi);
        }

        //Sil butonunda farklı durumlar için veya ile eklemeler yaptım.
        private void btnSilStandart_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtSonuc.Text) != 0 || txtSonuc.Text == "0," || txtSonuc.Text == "-0," || txtSonuc.Text.Length != 1)
            {
                txtSonuc.Text = txtSonuc.Text.Remove(txtSonuc.Text.Length - 1, 1);
                if (txtSonuc.Text.Length == 0 || txtSonuc.Text == "0," || txtSonuc.Text == "-" || txtSonuc.Text == "-0," || txtSonuc.Text == "-0")
                {
                    txtSonuc.Text = "0";
                }
            }
        }

        //Mutlak kısmında farklı durumlar için birden fazla if kullandım.
        private void btnMutlakStandart_Click(object sender, EventArgs e)
        {
            double sonDeger = Convert.ToDouble(txtSonuc.Text);
            if (sonDeger > 0)
            {
                sonDeger = -1 * sonDeger;
                txtSonuc.Text = Convert.ToString(sonDeger);
            }
            else if (sonDeger < 0)
            {
                sonDeger = -1 * sonDeger;
                txtSonuc.Text = Convert.ToString(sonDeger);
            }


            if (txtSonuc.Text == "-0,")
            {
                txtSonuc.Text = "0,";
            }
            else if (txtSonuc.Text == "0,")
            {
                txtSonuc.Text = "-" + txtSonuc.Text;
            }
        }
        //STANDART HESAP MAKİNESİ BİTİŞ

        //BASINÇ GİRİŞ
        private void rakamClickBasinc(object sender, EventArgs e)
        {
            if (txtBasinc1.Text == "0")
            {
                txtBasinc1.Clear();
            }
            
            Button btn = (Button)sender;
            txtBasinc1.Text = txtBasinc1.Text + btn.Text; 

            if(lblBasinc1.Text == "Atmosfer" )
            {
                if(lblBasinc2.Text == "Atmosfer")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 1.01325 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }if(lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 101.325 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 760.1275 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 101.325 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 14.69595 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Bar")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.986923 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 100 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 750.1875 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 100.000 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 14.50377 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Kilopascal")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.009869 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.01 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 7.501875 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 1000 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 0.145038 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Milimetre cıva")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.001316 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.001333 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 0.1333 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 133.3 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 0.019334 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Pascal")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.00001 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.00001 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 0.001 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 0.007502 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 0.000145 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Libre/inçkare")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.068046 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.068948 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 6.894757 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 51.72361 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 6.894757 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
            }

        }

        private void btnCEBasinc_Click(object sender, EventArgs e)
        {
            txtBasinc1.Text = "0";
            txtBasinc2.Text = "0";
        }

        private void treeViewBasinc1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Atmosfer")
            {
                lblBasinc1.Text = "Atmosfer";
                treeViewBasinc1.Visible = false;
            }
            if (e.Node.Name == "Bar")
            {
                lblBasinc1.Text = "Bar";
                treeViewBasinc1.Visible = false;
            }
            if (e.Node.Name == "Kilopascal")
            {
                lblBasinc1.Text = "Kilopascal";
                treeViewBasinc1.Visible = false;
            }
            if (e.Node.Name == "MilimetreCiva")
            {
                lblBasinc1.Text = "Milimetre Civa";
                treeViewBasinc1.Visible = false;
            }
            if (e.Node.Name == "Pascal")
            {
                lblBasinc1.Text = "Pascal";
                treeViewBasinc1.Visible = false;
            }
            if (e.Node.Name == "Libre/inçkare")
            {
                lblBasinc1.Text = "Libre/inçkare";
                treeViewBasinc1.Visible = false;
            }
        }

        private void treeViewBasinc2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Name == "Atmosfer")
            {
                lblBasinc2.Text = "Atmosfer";
                treeViewBasinc2.Visible = false;
            }
            if (e.Node.Name == "Bar")
            {
                lblBasinc2.Text = "Bar";
                treeViewBasinc2.Visible = false;
            }
            if (e.Node.Name == "Kilopascal")
            {
                lblBasinc2.Text = "Kilopascal";
                treeViewBasinc2.Visible = false;
            }
            if (e.Node.Name == "MilimetreCiva")
            {
                lblBasinc2.Text = "Milimetre Civa";
                treeViewBasinc2.Visible = false;
            }
            if (e.Node.Name == "Pascal")
            {
                lblBasinc2.Text = "Pascal";
                treeViewBasinc2.Visible = false;
            }
            if (e.Node.Name == "Libre/inçkare")
            {
                lblBasinc2.Text = "Libre/inçkare";
                treeViewBasinc2.Visible = false;
            }
        }

        private void lblBasinc1_Click(object sender, EventArgs e)
        {
            treeViewBasinc1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            treeViewBasinc2.Visible = true;
        }

        private void btnSilBasinc_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtBasinc1.Text) != 0 )
            {
                txtBasinc1.Text = txtBasinc1.Text.Remove(txtBasinc1.Text.Length - 1, 1);
                if (txtBasinc1.Text.Length == 0 )
                {
                    txtBasinc1.Text = "0";
                }
            }
            if (lblBasinc1.Text == "Atmosfer")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 1.01325 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 101.325 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 760.1275 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 101.325 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 14.69595 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Bar")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.986923 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 100 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 750.1875 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 100.000 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 14.50377 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Kilopascal")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.009869 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.01 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 7.501875 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 1000 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 0.145038 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Milimetre cıva")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.001316 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.001333 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 0.1333 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 133.3 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 0.019334 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Pascal")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.00001 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.00001 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 0.001 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 0.007502 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    double sayi = 0.000145 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
            }
            if (lblBasinc1.Text == "Libre/inçkare")
            {
                if (lblBasinc2.Text == "Atmosfer")
                {
                    double sayi = 0.068046 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Bar")
                {
                    double sayi = 0.068948 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Kilopascal")
                {
                    double sayi = 6.894757 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Milimetre Cıva")
                {
                    double sayi = 51.72361 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Pascal")
                {
                    double sayi = 6.894757 * Convert.ToDouble(txtBasinc1.Text);
                    txtBasinc2.Text = Convert.ToString(sayi);
                }
                if (lblBasinc2.Text == "Libre/inçkare")
                {
                    txtBasinc2.Text = txtBasinc1.Text;
                }
            }
        }
        //BASINÇ BİTİŞ
        

        //AÇI BAŞLANGIÇ
        private void btnClickAci(object sender, EventArgs e)
        {
            if (txtAci1.Text == "0")
            {
                txtAci1.Clear();
            }

            Button btn = (Button)sender;
            txtAci1.Text = txtAci1.Text + btn.Text;
        }

        private void btnCEAçi_Click(object sender, EventArgs e)
        {
            txtAci1.Text = "0";
            txtAci2.Text = "0";
        }

        private void lblAci1_Click(object sender, EventArgs e)
        {
            treeViewAci1.Visible = true;
        }

        private void lblAci2_Click(object sender, EventArgs e)
        {
            treeViewAci2.Visible = true;
        }


        //AÇI BİTİŞ

        bool operatorDurumBilimsel;
        private void btnBilimselClick(object sender, EventArgs e)
        {
            if (txtBilimsel.Text == "0" || operatorDurumBilimsel == true)
            {
                txtSonuc.Clear();
            }
            operatorDurumBilimsel = false;
            Button btn = (Button)sender;
            txtBilimsel.Text = txtBilimsel.Text + btn.Text;

        }
        
        private void operatorİslemBilimsel(object sender, EventArgs e)
        {
            operatorDurumBilimsel = true;
            Button btn = (Button)sender;
            string yeniOptBilgisiBilimsel = btn.Text;

            lblBilimsel.Text = lblBilimsel.Text + " " + txtBilimsel.Text + " " + yeniOptBilgisiBilimsel;
            switch (opt)
            {
                case "+": txtBilimsel.Text = (sonuc + double.Parse(txtBilimsel.Text)).ToString(); break;
                case "-": txtBilimsel.Text = (sonuc - double.Parse(txtBilimsel.Text)).ToString(); break;
                case "/": txtBilimsel.Text = (sonuc / double.Parse(txtBilimsel.Text)).ToString(); break;
                case "*": txtBilimsel.Text = (sonuc * double.Parse(txtBilimsel.Text)).ToString(); break;

            }
            sonuc = Double.Parse(txtBilimsel.Text);
            txtBilimsel.Text = sonuc.ToString();
            opt = yeniOptBilgisiBilimsel;
        }

        private void btnCBilimsel_Click(object sender, EventArgs e)
        {
            txtBilimsel.Text = "0";
        }

        private void btnEsittirBilimsel_Click(object sender, EventArgs e)
        {
            lblBilimsel.Text = " ";
            operatorDurumBilimsel = true;
            switch (opt)
            {
                case "+": txtBilimsel.Text = (sonuc + double.Parse(txtBilimsel.Text)).ToString(); break;
                case "-": txtBilimsel.Text = (sonuc - double.Parse(txtBilimsel.Text)).ToString(); break;
                case "/": txtBilimsel.Text = (sonuc / double.Parse(txtBilimsel.Text)).ToString(); break;
                case "*": txtBilimsel.Text = (sonuc * double.Parse(txtBilimsel.Text)).ToString(); break;

            }
            sonuc = Double.Parse(txtSonuc.Text);
            txtBilimsel.Text = sonuc.ToString();
            opt = "";
        }

        private void btnVirgulBilimsel_Click(object sender, EventArgs e)
        {
            if (txtBilimsel.Text == "0")
            {
                txtBilimsel.Text = "0";
            }
            else if (operatorDurumBilimsel == true)
            {
                txtBilimsel.Text = "0";
            }

            if (!txtBilimsel.Text.Contains(","))
            {
                txtBilimsel.Text = txtBilimsel.Text + ",";
            }
            operatorDurumBilimsel = false;
        }

        private void btnKareBilimsel_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            sayi = sayi * sayi;
            txtBilimsel.Text = Convert.ToString(sayi);
        }

        private void btnİkiKökX_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            sayi = Math.Sqrt(sayi);
            txtBilimsel.Text = Convert.ToString(sayi);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            sayi = Math.Log(sayi);
            txtBilimsel.Text = Convert.ToString(sayi);
        }

        private void btnBirBoluX_Click(object sender, EventArgs e)
        {
            double sayi = Convert.ToDouble(txtBilimsel.Text);
            sayi = 1 / (sayi);
            txtBilimsel.Text = Convert.ToString(sayi);
        }

        private void btnSilBilimsel_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtBilimsel.Text) != 0 || txtBilimsel.Text == "0," || txtBilimsel.Text == "-0," || txtBilimsel.Text.Length != 1)
            {
                txtBilimsel.Text = txtBilimsel.Text.Remove(txtBilimsel.Text.Length - 1, 1);
                if (txtBilimsel.Text.Length == 0 || txtBilimsel.Text == "0," || txtBilimsel.Text == "-" || txtBilimsel.Text == "-0," || txtBilimsel.Text == "-0")
                {
                    txtBilimsel.Text = "0";
                }
            }
        }

        private void btnMutlakBilimsel_Click(object sender, EventArgs e)
        {
            double sonDeger = Convert.ToDouble(txtBilimsel.Text);
            if (sonDeger > 0)
            {
                sonDeger = -1 * sonDeger;
                txtBilimsel.Text = Convert.ToString(sonDeger);
            }
            else if (sonDeger < 0)
            {
                sonDeger = -1 * sonDeger;
                txtBilimsel.Text = Convert.ToString(sonDeger);
            }


            if (txtBilimsel.Text == "-0,")
            {
                txtBilimsel.Text = "0,";
            }
            else if (txtBilimsel.Text == "0,")
            {
                txtBilimsel.Text = "-" + txtBilimsel.Text;
            }
        }

        private void btnMutlak2Bilimsel_Click(object sender, EventArgs e)
        {
            double sonDeger = Convert.ToDouble(txtBilimsel.Text);
            if (sonDeger > 0)
            {
                sonDeger = -1 * sonDeger;
                txtBilimsel.Text = Convert.ToString(sonDeger);
            }
            else if (sonDeger < 0)
            {
                sonDeger = -1 * sonDeger;
                txtBilimsel.Text = Convert.ToString(sonDeger);
            }


            if (txtBilimsel.Text == "-0,")
            {
                txtBilimsel.Text = "0,";
            }
            else if (txtBilimsel.Text == "0,")
            {
                txtBilimsel.Text = "-" + txtBilimsel.Text;
            }
        }
    }
    }
   