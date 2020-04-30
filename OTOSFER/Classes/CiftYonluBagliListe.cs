using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OTOSFER.Classes
{
    public class Node
    {
        public int i = 0;
        public int j = 0;
        public int k = 0;
        public string temp = " ";
        public string[] dizi = new string[8];
        public Node previous;
        public Node next;
        public string Data;
        public int SeferNo;
        public string Tarih;
        public string Saat;
        public string Guzergah;
        public string Kaptan;
        public string Plaka;
        public string Kapasite;
        public string BiletFiyati;
        public Node1 Otobus;

        public Node(string Data)
        {
            
            while (i != Data.Length)
            {

                if (Data[i] != '-')
                {
                    temp = temp + Data[i].ToString();
                }
                else
                {
                    dizi[j] = temp;
                    temp = " ";
                    j++;
                    if (j == dizi.Length)
                        j = 0;
                }
                i++;

                
            }
            this.Data = Data;
            SeferNo = Convert.ToInt32(dizi[0]);
            Tarih = dizi[1];
            Saat = dizi[2];
            Guzergah = dizi[3];
            Kaptan = dizi[4];
            Plaka = dizi[5];
            Kapasite = dizi[6];
            BiletFiyati = dizi[7];
            
        }
        public class DoubleLinkedList
        {
            public Node First;
            public Node Last;

            public void AddNode(string Data)
            {
                Node node = new Node(Data);
                if (First == null)
                {
                    First = node;
                    Last = node;
                    First.previous = null;
                    Last.next = null;
                }
                else
                {
                    node.previous = Last;
                    Last.next = node;
                    Last = node;
                    Last.next = null;
                }

            }
            public string ListNodes()
            {
                Node node = First;
                string NodeData = "";
                if (node == null)
                {
                    MessageBox.Show("Liste Boş");
                }
                else
                {
                    while (node != null)
                    {
                        NodeData += node.Data + Environment.NewLine;
                        node = node.next;
                    }
                }

                return NodeData;
            }
            public void Delete()
            {
                First = null;
                Last = null;
            }
            public void DeleteNode()
            {
                Node node = First;
                while (node != null)
                {
                    if (node.previous == null && node.SeferNo == Globals.seferno)
                    {
                        node.next.previous = null;
                    }
                    else if (node.SeferNo == Globals.seferno)
                    {

                        node.next.previous = node.previous;
                        node.previous.next = node.next;
                    }
                    else if (node.next == null && node.SeferNo == Globals.seferno)
                    {
                        node.previous.next = null;
                    }

                    node = node.next;
                }

            }
        }
           
        public class Node1
        {
            public int i = 0;
            public int j = 0;
            public int k = 0;
            public string temp = " ";
            public string[] dizi = new string[5];
            public Node1 previous;
            public Node1 next;
            public string Data;
            public int KoltukNo;
            public string Fiyat;
            public string AdSoyad;
            public string Cinsiyet;
            public string Durum;
            public string Plaka;


            public Node1(string Data)
            {
                while (i != Data.Length)
                {

                    if (Data[i] != '-')
                    {
                        temp = temp + Data[i].ToString();
                    }
                    else
                    {
                        dizi[j] = temp;
                        temp = " ";
                        j++;
                        if (j == dizi.Length)
                            j = 0;
                    }
                    i++;
                }
                this.Data = Data;
                KoltukNo = Convert.ToInt32(dizi[0]);
                Fiyat = dizi[1];
                AdSoyad = dizi[2];
                Cinsiyet = dizi[3];
                Durum = dizi[4];
            }
            public class DoubleLinkedList1
            {
                public Node1 First;
                public Node1 Last;

                public void AddNode1(string Data)
                {
                    Node1 node = new Node1(Data);
                    if (First == null)
                    {
                        First = node;
                        Last = node;
                        First.previous = null;
                        Last.next = null;
                    }
                    else
                    {
                        node.previous = Last;
                        Last.next = node;
                        Last = node;
                        Last.next = null;
                    }

                }
                public string ListNodes1()
                {
                    Node1 node = First;
                    string NodeData = "";
                    if (node == null)
                    {
                        MessageBox.Show("Liste Boş");
                    }
                    else
                    {
                        while (node != null)
                        {
                            NodeData += node.Data + Environment.NewLine;
                            node = node.next;
                        }
                    }

                    return NodeData;
                }
                public void Delete1()
                {
                    First = null;
                    Last = null;
                }
            }
        }
        /*public class SeferDugum
        {
            public string SeferNo;
            public string Tarih;
            public string Saat;
            public string Guzergah;
            public string Kaptan;
            public string Plaka;
            public string Kapasite;
            public string BiletFiyati;
            public Dugum Otobus;
            public SeferDugum SeferOnceki;
            public SeferDugum SeferSonraki;
            public SeferDugum(string SeferNo, string Tarih, string Saat, string Guzergah, string Kaptan, string Plaka,string Kapasite, string BiletFiyati,Dugum Otobus)
            {
                this.SeferNo = SeferNo;
                this.Tarih = Tarih;
                this.Saat = Saat;
                this.Guzergah = Guzergah;
                this.Kaptan = Kaptan;
                this.Plaka = Plaka;
                this.Kapasite = Kapasite;
                this.BiletFiyati = BiletFiyati;
                this.Otobus = Otobus;
            }
        }
        public class CiftYonluBagliListe
        {
            public SeferDugum Seferilk;
            public SeferDugum Seferson;
            //Liste Uzunluğu 
            public int SeferSay()
            {
                int n = 0;
                SeferDugum gecici = Seferilk;
                while (gecici != null)
                {
                    n++;
                    gecici = gecici.SeferSonraki;
                }
                return n;
            }
            //Listeye Eleman Ekleme(sona ekler)
            public void SeferEkle(string SeferNo, string Tarih, string Saat, string Guzergah, string Kaptan, string Plaka, string Kapasite, string BiletFiyati, Dugum Otobus)
            {
                SeferDugum Dugum = new SeferDugum(SeferNo,Tarih,Saat,Guzergah,Kaptan,Plaka,Kapasite,BiletFiyati,Otobus);
                if (Seferilk == null)
                {
                    Seferilk = Dugum;
                    Seferson = Dugum;
                    Seferson.SeferSonraki = null;
                }
                else
                {
                    Dugum.SeferOnceki = Seferson;
                    Seferson.SeferSonraki = Dugum;
                    Seferson = Dugum;
                    Seferson.SeferSonraki = null;
                }
            }

            //Listeyi Temizler
            public void SeferTemizle()
            {
                Seferilk = null;
                Seferson = null;
            }
            //Listenin elemanının sırasını bulma
            /*public void SeferIndex(string SeferNo, string Tarih, string Saat, string Guzergah, string Kaptan, string Plaka, string Kapasite, string BiletFiyati, string Otobus)
            {
                int meter = 0;
                int status = 0;
                SeferDugum gecici = Seferilk;
                while (gecici != null)
                {
                    if (gecici.SeferNo == SeferNo && gecici.Tarih)
                    {
                        status = 1;
                        break;
                    }
                    meter++;
                    gecici = gecici.Sonraki;
                }
                if (status == 1) Console.WriteLine("Aradığınız Eleman Listenin " + meter + ".elemanı olarak bulundu");
                else Console.WriteLine("Aradığınız Eleman Listede bulunmamaktadır...");
            }*/
        //Listenin n.elemanını çağırır
        /* public object Veri(int Veri)
        {
            Dugum gecici = ilk;
            for (int i = 0; i < Veri; i++)
            {
                gecici = gecici.Sonraki;
            }
            return gecici.Veri;
        }*/
        //Listeyi Okutur.
        /*    
        public object SeferOku()
            {
                SeferDugum gecici = Seferilk;
                string Veri = "";
                if (gecici == null)
                {
                    Veri = "ArrayList Boş...";
                }
                else
                {
                    while (gecici != null)
                    {
                        Veri = gecici.SeferNo.ToString()+gecici.Tarih+gecici.Saat+gecici.Guzergah+gecici.Kaptan+gecici.Plaka+gecici.Kapasite+gecici.BiletFiyati+gecici.Otobus;
                        gecici = gecici.SeferSonraki;
                    }
                }
                return Veri;
            }
            //Listenin istenilen elemanını siler(sıralaması ile)
            public void Kaldir(string SeferNo)
            {
                SeferDugum gecici = Seferilk;
                if (gecici == null)
                {
                    //LİSTE BOŞ
                }
                else
                {
                    while (gecici != null)
                    {
                        if (gecici.SeferNo == SeferNo)
                        { break; }
                        gecici = gecici.SeferSonraki;
                    }
                    if (gecici == null)
                    {
                        //SİLİNECEK ELEMAN LİSTEDE YOK
                    }
                    else
                    {
                        if (gecici == Seferilk)
                        {
                            if (Seferilk == Seferson)
                            {
                                Seferilk = null;
                                Seferson = null;
                            }
                            else
                            {
                                Seferilk = Seferson.SeferSonraki;
                                Seferilk.SeferOnceki = null;
                            }
                        }
                        else if (gecici == Seferson)
                        {
                            Seferson = Seferson.SeferOnceki;
                            Seferson.SeferSonraki = null;
                        }
                        else
                        {
                            gecici.SeferOnceki.SeferSonraki = gecici.SeferSonraki;
                            gecici.SeferSonraki.SeferOnceki = gecici.SeferOnceki;
                        }
                    }
                }
            }
            //Listenin istenilen elemanının siler(değer ile)
            /*public void KaldirAt(int order)
            {
                Dugum gecici = ilk;
                int count = Say();
                if (count <= order)
                {
                    //HATA
                }
                else
                {
                    for (int i = 0; i < order; i++)
                    {
                        gecici = gecici.Sonraki;
                    }
                    if (gecici == ilk)
                    {
                        if (ilk == son)
                        {
                            ilk = null;
                            son = null;
                        }
                        else
                        {
                            ilk = ilk.Sonraki;
                            ilk.Onceki = null;
                        }
                    }
                    else if (gecici == son)
                    {
                        son = son.Onceki;
                        ilk.Sonraki = null;
                    }
                    else
                    {
                        gecici.Onceki.Sonraki = gecici.Sonraki;
                        gecici.Sonraki.Onceki = gecici.Onceki;

                    }
                }
            }*/
        /*}
        public class Dugum
        {
            public string KoltukNo;
            public string Fiyat;
            public string AdSoyad;
            public string Cinsiyet;
            public string Durum;
            public Dugum Onceki;
            public Dugum Sonraki;
            public Dugum(string KoltukNo, string Fiyat,string AdSoyad, string Cinsiyet, string Durum)
            {
                this.KoltukNo = KoltukNo;
                this.Fiyat = Fiyat;
                this.AdSoyad = AdSoyad;
                this.Cinsiyet = Cinsiyet;
                this.Durum = Durum;
            }
        }
        public class CiftYonluBagliListee
        {
            public Dugum ilk;
            public Dugum son;
            //Liste Uzunluğu 
            public int Say()
            {
                int n = 0;
                Dugum gecici = ilk;
                while (gecici != null)
                {
                    n++;
                    gecici = gecici.Sonraki;
                }
                return n;
            }
            //Listeye Eleman Ekleme(sona ekler)
            public void Ekle(string KoltukNo, string Fiyat, string AdSoyad, string Cinsiyet, string Durum)
            {
                Dugum Dugum = new Dugum(KoltukNo,Fiyat,AdSoyad,Cinsiyet,Durum);
                if (ilk == null)
                {
                    ilk = Dugum;
                    son = Dugum;
                    son.Sonraki = null;
                }
                else
                {
                    Dugum.Onceki = son;
                    son.Sonraki = Dugum;
                    son = Dugum;
                    son.Sonraki = null;
                }
            }
            //Listeyi Temizler
            public void Temizle()
            {
                ilk = null;
                son = null;
            }
            //Listenin elemanının sırasını bulma
            /*public void Index(object Veri)
            {
                int meter = 0;
                int status = 0;
                Dugum gecici = ilk;
                while (gecici != null)
                {
                    if (gecici.Veri == Veri)
                    {
                        status = 1;
                        break;
                    }
                    meter++;
                    gecici = gecici.Sonraki;
                }
                if (status == 1) Console.WriteLine("Aradığınız Eleman Listenin " + meter + ".elemanı olarak bulundu");
                else Console.WriteLine("Aradığınız Eleman Listede bulunmamaktadır...");
            }*/
        //Listenin n.elemanını çağırır
        /*public object Veri(int Veri)
        {
            Dugum gecici = ilk;
            for (int i = 0; i < Veri; i++)
            {
                gecici = gecici.Sonraki;
            }
            return gecici.Veri;
        }*/
        //Listeyi Okutur.
        /*public object Oku()
        {
            Dugum gecici = ilk;
            var Veri = "";
            if (gecici == null)
            {
                Veri = "ArrayList Boş...";
            }
            else
            {
                while (gecici != null)
                {
                    Veri = gecici.Veri.ToString();
                    gecici = gecici.Sonraki;
                }
            }
            return Veri;
        }*/
        //Listenin istenilen elemanını siler(sıralaması ile)
        /*public void Kaldir(object Veri)
        {
            Dugum gecici = ilk;
            if (gecici == null)
            {
                //LİSTE BOŞ
            }
            else
            {
                while (gecici != null)
                {
                    if (gecici.KoltukNo == Veri)
                    { break; }
                    gecici = gecici.Sonraki;
                }
                if (gecici == null)
                {
                    //SİLİNECEK ELEMAN LİSTEDE YOK
                }
                else
                {
                    if (gecici == ilk)
                    {
                        if (ilk == son)
                        {
                            ilk = null;
                            son = null;
                        }
                        else
                        {
                            ilk = son.Sonraki;
                            ilk.Onceki = null;
                        }
                    }
                    else if (gecici == son)
                    {
                        son = son.Onceki;
                        son.Sonraki = null;
                    }
                    else
                    {
                        gecici.Onceki.Sonraki = gecici.Sonraki;
                        gecici.Sonraki.Onceki = gecici.Onceki;
                    }
                }
            }
        }*/
        //Listenin istenilen elemanının siler(değer ile)
        /*public void KaldirAt(int order)
        {
            Dugum gecici = ilk;
            int count = Say();
            if (count <= order)
            {
                //HATA
            }
            else
            {
                for (int i = 0; i < order; i++)
                {
                    gecici = gecici.Sonraki;
                }
                if (gecici == ilk)
                {
                    if (ilk == son)
                    {
                        ilk = null;
                        son = null;
                    }
                    else
                    {
                        ilk = ilk.Sonraki;
                        ilk.Onceki = null;
                    }
                }
                else if (gecici == son)
                {
                    son = son.Onceki;
                    ilk.Sonraki = null;
                }
                else
                {
                    gecici.Onceki.Sonraki = gecici.Sonraki;
                    gecici.Sonraki.Onceki = gecici.Onceki;

                }
            }*/
    }
}



