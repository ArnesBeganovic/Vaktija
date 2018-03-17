using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vaktija
{
    /*
     * U ovom namespacu se nalaze tri klase:
     * VAKTIJA - koja sadrzi hardcoded databazu sa svim namaskim vremenima
     * JedanDaa - koja sluzi da se napravi objekat koji ce biti most izmedju VAKTIJE (databaza) i VaktijaProperty (trenutnog datuma sa kojim se radi)
     * VaktijaProperty - je radna klasa koja sadrzi sve vezano za trenutnu poziciju skripte. 
     */
    public class Vaktija
    {
        //Lista svih dana u godini
        public static List<JedanDan> KreirajVaktiju()
        {
            //Kreiraj listu koju ce funkcija vratiti
            List<JedanDan> kompletnaVaktija = new List<JedanDan>();
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 1, Dan = 31, ZoraSat = 6, ZoraMinuta = 22, SabahSat = 8, SabahMinuta = 12, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 13, AksamSat = 16, AksamMinuta = 40, JacijaSat = 18, JacijaMinuta = 23 });

            //FEBRUAR
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 1, ZoraSat = 6, ZoraMinuta = 22, SabahSat = 8, SabahMinuta = 12, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 13, AksamSat = 16, AksamMinuta = 40, JacijaSat = 18, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 2, ZoraSat = 6, ZoraMinuta = 21, SabahSat = 8, SabahMinuta = 10, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 0, IkindijaMinuta = 14, AksamSat = 16, AksamMinuta = 42, JacijaSat = 18, JacijaMinuta = 25 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 3, ZoraSat = 6, ZoraMinuta = 19, SabahSat = 8, SabahMinuta = 8, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 16, AksamSat = 16, AksamMinuta = 44, JacijaSat = 18, JacijaMinuta = 27 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 4, ZoraSat = 6, ZoraMinuta = 17, SabahSat = 8, SabahMinuta = 6, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 18, AksamSat = 16, AksamMinuta = 47, JacijaSat = 18, JacijaMinuta = 29 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 5, ZoraSat = 6, ZoraMinuta = 16, SabahSat = 8, SabahMinuta = 4, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 20, AksamSat = 16, AksamMinuta = 49, JacijaSat = 18, JacijaMinuta = 31 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 6, ZoraSat = 6, ZoraMinuta = 14, SabahSat = 8, SabahMinuta = 1, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 22, AksamSat = 16, AksamMinuta = 51, JacijaSat = 18, JacijaMinuta = 33 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 7, ZoraSat = 6, ZoraMinuta = 12, SabahSat = 7, SabahMinuta = 59, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 24, AksamSat = 16, AksamMinuta = 54, JacijaSat = 18, JacijaMinuta = 35 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 8, ZoraSat = 6, ZoraMinuta = 10, SabahSat = 7, SabahMinuta = 57, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 25, AksamSat = 16, AksamMinuta = 56, JacijaSat = 18, JacijaMinuta = 37 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 9, ZoraSat = 6, ZoraMinuta = 8, SabahSat = 7, SabahMinuta = 55, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 27, AksamSat = 16, AksamMinuta = 59, JacijaSat = 18, JacijaMinuta = 39 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 10, ZoraSat = 6, ZoraMinuta = 6, SabahSat = 7, SabahMinuta = 52, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 29, AksamSat = 17, AksamMinuta = 1, JacijaSat = 18, JacijaMinuta = 41 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 11, ZoraSat = 6, ZoraMinuta = 4, SabahSat = 7, SabahMinuta = 50, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 31, AksamSat = 17, AksamMinuta = 3, JacijaSat = 18, JacijaMinuta = 43 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 12, ZoraSat = 6, ZoraMinuta = 2, SabahSat = 7, SabahMinuta = 48, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 33, AksamSat = 17, AksamMinuta = 6, JacijaSat = 18, JacijaMinuta = 45 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 13, ZoraSat = 6, ZoraMinuta = 0, SabahSat = 7, SabahMinuta = 45, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 34, AksamSat = 17, AksamMinuta = 8, JacijaSat = 18, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 14, ZoraSat = 5, ZoraMinuta = 58, SabahSat = 7, SabahMinuta = 43, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 36, AksamSat = 17, AksamMinuta = 10, JacijaSat = 18, JacijaMinuta = 49 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 15, ZoraSat = 5, ZoraMinuta = 56, SabahSat = 7, SabahMinuta = 40, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 38, AksamSat = 17, AksamMinuta = 13, JacijaSat = 18, JacijaMinuta = 51 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 16, ZoraSat = 5, ZoraMinuta = 54, SabahSat = 7, SabahMinuta = 38, PodneSat = 12, PodneMinuta = 28, IkindijaSat = 14, IkindijaMinuta = 40, AksamSat = 17, AksamMinuta = 15, JacijaSat = 18, JacijaMinuta = 53 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 17, ZoraSat = 5, ZoraMinuta = 52, SabahSat = 7, SabahMinuta = 36, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 41, AksamSat = 17, AksamMinuta = 18, JacijaSat = 18, JacijaMinuta = 55 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 18, ZoraSat = 5, ZoraMinuta = 49, SabahSat = 7, SabahMinuta = 33, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 43, AksamSat = 17, AksamMinuta = 20, JacijaSat = 18, JacijaMinuta = 57 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 19, ZoraSat = 5, ZoraMinuta = 47, SabahSat = 7, SabahMinuta = 31, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 45, AksamSat = 17, AksamMinuta = 22, JacijaSat = 19, JacijaMinuta = 0 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 20, ZoraSat = 5, ZoraMinuta = 45, SabahSat = 7, SabahMinuta = 28, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 47, AksamSat = 17, AksamMinuta = 25, JacijaSat = 19, JacijaMinuta = 2 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 21, ZoraSat = 5, ZoraMinuta = 43, SabahSat = 7, SabahMinuta = 25, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 48, AksamSat = 17, AksamMinuta = 27, JacijaSat = 19, JacijaMinuta = 4 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 22, ZoraSat = 5, ZoraMinuta = 41, SabahSat = 7, SabahMinuta = 23, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 50, AksamSat = 17, AksamMinuta = 29, JacijaSat = 19, JacijaMinuta = 6 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 23, ZoraSat = 5, ZoraMinuta = 38, SabahSat = 7, SabahMinuta = 20, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 52, AksamSat = 17, AksamMinuta = 32, JacijaSat = 19, JacijaMinuta = 8 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 24, ZoraSat = 5, ZoraMinuta = 36, SabahSat = 7, SabahMinuta = 18, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 54, AksamSat = 17, AksamMinuta = 34, JacijaSat = 19, JacijaMinuta = 10 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 25, ZoraSat = 5, ZoraMinuta = 34, SabahSat = 7, SabahMinuta = 15, PodneSat = 12, PodneMinuta = 27, IkindijaSat = 14, IkindijaMinuta = 55, AksamSat = 17, AksamMinuta = 36, JacijaSat = 19, JacijaMinuta = 12 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 26, ZoraSat = 5, ZoraMinuta = 31, SabahSat = 7, SabahMinuta = 13, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 14, IkindijaMinuta = 57, AksamSat = 17, AksamMinuta = 39, JacijaSat = 19, JacijaMinuta = 14 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 27, ZoraSat = 5, ZoraMinuta = 29, SabahSat = 7, SabahMinuta = 10, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 14, IkindijaMinuta = 59, AksamSat = 17, AksamMinuta = 41, JacijaSat = 19, JacijaMinuta = 16 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 28, ZoraSat = 5, ZoraMinuta = 27, SabahSat = 7, SabahMinuta = 8, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 15, IkindijaMinuta = 0, AksamSat = 17, AksamMinuta = 43, JacijaSat = 19, JacijaMinuta = 17 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 2, Dan = 29, ZoraSat = 5, ZoraMinuta = 27, SabahSat = 7, SabahMinuta = 8, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 15, IkindijaMinuta = 0, AksamSat = 17, AksamMinuta = 43, JacijaSat = 19, JacijaMinuta = 17 });

            //MART
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 1, ZoraSat = 5, ZoraMinuta = 25, SabahSat = 7, SabahMinuta = 6, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 15, IkindijaMinuta = 1, AksamSat = 17, AksamMinuta = 45, JacijaSat = 19, JacijaMinuta = 19 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 2, ZoraSat = 5, ZoraMinuta = 24, SabahSat = 7, SabahMinuta = 5, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 15, IkindijaMinuta = 2, AksamSat = 17, AksamMinuta = 46, JacijaSat = 19, JacijaMinuta = 20 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 3, ZoraSat = 5, ZoraMinuta = 22, SabahSat = 7, SabahMinuta = 2, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 15, IkindijaMinuta = 4, AksamSat = 17, AksamMinuta = 48, JacijaSat = 19, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 4, ZoraSat = 5, ZoraMinuta = 19, SabahSat = 6, SabahMinuta = 59, PodneSat = 12, PodneMinuta = 26, IkindijaSat = 15, IkindijaMinuta = 5, AksamSat = 17, AksamMinuta = 50, JacijaSat = 19, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 5, ZoraSat = 5, ZoraMinuta = 17, SabahSat = 6, SabahMinuta = 57, PodneSat = 12, PodneMinuta = 25, IkindijaSat = 15, IkindijaMinuta = 7, AksamSat = 17, AksamMinuta = 52, JacijaSat = 19, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 6, ZoraSat = 5, ZoraMinuta = 14, SabahSat = 6, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 25, IkindijaSat = 15, IkindijaMinuta = 8, AksamSat = 17, AksamMinuta = 55, JacijaSat = 19, JacijaMinuta = 28 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 7, ZoraSat = 5, ZoraMinuta = 12, SabahSat = 6, SabahMinuta = 51, PodneSat = 12, PodneMinuta = 25, IkindijaSat = 15, IkindijaMinuta = 10, AksamSat = 17, AksamMinuta = 57, JacijaSat = 19, JacijaMinuta = 31 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 8, ZoraSat = 5, ZoraMinuta = 9, SabahSat = 6, SabahMinuta = 48, PodneSat = 12, PodneMinuta = 25, IkindijaSat = 15, IkindijaMinuta = 12, AksamSat = 17, AksamMinuta = 59, JacijaSat = 19, JacijaMinuta = 33 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 9, ZoraSat = 5, ZoraMinuta = 7, SabahSat = 6, SabahMinuta = 46, PodneSat = 12, PodneMinuta = 24, IkindijaSat = 15, IkindijaMinuta = 13, AksamSat = 18, AksamMinuta = 1, JacijaSat = 19, JacijaMinuta = 35 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 10, ZoraSat = 5, ZoraMinuta = 4, SabahSat = 6, SabahMinuta = 43, PodneSat = 12, PodneMinuta = 24, IkindijaSat = 15, IkindijaMinuta = 15, AksamSat = 18, AksamMinuta = 4, JacijaSat = 19, JacijaMinuta = 37 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 11, ZoraSat = 5, ZoraMinuta = 1, SabahSat = 6, SabahMinuta = 40, PodneSat = 12, PodneMinuta = 24, IkindijaSat = 15, IkindijaMinuta = 16, AksamSat = 18, AksamMinuta = 6, JacijaSat = 19, JacijaMinuta = 39 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 12, ZoraSat = 4, ZoraMinuta = 59, SabahSat = 6, SabahMinuta = 37, PodneSat = 12, PodneMinuta = 24, IkindijaSat = 15, IkindijaMinuta = 18, AksamSat = 18, AksamMinuta = 8, JacijaSat = 19, JacijaMinuta = 41 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 13, ZoraSat = 4, ZoraMinuta = 56, SabahSat = 6, SabahMinuta = 35, PodneSat = 12, PodneMinuta = 23, IkindijaSat = 15, IkindijaMinuta = 19, AksamSat = 18, AksamMinuta = 10, JacijaSat = 19, JacijaMinuta = 43 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 14, ZoraSat = 4, ZoraMinuta = 54, SabahSat = 6, SabahMinuta = 32, PodneSat = 12, PodneMinuta = 23, IkindijaSat = 15, IkindijaMinuta = 21, AksamSat = 18, AksamMinuta = 13, JacijaSat = 19, JacijaMinuta = 45 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 15, ZoraSat = 4, ZoraMinuta = 51, SabahSat = 6, SabahMinuta = 29, PodneSat = 12, PodneMinuta = 23, IkindijaSat = 15, IkindijaMinuta = 22, AksamSat = 18, AksamMinuta = 15, JacijaSat = 19, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 16, ZoraSat = 4, ZoraMinuta = 48, SabahSat = 6, SabahMinuta = 26, PodneSat = 12, PodneMinuta = 23, IkindijaSat = 15, IkindijaMinuta = 24, AksamSat = 18, AksamMinuta = 17, JacijaSat = 19, JacijaMinuta = 49 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 17, ZoraSat = 4, ZoraMinuta = 46, SabahSat = 6, SabahMinuta = 24, PodneSat = 12, PodneMinuta = 22, IkindijaSat = 15, IkindijaMinuta = 25, AksamSat = 18, AksamMinuta = 19, JacijaSat = 19, JacijaMinuta = 51 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 18, ZoraSat = 4, ZoraMinuta = 43, SabahSat = 6, SabahMinuta = 21, PodneSat = 12, PodneMinuta = 22, IkindijaSat = 15, IkindijaMinuta = 27, AksamSat = 18, AksamMinuta = 22, JacijaSat = 19, JacijaMinuta = 53 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 19, ZoraSat = 4, ZoraMinuta = 40, SabahSat = 6, SabahMinuta = 18, PodneSat = 12, PodneMinuta = 22, IkindijaSat = 15, IkindijaMinuta = 28, AksamSat = 18, AksamMinuta = 24, JacijaSat = 19, JacijaMinuta = 56 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 20, ZoraSat = 4, ZoraMinuta = 38, SabahSat = 6, SabahMinuta = 15, PodneSat = 12, PodneMinuta = 21, IkindijaSat = 15, IkindijaMinuta = 29, AksamSat = 18, AksamMinuta = 26, JacijaSat = 19, JacijaMinuta = 58 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 21, ZoraSat = 4, ZoraMinuta = 35, SabahSat = 6, SabahMinuta = 12, PodneSat = 12, PodneMinuta = 21, IkindijaSat = 15, IkindijaMinuta = 31, AksamSat = 18, AksamMinuta = 28, JacijaSat = 20, JacijaMinuta = 0 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 22, ZoraSat = 4, ZoraMinuta = 32, SabahSat = 6, SabahMinuta = 10, PodneSat = 12, PodneMinuta = 21, IkindijaSat = 15, IkindijaMinuta = 32, AksamSat = 18, AksamMinuta = 30, JacijaSat = 20, JacijaMinuta = 2 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 23, ZoraSat = 4, ZoraMinuta = 29, SabahSat = 6, SabahMinuta = 7, PodneSat = 12, PodneMinuta = 21, IkindijaSat = 15, IkindijaMinuta = 33, AksamSat = 18, AksamMinuta = 33, JacijaSat = 20, JacijaMinuta = 4 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 24, ZoraSat = 4, ZoraMinuta = 27, SabahSat = 6, SabahMinuta = 4, PodneSat = 12, PodneMinuta = 20, IkindijaSat = 15, IkindijaMinuta = 35, AksamSat = 18, AksamMinuta = 35, JacijaSat = 20, JacijaMinuta = 6 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 25, ZoraSat = 5, ZoraMinuta = 24, SabahSat = 7, SabahMinuta = 1, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 16, IkindijaMinuta = 36, AksamSat = 19, AksamMinuta = 37, JacijaSat = 21, JacijaMinuta = 8 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 26, ZoraSat = 5, ZoraMinuta = 21, SabahSat = 6, SabahMinuta = 58, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 16, IkindijaMinuta = 37, AksamSat = 19, AksamMinuta = 39, JacijaSat = 21, JacijaMinuta = 10 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 27, ZoraSat = 5, ZoraMinuta = 18, SabahSat = 6, SabahMinuta = 55, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 16, IkindijaMinuta = 39, AksamSat = 19, AksamMinuta = 41, JacijaSat = 21, JacijaMinuta = 12 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 28, ZoraSat = 5, ZoraMinuta = 15, SabahSat = 6, SabahMinuta = 53, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 16, IkindijaMinuta = 40, AksamSat = 19, AksamMinuta = 43, JacijaSat = 21, JacijaMinuta = 15 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 29, ZoraSat = 5, ZoraMinuta = 13, SabahSat = 6, SabahMinuta = 50, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 16, IkindijaMinuta = 41, AksamSat = 19, AksamMinuta = 46, JacijaSat = 21, JacijaMinuta = 17 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 30, ZoraSat = 5, ZoraMinuta = 10, SabahSat = 6, SabahMinuta = 47, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 16, IkindijaMinuta = 43, AksamSat = 19, AksamMinuta = 48, JacijaSat = 21, JacijaMinuta = 19 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 3, Dan = 31, ZoraSat = 5, ZoraMinuta = 7, SabahSat = 6, SabahMinuta = 44, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 16, IkindijaMinuta = 44, AksamSat = 19, AksamMinuta = 50, JacijaSat = 21, JacijaMinuta = 21 });

            //APRIL
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 1, ZoraSat = 5, ZoraMinuta = 4, SabahSat = 6, SabahMinuta = 41, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 16, IkindijaMinuta = 45, AksamSat = 19, AksamMinuta = 52, JacijaSat = 21, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 2, ZoraSat = 5, ZoraMinuta = 1, SabahSat = 6, SabahMinuta = 39, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 16, IkindijaMinuta = 46, AksamSat = 19, AksamMinuta = 54, JacijaSat = 21, JacijaMinuta = 25 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 3, ZoraSat = 4, ZoraMinuta = 59, SabahSat = 6, SabahMinuta = 36, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 16, IkindijaMinuta = 48, AksamSat = 19, AksamMinuta = 57, JacijaSat = 21, JacijaMinuta = 28 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 4, ZoraSat = 4, ZoraMinuta = 56, SabahSat = 6, SabahMinuta = 33, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 16, IkindijaMinuta = 49, AksamSat = 19, AksamMinuta = 59, JacijaSat = 21, JacijaMinuta = 30 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 5, ZoraSat = 4, ZoraMinuta = 53, SabahSat = 6, SabahMinuta = 30, PodneSat = 13, PodneMinuta = 16, IkindijaSat = 16, IkindijaMinuta = 50, AksamSat = 20, AksamMinuta = 1, JacijaSat = 21, JacijaMinuta = 32 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 6, ZoraSat = 4, ZoraMinuta = 50, SabahSat = 6, SabahMinuta = 27, PodneSat = 13, PodneMinuta = 16, IkindijaSat = 16, IkindijaMinuta = 51, AksamSat = 20, AksamMinuta = 3, JacijaSat = 21, JacijaMinuta = 34 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 7, ZoraSat = 4, ZoraMinuta = 47, SabahSat = 6, SabahMinuta = 25, PodneSat = 13, PodneMinuta = 16, IkindijaSat = 16, IkindijaMinuta = 52, AksamSat = 20, AksamMinuta = 5, JacijaSat = 21, JacijaMinuta = 36 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 8, ZoraSat = 4, ZoraMinuta = 45, SabahSat = 6, SabahMinuta = 22, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 16, IkindijaMinuta = 53, AksamSat = 20, AksamMinuta = 7, JacijaSat = 21, JacijaMinuta = 39 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 9, ZoraSat = 4, ZoraMinuta = 42, SabahSat = 6, SabahMinuta = 19, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 16, IkindijaMinuta = 55, AksamSat = 20, AksamMinuta = 10, JacijaSat = 21, JacijaMinuta = 41 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 10, ZoraSat = 4, ZoraMinuta = 39, SabahSat = 6, SabahMinuta = 16, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 16, IkindijaMinuta = 56, AksamSat = 20, AksamMinuta = 12, JacijaSat = 21, JacijaMinuta = 43 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 11, ZoraSat = 4, ZoraMinuta = 36, SabahSat = 6, SabahMinuta = 13, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 16, IkindijaMinuta = 57, AksamSat = 20, AksamMinuta = 14, JacijaSat = 21, JacijaMinuta = 45 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 12, ZoraSat = 4, ZoraMinuta = 33, SabahSat = 6, SabahMinuta = 11, PodneSat = 13, PodneMinuta = 14, IkindijaSat = 16, IkindijaMinuta = 58, AksamSat = 20, AksamMinuta = 16, JacijaSat = 21, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 13, ZoraSat = 4, ZoraMinuta = 30, SabahSat = 6, SabahMinuta = 8, PodneSat = 13, PodneMinuta = 14, IkindijaSat = 16, IkindijaMinuta = 59, AksamSat = 20, AksamMinuta = 18, JacijaSat = 21, JacijaMinuta = 50 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 14, ZoraSat = 4, ZoraMinuta = 28, SabahSat = 6, SabahMinuta = 5, PodneSat = 13, PodneMinuta = 14, IkindijaSat = 17, IkindijaMinuta = 0, AksamSat = 20, AksamMinuta = 21, JacijaSat = 21, JacijaMinuta = 52 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 15, ZoraSat = 4, ZoraMinuta = 25, SabahSat = 6, SabahMinuta = 2, PodneSat = 13, PodneMinuta = 14, IkindijaSat = 17, IkindijaMinuta = 1, AksamSat = 20, AksamMinuta = 23, JacijaSat = 21, JacijaMinuta = 54 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 16, ZoraSat = 4, ZoraMinuta = 22, SabahSat = 6, SabahMinuta = 0, PodneSat = 13, PodneMinuta = 13, IkindijaSat = 17, IkindijaMinuta = 2, AksamSat = 20, AksamMinuta = 25, JacijaSat = 21, JacijaMinuta = 56 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 17, ZoraSat = 4, ZoraMinuta = 19, SabahSat = 5, SabahMinuta = 57, PodneSat = 13, PodneMinuta = 13, IkindijaSat = 17, IkindijaMinuta = 3, AksamSat = 20, AksamMinuta = 27, JacijaSat = 21, JacijaMinuta = 59 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 18, ZoraSat = 4, ZoraMinuta = 16, SabahSat = 5, SabahMinuta = 54, PodneSat = 13, PodneMinuta = 13, IkindijaSat = 17, IkindijaMinuta = 5, AksamSat = 20, AksamMinuta = 29, JacijaSat = 22, JacijaMinuta = 1 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 19, ZoraSat = 4, ZoraMinuta = 14, SabahSat = 5, SabahMinuta = 52, PodneSat = 13, PodneMinuta = 13, IkindijaSat = 17, IkindijaMinuta = 6, AksamSat = 20, AksamMinuta = 32, JacijaSat = 22, JacijaMinuta = 3 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 20, ZoraSat = 4, ZoraMinuta = 11, SabahSat = 5, SabahMinuta = 49, PodneSat = 13, PodneMinuta = 12, IkindijaSat = 17, IkindijaMinuta = 7, AksamSat = 20, AksamMinuta = 34, JacijaSat = 22, JacijaMinuta = 6 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 21, ZoraSat = 4, ZoraMinuta = 8, SabahSat = 5, SabahMinuta = 46, PodneSat = 13, PodneMinuta = 12, IkindijaSat = 17, IkindijaMinuta = 8, AksamSat = 20, AksamMinuta = 36, JacijaSat = 22, JacijaMinuta = 8 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 22, ZoraSat = 4, ZoraMinuta = 5, SabahSat = 5, SabahMinuta = 44, PodneSat = 13, PodneMinuta = 12, IkindijaSat = 17, IkindijaMinuta = 9, AksamSat = 20, AksamMinuta = 38, JacijaSat = 22, JacijaMinuta = 10 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 23, ZoraSat = 4, ZoraMinuta = 3, SabahSat = 5, SabahMinuta = 41, PodneSat = 13, PodneMinuta = 12, IkindijaSat = 17, IkindijaMinuta = 10, AksamSat = 20, AksamMinuta = 40, JacijaSat = 22, JacijaMinuta = 13 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 24, ZoraSat = 4, ZoraMinuta = 0, SabahSat = 5, SabahMinuta = 39, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 11, AksamSat = 20, AksamMinuta = 43, JacijaSat = 22, JacijaMinuta = 15 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 25, ZoraSat = 3, ZoraMinuta = 57, SabahSat = 5, SabahMinuta = 36, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 12, AksamSat = 20, AksamMinuta = 45, JacijaSat = 22, JacijaMinuta = 17 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 26, ZoraSat = 3, ZoraMinuta = 54, SabahSat = 5, SabahMinuta = 33, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 13, AksamSat = 20, AksamMinuta = 47, JacijaSat = 22, JacijaMinuta = 19 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 27, ZoraSat = 3, ZoraMinuta = 52, SabahSat = 5, SabahMinuta = 31, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 14, AksamSat = 20, AksamMinuta = 49, JacijaSat = 22, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 28, ZoraSat = 3, ZoraMinuta = 49, SabahSat = 5, SabahMinuta = 28, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 15, AksamSat = 20, AksamMinuta = 51, JacijaSat = 22, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 29, ZoraSat = 3, ZoraMinuta = 46, SabahSat = 5, SabahMinuta = 26, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 16, AksamSat = 20, AksamMinuta = 54, JacijaSat = 22, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 4, Dan = 30, ZoraSat = 3, ZoraMinuta = 44, SabahSat = 5, SabahMinuta = 23, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 17, AksamSat = 20, AksamMinuta = 56, JacijaSat = 22, JacijaMinuta = 29 });

            //MAJ
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 1, ZoraSat = 3, ZoraMinuta = 41, SabahSat = 5, SabahMinuta = 21, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 18, AksamSat = 20, AksamMinuta = 58, JacijaSat = 22, JacijaMinuta = 31 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 2, ZoraSat = 3, ZoraMinuta = 38, SabahSat = 5, SabahMinuta = 18, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 19, AksamSat = 21, AksamMinuta = 0, JacijaSat = 22, JacijaMinuta = 33 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 3, ZoraSat = 3, ZoraMinuta = 36, SabahSat = 5, SabahMinuta = 16, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 20, AksamSat = 21, AksamMinuta = 3, JacijaSat = 22, JacijaMinuta = 36 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 4, ZoraSat = 3, ZoraMinuta = 33, SabahSat = 5, SabahMinuta = 14, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 21, AksamSat = 21, AksamMinuta = 5, JacijaSat = 22, JacijaMinuta = 38 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 5, ZoraSat = 3, ZoraMinuta = 31, SabahSat = 5, SabahMinuta = 11, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 21, AksamSat = 21, AksamMinuta = 7, JacijaSat = 22, JacijaMinuta = 40 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 6, ZoraSat = 3, ZoraMinuta = 28, SabahSat = 5, SabahMinuta = 9, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 22, AksamSat = 21, AksamMinuta = 9, JacijaSat = 22, JacijaMinuta = 43 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 7, ZoraSat = 3, ZoraMinuta = 26, SabahSat = 5, SabahMinuta = 7, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 23, AksamSat = 21, AksamMinuta = 11, JacijaSat = 22, JacijaMinuta = 45 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 8, ZoraSat = 3, ZoraMinuta = 23, SabahSat = 5, SabahMinuta = 4, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 24, AksamSat = 21, AksamMinuta = 14, JacijaSat = 22, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 9, ZoraSat = 3, ZoraMinuta = 21, SabahSat = 5, SabahMinuta = 2, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 25, AksamSat = 21, AksamMinuta = 16, JacijaSat = 22, JacijaMinuta = 50 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 10, ZoraSat = 3, ZoraMinuta = 18, SabahSat = 5, SabahMinuta = 0, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 26, AksamSat = 21, AksamMinuta = 18, JacijaSat = 22, JacijaMinuta = 52 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 11, ZoraSat = 3, ZoraMinuta = 16, SabahSat = 4, SabahMinuta = 58, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 27, AksamSat = 21, AksamMinuta = 20, JacijaSat = 22, JacijaMinuta = 54 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 12, ZoraSat = 3, ZoraMinuta = 14, SabahSat = 4, SabahMinuta = 55, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 28, AksamSat = 21, AksamMinuta = 22, JacijaSat = 22, JacijaMinuta = 57 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 13, ZoraSat = 3, ZoraMinuta = 11, SabahSat = 4, SabahMinuta = 53, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 29, AksamSat = 21, AksamMinuta = 24, JacijaSat = 22, JacijaMinuta = 59 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 14, ZoraSat = 3, ZoraMinuta = 9, SabahSat = 4, SabahMinuta = 51, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 29, AksamSat = 21, AksamMinuta = 26, JacijaSat = 23, JacijaMinuta = 1 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 15, ZoraSat = 3, ZoraMinuta = 7, SabahSat = 4, SabahMinuta = 49, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 30, AksamSat = 21, AksamMinuta = 29, JacijaSat = 23, JacijaMinuta = 3 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 16, ZoraSat = 3, ZoraMinuta = 5, SabahSat = 4, SabahMinuta = 47, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 31, AksamSat = 21, AksamMinuta = 31, JacijaSat = 23, JacijaMinuta = 5 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 17, ZoraSat = 3, ZoraMinuta = 3, SabahSat = 4, SabahMinuta = 45, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 32, AksamSat = 21, AksamMinuta = 33, JacijaSat = 23, JacijaMinuta = 8 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 18, ZoraSat = 3, ZoraMinuta = 0, SabahSat = 4, SabahMinuta = 43, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 33, AksamSat = 21, AksamMinuta = 35, JacijaSat = 23, JacijaMinuta = 10 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 19, ZoraSat = 2, ZoraMinuta = 58, SabahSat = 4, SabahMinuta = 41, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 34, AksamSat = 21, AksamMinuta = 37, JacijaSat = 23, JacijaMinuta = 12 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 20, ZoraSat = 2, ZoraMinuta = 56, SabahSat = 4, SabahMinuta = 39, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 34, AksamSat = 21, AksamMinuta = 39, JacijaSat = 23, JacijaMinuta = 14 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 21, ZoraSat = 2, ZoraMinuta = 54, SabahSat = 4, SabahMinuta = 37, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 35, AksamSat = 21, AksamMinuta = 41, JacijaSat = 23, JacijaMinuta = 16 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 22, ZoraSat = 2, ZoraMinuta = 52, SabahSat = 4, SabahMinuta = 36, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 36, AksamSat = 21, AksamMinuta = 43, JacijaSat = 23, JacijaMinuta = 18 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 23, ZoraSat = 2, ZoraMinuta = 50, SabahSat = 4, SabahMinuta = 34, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 37, AksamSat = 21, AksamMinuta = 45, JacijaSat = 23, JacijaMinuta = 20 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 24, ZoraSat = 2, ZoraMinuta = 48, SabahSat = 4, SabahMinuta = 32, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 37, AksamSat = 21, AksamMinuta = 47, JacijaSat = 23, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 25, ZoraSat = 2, ZoraMinuta = 47, SabahSat = 4, SabahMinuta = 30, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 38, AksamSat = 21, AksamMinuta = 48, JacijaSat = 23, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 26, ZoraSat = 2, ZoraMinuta = 45, SabahSat = 4, SabahMinuta = 29, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 17, IkindijaMinuta = 39, AksamSat = 21, AksamMinuta = 50, JacijaSat = 23, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 27, ZoraSat = 2, ZoraMinuta = 43, SabahSat = 4, SabahMinuta = 27, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 39, AksamSat = 21, AksamMinuta = 52, JacijaSat = 23, JacijaMinuta = 28 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 28, ZoraSat = 2, ZoraMinuta = 42, SabahSat = 4, SabahMinuta = 26, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 40, AksamSat = 21, AksamMinuta = 54, JacijaSat = 23, JacijaMinuta = 30 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 29, ZoraSat = 2, ZoraMinuta = 40, SabahSat = 4, SabahMinuta = 24, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 41, AksamSat = 21, AksamMinuta = 55, JacijaSat = 23, JacijaMinuta = 32 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 30, ZoraSat = 2, ZoraMinuta = 38, SabahSat = 4, SabahMinuta = 23, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 41, AksamSat = 21, AksamMinuta = 57, JacijaSat = 23, JacijaMinuta = 33 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 5, Dan = 31, ZoraSat = 2, ZoraMinuta = 37, SabahSat = 4, SabahMinuta = 22, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 17, IkindijaMinuta = 42, AksamSat = 21, AksamMinuta = 59, JacijaSat = 23, JacijaMinuta = 35 });

            //JUNI


            //JULI
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 1, ZoraSat = 2, ZoraMinuta = 27, SabahSat = 4, SabahMinuta = 13, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 17, IkindijaMinuta = 53, AksamSat = 22, AksamMinuta = 19, JacijaSat = 23, JacijaMinuta = 56 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 2, ZoraSat = 2, ZoraMinuta = 28, SabahSat = 4, SabahMinuta = 14, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 17, IkindijaMinuta = 52, AksamSat = 22, AksamMinuta = 18, JacijaSat = 23, JacijaMinuta = 55 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 3, ZoraSat = 2, ZoraMinuta = 29, SabahSat = 4, SabahMinuta = 15, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 17, IkindijaMinuta = 52, AksamSat = 22, AksamMinuta = 18, JacijaSat = 23, JacijaMinuta = 55 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 4, ZoraSat = 2, ZoraMinuta = 30, SabahSat = 4, SabahMinuta = 16, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 52, AksamSat = 22, AksamMinuta = 17, JacijaSat = 23, JacijaMinuta = 54 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 5, ZoraSat = 2, ZoraMinuta = 32, SabahSat = 4, SabahMinuta = 17, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 52, AksamSat = 22, AksamMinuta = 16, JacijaSat = 23, JacijaMinuta = 53 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 6, ZoraSat = 2, ZoraMinuta = 33, SabahSat = 4, SabahMinuta = 18, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 52, AksamSat = 22, AksamMinuta = 15, JacijaSat = 23, JacijaMinuta = 52 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 7, ZoraSat = 2, ZoraMinuta = 34, SabahSat = 4, SabahMinuta = 20, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 52, AksamSat = 22, AksamMinuta = 15, JacijaSat = 23, JacijaMinuta = 51 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 8, ZoraSat = 2, ZoraMinuta = 35, SabahSat = 4, SabahMinuta = 21, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 52, AksamSat = 22, AksamMinuta = 14, JacijaSat = 23, JacijaMinuta = 50 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 9, ZoraSat = 2, ZoraMinuta = 37, SabahSat = 4, SabahMinuta = 22, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 51, AksamSat = 22, AksamMinuta = 13, JacijaSat = 23, JacijaMinuta = 49 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 10, ZoraSat = 2, ZoraMinuta = 38, SabahSat = 4, SabahMinuta = 24, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 51, AksamSat = 22, AksamMinuta = 12, JacijaSat = 23, JacijaMinuta = 48 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 11, ZoraSat = 2, ZoraMinuta = 40, SabahSat = 4, SabahMinuta = 25, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 51, AksamSat = 22, AksamMinuta = 10, JacijaSat = 23, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 12, ZoraSat = 2, ZoraMinuta = 41, SabahSat = 4, SabahMinuta = 26, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 51, AksamSat = 22, AksamMinuta = 9, JacijaSat = 23, JacijaMinuta = 46 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 13, ZoraSat = 2, ZoraMinuta = 43, SabahSat = 4, SabahMinuta = 28, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 50, AksamSat = 22, AksamMinuta = 8, JacijaSat = 23, JacijaMinuta = 44 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 14, ZoraSat = 2, ZoraMinuta = 45, SabahSat = 4, SabahMinuta = 29, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 50, AksamSat = 22, AksamMinuta = 7, JacijaSat = 23, JacijaMinuta = 43 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 15, ZoraSat = 2, ZoraMinuta = 46, SabahSat = 4, SabahMinuta = 31, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 50, AksamSat = 22, AksamMinuta = 5, JacijaSat = 23, JacijaMinuta = 41 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 16, ZoraSat = 2, ZoraMinuta = 48, SabahSat = 4, SabahMinuta = 33, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 49, AksamSat = 22, AksamMinuta = 4, JacijaSat = 23, JacijaMinuta = 40 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 17, ZoraSat = 2, ZoraMinuta = 50, SabahSat = 4, SabahMinuta = 34, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 49, AksamSat = 22, AksamMinuta = 2, JacijaSat = 23, JacijaMinuta = 38 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 18, ZoraSat = 2, ZoraMinuta = 52, SabahSat = 4, SabahMinuta = 36, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 48, AksamSat = 22, AksamMinuta = 1, JacijaSat = 23, JacijaMinuta = 37 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 19, ZoraSat = 2, ZoraMinuta = 54, SabahSat = 4, SabahMinuta = 38, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 48, AksamSat = 21, AksamMinuta = 59, JacijaSat = 23, JacijaMinuta = 35 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 20, ZoraSat = 2, ZoraMinuta = 56, SabahSat = 4, SabahMinuta = 40, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 47, AksamSat = 21, AksamMinuta = 57, JacijaSat = 23, JacijaMinuta = 33 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 21, ZoraSat = 2, ZoraMinuta = 58, SabahSat = 4, SabahMinuta = 41, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 47, AksamSat = 21, AksamMinuta = 56, JacijaSat = 23, JacijaMinuta = 32 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 22, ZoraSat = 3, ZoraMinuta = 0, SabahSat = 4, SabahMinuta = 43, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 46, AksamSat = 21, AksamMinuta = 54, JacijaSat = 23, JacijaMinuta = 30 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 23, ZoraSat = 3, ZoraMinuta = 2, SabahSat = 4, SabahMinuta = 45, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 45, AksamSat = 21, AksamMinuta = 52, JacijaSat = 23, JacijaMinuta = 28 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 24, ZoraSat = 3, ZoraMinuta = 4, SabahSat = 4, SabahMinuta = 47, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 45, AksamSat = 21, AksamMinuta = 50, JacijaSat = 23, JacijaMinuta = 36 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 25, ZoraSat = 3, ZoraMinuta = 6, SabahSat = 4, SabahMinuta = 49, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 44, AksamSat = 21, AksamMinuta = 49, JacijaSat = 23, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 26, ZoraSat = 3, ZoraMinuta = 8, SabahSat = 4, SabahMinuta = 51, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 43, AksamSat = 21, AksamMinuta = 47, JacijaSat = 23, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 27, ZoraSat = 3, ZoraMinuta = 10, SabahSat = 4, SabahMinuta = 53, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 43, AksamSat = 21, AksamMinuta = 45, JacijaSat = 23, JacijaMinuta = 20 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 28, ZoraSat = 3, ZoraMinuta = 12, SabahSat = 4, SabahMinuta = 55, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 42, AksamSat = 21, AksamMinuta = 43, JacijaSat = 23, JacijaMinuta = 18 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 29, ZoraSat = 3, ZoraMinuta = 14, SabahSat = 4, SabahMinuta = 57, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 41, AksamSat = 21, AksamMinuta = 41, JacijaSat = 23, JacijaMinuta = 16 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 30, ZoraSat = 3, ZoraMinuta = 17, SabahSat = 4, SabahMinuta = 59, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 40, AksamSat = 21, AksamMinuta = 39, JacijaSat = 23, JacijaMinuta = 13 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 7, Dan = 31, ZoraSat = 3, ZoraMinuta = 19, SabahSat = 5, SabahMinuta = 1, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 39, AksamSat = 21, AksamMinuta = 37, JacijaSat = 23, JacijaMinuta = 11 });

            //AUGUST
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 1, ZoraSat = 3, ZoraMinuta = 21, SabahSat = 5, SabahMinuta = 3, PodneSat = 13, PodneMinuta = 20, IkindijaSat = 17, IkindijaMinuta = 39, AksamSat = 21, AksamMinuta = 34, JacijaSat = 23, JacijaMinuta = 9 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 2, ZoraSat = 3, ZoraMinuta = 23, SabahSat = 5, SabahMinuta = 5, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 38, AksamSat = 21, AksamMinuta = 32, JacijaSat = 23, JacijaMinuta = 7 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 3, ZoraSat = 3, ZoraMinuta = 26, SabahSat = 5, SabahMinuta = 7, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 37, AksamSat = 21, AksamMinuta = 30, JacijaSat = 23, JacijaMinuta = 4 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 4, ZoraSat = 3, ZoraMinuta = 28, SabahSat = 5, SabahMinuta = 9, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 36, AksamSat = 21, AksamMinuta = 28, JacijaSat = 23, JacijaMinuta = 2 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 5, ZoraSat = 3, ZoraMinuta = 30, SabahSat = 5, SabahMinuta = 11, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 35, AksamSat = 21, AksamMinuta = 26, JacijaSat = 23, JacijaMinuta = 0 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 6, ZoraSat = 3, ZoraMinuta = 32, SabahSat = 5, SabahMinuta = 13, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 34, AksamSat = 21, AksamMinuta = 23, JacijaSat = 22, JacijaMinuta = 57 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 7, ZoraSat = 3, ZoraMinuta = 35, SabahSat = 5, SabahMinuta = 15, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 33, AksamSat = 21, AksamMinuta = 21, JacijaSat = 22, JacijaMinuta = 55 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 8, ZoraSat = 3, ZoraMinuta = 37, SabahSat = 5, SabahMinuta = 18, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 32, AksamSat = 21, AksamMinuta = 19, JacijaSat = 22, JacijaMinuta = 52 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 9, ZoraSat = 3, ZoraMinuta = 39, SabahSat = 5, SabahMinuta = 20, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 31, AksamSat = 21, AksamMinuta = 16, JacijaSat = 22, JacijaMinuta = 50 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 10, ZoraSat = 3, ZoraMinuta = 42, SabahSat = 5, SabahMinuta = 22, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 29, AksamSat = 21, AksamMinuta = 14, JacijaSat = 22, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 11, ZoraSat = 3, ZoraMinuta = 44, SabahSat = 5, SabahMinuta = 24, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 28, AksamSat = 21, AksamMinuta = 12, JacijaSat = 22, JacijaMinuta = 45 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 12, ZoraSat = 3, ZoraMinuta = 46, SabahSat = 5, SabahMinuta = 26, PodneSat = 13, PodneMinuta = 19, IkindijaSat = 17, IkindijaMinuta = 27, AksamSat = 21, AksamMinuta = 9, JacijaSat = 22, JacijaMinuta = 42 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 13, ZoraSat = 3, ZoraMinuta = 48, SabahSat = 5, SabahMinuta = 28, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 26, AksamSat = 21, AksamMinuta = 7, JacijaSat = 22, JacijaMinuta = 40 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 14, ZoraSat = 3, ZoraMinuta = 51, SabahSat = 5, SabahMinuta = 30, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 25, AksamSat = 21, AksamMinuta = 4, JacijaSat = 22, JacijaMinuta = 37 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 15, ZoraSat = 3, ZoraMinuta = 53, SabahSat = 5, SabahMinuta = 33, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 23, AksamSat = 21, AksamMinuta = 2, JacijaSat = 22, JacijaMinuta = 34 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 16, ZoraSat = 3, ZoraMinuta = 55, SabahSat = 5, SabahMinuta = 35, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 22, AksamSat = 20, AksamMinuta = 59, JacijaSat = 22, JacijaMinuta = 32 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 17, ZoraSat = 3, ZoraMinuta = 58, SabahSat = 5, SabahMinuta = 37, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 21, AksamSat = 20, AksamMinuta = 57, JacijaSat = 22, JacijaMinuta = 29 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 18, ZoraSat = 4, ZoraMinuta = 0, SabahSat = 5, SabahMinuta = 39, PodneSat = 13, PodneMinuta = 18, IkindijaSat = 17, IkindijaMinuta = 19, AksamSat = 20, AksamMinuta = 54, JacijaSat = 22, JacijaMinuta = 27 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 19, ZoraSat = 4, ZoraMinuta = 2, SabahSat = 5, SabahMinuta = 41, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 17, IkindijaMinuta = 18, AksamSat = 20, AksamMinuta = 52, JacijaSat = 22, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 20, ZoraSat = 4, ZoraMinuta = 5, SabahSat = 5, SabahMinuta = 43, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 17, IkindijaMinuta = 17, AksamSat = 20, AksamMinuta = 49, JacijaSat = 22, JacijaMinuta = 21 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 21, ZoraSat = 4, ZoraMinuta = 7, SabahSat = 5, SabahMinuta = 46, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 17, IkindijaMinuta = 15, AksamSat = 20, AksamMinuta = 46, JacijaSat = 22, JacijaMinuta = 19 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 22, ZoraSat = 4, ZoraMinuta = 9, SabahSat = 5, SabahMinuta = 48, PodneSat = 13, PodneMinuta = 17, IkindijaSat = 17, IkindijaMinuta = 14, AksamSat = 20, AksamMinuta = 44, JacijaSat = 22, JacijaMinuta = 16 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 23, ZoraSat = 4, ZoraMinuta = 11, SabahSat = 5, SabahMinuta = 50, PodneSat = 13, PodneMinuta = 16, IkindijaSat = 17, IkindijaMinuta = 12, AksamSat = 20, AksamMinuta = 41, JacijaSat = 22, JacijaMinuta = 13 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 24, ZoraSat = 4, ZoraMinuta = 14, SabahSat = 5, SabahMinuta = 52, PodneSat = 13, PodneMinuta = 16, IkindijaSat = 17, IkindijaMinuta = 11, AksamSat = 20, AksamMinuta = 39, JacijaSat = 22, JacijaMinuta = 10 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 25, ZoraSat = 4, ZoraMinuta = 16, SabahSat = 5, SabahMinuta = 54, PodneSat = 13, PodneMinuta = 16, IkindijaSat = 17, IkindijaMinuta = 9, AksamSat = 20, AksamMinuta = 36, JacijaSat = 22, JacijaMinuta = 8 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 26, ZoraSat = 4, ZoraMinuta = 18, SabahSat = 5, SabahMinuta = 56, PodneSat = 13, PodneMinuta = 16, IkindijaSat = 17, IkindijaMinuta = 8, AksamSat = 20, AksamMinuta = 33, JacijaSat = 22, JacijaMinuta = 5 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 27, ZoraSat = 4, ZoraMinuta = 21, SabahSat = 5, SabahMinuta = 58, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 17, IkindijaMinuta = 6, AksamSat = 20, AksamMinuta = 31, JacijaSat = 22, JacijaMinuta = 2 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 28, ZoraSat = 4, ZoraMinuta = 23, SabahSat = 6, SabahMinuta = 1, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 17, IkindijaMinuta = 5, AksamSat = 20, AksamMinuta = 28, JacijaSat = 21, JacijaMinuta = 59 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 29, ZoraSat = 4, ZoraMinuta = 25, SabahSat = 6, SabahMinuta = 3, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 17, IkindijaMinuta = 3, AksamSat = 20, AksamMinuta = 25, JacijaSat = 21, JacijaMinuta = 57 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 30, ZoraSat = 4, ZoraMinuta = 27, SabahSat = 6, SabahMinuta = 5, PodneSat = 13, PodneMinuta = 15, IkindijaSat = 17, IkindijaMinuta = 2, AksamSat = 20, AksamMinuta = 22, JacijaSat = 21, JacijaMinuta = 54 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 8, Dan = 31, ZoraSat = 4, ZoraMinuta = 29, SabahSat = 6, SabahMinuta = 7, PodneSat = 13, PodneMinuta = 14, IkindijaSat = 17, IkindijaMinuta = 0, AksamSat = 20, AksamMinuta = 20, JacijaSat = 21, JacijaMinuta = 51 });

            //SEPTEMBAR
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 1, ZoraSat = 4, ZoraMinuta = 32, SabahSat = 6, SabahMinuta = 9, PodneSat = 13, PodneMinuta = 14, IkindijaSat = 16, IkindijaMinuta = 58, AksamSat = 20, AksamMinuta = 17, JacijaSat = 21, JacijaMinuta = 48 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 2, ZoraSat = 4, ZoraMinuta = 34, SabahSat = 6, SabahMinuta = 11, PodneSat = 13, PodneMinuta = 14, IkindijaSat = 16, IkindijaMinuta = 57, AksamSat = 20, AksamMinuta = 14, JacijaSat = 21, JacijaMinuta = 45 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 3, ZoraSat = 4, ZoraMinuta = 36, SabahSat = 6, SabahMinuta = 13, PodneSat = 13, PodneMinuta = 13, IkindijaSat = 16, IkindijaMinuta = 55, AksamSat = 20, AksamMinuta = 12, JacijaSat = 21, JacijaMinuta = 43 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 4, ZoraSat = 4, ZoraMinuta = 38, SabahSat = 6, SabahMinuta = 16, PodneSat = 13, PodneMinuta = 13, IkindijaSat = 16, IkindijaMinuta = 53, AksamSat = 20, AksamMinuta = 9, JacijaSat = 21, JacijaMinuta = 40 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 5, ZoraSat = 4, ZoraMinuta = 40, SabahSat = 6, SabahMinuta = 18, PodneSat = 13, PodneMinuta = 13, IkindijaSat = 16, IkindijaMinuta = 51, AksamSat = 20, AksamMinuta = 6, JacijaSat = 21, JacijaMinuta = 37 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 6, ZoraSat = 4, ZoraMinuta = 43, SabahSat = 6, SabahMinuta = 20, PodneSat = 13, PodneMinuta = 12, IkindijaSat = 16, IkindijaMinuta = 50, AksamSat = 20, AksamMinuta = 3, JacijaSat = 21, JacijaMinuta = 34 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 7, ZoraSat = 4, ZoraMinuta = 45, SabahSat = 6, SabahMinuta = 22, PodneSat = 13, PodneMinuta = 12, IkindijaSat = 16, IkindijaMinuta = 48, AksamSat = 20, AksamMinuta = 0, JacijaSat = 21, JacijaMinuta = 31 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 8, ZoraSat = 4, ZoraMinuta = 47, SabahSat = 6, SabahMinuta = 24, PodneSat = 13, PodneMinuta = 12, IkindijaSat = 16, IkindijaMinuta = 46, AksamSat = 19, AksamMinuta = 58, JacijaSat = 21, JacijaMinuta = 29 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 9, ZoraSat = 4, ZoraMinuta = 49, SabahSat = 6, SabahMinuta = 26, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 16, IkindijaMinuta = 44, AksamSat = 19, AksamMinuta = 55, JacijaSat = 21, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 10, ZoraSat = 4, ZoraMinuta = 51, SabahSat = 6, SabahMinuta = 28, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 16, IkindijaMinuta = 42, AksamSat = 19, AksamMinuta = 52, JacijaSat = 21, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 11, ZoraSat = 4, ZoraMinuta = 53, SabahSat = 6, SabahMinuta = 30, PodneSat = 13, PodneMinuta = 11, IkindijaSat = 16, IkindijaMinuta = 41, AksamSat = 19, AksamMinuta = 49, JacijaSat = 21, JacijaMinuta = 20 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 12, ZoraSat = 4, ZoraMinuta = 55, SabahSat = 6, SabahMinuta = 32, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 16, IkindijaMinuta = 39, AksamSat = 19, AksamMinuta = 46, JacijaSat = 21, JacijaMinuta = 17 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 13, ZoraSat = 4, ZoraMinuta = 58, SabahSat = 6, SabahMinuta = 35, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 16, IkindijaMinuta = 37, AksamSat = 19, AksamMinuta = 44, JacijaSat = 21, JacijaMinuta = 15 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 14, ZoraSat = 5, ZoraMinuta = 0, SabahSat = 6, SabahMinuta = 37, PodneSat = 13, PodneMinuta = 10, IkindijaSat = 16, IkindijaMinuta = 35, AksamSat = 19, AksamMinuta = 41, JacijaSat = 21, JacijaMinuta = 12 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 15, ZoraSat = 5, ZoraMinuta = 2, SabahSat = 6, SabahMinuta = 39, PodneSat = 13, PodneMinuta = 9, IkindijaSat = 16, IkindijaMinuta = 33, AksamSat = 19, AksamMinuta = 38, JacijaSat = 21, JacijaMinuta = 9 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 16, ZoraSat = 5, ZoraMinuta = 4, SabahSat = 6, SabahMinuta = 41, PodneSat = 13, PodneMinuta = 9, IkindijaSat = 16, IkindijaMinuta = 31, AksamSat = 19, AksamMinuta = 35, JacijaSat = 21, JacijaMinuta = 6 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 17, ZoraSat = 5, ZoraMinuta = 6, SabahSat = 6, SabahMinuta = 43, PodneSat = 13, PodneMinuta = 9, IkindijaSat = 16, IkindijaMinuta = 29, AksamSat = 19, AksamMinuta = 32, JacijaSat = 21, JacijaMinuta = 3 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 18, ZoraSat = 5, ZoraMinuta = 8, SabahSat = 6, SabahMinuta = 45, PodneSat = 13, PodneMinuta = 8, IkindijaSat = 16, IkindijaMinuta = 27, AksamSat = 19, AksamMinuta = 29, JacijaSat = 21, JacijaMinuta = 1 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 19, ZoraSat = 5, ZoraMinuta = 10, SabahSat = 6, SabahMinuta = 47, PodneSat = 13, PodneMinuta = 8, IkindijaSat = 16, IkindijaMinuta = 25, AksamSat = 19, AksamMinuta = 27, JacijaSat = 20, JacijaMinuta = 58 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 20, ZoraSat = 5, ZoraMinuta = 12, SabahSat = 6, SabahMinuta = 49, PodneSat = 13, PodneMinuta = 7, IkindijaSat = 16, IkindijaMinuta = 23, AksamSat = 19, AksamMinuta = 24, JacijaSat = 20, JacijaMinuta = 55 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 21, ZoraSat = 5, ZoraMinuta = 14, SabahSat = 6, SabahMinuta = 51, PodneSat = 13, PodneMinuta = 7, IkindijaSat = 16, IkindijaMinuta = 21, AksamSat = 19, AksamMinuta = 21, JacijaSat = 20, JacijaMinuta = 52 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 22, ZoraSat = 5, ZoraMinuta = 16, SabahSat = 6, SabahMinuta = 53, PodneSat = 13, PodneMinuta = 7, IkindijaSat = 16, IkindijaMinuta = 19, AksamSat = 19, AksamMinuta = 18, JacijaSat = 20, JacijaMinuta = 50 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 23, ZoraSat = 5, ZoraMinuta = 18, SabahSat = 6, SabahMinuta = 56, PodneSat = 13, PodneMinuta = 6, IkindijaSat = 16, IkindijaMinuta = 17, AksamSat = 19, AksamMinuta = 15, JacijaSat = 20, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 24, ZoraSat = 5, ZoraMinuta = 20, SabahSat = 6, SabahMinuta = 58, PodneSat = 13, PodneMinuta = 6, IkindijaSat = 16, IkindijaMinuta = 15, AksamSat = 19, AksamMinuta = 12, JacijaSat = 20, JacijaMinuta = 44 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 25, ZoraSat = 5, ZoraMinuta = 22, SabahSat = 7, SabahMinuta = 0, PodneSat = 13, PodneMinuta = 6, IkindijaSat = 16, IkindijaMinuta = 13, AksamSat = 19, AksamMinuta = 10, JacijaSat = 20, JacijaMinuta = 41 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 26, ZoraSat = 5, ZoraMinuta = 24, SabahSat = 7, SabahMinuta = 2, PodneSat = 13, PodneMinuta = 5, IkindijaSat = 16, IkindijaMinuta = 11, AksamSat = 19, AksamMinuta = 7, JacijaSat = 20, JacijaMinuta = 39 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 27, ZoraSat = 5, ZoraMinuta = 26, SabahSat = 7, SabahMinuta = 4, PodneSat = 13, PodneMinuta = 5, IkindijaSat = 16, IkindijaMinuta = 9, AksamSat = 19, AksamMinuta = 4, JacijaSat = 20, JacijaMinuta = 36 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 28, ZoraSat = 5, ZoraMinuta = 28, SabahSat = 7, SabahMinuta = 6, PodneSat = 13, PodneMinuta = 4, IkindijaSat = 16, IkindijaMinuta = 7, AksamSat = 19, AksamMinuta = 1, JacijaSat = 20, JacijaMinuta = 33 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 29, ZoraSat = 5, ZoraMinuta = 30, SabahSat = 7, SabahMinuta = 8, PodneSat = 13, PodneMinuta = 4, IkindijaSat = 16, IkindijaMinuta = 5, AksamSat = 18, AksamMinuta = 58, JacijaSat = 20, JacijaMinuta = 30 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 9, Dan = 30, ZoraSat = 5, ZoraMinuta = 32, SabahSat = 7, SabahMinuta = 10, PodneSat = 13, PodneMinuta = 4, IkindijaSat = 16, IkindijaMinuta = 3, AksamSat = 18, AksamMinuta = 55, JacijaSat = 20, JacijaMinuta = 28 });

            //OKTOBAR
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 1, ZoraSat = 5, ZoraMinuta = 34, SabahSat = 7, SabahMinuta = 12, PodneSat = 13, PodneMinuta = 3, IkindijaSat = 16, IkindijaMinuta = 1, AksamSat = 18, AksamMinuta = 53, JacijaSat = 20, JacijaMinuta = 25 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 2, ZoraSat = 5, ZoraMinuta = 36, SabahSat = 7, SabahMinuta = 14, PodneSat = 13, PodneMinuta = 3, IkindijaSat = 15, IkindijaMinuta = 59, AksamSat = 18, AksamMinuta = 50, JacijaSat = 20, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 3, ZoraSat = 5, ZoraMinuta = 38, SabahSat = 7, SabahMinuta = 17, PodneSat = 13, PodneMinuta = 3, IkindijaSat = 15, IkindijaMinuta = 57, AksamSat = 18, AksamMinuta = 47, JacijaSat = 20, JacijaMinuta = 20 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 4, ZoraSat = 5, ZoraMinuta = 40, SabahSat = 7, SabahMinuta = 19, PodneSat = 13, PodneMinuta = 2, IkindijaSat = 15, IkindijaMinuta = 55, AksamSat = 18, AksamMinuta = 44, JacijaSat = 20, JacijaMinuta = 17 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 5, ZoraSat = 5, ZoraMinuta = 42, SabahSat = 7, SabahMinuta = 21, PodneSat = 13, PodneMinuta = 2, IkindijaSat = 15, IkindijaMinuta = 52, AksamSat = 18, AksamMinuta = 41, JacijaSat = 20, JacijaMinuta = 14 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 6, ZoraSat = 5, ZoraMinuta = 44, SabahSat = 7, SabahMinuta = 23, PodneSat = 13, PodneMinuta = 2, IkindijaSat = 15, IkindijaMinuta = 50, AksamSat = 18, AksamMinuta = 39, JacijaSat = 20, JacijaMinuta = 12 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 7, ZoraSat = 5, ZoraMinuta = 46, SabahSat = 7, SabahMinuta = 25, PodneSat = 13, PodneMinuta = 1, IkindijaSat = 15, IkindijaMinuta = 48, AksamSat = 18, AksamMinuta = 36, JacijaSat = 20, JacijaMinuta = 9 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 8, ZoraSat = 5, ZoraMinuta = 48, SabahSat = 7, SabahMinuta = 27, PodneSat = 13, PodneMinuta = 1, IkindijaSat = 15, IkindijaMinuta = 46, AksamSat = 18, AksamMinuta = 33, JacijaSat = 20, JacijaMinuta = 7 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 9, ZoraSat = 5, ZoraMinuta = 50, SabahSat = 7, SabahMinuta = 29, PodneSat = 13, PodneMinuta = 1, IkindijaSat = 15, IkindijaMinuta = 44, AksamSat = 18, AksamMinuta = 30, JacijaSat = 20, JacijaMinuta = 4 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 10, ZoraSat = 5, ZoraMinuta = 52, SabahSat = 7, SabahMinuta = 32, PodneSat = 13, PodneMinuta = 0, IkindijaSat = 15, IkindijaMinuta = 42, AksamSat = 18, AksamMinuta = 28, JacijaSat = 20, JacijaMinuta = 2 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 11, ZoraSat = 5, ZoraMinuta = 54, SabahSat = 7, SabahMinuta = 34, PodneSat = 13, PodneMinuta = 0, IkindijaSat = 15, IkindijaMinuta = 40, AksamSat = 18, AksamMinuta = 25, JacijaSat = 19, JacijaMinuta = 59 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 12, ZoraSat = 5, ZoraMinuta = 56, SabahSat = 7, SabahMinuta = 36, PodneSat = 13, PodneMinuta = 0, IkindijaSat = 15, IkindijaMinuta = 38, AksamSat = 18, AksamMinuta = 22, JacijaSat = 19, JacijaMinuta = 56 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 13, ZoraSat = 5, ZoraMinuta = 58, SabahSat = 7, SabahMinuta = 38, PodneSat = 13, PodneMinuta = 0, IkindijaSat = 15, IkindijaMinuta = 36, AksamSat = 18, AksamMinuta = 19, JacijaSat = 19, JacijaMinuta = 54 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 14, ZoraSat = 6, ZoraMinuta = 0, SabahSat = 7, SabahMinuta = 40, PodneSat = 12, PodneMinuta = 59, IkindijaSat = 15, IkindijaMinuta = 34, AksamSat = 18, AksamMinuta = 17, JacijaSat = 19, JacijaMinuta = 52 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 15, ZoraSat = 6, ZoraMinuta = 1, SabahSat = 7, SabahMinuta = 42, PodneSat = 12, PodneMinuta = 59, IkindijaSat = 15, IkindijaMinuta = 32, AksamSat = 18, AksamMinuta = 14, JacijaSat = 19, JacijaMinuta = 49 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 16, ZoraSat = 6, ZoraMinuta = 3, SabahSat = 7, SabahMinuta = 45, PodneSat = 12, PodneMinuta = 59, IkindijaSat = 15, IkindijaMinuta = 30, AksamSat = 18, AksamMinuta = 11, JacijaSat = 19, JacijaMinuta = 47 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 17, ZoraSat = 6, ZoraMinuta = 5, SabahSat = 7, SabahMinuta = 47, PodneSat = 12, PodneMinuta = 59, IkindijaSat = 15, IkindijaMinuta = 28, AksamSat = 18, AksamMinuta = 9, JacijaSat = 19, JacijaMinuta = 44 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 18, ZoraSat = 6, ZoraMinuta = 7, SabahSat = 7, SabahMinuta = 49, PodneSat = 12, PodneMinuta = 58, IkindijaSat = 15, IkindijaMinuta = 26, AksamSat = 18, AksamMinuta = 6, JacijaSat = 19, JacijaMinuta = 42 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 19, ZoraSat = 6, ZoraMinuta = 9, SabahSat = 7, SabahMinuta = 51, PodneSat = 12, PodneMinuta = 58, IkindijaSat = 15, IkindijaMinuta = 24, AksamSat = 18, AksamMinuta = 3, JacijaSat = 19, JacijaMinuta = 39 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 20, ZoraSat = 6, ZoraMinuta = 11, SabahSat = 7, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 58, IkindijaSat = 15, IkindijaMinuta = 22, AksamSat = 18, AksamMinuta = 1, JacijaSat = 19, JacijaMinuta = 37 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 21, ZoraSat = 6, ZoraMinuta = 13, SabahSat = 7, SabahMinuta = 56, PodneSat = 12, PodneMinuta = 58, IkindijaSat = 15, IkindijaMinuta = 20, AksamSat = 17, AksamMinuta = 58, JacijaSat = 19, JacijaMinuta = 35 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 22, ZoraSat = 6, ZoraMinuta = 15, SabahSat = 7, SabahMinuta = 58, PodneSat = 12, PodneMinuta = 58, IkindijaSat = 15, IkindijaMinuta = 18, AksamSat = 17, AksamMinuta = 56, JacijaSat = 19, JacijaMinuta = 32 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 23, ZoraSat = 6, ZoraMinuta = 17, SabahSat = 8, SabahMinuta = 0, PodneSat = 12, PodneMinuta = 58, IkindijaSat = 15, IkindijaMinuta = 16, AksamSat = 17, AksamMinuta = 53, JacijaSat = 19, JacijaMinuta = 30 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 24, ZoraSat = 6, ZoraMinuta = 19, SabahSat = 8, SabahMinuta = 3, PodneSat = 12, PodneMinuta = 57, IkindijaSat = 15, IkindijaMinuta = 14, AksamSat = 17, AksamMinuta = 50, JacijaSat = 19, JacijaMinuta = 28 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 25, ZoraSat = 5, ZoraMinuta = 21, SabahSat = 8, SabahMinuta = 5, PodneSat = 12, PodneMinuta = 57, IkindijaSat = 15, IkindijaMinuta = 12, AksamSat = 17, AksamMinuta = 48, JacijaSat = 19, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 26, ZoraSat = 6, ZoraMinuta = 23, SabahSat = 8, SabahMinuta = 7, PodneSat = 12, PodneMinuta = 57, IkindijaSat = 15, IkindijaMinuta = 10, AksamSat = 17, AksamMinuta = 45, JacijaSat = 19, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 27, ZoraSat = 6, ZoraMinuta = 25, SabahSat = 8, SabahMinuta = 9, PodneSat = 12, PodneMinuta = 57, IkindijaSat = 15, IkindijaMinuta = 8, AksamSat = 17, AksamMinuta = 43, JacijaSat = 19, JacijaMinuta = 21 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 28, ZoraSat = 5, ZoraMinuta = 27, SabahSat = 7, SabahMinuta = 12, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 14, IkindijaMinuta = 6, AksamSat = 16, AksamMinuta = 40, JacijaSat = 18, JacijaMinuta = 19 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 29, ZoraSat = 5, ZoraMinuta = 29, SabahSat = 7, SabahMinuta = 14, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 14, IkindijaMinuta = 4, AksamSat = 16, AksamMinuta = 38, JacijaSat = 18, JacijaMinuta = 17 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 30, ZoraSat = 5, ZoraMinuta = 31, SabahSat = 7, SabahMinuta = 16, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 14, IkindijaMinuta = 2, AksamSat = 16, AksamMinuta = 36, JacijaSat = 18, JacijaMinuta = 15 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 10, Dan = 31, ZoraSat = 5, ZoraMinuta = 33, SabahSat = 7, SabahMinuta = 18, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 14, IkindijaMinuta = 0, AksamSat = 16, AksamMinuta = 33, JacijaSat = 18, JacijaMinuta = 13 });

            //NOVEMBAR
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 1, ZoraSat = 5, ZoraMinuta = 35, SabahSat = 7, SabahMinuta = 21, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 59, AksamSat = 16, AksamMinuta = 31, JacijaSat = 18, JacijaMinuta = 11 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 2, ZoraSat = 5, ZoraMinuta = 37, SabahSat = 7, SabahMinuta = 23, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 57, AksamSat = 16, AksamMinuta = 28, JacijaSat = 18, JacijaMinuta = 9 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 3, ZoraSat = 5, ZoraMinuta = 38, SabahSat = 7, SabahMinuta = 25, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 55, AksamSat = 16, AksamMinuta = 26, JacijaSat = 18, JacijaMinuta = 7 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 4, ZoraSat = 5, ZoraMinuta = 40, SabahSat = 7, SabahMinuta = 28, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 53, AksamSat = 16, AksamMinuta = 24, JacijaSat = 18, JacijaMinuta = 5 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 5, ZoraSat = 5, ZoraMinuta = 42, SabahSat = 7, SabahMinuta = 30, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 52, AksamSat = 16, AksamMinuta = 22, JacijaSat = 18, JacijaMinuta = 3 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 6, ZoraSat = 5, ZoraMinuta = 44, SabahSat = 7, SabahMinuta = 32, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 50, AksamSat = 16, AksamMinuta = 19, JacijaSat = 18, JacijaMinuta = 1 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 7, ZoraSat = 5, ZoraMinuta = 46, SabahSat = 7, SabahMinuta = 35, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 48, AksamSat = 16, AksamMinuta = 17, JacijaSat = 17, JacijaMinuta = 59 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 8, ZoraSat = 5, ZoraMinuta = 48, SabahSat = 7, SabahMinuta = 37, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 47, AksamSat = 16, AksamMinuta = 15, JacijaSat = 17, JacijaMinuta = 58 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 9, ZoraSat = 5, ZoraMinuta = 50, SabahSat = 7, SabahMinuta = 39, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 45, AksamSat = 16, AksamMinuta = 13, JacijaSat = 17, JacijaMinuta = 56 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 10, ZoraSat = 5, ZoraMinuta = 52, SabahSat = 7, SabahMinuta = 42, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 44, AksamSat = 16, AksamMinuta = 11, JacijaSat = 17, JacijaMinuta = 54 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 11, ZoraSat = 5, ZoraMinuta = 54, SabahSat = 7, SabahMinuta = 44, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 42, AksamSat = 16, AksamMinuta = 9, JacijaSat = 17, JacijaMinuta = 52 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 12, ZoraSat = 5, ZoraMinuta = 56, SabahSat = 7, SabahMinuta = 46, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 41, AksamSat = 16, AksamMinuta = 7, JacijaSat = 17, JacijaMinuta = 51 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 13, ZoraSat = 5, ZoraMinuta = 58, SabahSat = 7, SabahMinuta = 48, PodneSat = 11, PodneMinuta = 57, IkindijaSat = 13, IkindijaMinuta = 39, AksamSat = 16, AksamMinuta = 5, JacijaSat = 17, JacijaMinuta = 49 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 14, ZoraSat = 6, ZoraMinuta = 0, SabahSat = 7, SabahMinuta = 51, PodneSat = 11, PodneMinuta = 58, IkindijaSat = 13, IkindijaMinuta = 38, AksamSat = 16, AksamMinuta = 3, JacijaSat = 17, JacijaMinuta = 48 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 15, ZoraSat = 6, ZoraMinuta = 1, SabahSat = 7, SabahMinuta = 53, PodneSat = 11, PodneMinuta = 58, IkindijaSat = 13, IkindijaMinuta = 37, AksamSat = 16, AksamMinuta = 1, JacijaSat = 17, JacijaMinuta = 46 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 16, ZoraSat = 6, ZoraMinuta = 3, SabahSat = 7, SabahMinuta = 55, PodneSat = 0, PodneMinuta = 0, IkindijaSat = 13, IkindijaMinuta = 35, AksamSat = 15, AksamMinuta = 59, JacijaSat = 17, JacijaMinuta = 45 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 17, ZoraSat = 6, ZoraMinuta = 5, SabahSat = 7, SabahMinuta = 57, PodneSat = 11, PodneMinuta = 58, IkindijaSat = 13, IkindijaMinuta = 34, AksamSat = 15, AksamMinuta = 57, JacijaSat = 17, JacijaMinuta = 43 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 18, ZoraSat = 6, ZoraMinuta = 7, SabahSat = 8, SabahMinuta = 0, PodneSat = 11, PodneMinuta = 58, IkindijaSat = 13, IkindijaMinuta = 33, AksamSat = 15, AksamMinuta = 55, JacijaSat = 17, JacijaMinuta = 42 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 19, ZoraSat = 6, ZoraMinuta = 9, SabahSat = 8, SabahMinuta = 2, PodneSat = 11, PodneMinuta = 59, IkindijaSat = 13, IkindijaMinuta = 31, AksamSat = 15, AksamMinuta = 54, JacijaSat = 17, JacijaMinuta = 40 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 20, ZoraSat = 6, ZoraMinuta = 11, SabahSat = 8, SabahMinuta = 4, PodneSat = 11, PodneMinuta = 59, IkindijaSat = 13, IkindijaMinuta = 30, AksamSat = 15, AksamMinuta = 52, JacijaSat = 17, JacijaMinuta = 39 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 21, ZoraSat = 6, ZoraMinuta = 12, SabahSat = 8, SabahMinuta = 6, PodneSat = 11, PodneMinuta = 59, IkindijaSat = 13, IkindijaMinuta = 29, AksamSat = 15, AksamMinuta = 50, JacijaSat = 17, JacijaMinuta = 38 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 22, ZoraSat = 6, ZoraMinuta = 14, SabahSat = 8, SabahMinuta = 8, PodneSat = 11, PodneMinuta = 59, IkindijaSat = 13, IkindijaMinuta = 28, AksamSat = 15, AksamMinuta = 49, JacijaSat = 17, JacijaMinuta = 36 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 23, ZoraSat = 6, ZoraMinuta = 16, SabahSat = 8, SabahMinuta = 10, PodneSat = 12, PodneMinuta = 0, IkindijaSat = 13, IkindijaMinuta = 27, AksamSat = 15, AksamMinuta = 47, JacijaSat = 17, JacijaMinuta = 35 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 24, ZoraSat = 6, ZoraMinuta = 18, SabahSat = 8, SabahMinuta = 13, PodneSat = 12, PodneMinuta = 0, IkindijaSat = 13, IkindijaMinuta = 26, AksamSat = 15, AksamMinuta = 46, JacijaSat = 17, JacijaMinuta = 34 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 25, ZoraSat = 6, ZoraMinuta = 19, SabahSat = 8, SabahMinuta = 15, PodneSat = 12, PodneMinuta = 0, IkindijaSat = 13, IkindijaMinuta = 25, AksamSat = 15, AksamMinuta = 44, JacijaSat = 17, JacijaMinuta = 33 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 26, ZoraSat = 6, ZoraMinuta = 21, SabahSat = 8, SabahMinuta = 17, PodneSat = 12, PodneMinuta = 1, IkindijaSat = 13, IkindijaMinuta = 24, AksamSat = 15, AksamMinuta = 43, JacijaSat = 17, JacijaMinuta = 32 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 27, ZoraSat = 6, ZoraMinuta = 23, SabahSat = 8, SabahMinuta = 19, PodneSat = 12, PodneMinuta = 1, IkindijaSat = 13, IkindijaMinuta = 23, AksamSat = 15, AksamMinuta = 41, JacijaSat = 17, JacijaMinuta = 31 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 28, ZoraSat = 6, ZoraMinuta = 24, SabahSat = 8, SabahMinuta = 21, PodneSat = 12, PodneMinuta = 1, IkindijaSat = 13, IkindijaMinuta = 22, AksamSat = 15, AksamMinuta = 40, JacijaSat = 17, JacijaMinuta = 30 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 29, ZoraSat = 6, ZoraMinuta = 26, SabahSat = 8, SabahMinuta = 23, PodneSat = 12, PodneMinuta = 2, IkindijaSat = 13, IkindijaMinuta = 22, AksamSat = 15, AksamMinuta = 39, JacijaSat = 17, JacijaMinuta = 29 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 11, Dan = 30, ZoraSat = 6, ZoraMinuta = 27, SabahSat = 8, SabahMinuta = 25, PodneSat = 12, PodneMinuta = 2, IkindijaSat = 13, IkindijaMinuta = 21, AksamSat = 15, AksamMinuta = 38, JacijaSat = 17, JacijaMinuta = 28 });

            //DECEMBAR
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 1, ZoraSat = 6, ZoraMinuta = 29, SabahSat = 8, SabahMinuta = 26, PodneSat = 12, PodneMinuta = 2, IkindijaSat = 13, IkindijaMinuta = 20, AksamSat = 15, AksamMinuta = 37, JacijaSat = 17, JacijaMinuta = 28 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 2, ZoraSat = 6, ZoraMinuta = 30, SabahSat = 8, SabahMinuta = 28, PodneSat = 12, PodneMinuta = 3, IkindijaSat = 13, IkindijaMinuta = 20, AksamSat = 15, AksamMinuta = 36, JacijaSat = 17, JacijaMinuta = 27 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 3, ZoraSat = 6, ZoraMinuta = 32, SabahSat = 8, SabahMinuta = 30, PodneSat = 12, PodneMinuta = 3, IkindijaSat = 13, IkindijaMinuta = 19, AksamSat = 15, AksamMinuta = 35, JacijaSat = 17, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 4, ZoraSat = 6, ZoraMinuta = 33, SabahSat = 8, SabahMinuta = 32, PodneSat = 12, PodneMinuta = 4, IkindijaSat = 13, IkindijaMinuta = 19, AksamSat = 15, AksamMinuta = 34, JacijaSat = 17, JacijaMinuta = 25 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 5, ZoraSat = 6, ZoraMinuta = 35, SabahSat = 8, SabahMinuta = 33, PodneSat = 12, PodneMinuta = 4, IkindijaSat = 13, IkindijaMinuta = 18, AksamSat = 15, AksamMinuta = 33, JacijaSat = 17, JacijaMinuta = 25 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 6, ZoraSat = 6, ZoraMinuta = 36, SabahSat = 8, SabahMinuta = 35, PodneSat = 12, PodneMinuta = 4, IkindijaSat = 13, IkindijaMinuta = 18, AksamSat = 15, AksamMinuta = 32, JacijaSat = 17, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 7, ZoraSat = 6, ZoraMinuta = 37, SabahSat = 8, SabahMinuta = 37, PodneSat = 12, PodneMinuta = 5, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 31, JacijaSat = 17, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 8, ZoraSat = 6, ZoraMinuta = 39, SabahSat = 8, SabahMinuta = 38, PodneSat = 12, PodneMinuta = 5, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 31, JacijaSat = 17, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 9, ZoraSat = 6, ZoraMinuta = 40, SabahSat = 8, SabahMinuta = 40, PodneSat = 12, PodneMinuta = 6, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 30, JacijaSat = 17, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 10, ZoraSat = 6, ZoraMinuta = 41, SabahSat = 8, SabahMinuta = 41, PodneSat = 12, PodneMinuta = 6, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 30, JacijaSat = 17, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 11, ZoraSat = 6, ZoraMinuta = 42, SabahSat = 8, SabahMinuta = 42, PodneSat = 12, PodneMinuta = 7, IkindijaSat = 13, IkindijaMinuta = 16, AksamSat = 15, AksamMinuta = 29, JacijaSat = 17, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 12, ZoraSat = 6, ZoraMinuta = 43, SabahSat = 8, SabahMinuta = 44, PodneSat = 12, PodneMinuta = 7, IkindijaSat = 13, IkindijaMinuta = 16, AksamSat = 15, AksamMinuta = 29, JacijaSat = 17, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 13, ZoraSat = 6, ZoraMinuta = 44, SabahSat = 8, SabahMinuta = 45, PodneSat = 12, PodneMinuta = 8, IkindijaSat = 13, IkindijaMinuta = 16, AksamSat = 15, AksamMinuta = 29, JacijaSat = 17, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 14, ZoraSat = 6, ZoraMinuta = 45, SabahSat = 8, SabahMinuta = 46, PodneSat = 12, PodneMinuta = 8, IkindijaSat = 13, IkindijaMinuta = 16, AksamSat = 15, AksamMinuta = 28, JacijaSat = 17, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 15, ZoraSat = 6, ZoraMinuta = 46, SabahSat = 8, SabahMinuta = 47, PodneSat = 12, PodneMinuta = 9, IkindijaSat = 13, IkindijaMinuta = 16, AksamSat = 15, AksamMinuta = 28, JacijaSat = 17, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 16, ZoraSat = 6, ZoraMinuta = 47, SabahSat = 8, SabahMinuta = 48, PodneSat = 12, PodneMinuta = 9, IkindijaSat = 13, IkindijaMinuta = 16, AksamSat = 15, AksamMinuta = 28, JacijaSat = 17, JacijaMinuta = 22 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 17, ZoraSat = 6, ZoraMinuta = 48, SabahSat = 8, SabahMinuta = 49, PodneSat = 12, PodneMinuta = 10, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 28, JacijaSat = 17, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 18, ZoraSat = 6, ZoraMinuta = 49, SabahSat = 8, SabahMinuta = 50, PodneSat = 12, PodneMinuta = 10, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 28, JacijaSat = 17, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 19, ZoraSat = 6, ZoraMinuta = 49, SabahSat = 8, SabahMinuta = 51, PodneSat = 12, PodneMinuta = 10, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 29, JacijaSat = 17, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 20, ZoraSat = 6, ZoraMinuta = 50, SabahSat = 8, SabahMinuta = 51, PodneSat = 12, PodneMinuta = 11, IkindijaSat = 13, IkindijaMinuta = 17, AksamSat = 15, AksamMinuta = 29, JacijaSat = 17, JacijaMinuta = 23 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 21, ZoraSat = 6, ZoraMinuta = 51, SabahSat = 8, SabahMinuta = 52, PodneSat = 12, PodneMinuta = 11, IkindijaSat = 13, IkindijaMinuta = 18, AksamSat = 15, AksamMinuta = 29, JacijaSat = 17, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 22, ZoraSat = 6, ZoraMinuta = 51, SabahSat = 8, SabahMinuta = 52, PodneSat = 12, PodneMinuta = 12, IkindijaSat = 13, IkindijaMinuta = 18, AksamSat = 15, AksamMinuta = 30, JacijaSat = 17, JacijaMinuta = 24 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 23, ZoraSat = 6, ZoraMinuta = 52, SabahSat = 8, SabahMinuta = 53, PodneSat = 12, PodneMinuta = 12, IkindijaSat = 13, IkindijaMinuta = 19, AksamSat = 15, AksamMinuta = 30, JacijaSat = 17, JacijaMinuta = 25 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 24, ZoraSat = 6, ZoraMinuta = 52, SabahSat = 8, SabahMinuta = 53, PodneSat = 12, PodneMinuta = 13, IkindijaSat = 13, IkindijaMinuta = 19, AksamSat = 15, AksamMinuta = 31, JacijaSat = 17, JacijaMinuta = 25 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 25, ZoraSat = 6, ZoraMinuta = 52, SabahSat = 8, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 13, IkindijaSat = 13, IkindijaMinuta = 20, AksamSat = 15, AksamMinuta = 31, JacijaSat = 17, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 26, ZoraSat = 6, ZoraMinuta = 53, SabahSat = 8, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 14, IkindijaSat = 13, IkindijaMinuta = 21, AksamSat = 15, AksamMinuta = 32, JacijaSat = 17, JacijaMinuta = 26 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 27, ZoraSat = 6, ZoraMinuta = 53, SabahSat = 8, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 14, IkindijaSat = 13, IkindijaMinuta = 21, AksamSat = 15, AksamMinuta = 33, JacijaSat = 17, JacijaMinuta = 27 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 28, ZoraSat = 6, ZoraMinuta = 53, SabahSat = 8, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 15, IkindijaSat = 13, IkindijaMinuta = 22, AksamSat = 15, AksamMinuta = 34, JacijaSat = 17, JacijaMinuta = 28 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 29, ZoraSat = 6, ZoraMinuta = 53, SabahSat = 8, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 15, IkindijaSat = 13, IkindijaMinuta = 23, AksamSat = 15, AksamMinuta = 35, JacijaSat = 17, JacijaMinuta = 29 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 30, ZoraSat = 6, ZoraMinuta = 53, SabahSat = 8, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 16, IkindijaSat = 13, IkindijaMinuta = 23, AksamSat = 15, AksamMinuta = 36, JacijaSat = 17, JacijaMinuta = 30 });
            kompletnaVaktija.Add(new JedanDan() { Mjesec = 12, Dan = 31, ZoraSat = 6, ZoraMinuta = 53, SabahSat = 8, SabahMinuta = 54, PodneSat = 12, PodneMinuta = 16, IkindijaSat = 13, IkindijaMinuta = 24, AksamSat = 15, AksamMinuta = 37, JacijaSat = 17, JacijaMinuta = 30 });

            //vrati listu
            return kompletnaVaktija;
        }
    }
    public class JedanDan
    {
        //Propertiji potrebni za objekat jednog dana
        public int Mjesec { get; set; }
        public int Dan { get; set; }

        public int ZoraSat { get; set; }
        public int ZoraMinuta { get; set; }

        public int SabahSat { get; set; }
        public int SabahMinuta { get; set; }

        public int PodneSat { get; set; }
        public int PodneMinuta { get; set; }

        public int IkindijaSat { get; set; }
        public int IkindijaMinuta { get; set; }

        public int AksamSat { get; set; }
        public int AksamMinuta { get; set; }

        public int JacijaSat { get; set; }
        public int JacijaMinuta { get; set; }
    }
    public class VaktijaProperty
    {
        //CAROBNI SASTOJCI VAKTIJE
        private PrivateFontCollection pfc { get; set; }
        private Rectangle ekran { get; set; }
        private int visinaEkrana { get; set; }
        private int sirinaEkrana { get; set; }
        private int visinaForme { get; set; }
        private int sirinaForme { get; set; }
        private Image pozadina { get; set; }
        private Image zoraSlika { get; set; }
        private Image sabahSlika { get; set; }
        private Image podneSlika { get; set; }
        private Image ikindijaSlika { get; set; }
        private Image aksamSlika { get; set; }
        private Image jacijaSlika { get; set; }
        private int[,] x1y1x2y2 { get; set; }
        private double koeficijentVisine { get; set; }
        private double koeficijentSirine { get; set; }
        private double racioSlike { get; set; }
        private int fontVrijemeSize { get; set; }
        private int fontVrijemeVisina { get; set; }
        private int fontVrijemeSirina { get; set; }
        private int fontDvotackaVisina { get; set; }
        private int fontDvotackaSirina { get; set; }

        //KONSTRUKTOR - poziva sve funkcije koje preracunavaju potrebne stvari za normalan rad vaktije jer je u pitanju dinamicno prikazivanje
        public VaktijaProperty()
        {
            PodesiFont(); 
            PodesiPozadinu(); 
            PodesiEkran();
            PodesiFormu();
            Podesix1y1x2y2(); //POzicija label-a u koje se upisuju namaska vremena
            PodesiNamaskeSlike(); //Pozicija slika koje prikazuju trenutni namaz
            PodesiPozicijuSata(); //POzicija glavnog sata
            PodesiPomocneSlike(); //Pozicija slika koje se random prikazuju
        }

        //SKRIVENE STVARI KOJE POMAZU KONSTRUKOTRU
        private void PodesiFont()
        {
            //Font je dio resursa
            this.pfc = new PrivateFontCollection();
            this.pfc.AddFontFile(@"C:\Users\arnes.beganovic\source\repos\Vaktija\Vaktija\Resources\digital-7.ttf");
        }
        private void PodesiPozadinu()
        {
            //Pozadina je dio resursa
            object O = Properties.Resources.ResourceManager.GetObject("Pozadina");
            this.pozadina = (Image)O;
        }
        private void PodesiNamaskeSlike()
        {
            //Namaske slike su dio resursa
            object zora = Properties.Resources.ResourceManager.GetObject("zoraSlika");
            object sabah = Properties.Resources.ResourceManager.GetObject("sabahSlika");
            object podne = Properties.Resources.ResourceManager.GetObject("podneSlika");
            object ikindija = Properties.Resources.ResourceManager.GetObject("ikindijaSlika");
            object aksam = Properties.Resources.ResourceManager.GetObject("aksamSlika");
            object jacija = Properties.Resources.ResourceManager.GetObject("jacijaSlika");
            this.zoraSlika = (Image)zora;
            this.sabahSlika = (Image)sabah;
            this.podneSlika = (Image)podne;
            this.ikindijaSlika = (Image)ikindija;
            this.aksamSlika = (Image)aksam;
            this.jacijaSlika = (Image)jacija;

            
        }
        private void PodesiEkran()
        {
            //Podesavanje visine i sirine displeja kako bi se dinamicki postavile ostale stvari
            this.ekran = Screen.PrimaryScreen.WorkingArea;
            this.visinaEkrana = ekran.Height;
            this.sirinaEkrana = ekran.Width;
            this.koeficijentVisine  = (double)this.visinaEkrana / (double)this.pozadina.Height;
        }
        private void PodesiFormu()
        {
            //Na bazi ekrana podesi izgled forme dinamicki
            this.racioSlike = (Double)pozadina.Height / (double)pozadina.Width;
            this.visinaForme = this.visinaEkrana;
            this.sirinaForme = (int)Math.Round(this.visinaEkrana / this.racioSlike, 1);
            this.koeficijentSirine = (double)this.sirinaForme / (double)this.pozadina.Width;
        }
        private void Podesix1y1x2y2()
        {
            //TBD - Finalna verzija koda treba imati neki sistem u kojem ce se uz pozadinu automatski povuci koordinate za predvidjena polja svakog namaza. Do tada koristim hard coded verziju
            this.x1y1x2y2 = new int[,] { 
                { 224,290,395,348 }, //Zora 
                { 224,379,395,437 }, //Izlazak Sunca
                { 224,468,395,526 }, //Podne
                { 224,557,395,614 }, //Ikindija
                { 224,646,395,704 }, //Aksam
                { 224,737,395,793 }  //Jacija
            };
        }

        //JAVNE STVARI DOSTUPNE DRUGIM KLASAMA
        public void PostaviVelicinuVremenskogFonta(FormaVaktije fv)
        {
            //Ova funkcija se racuna u runtime-u zato je public a poziva je sama forma nakon sto se loadira i izgradi radno okruzenje. Treba mi takva da joj dodam label i nadjem
            //kolika je maksimalna velicina fonta kojeg smijem dodati kako bi se uklopio u nacrtano polje. Radi tako sto uzmem Sabah namaz i napisem 00 te racunam u pravogaoniku koji mi je
            //zadan.
            int X1, Y1, X2, Y2;
            X1 = this.ParentKvadratZaNamaskiFrame(0)[0];
            Y1 = this.ParentKvadratZaNamaskiFrame(0)[1];
            X2 = this.ParentKvadratZaNamaskiFrame(0)[2];
            Y2 = this.ParentKvadratZaNamaskiFrame(0)[3];

            Label testniL = new Label();
            Label testniD = new Label();

            fv.Controls.Add(testniL);
            fv.Controls.Add(testniD);

            testniL.Text = "00";
            testniD.Text = ":";

            testniL.AutoSize = true;
            testniD.AutoSize = true;

            testniL.Font = new Font(this.FontFamilija(), 1, FontStyle.Regular);

            int n = 1;
            while (testniL.Height < Y2 - Y1 || testniL.Width < (X2 - X1) / 2)
            {
                testniL.Font = new Font(this.FontFamilija(), n, FontStyle.Regular);
                n++;
            }

            this.fontVrijemeVisina = testniL.Height + 2; //Dodaj 2 piksela zbog margine
            this.fontVrijemeSirina = testniL.Width + 2; //Dodaj 2 piksela zbog margine

            //Svrha cijelog koda je da imam izracunatu velicinu fonta kojeg cu koristiti za namaze.
            this.fontVrijemeSize = n;

            testniD.Font = new Font(this.FontFamilija(), this.fontVrijemeSize, FontStyle.Regular);
            this.fontDvotackaVisina = testniD.Height + 2; //Dodaj 2 piksela zbog margine
            this.fontDvotackaSirina = testniD.Width + 2; //Dodaj 2 piksela zbog margine

            fv.Controls.Remove(testniL);
            fv.Controls.Remove(testniD);

        }
        public int VisinaEkrana()
        {
            return this.visinaEkrana;
        }
        public int SirinaEkrana()
        {
            return this.sirinaEkrana;
        }
        public int SirinaForme()
        {
            return sirinaForme;
        }
        public int VisinaForme()
        {
            return visinaForme;
        }
        public int VelicinaVremenskogFonta()
        {
            return this.fontVrijemeSize;
        }
        public int VisinaVremenskogFonta()
        {
            return this.fontVrijemeVisina;
        }
        public int SirinaVremenskogFonta()
        {
            return this.fontVrijemeSirina;
        }
        public int VisinaDvotackeFonta()
        {
            return this.fontDvotackaVisina;
        }
        public int SirinaDvotackeFonta()
        {
            return this.fontDvotackaSirina;
        }
        public int[] ParentKvadratZaNamaskiFrame(int i)
        {
            //i je namaz cija vremena zelim povuci. za i bude 0 = zora, 1 = izlazak sunca, 2 = podne, 3 = ikindija, 4=aksam, 5 = jacija
            //Posto je sve dinamicki moram preracunati poziciju kvadrata za namasko vrijeme na bazi ekrana i pozadinske slike.
            return new int[] {
                (int)Math.Round(koeficijentVisine * x1y1x2y2[i,0],0),
                (int)Math.Round(koeficijentSirine * x1y1x2y2[i,1],0),
                (int)Math.Round(koeficijentVisine * x1y1x2y2[i,2],0),
                (int)Math.Round(koeficijentSirine * x1y1x2y2[i,3],0)
            };
        }
        public Image PodesiPozadinskuSliku()
        {
            return pozadina;
        }
        public PictureBox DajNamaskuSliku(int namaz)
        {
            //Kreiranje namaskih slika na formi te podesavanje visibility = false. 
            PictureBox pb = new PictureBox();
            pb.Location = new Point(ParentKvadratZaNamaskiFrame(namaz)[2] + 30, ParentKvadratZaNamaskiFrame(namaz)[1]);
            pb.BackColor = Color.Transparent;
            pb.Size = new Size(50, 50);
            pb.Visible = false;
            //Dodaj sliku
            switch (namaz)
            {
                case 0:
                     pb.Name = "SlikaZora";
                     pb.Image = this.zoraSlika;
                    break;
                case 1:
                    pb.Name = "SlikaSabah";
                    pb.Image = this.sabahSlika;
                    break;
                case 2:
                    pb.Name = "SlikaPodne";
                    pb.Image = this.podneSlika;
                    break;
                case 3:
                    pb.Name = "SlikaIkindija";
                    pb.Image = this.ikindijaSlika;
                    break;
                case 4:
                    pb.Name = "SlikaAksam";
                    pb.Image = this.aksamSlika;
                    break;
                case 5:
                    pb.Name = "SlikaJacija";
                    pb.Image = this.jacijaSlika;
                    break;
            }
            return pb;
        }
        public FontFamily FontFamilija()
        {
            return this.pfc.Families[0];
        }
    }
}
