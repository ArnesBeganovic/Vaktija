using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Vaktija
{
    public partial class FormaVaktije : Form
	{
        //Klasa sa formu
        Timer t = new Timer();
        JedanDan Danas = new JedanDan();
        public FormaVaktije()
		{
			InitializeComponent();

        }
        private void FormaVaktije_Load(object sender, EventArgs e)
        {
            //Sakrij da je forma
            FormBorderStyle = FormBorderStyle.None;

            //Vaktija property
            VaktijaProperty vp = new VaktijaProperty();
            
            //Podesi velicinu i poziciju forme u zavisnosti od ekrana na kojem se prikazuje. Dinamicno podesavanje svih komponenti.
            this.Size = new Size(vp.SirinaForme(),vp.VisinaForme());
            this.Location = new Point(vp.SirinaEkrana()/2 - vp.SirinaForme()/2, 0);
            this.BackgroundImage = vp.PodesiPozadinskuSliku();
            //Preracunaj velicinu fonta kojeg cu kasnije koristiti
            vp.PostaviVelicinuVremenskogFonta(this);
            //Pripremi sve labele u koje ce se upisivati vrijeme, datum i namaska vremena
            PripremiLabele(vp);

            
            List<JedanDan> vaktija = Vaktija.KreirajVaktiju(); //Pozovi databazu sa namaskim vremenima
            Danas = NoviDan(); //Nadji danasnji datum u Vaktiji
            NovaMinuta(); //Pozovi funkciju prvi put. 
            t.Interval = 60000; //Postavi interval od jedne minute
            t.Tick += new EventHandler(this.PozoviNovuMinutu); //Kad istekne jedna minuta pozovi funkciju NovaMinuta
            t.Start(); //Pocni brojati minute
        }
        private void PripremiLabele(VaktijaProperty vp)
        {
            List<Label> l = new List<Label>(); //labeliZaNamaze
            double X1, Y1, X2, Y2,X3,X4,X5,X6;
            int z = 0;
            //idi jedan po jedan namaz, izracunaj gdje se label treba postaviti a zatim ga i postavi sa dummy tekstom
            for (int i = 0;i<=17;i+=3)
            {

                X1 = vp.ParentKvadratZaNamaskiFrame(z)[0];
                Y1 = vp.ParentKvadratZaNamaskiFrame(z)[1];
                X2 = vp.ParentKvadratZaNamaskiFrame(z)[2];
                Y2 = vp.ParentKvadratZaNamaskiFrame(z)[3];

                l.Add(new Label());
                l.Add(new Label());
                l.Add(new Label());

                l[i].Text = "00";
                l[i + 1].Text = ":";
                l[i + 2].Text = "00";

                l[i].Font = new Font(vp.FontFamilija(), vp.VelicinaVremenskogFonta(), FontStyle.Regular);
                l[i + 1].Font = new Font(vp.FontFamilija(), vp.VelicinaVremenskogFonta(), FontStyle.Regular);
                l[i + 2].Font = new Font(vp.FontFamilija(), vp.VelicinaVremenskogFonta(), FontStyle.Regular);

                l[i].ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                l[i + 1].ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                l[i + 2].ForeColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");

                l[i].BackColor = System.Drawing.Color.Transparent;
                l[i + 1].BackColor = System.Drawing.Color.Transparent;
                l[i + 2].BackColor = System.Drawing.Color.Transparent;

                l[i].Name = i + "Sat";
                l[i + 1].Name = i + "Dvotacka";
                l[i + 2].Name = i + "Minuta";

                l[i].Width = vp.SirinaVremenskogFonta();
                l[i + 1].Width = vp.SirinaDvotackeFonta();
                l[i + 2].Width = vp.SirinaVremenskogFonta();

                l[i].Height = vp.VisinaVremenskogFonta();
                l[i + 1].Height = vp.VisinaDvotackeFonta();
                l[i + 2].Height = vp.VisinaVremenskogFonta();

                X3 = (X2 + X1) / 2;
                X4 = X3 - (X3 * 0.05);
                X5 = l[i].Width;
                X6 = (X4 - X1 - X5) / 2;

                int A = (int)X1 + (int)X6;
                int B = (int)X3 - ((int)X3 - (int)X4);
                int C = (int)X3 + ((int)X3 - (int)X4);

                l[i].Location = new Point(A, (int)Y1);
                l[i + 1].Location = new Point(B, (int)Y1);
                l[i + 2].Location = new Point(C, (int)Y1);

                this.Controls.Add(l[i]);
                this.Controls.Add(l[i + 1]);
                this.Controls.Add(l[i + 2]);
                z++;
            }

            //Postavi slike namaskih vremena
            PictureBox zoraSlika = vp.DajNamaskuSliku(0); 
            PictureBox sabahSlika = vp.DajNamaskuSliku(1); 
            PictureBox podneSlika = vp.DajNamaskuSliku(2); 
            PictureBox ikindijaSlika = vp.DajNamaskuSliku(3); 
            PictureBox aksamSlika = vp.DajNamaskuSliku(4); 
            PictureBox jacijaSlika = vp.DajNamaskuSliku(5); 
            this.Controls.Add(zoraSlika);
            this.Controls.Add(sabahSlika);
            this.Controls.Add(podneSlika);
            this.Controls.Add(ikindijaSlika);
            this.Controls.Add(aksamSlika);
            this.Controls.Add(jacijaSlika);

        }
        private void NovaMinuta()
        {
            /*
             * Ova funkcija se poziva svake minute i u principu ona treba da provjeri da li je nastupio novi namaz i shodno tome promijeni vizuelni sadrzaj na ekranu.
             */


            //Promijeni vrijeme na formi
           

            //Pregledaj jel datum isti nakon sto se vrijeme updatovalo. Ako nije updatuj globalnu varijablu a zatim i formu (funkcija 1)
            if (Danas.Mjesec != DateTime.Now.Month || Danas.Dan != DateTime.Now.Day)
            {
                Danas = NoviDan();
            }
            //Pregledaj da li se namaz promijenio i updatuj sliku ako jeste.
            OznaciTrenutniNamaz(Danas);

        }
        private void PozoviNovuMinutu(object sender, EventArgs e)
        {
            NovaMinuta();
        }
        private JedanDan NoviDan()
        {
            //Nadji danasnji dan iz databaze
            List<JedanDan> vaktija = Vaktija.KreirajVaktiju();
            JedanDan novidan = new JedanDan();
            novidan = vaktija.Find(x => (x.Mjesec == DateTime.Now.Month) && (x.Dan == DateTime.Now.Day));
            PopuniNamaskaVremenaZaDanas(novidan);
            return novidan;
        }
        private void PopuniNamaskaVremenaZaDanas(JedanDan novidan)
        {
            //Popuni labele ranije pripremljene i pozicionirane sa vremenima iz danasnjeg dana
            Label l0Sat = (Label)Controls.Find("0Sat", true).FirstOrDefault();
            Label l0Min = (Label)Controls.Find("0Minuta", true).FirstOrDefault();
            Label l3Sat = (Label)Controls.Find("3Sat", true).FirstOrDefault();
            Label l3Min = (Label)Controls.Find("3Minuta", true).FirstOrDefault();
            Label l6Sat = (Label)Controls.Find("6Sat", true).FirstOrDefault();
            Label l6Min = (Label)Controls.Find("6Minuta", true).FirstOrDefault();
            Label l9Sat = (Label)Controls.Find("9Sat", true).FirstOrDefault();
            Label l9Min = (Label)Controls.Find("9Minuta", true).FirstOrDefault();
            Label l12Sat = (Label)Controls.Find("12Sat", true).FirstOrDefault();
            Label l12Min = (Label)Controls.Find("12Minuta", true).FirstOrDefault();
            Label l15Sat = (Label)Controls.Find("15Sat", true).FirstOrDefault();
            Label l15Min = (Label)Controls.Find("15Minuta", true).FirstOrDefault();

            String sat = "0" + novidan.ZoraSat.ToString();
            String min = "0" + novidan.ZoraMinuta.ToString();
            l0Sat.Text = sat.Substring(sat.Length - 2, 2);
            l0Min.Text = min.Substring(min.Length - 2, 2);
            l0Sat.AutoSize = false;
            l0Sat.TextAlign = ContentAlignment.MiddleRight;
            l0Min.AutoSize = false;
            l0Min.TextAlign = ContentAlignment.MiddleRight;

            sat = "0" + novidan.SabahSat.ToString();
            min = "0" + novidan.SabahMinuta.ToString();
            l3Sat.Text = sat.Substring(sat.Length - 2, 2);
            l3Min.Text = min.Substring(min.Length - 2, 2);
            l3Sat.AutoSize = false;
            l3Sat.TextAlign = ContentAlignment.MiddleRight;
            l3Min.AutoSize = false;
            l3Min.TextAlign = ContentAlignment.MiddleRight;

            sat = "0" + novidan.PodneSat.ToString();
            min = "0" + novidan.PodneMinuta.ToString();
            l6Sat.Text = sat.Substring(sat.Length - 2, 2);
            l6Min.Text = min.Substring(min.Length - 2, 2);
            l6Sat.AutoSize = false;
            l6Sat.TextAlign = ContentAlignment.MiddleRight;
            l6Min.AutoSize = false;
            l6Min.TextAlign = ContentAlignment.MiddleRight;

            sat = "0" + novidan.IkindijaSat.ToString();
            min = "0" + novidan.IkindijaMinuta.ToString();
            l9Sat.Text = sat.Substring(sat.Length - 2, 2);
            l9Min.Text = min.Substring(min.Length - 2, 2);
            l9Sat.AutoSize = false;
            l9Sat.TextAlign = ContentAlignment.MiddleRight;
            l9Min.AutoSize = false;
            l9Min.TextAlign = ContentAlignment.MiddleCenter;

            sat = "0" + novidan.AksamSat.ToString();
            min = "0" + novidan.AksamMinuta.ToString();
            l12Sat.Text = sat.Substring(sat.Length - 2, 2);
            l12Min.Text = min.Substring(min.Length - 2, 2);
            l12Sat.AutoSize = false;
            l12Sat.TextAlign = ContentAlignment.MiddleRight;
            l12Min.AutoSize = false;
            l12Min.TextAlign = ContentAlignment.MiddleRight;

            sat = "0" + novidan.JacijaSat.ToString();
            min = "0" + novidan.JacijaMinuta.ToString();
            l15Sat.Text = sat.Substring(sat.Length - 2, 2);
            l15Min.Text = min.Substring(min.Length - 2, 2);
            l15Sat.AutoSize = false;
            l15Sat.TextAlign = ContentAlignment.MiddleRight;
            l15Min.AutoSize = false;
            l15Min.TextAlign = ContentAlignment.MiddleRight;

        }
        private void OznaciTrenutniNamaz(JedanDan Danas)
        {

            int Sat = DateTime.Now.Hour;
            int Minuta = DateTime.Now.Minute;

            Console.WriteLine(Sat.ToString());
            Console.WriteLine(Minuta.ToString());
            //Sve nuliraj
            this.Controls.Find("SlikaJacija", true).FirstOrDefault().Visible = false;
            this.Controls.Find("SlikaAksam", true).FirstOrDefault().Visible = false;
            this.Controls.Find("SlikaIkindija", true).FirstOrDefault().Visible = false;
            this.Controls.Find("SlikaPodne", true).FirstOrDefault().Visible = false;
            this.Controls.Find("SlikaSabah", true).FirstOrDefault().Visible = false;
            this.Controls.Find("SlikaZora", true).FirstOrDefault().Visible = false;

            //Prikazi samo onu koja odgovara vremenskom intervalu

            //JACIJA
            if ((Sat==Danas.JacijaSat && Minuta>=Danas.JacijaMinuta)|| Sat > Danas.JacijaSat)
            {
                this.Controls.Find("SlikaJacija", true).FirstOrDefault().Visible = true;
            }
            //AKSAM
            else if (
                (Sat==Danas.AksamSat && Minuta>=Danas.AksamMinuta) || 
                (Sat>Danas.AksamSat && Sat<Danas.JacijaSat) ||
                (Sat==Danas.JacijaSat &&Minuta<Danas.JacijaMinuta)
             ){this.Controls.Find("SlikaAksam", true).FirstOrDefault().Visible = true;}
            //IKINDIJA
            else if (
                (Sat == Danas.IkindijaSat && Minuta >= Danas.IkindijaMinuta) ||
                (Sat > Danas.IkindijaSat && Sat < Danas.AksamSat) ||
                (Sat == Danas.AksamSat && Minuta < Danas.AksamMinuta)
             ) { this.Controls.Find("SlikaIkindija", true).FirstOrDefault().Visible = true; }
            //PODNE
            else if (
                (Sat == Danas.PodneSat && Minuta >= Danas.PodneMinuta) ||
                (Sat > Danas.PodneSat && Sat < Danas.IkindijaSat) ||
                (Sat == Danas.IkindijaSat && Minuta < Danas.IkindijaMinuta)
             ) { this.Controls.Find("SlikaPodne", true).FirstOrDefault().Visible = true; }
            //SABAH
            else if (
                (Sat == Danas.SabahSat && Minuta >= Danas.SabahMinuta) ||
                (Sat > Danas.SabahSat && Sat < Danas.PodneSat) ||
                (Sat == Danas.PodneSat && Minuta < Danas.PodneMinuta)
             ) { this.Controls.Find("SlikaSabah", true).FirstOrDefault().Visible = true; }
            //ZORA
            else if (
                (Sat == Danas.ZoraSat && Minuta >= Danas.ZoraMinuta) ||
                (Sat > Danas.ZoraSat && Sat < Danas.SabahSat) ||
                (Sat == Danas.SabahSat && Minuta < Danas.PodneMinuta)
             ) { this.Controls.Find("SlikaZora", true).FirstOrDefault().Visible = true; }
        }

    }
}
