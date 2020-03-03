using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracaDomowaLab1
{
    public partial class FormGra : Form
    {
        //Deklaruje statyczna referencje klasy FormGra 
        public static FormGra gra;    
        //Dodaj zasoby
        int DodajZasoby = 0;
        //Liczba złota
        int LiczbaZlota = 0;
        //Odliczaj czasu do wykucia broni
        int Odliczanie = 0;    
        //Liczba żelaza w głównym zasobie
        int LiczbaŻelaza = 0;
        //Liczba drewna w głównym zasobie
        int LiczbaDrewna = 0;
        //Liczba skór w głównym zasobie
        int LiczbaSkór = 0;
        //Liczba wody w głłównym zasobie
        int LiczbaWody = 0;
        //Liczba ognia w glównym zasobie
        int LiczbaOgnia = 0;
        // Liczba zahartowanego żelzaza w głównym zasobie
        int LiczbaZahartowanegoŻelaza = 0;
        // Liczba oleju w głównym zasobie
        int LiczbaOleju = 0;   
        //Godzina w grze
        int Godzina = 1;
        //Liczba żelaza przeznaczona do zużycia 
        int LiczbaŻelazaDoZużycia = 0;
        //Liczba drewna przeznaczona do zuzycia
        int LiczbaDrewnaDoZuzycia = 0;
        //Liczba Skór przeznaczona do zuzycia
        int LiczbaSkórDoZużycia = 0;
        //Liczba Wody przeznaczona do zużycia
        int LiczbaWodyDoZzużycia = 0;
        //Liczba ognia przeznaczona do zuzycia
        int LiczbaOgniaDoZużycia = 0;
        //Liczba zahartowanego żelaza przeznaczona do zużycia
        int LiczbaZahartowanegoŻelazaDoZużycia = 0;
        //Liczba oleju przeznaczona do zużycia
        int LiczbaOlejuDoZzużycia = 0;
        //Liczba wymaganego żelaza do wykucia itemu
        int WymaganaIloscŻelaza = 0;
        //Liczba wymaganego drewna do wykucia itemu
        int WymaganaIloscDrewna = 0;
        //Liczba wymaganych skór do wykucia itemu 
        int WymaganaIloscSkor = 0;
        //Licza wymaganej wody do wykucia
        int WymaganaIloscWody = 0;
        //Liczba wymaganego ognia do wykucia itemu
        int WymaganaIloscOgnia = 0;
        //Liczba wymaganego zahartowanego żelaza do wykucia itemu 
        int WymaganaIloscZahartowanegoŻelaza = 0;
        // Liczba wymaganego oleju do wykucia itemu
        int WymaganaIloscOleju = 0;
        //Ilość kradzieży która nastąpiła w grze
        int LicznikKradziezy = 0;
        //Ilosc straznikow zelaza
        int liczbaStraznikowZelaza = 0;
        // Długość ochrony żelaza
        int dlugoscOchronyZelaza = 0;
        //Ilosc straznikow drewna
        int liczbaStraznikowDrewna = 0;
        // Długość ochrony drewna
        int dlugoscOchornyDrewna = 0;
        // Ilosc straznikow skor
        int liczbaStraznikowSkor = 0;
        // Dlugosc ochrony skor w turach
        int dlugoscOchornySkor = 0;
        //Ilosc straznikow wody
        int liczbaStraznikowWody = 0;
        // Dlugosc ochrony wody w turach
        int dlugoscOchronyWody = 0;
        // Ilosc straznikow ognia
        int liczbaStraznikowOgnia = 0;
        // Dlugosc ochrony ognia w turach
        int dlugoscOchronyOgnia = 0;
        // Ilosc straznikow oleju
        int liczbaStraznikowOleju = 0;
        // Dlugosc ochrony oleju w turach
        int dlugoscOchronyOleju = 0;
        // Ilosc straznikow zahartowanego zelaza
        int liczbaStraznikowZahartowanegoZelaza = 0;
        // Dlugosc ochrony Zahartowanego zelaza w turach
        int dlugoscOchronyZahartowaneZelaza = 0;
        //Ilosc straznikow zlota
        int liczbaStraznikowZlota = 0;
        // Dlugosc ochrony zlota w turach
        int dlugoscOchronyZlota = 0;
        //Ilosc straznikow recept
        int liczbaStraznikowRecept = 0;
        // Ilosc stranzikow czasu
        int liczbaStraznikowCzasu = 0;
        // Ilosc zablokowanych tur zweikszania zelaza
        int zablokujZwiekszanieZelaza = 0;
        // ilosc zablokowanych tur zwiekszania drewna
        int zablokujZwieksanieDrewna = 0;
        // Ilosc zablokowanych tur zwiekszania ognia
        int zablokujZwiekszanieOgnia = 0;
        // Ilosc zablokowanych tur zwiekszania wody
        int zablokujZwiekszanieWody = 0;
        // Ilosc zablokowanych tur zwiekszania skor 
        int zablokujZwiekszanieSkor = 0;
        // Ilosc zablokowanych tur zwiekszania zlota
        int zablokujZwiekszanieZlota = 0;
        // Wartosc logiczna blokujaca/pozwalajaca na przyrost zelaza
        bool zwiekszZelazo = true;
        // Wartosc logiczna blokujaca/pozwalajaca na przyrost drewna
        bool zwiekszDrewno = true;
        // Wartosc logiczna blokujaca/pozwalajaca na przyrost skor
        bool zwiekszSkory = true;
        // Wartosc logiczna blokujaca/pozwalajaca na przyrost wod
        bool zwiekszWode = true;
        // Wartosc logiczna blokujaca/pozwalajaca na przyrost ognia
        bool zwiekszOgien = true;
        // Wartosc logiczna blokujaca/pozwalajaca na przyrost zlota
        bool zwiekszZloto = true;
        // Wartosc logiczna blokujaca/zezwalajaca na skracanie czasu przez złodzieja
        bool skrocCzas=false;
        //Deklaruje referencję do klasy FormStart
        FormStart formStart;
        //Deklaruje referencje do klasy typu FormRecepta
        FormRecepta formRecepta;
        //Deklaruje referncję do klasy random
        Random losowaLiczba;
        //Deklaruję listę która gromadzi typ BitMap, potrzebna do trzymania obrazów
        List<Bitmap> listaObrazów;
        //Deklaruję liste typu TextBox do trzymania texboxów
        List<TextBox> listaTextBox;
        // Referencja do klasy StraznikZasobów
        StrażnikZasobów straznikZasobow;
        // Regerencja do klasy StrażnikCzasu
        StraznikCzasu straznikCzasu;
        // Referencja do klasy StrażnikRecept
        StrażnikRecept straznikRecept;
        // Referencja do klasy ZłodziejZasobów
        ZlodziejZasobow zlodziejZasobow;
        // Referencja do klasy ZłodziejCzasu
        ZłodziejCzasu zlodziejCzasu;
        // Referencja do klasy ZłodziejRecept
        ZłodziejRecept zlodziejRecept;

        public FormGra()
        {
            InitializeComponent();
            // Utworzenie nowego obiektu typu
            zlodziejZasobow = new ZlodziejZasobow();
            // Utworzenie nowego o biektu typu ZłodziejCzasu
            zlodziejCzasu = new ZłodziejCzasu();
            // Utworzenie zmiennej typu ZłodziejRecept
            zlodziejRecept = new ZłodziejRecept();
            // Utworzenie zmiennej typu StrażnikZasobów
            straznikZasobow = new StrażnikZasobów();
            // Utworzenie zmiennej typu StrażnikCzasu
            straznikCzasu = new StraznikCzasu();
            // Utworzenie zmiennej typu StraznikRecept
            straznikRecept = new StrażnikRecept();          
            //Przypisuje ten obiekt typu FormGra do statycznej zmiennej gra
            gra = this;
            //Przypisuje zmienna statyczna jako interwal i mnoze razy 1000
            LicznikCzasuGry.Interval = FormStart.interwal * 1000;
            //Startuje główny licznik gry
            LicznikCzasuGry.Start();
            //Tworze nowa instancję listy typu BitMap
            listaObrazów = new List<Bitmap>();
            //Tworzę nową instancję listy typu TextBox
            listaTextBox = new List<TextBox>();
            //Dodaj do listy textBox
            listaTextBox.Add(textBoxLiczbaDrewnaDoZużycia);
            //Dodaj do listy textBox textBoxLiczbaOgniaDoZużycia
            listaTextBox.Add(textBoxLiczbaOgniaDoZużycia);
            //Dodaj do listy textBoxLiczbaOlejuDoZużycia
            listaTextBox.Add(textBoxLiczbaOlejuDoZużycia);
            //Dodaj do listy textBoxLiczbaSkórDoZużycia
            listaTextBox.Add(textBoxLiczbaSkórDoZużycia);
            //Dodaj do listy textBoxLiczbaWodyDoZużycia
            listaTextBox.Add(textBoxLiczbaWodyDoZużycia);
            //Dodaj do listy textBoxLiczbaZahartowanegoŻelazaDoZużycia
            listaTextBox.Add(textBoxLiczbaZahartowanegoŻelazaDoZużycia);
            //Dodaj do listy textBoxLiczbaŻelazaDoZuzycia
            listaTextBox.Add(textBoxLiczbaŻelazaDoZuzycia);
            //Dodaj do listy obraz itemu kusza
            listaObrazów.Add(Properties.Resources.Kuszapng);
            //Dodaj do listy obraz itemu luk
            listaObrazów.Add(Properties.Resources.luk);
            //Dodaj do listy obraz itemu miecz
            listaObrazów.Add(Properties.Resources.miecz);
            //Dodaj do listy obraz itemu skorzana zbroja
            listaObrazów.Add(Properties.Resources.SkorzanaZbroja);
            //Dodaj do listy obraz itemu tarcza
            listaObrazów.Add(Properties.Resources.Tarcza);
            //Dodaj do listy obraz itemu zbroja
            listaObrazów.Add(Properties.Resources.zbroja);
            //Dodaj do listy obraz itemu wlocznia
            listaObrazów.Add(Properties.Resources.Wlocznia);
            //Ustawiam maksymalna wartość paska porgresu na 100
            progressBarPasekZłodzieja.Maximum = 100;           
            //Tworzę nową instancję klasy Random 
            losowaLiczba = new Random();
            //Tworze nową instancje typu FormRecepta
            formRecepta = new FormRecepta();
            //Ustawiam wartosc logiczna na true
            formRecepta.wroc = true;
            //Ustawiam  typ paska progresu na bloczki
            progressBarPasekZłodzieja.Style = ProgressBarStyle.Blocks;
            //Wywołuje metodę do losowania broni do wytworzenia
            losujBronDoWwykucia();
           
        }

        /// <summary>
        /// Metoda sprawdzająca czy zgadza się liczba potrzebnych zasobów do wykucia
        /// </summary>
        private void sprawdzZgodnoscMaterialow()
        {
            //Jeżeli wymagane liczby potrzebne do wytworzenia danego itemu są takie same bądź są równe wymaganej ilości do wytworzenia
            if(LiczbaŻelazaDoZużycia>=WymaganaIloscŻelaza && LiczbaDrewnaDoZuzycia>=WymaganaIloscDrewna && LiczbaSkórDoZużycia>=WymaganaIloscSkor
                && LiczbaWodyDoZzużycia>=WymaganaIloscWody && LiczbaOgniaDoZużycia>=WymaganaIloscOgnia && LiczbaZahartowanegoŻelazaDoZużycia>=WymaganaIloscZahartowanegoŻelaza
                && LiczbaOlejuDoZzużycia>=WymaganaIloscOleju)
            {
                //Wywołaj metodę nagrody
                dodajNagrode();
            }
            //W przeciwnym razie
            else
            {
                //Zwiększ wartość paska postepu o wartość
                progressBarPasekZłodzieja.Value += 50;

            }
            //Ustawiam w tablicy textBoxo wartość wyświetlanego textu na 0
            for (int i = 0; i < listaTextBox.Count; i++)
            {
                //
                listaTextBox[i].Text = 0.ToString();
            }
            //Wymagana liczba żelaza do wykucia itemu jest resetowana
            WymaganaIloscŻelaza = 0;     
            //Wyzerowanie wymaganej ilości drewna do wykucia
            WymaganaIloscDrewna = 0;
            //Wyzerowanie wymaganej ilosci skór do wykucia
            WymaganaIloscSkor = 0;
            //Wyzerowanie wymaganej ilości wody do wykucia
            WymaganaIloscWody = 0;
            //Wyzerowanie wymaganej ilości ognia do wykucia
            WymaganaIloscOgnia = 0;
            //Wyzerowanie wymaganej ilości zahartowanego żelaza do wykucia
            WymaganaIloscZahartowanegoŻelaza = 0;
            //Wyzerowanie wymaganej ilości oleju do wykucia
            WymaganaIloscOleju = 0;
        }
        /// <summary>
        /// Metoda losująca broń oraz ilość do wytworzenia
        /// </summary>
        private void losujBronDoWwykucia()
        {
             //Stwórz lokalny typ int, za pomocą funkcji Next z klasy Random wylosuj cyfrę z przedziału 1,3
             int iloscBroni = losowaLiczba.Next(1, 3);
            //Stwórz lokalny typ int, za pomocą funkcji Next z klasy Random wylosuj cyfrę z przedziału 1,3
            int losujBron = losowaLiczba.Next(0,listaObrazów.Count);
            
            //Wybierz broń na podstawie wylosowanej liczby
            switch (losujBron)
            {
                //losujBron równe 0
                case 0:
                    //Wyświetl ilość broni do wykucia
                    textBoxIlośćSztukBroni.Text = "x"+iloscBroni.ToString();
                    //Wybierz wylosowany obraz z liście do wytworzenia na podstawie wylosowanej cyfry
                    pictureBoxBroń.BackgroundImage = listaObrazów[losujBron];
                    //Przypisz ilość wymaganego żelaza do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscŻelaza = 2*iloscBroni;
                    //Przypisz ilość wymaganego drewna  do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscDrewna = 4*iloscBroni;
                    //Przypisz ilość wymaganych skór do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscSkor = 2*iloscBroni;
                    //Przypisz wymaganą ilość wody do wykucia i pomnóż przez iloscBroni
                    WymaganaIloscWody = 1*iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 1*iloscBroni;
                    //Pyrzypisz wymaganą ilość drewna do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscDrewna = 4 * iloscBroni;
                    //Pyrzypisz wymaganą ilość oleju do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOleju = 3 * iloscBroni;
                    //Pyrzypisz wymaganą ilość zahartowanego zelaza do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscZahartowanegoŻelaza = 1 * iloscBroni;                  
                    //Jezeli wartosc logiczna jest prawda
                    if (skrocCzas)
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8 / 2;
                        skrocCzas = false;
                    }
                    // W przeciwnym razie
                    else
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8;
                    }
                    //Wyświetl wartość czaasu jaka pozostała do wytworzenia
                    textBoxLicznikWykucia.Text = Odliczanie.ToString();
                    
                  //Przerwij
                 break;

                //losujBron równe 1
                case 1:
                    //Wyświetl ilość broni do wykucia
                    textBoxIlośćSztukBroni.Text = "x" + iloscBroni.ToString();
                    //Wybierz wylosowany obraz z liście do wytworzenia na podstawie wylosowanej cyfry
                    pictureBoxBroń.BackgroundImage = listaObrazów[losujBron];
                    //Przypisz ilość wymaganego drewna  do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscDrewna = 3*iloscBroni;
                    //Przypisz ilość wymaganego żelaza do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscŻelaza = 1*iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 1*iloscBroni;
                    //Pyrzypisz wymaganą ilość skor do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscSkor = 2 * iloscBroni;
                    //Pyrzypisz wymaganą ilość oleju do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOleju = 2 * iloscBroni;                    
                    //Jezeli wartosc logiczna jest prawda
                    if (skrocCzas)
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 10 / 2;
                        skrocCzas = false;
                    }
                    // W przeciwnym razie
                    else
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 10;
                    }                   
                    //Wyświetl wartość czaasu jaka pozostała do wytworzenia
                    textBoxLicznikWykucia.Text = Odliczanie.ToString();

                    //Przerwij
                    break;
                //losujBron równe 2
                case 2:

                    //Wyświetl ilość broni do wykucia
                    textBoxIlośćSztukBroni.Text = "x" + iloscBroni.ToString();
                    //Wybierz wylosowany obraz z liście do wytworzenia na podstawie wylosowanej cyfry
                    pictureBoxBroń.BackgroundImage = listaObrazów[losujBron];
                    //Przypisz ilość wymaganego drewna  do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscDrewna = 1*iloscBroni;
                    //Przypisz ilość wymaganego żelaza do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscŻelaza = 2*iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 2*iloscBroni;
                    //Pyrzypisz wymaganą ilość wody do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscWody = 2 * iloscBroni;
                    //Pyrzypisz wymaganą ilość zahartowanego zelaza do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscZahartowanegoŻelaza = 2 * iloscBroni;
                    //Pyrzypisz wymaganą ilość oleju do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOleju = 1*iloscBroni;                                 
                    //Jezeli wartosc logiczna jest prawda
                    if (skrocCzas)
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 9 / 2;
                        // Ustaw wartosc logiczna na fałsz
                        skrocCzas = false;
                    }
                    // W przeciwnym razie
                    else
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 9;
                    }
                    //Wyświetl wartość czaasu jaka pozostała do wytworzenia
                    textBoxLicznikWykucia.Text = Odliczanie.ToString();

                    //Przerwij
                    break;
                //losujBron równe 3
                case 3:
                    //Wyświetl ilość broni do wykucia
                    pictureBoxBroń.BackgroundImage = listaObrazów[losujBron];
                    //Wybierz wylosowany obraz z liście do wytworzenia na podstawie wylosowanej cyfry
                    textBoxIlośćSztukBroni.Text = "x" + iloscBroni.ToString();
                    //Przypisz ilość wymaganego żelaza do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscŻelaza = 1*iloscBroni;
                    //Pyrzypisz wymaganą ilość drewna do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscDrewna = 2 * iloscBroni;
                    //Przypisz ilość wymaganego skór do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscSkor = 4*iloscBroni;
                    //Przypisz ilość wymaganego zahartowanego żelaza do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscZahartowanegoŻelaza = 2*iloscBroni;                  
                    //Pyrzypisz wymaganą ilość oleju do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOleju = 1*iloscBroni;
                    //Jezeli wartosc logiczna jest prawda
                    if (skrocCzas)
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 7 / 2;
                        // Ustaw wartosc logiczna na fałsz
                        skrocCzas = false;
                    }
                    // W przeciwnym razie
                    else
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 7;
                    }
                    //Wyświetl wartość czaasu jaka pozostała do wytworzenia
                    textBoxLicznikWykucia.Text = Odliczanie.ToString();

                    //Przerwij
                    break;
                //losujBron równe 4
                case 4:

                    //Wyświetl ilość broni do wykucia
                    textBoxIlośćSztukBroni.Text = "x" + iloscBroni.ToString();
                    //Wybierz wylosowany obraz z liście do wytworzenia na podstawie wylosowanej cyfry
                    pictureBoxBroń.BackgroundImage = listaObrazów[losujBron];
                    // Przypisz ilosc wymaganego zelaza do wykucia i pomno przez ilosc broni
                    WymaganaIloscŻelaza = 2 * iloscBroni;
                    //Przypisz ilość wymaganego skór do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscSkor = 1*iloscBroni;
                    //Pyrzypisz wymaganą ilość oleju do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOleju = 2*iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 2*iloscBroni;
                    //Przypisz ilość wymaganego drewna  do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscDrewna = 2*iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 3 * iloscBroni;
                    //Pyrzypisz wymaganą ilość wody do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscWody = 3 * iloscBroni;
                    //Pyrzypisz wymaganą ilość zahartowanego zelaza do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscZahartowanegoŻelaza = 3 * iloscBroni;
                    //Jezeli wartosc logiczna jest prawda
                    if(skrocCzas)
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8/2;
                        skrocCzas = false;
                    }
                    // W przeciwnym razie
                    else
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8;
                    }
                    //Wyświetl wartość czaasu jaka pozostała do wytworzenia
                    textBoxLicznikWykucia.Text = Odliczanie.ToString();

                    //Przerwij
                    break;

                //losujBron równe 4
                case 5:

                    //Wyświetl ilość broni do wykucia
                    textBoxIlośćSztukBroni.Text = "x" + iloscBroni.ToString();
                    //Wybierz wylosowany obraz z liście do wytworzenia na podstawie wylosowanej cyfry
                    pictureBoxBroń.BackgroundImage = listaObrazów[losujBron];
                    // Przypisz ilosc wymaganego zelaza do wykucia i pomno przez ilosc broni
                    WymaganaIloscŻelaza = 3 * iloscBroni;
                    //Przypisz ilość wymaganego skór do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscSkor = 2 * iloscBroni;
                    //Pyrzypisz wymaganą ilość oleju do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOleju = 3 * iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 3 * iloscBroni;
                    //Przypisz ilość wymaganego drewna  do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscDrewna = 1 * iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 3 * iloscBroni;
                    //Pyrzypisz wymaganą ilość wody do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscWody = 3 * iloscBroni;
                    //Pyrzypisz wymaganą ilość zahartowanego zelaza do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscZahartowanegoŻelaza = 3 * iloscBroni;
                    //Jezeli wartosc logiczna jest prawda
                    if (skrocCzas)
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8 / 2;
                        // Ustaw wartosc logiczna na fałsz
                        skrocCzas = false;
                    }
                    // W przeciwnym razie
                    else
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8;
                    }
                    //Wyświetl wartość czaasu jaka pozostała do wytworzenia
                    textBoxLicznikWykucia.Text = Odliczanie.ToString();

                    //Przerwij
                    break;
                case 6:

                    //Wyświetl ilość broni do wykucia
                    textBoxIlośćSztukBroni.Text = "x" + iloscBroni.ToString();
                    //Wybierz wylosowany obraz z liście do wytworzenia na podstawie wylosowanej cyfry
                    pictureBoxBroń.BackgroundImage = listaObrazów[losujBron];
                    // Przypisz ilosc wymaganego zelaza do wykucia i pomno przez ilosc broni
                    WymaganaIloscŻelaza = 1 * iloscBroni;
                    //Przypisz ilość wymaganego skór do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscSkor = 1 * iloscBroni;
                    //Pyrzypisz wymaganą ilość oleju do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOleju = 1 * iloscBroni;
                    //Pyrzypisz wymaganą ilość ognia do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscOgnia = 3 * iloscBroni;
                    //Przypisz ilość wymaganego drewna  do wykucia i pomnóż przez ilośćBroni
                    WymaganaIloscDrewna = 2 * iloscBroni;
                    //Pyrzypisz wymaganą ilość wody do wykucia i pomnóz przez iloscBroni
                    WymaganaIloscWody = 3 * iloscBroni;
                    //Jezeli wartosc logiczna jest prawda
                    if (skrocCzas)
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8 / 2;
                        // Ustaw wartosc logiczna na fałsz
                        skrocCzas = false;
                    }
                    // W przeciwnym razie
                    else
                    {
                        //Ustaw czas na wykucie itemu
                        Odliczanie = 8;
                    }
                    //Wyświetl wartość czaasu jaka pozostała do wytworzenia
                    textBoxLicznikWykucia.Text = Odliczanie.ToString();

                    //Przerwij
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Licznik gry, odlicza czas do wykucia broni, czas gry, sprawdza warunki kradzieży oraz nagrody, 
        /// zwiększa ilość zasobów za każdym interwałem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LicznikCzasuGry_Tick(object sender, EventArgs e)
        {
            // Jeżeli wartość pasku progresu jest równa maksymalnej wartości paska progresu
            if(progressBarPasekZłodzieja.Value==progressBarPasekZłodzieja.Maximum)
            {
                // Wywołanie metody okradania zasobow
                okradnijZasoby();
                //Ustaw wartość paska progrsu na 0
                progressBarPasekZłodzieja.Value = 0;
                //Zwiększ licznik progresu o 1
                LicznikKradziezy += 1;
            }
            // Jeżeli licznik kradzieży jest równy 2
            if(LicznikKradziezy==5)
            {
                // Wywołaj funkcję Stop zatrzymującej licznik
                LicznikCzasuGry.Stop();
                // Stwórz nową instancję klasy FormStart              
                formStart = new FormStart();
                //Wywołaj funkcję Show i wyświetl obiekt
                formStart.Show();
                //Schowaj ten obiekt
                this.Hide();
                //Wyswietl komunikat
                MessageBox.Show("Przgrałeś, okradli Twoje zasoby!!!");
            
            }
            //Jeżeli odliczanie jest większe od 0
            if (Odliczanie > 0)
            {
                //Zminjesz odliczanie o 1
                Odliczanie -= 1;
                //Wyświetl wartość odliczania w textBox
                textBoxLicznikWykucia.Text = Odliczanie.ToString();
            }
            //W innym przypadku
            else
            {
                //Wywołaj metodę sprawdzZogdnoscMaterialow
                sprawdzZgodnoscMaterialow();
                //Wywołaj metode losujBronDoWykucia
                losujBronDoWwykucia();
            }
            //Zwiększ liczbę zasobów o 1
            DodajZasoby++;
            
            // Jezeli wartosc logiczna jets prawda
            if(zwiekszZloto)
            {
                //Zwiększ liczbę złota
                LiczbaZlota += DodajZasoby;
            }
            //W przeciwnym przypadku
            else
            {
                // Zmiejsz wartosc blokady o 1
                zablokujZwiekszanieZlota -= 1;
                //Jezeli wartosc blokady jest rowna 0
                if(zablokujZwiekszanieZlota==0)
                {
                    //Ustaw wartosc logicnza na prawde
                    zwiekszZloto = true;
                }
            }
            // Jezeli wartosc logiczna jets prawda
            if (zwiekszZelazo)
            {
                // Zwieksz liczbę żelaza
                LiczbaŻelaza += DodajZasoby;
            }
            //W przeciwnym przypadku
            else
            {
                // Zmniejsz wartosc blokday
                zablokujZwiekszanieZelaza -= 1;
                //Jezeli wartosc blokday zelaza jest rowna 0
                if(zablokujZwiekszanieZelaza==0)
                {
                    //Ustaw wartosc logiczna na prawde
                    zwiekszZelazo = true;
                }
            }
            // Jezeli wartosc logiczna jets prawda
            if (zwiekszDrewno)
            {
                //Zwieksz liczbę drewna
                LiczbaDrewna += DodajZasoby;
            }
            //W przeciwnym przypadku
            else
            {
                //Zmniejsz wartosc blokday drewna
                zablokujZwieksanieDrewna -= 1;
                // Jezeli wartosc blokady drewna jest rowna 0
                if(zablokujZwieksanieDrewna==0)
                {
                    // Ustaw wartosc logiczna na prawde
                    zwiekszDrewno = true;
                }
            }
            // Jezeli wartosc logiczna jets prawda
            if (zwiekszSkory)
            {
                //Zwieksz liczbę skór
                LiczbaSkór += DodajZasoby;
            }
            //W przeciwnym przypadku
            else
            {
                //Zmniejsz wartosc blokady skor
                zablokujZwiekszanieSkor -= 1;
                //Jezeli wartosc blokday skor jest rowna 0
                if(zablokujZwiekszanieSkor==0)
                {
                    //Ustaw wartosc logiczna na prawde
                    zwiekszSkory = true;
                }
            }
            // Jezeli wartosc logiczna jets prawda
            if (zwiekszWode)
            {
                //Zwieksz liczbę Wody
                LiczbaWody += DodajZasoby;
            }
            //W przeciwnym przypadku
            else
            {
                //Zmniejsz wartosc blokady wody o 1
                zablokujZwiekszanieWody -= 1;
                //Jezeli wartosc blokday jest rowna 0
                if(zablokujZwiekszanieWody==0)
                {
                    //Ustaw wartosc logiczna na prawde
                    zwiekszWode = true;
                }
            }
            // Jezeli wartosc logiczna jets prawda
            if (zwiekszOgien)
            {
                //Zwieksz liczbę ognia
                LiczbaOgnia += DodajZasoby;
            }
            //W przeciwnym przypadku
            else
            {
                //Zmniejsz wartosc blokkady ognia o 1
                zablokujZwiekszanieOgnia -= 1;
                //Jezeli wartosc blokady ognia jest rowna 0
                if(zablokujZwiekszanieOgnia==0)
                {
                    //Ustaw wartosc logiczna na prawde
                    zwiekszOgien = true;
                }
            }
            //Wyświetl wartość żelaza w textBox
            textBoxIlośćŻelaza.Text = LiczbaŻelaza.ToString();
            //Wyświetl wartość złota w textBox
            textBoxZłoto.Text = LiczbaZlota.ToString();
            //Wyświetl wartość drewna w textBox
            textBoxIlośćDrewna.Text = LiczbaDrewna.ToString();
            //Wyświetl wartość skór w textBox
            textBoxIlośćSkóry.Text = LiczbaSkór.ToString();
            //Wyświetl wartość wody w textBox
            textBoxIlośćWody.Text = LiczbaWody.ToString();
            //Wyświetl wartość ognia w textBox
            textBoxIlośćOgnia.Text = LiczbaOgnia.ToString();
            //Wyświetl wartość godziny w textBox
            textBoxGodzina.Text = Godzina.ToString();
            //Wyzeruj wartość zasobów
            DodajZasoby = 0;
            //Jeżeli godzina +1 jest większa od 24
            if(Godzina+1>24)
            {
                //Ustaw wartość godziny na 1
                Godzina = 1;
            }
            //W przeciwnym wypadku
            else
            {
                //Zzwiększ godzinę o 1
                Godzina += 1;
            }
            //Jeżeli godzina jest mniejsza bądź równa 12 i większa bąź równa 1
            if(Godzina<=12 && Godzina>=1)
            {
                //Odblokuj przycisk do wytwarzania oleju
                buttonStwórzOlej.Enabled = true;
            }
            //W przeciwnym wypadku
            else
            {
                //Zablokuj przycisk do wytwarzania oleju
                buttonStwórzOlej.Enabled = false;
            }
            //Jeżeli godzina jest większa od 12 i mniejsza bądź równa 24 
            if(Godzina>12 && Godzina<=24)
            {
                //Odblokuj przycisk tworzenia zahartowanego metalu
                buttonStwórzZahartowaneŻelazo.Enabled = true;
            }
            //W przeciwnym wypadku 
            else
            {
                //Zablokuj przycisk tworzenia zahrartowanego żelaza
                buttonStwórzZahartowaneŻelazo.Enabled = false;
            }
            
        }

        /// <summary>
        /// Funkcja odpowiadająca za działanie złodzieja
        /// </summary>
        private void okradnijZasoby()
        {
            //Lokalna zmienna do ktorej jest przypisana wartosc z losowania
            int okradnij = losowaLiczba.Next(1,10);
            //Wybierz jedno z 10 warantow
            switch (okradnij)
            {
                //Przypadek okradnij=1
                case 1:
                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int złodziej1 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowzelaza jest wieksza od zera
                    if (liczbaStraznikowZelaza > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowZelaza
                        złodziej1 -= liczbaStraznikowZelaza;
                        //Jezeli wartosc zmiennej lokalnej jest mniejsza od 0
                        if (złodziej1 < 0)
                        {
                            // Przypisz wartosc 0 
                            złodziej1 = 0;
                        }
                    }
                    //Odejmij od liczby zelaza wartosc zmiennej zlodziej1
                    LiczbaŻelaza -= złodziej1;
                    //Wyswietl wartosc liczby zelaza w textBoxie
                    textBoxIlośćŻelaza.Text = LiczbaŻelaza.ToString();                   
                    //Wylosuj liczbe od 1 do 10 i przypisz ja do mziennej zlodziej1
                    złodziej1 = losowaLiczba.Next(1, 10);
                    //jezeli wartosc jest mniejsza rowna 8
                    if (złodziej1 <= 8)
                    {
                        //Jezeli obiekt klasy ZlodziejZasobow dziedziczy po iinterfejsie IBlokuj
                        if (zlodziejZasobow is IBlokuj)
                        {
                            //Zablokuj zwiekszanie zelaza
                            zwiekszZelazo = false;
                            // Ustaw ilosc tur na ktora zablokowane bedzie zwiekszanie zasobu
                            zablokujZwiekszanieZelaza += zlodziejZasobow.BlokujZasob(zablokujZwiekszanieZelaza);
                        }
                    }
                    //Jzeli liczba zelaza jest mniejsza od zera
                    if (LiczbaŻelaza < 0)
                    {
                        //Liczba zelaza jest rowna 0
                        LiczbaŻelaza = 0;
                    }
                   
                    
                    //Przerwij
                    break;

                //okradnij rowne 2   
                case 2:
                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int zlodziej2 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowDrewna jest wieksza od zera
                    if (liczbaStraznikowDrewna > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowDrewna
                        zlodziej2 -= liczbaStraznikowDrewna;
                        //Jezeli wartosc zmiennej lokalnej jest mniejsza od 0
                        if (zlodziej2 < 0)
                        {
                            //Przypisz zero dozmiennej
                            zlodziej2 = 0;
                        }
                    }
                    //Odejmij od liczby zelaza wartosc zmiennej zlodziej2
                    LiczbaDrewna -= zlodziej2;
                    zlodziej2 = losowaLiczba.Next(1, 10);
                    //Jezeli zmienna jest mniejsza badz rowna 8
                    if (zlodziej2 <= 8)
                    {
                        //Jezeli obiekt klasy ZlodziejZasobow dziedziczy po iinterfejsie IBlokuj
                        if (zlodziejZasobow is IBlokuj)
                        {
                            //Zablokuj zwiekszanie drewna
                            zwiekszDrewno = false;
                            // Ustaw ilosc tur na ktora zablokowane bedzie zwiekszanie zasobu
                            zablokujZwieksanieDrewna += zlodziejZasobow.BlokujZasob(zablokujZwieksanieDrewna);
                        }
                    }
                    //Jezeli liczba drewna jest wieksza badz rowna 0
                    if (LiczbaDrewna <= 0)
                    {
                        //Liczba drewna jest rowna 0
                        LiczbaDrewna = 0;
                        //Przypisz wylosowana liczbe do zmiennej                       
                    }
                    //Wyswietl liczbe drewna w textBoxie
                    textBoxIlośćDrewna.Text = LiczbaDrewna.ToString();
                    //Przerwij
                    break;

                //okradnij rowne 3
                case 3:
                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int zlodziej3 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowSkor jest wieksza od zera
                    if (liczbaStraznikowSkor > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowSkor
                        zlodziej3 -= liczbaStraznikowSkor;
                        //Jezeli wartosc zmiennej jest mniejse od 0
                        if (zlodziej3 < 0)
                        {
                            //Przypisz 0 do zmiennej
                            zlodziej3 = 0;
                        }

                    }
                    //Odejmij ilosc ukradzionych zsobow
                    LiczbaSkór -= zlodziej3;
                    //Przypisz wylosowana liczbe do zmiennej 
                    zlodziej3 = losowaLiczba.Next(1, 10);
                    // Jezeli wylosowana zmienna jest mniejsza rowna 2
                    if (zlodziej3 <= 8)
                    {
                        //Jezeli obiekt klasy ZlodziejZasobow dziedziczy po iinterfejsie IBlokuj
                        if (zlodziejZasobow is IBlokuj)
                        {
                            //Zablokuj zwiekszanie skor
                            zwiekszSkory = false;
                            // Ustaw ilosc tur na ktora zablokowane bedzie zwiekszanie zasobu
                            zablokujZwiekszanieSkor += zlodziejZasobow.BlokujZasob(zablokujZwiekszanieSkor);
                        }
                    }
                    //Jezeli liczba skor jest mniejsza badz rowna -
                    if (LiczbaSkór <= 0)
                    {
                        //Przypisz 0 do zmiennej 
                        LiczbaSkór = 0;
                        
                    }
                    //Wysweitl ilosc skor w textBoxie
                    textBoxIlośćSkóry.Text = LiczbaSkór.ToString();
                    //Przerwij
                    break;
                //Przypadek okradnij rowne 4
                case 4:

                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int zlodziej4 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowOgnia jest wieksza od zera
                    if (liczbaStraznikowOgnia > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowOgnia
                        zlodziej4 -= liczbaStraznikowOgnia;
                        //Jezeli wartosc zmiennej jest minejsza badz rowna 0
                        if (zlodziej4 < 0)
                        {
                            //Przypisz 0 do zmiennej 
                            zlodziej4 = 0;
                        }
                    }
                    //  Odejmij od zasobow ognia liczbe ukradzionych zasobow
                    LiczbaOgnia -= zlodziej4;
                    //Wylosuj liczbe i przypisz do zmiennej
                    zlodziej4 = losowaLiczba.Next(1, 10);
                    //Jezeli zmienna ta jes mniejsza rowna 2
                    if (zlodziej4 <= 8)
                    {
                        //Jezeli obiekt klasy ZlodziejZasobow dziedziczy po iinterfejsie IBlokuj
                        if (zlodziejZasobow is IBlokuj)
                        {
                            //Zablokuj zwiekszanie ognia
                            zwiekszOgien = false;
                            // Ustaw ilosc tur na ktora zablokowane bedzie zwiekszanie zasobu
                            zablokujZwiekszanieOgnia += zlodziejZasobow.BlokujZasob(zablokujZwiekszanieOgnia);
                        }
                    }
                    //Jezeli liczba ognia jest mniejsza od 0
                    if (LiczbaOgnia <= 0)
                    {
                        //Przypisz 0 do zmiennej
                        LiczbaOgnia = 0;
                       
                    }
                    //Wyswietl ilosc ognia w textBoxie
                    textBoxIlośćOgnia.Text = LiczbaOgnia.ToString();
                    //Przerwij
                    break;

                //okradnij rowne 5
                case 5:
                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int zlodziej5 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowWody jest wieksza od zera
                    if (liczbaStraznikowWody > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowWody
                        zlodziej5 -= liczbaStraznikowWody;
                        // Jezeli wartosc zmiennej jst minejsza badz rowna 0
                        if (zlodziej5 <= 0)
                        {
                            //Przypisz 0 do zmiennej
                            zlodziej5 = 0;
                        }
                    }
                    //  Odejmij od zasobow wody liczbe ukradzionych zasobow
                    LiczbaWody -= zlodziej5;
                    //Przypisz wylosowana liczbe do zmiennej
                    zlodziej5 = losowaLiczba.Next(1, 10);
                    //Jezeli wartosc zmiennej jest mniejsza badz rowna 8
                    if (zlodziej5 <= 8)
                    {
                        //Jezeli obiekt klasy ZlodziejZasobow dziedziczy po iinterfejsie IBlokuj
                        if (zlodziejZasobow is IBlokuj)
                        {
                            //Zablokuj zwiekszanie wody
                            zwiekszWode = false;
                            // Ustaw ilosc tur na ktora zablokowane bedzie zwiekszanie zasobu
                            zablokujZwiekszanieWody += zlodziejZasobow.BlokujZasob(zablokujZwiekszanieWody);
                        }
                    }
                    //Jezeli liczba wody jest mniejsza od 0
                    if (LiczbaWody < 0)
                    {
                        //Pzypisz 0 do zmiennej
                        LiczbaWody = 0;                       
                    }
                    //Wyswietl ilosc wody w textBoxie
                    textBoxIlośćWody.Text = LiczbaWody.ToString();
                    //Przerwij
                    break;

                //okradnij rowne 6
                case 6:

                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int zlodziej6 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowOleju jest wieksza od zera
                    if (liczbaStraznikowOleju > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowOleju
                        zlodziej6 -= liczbaStraznikowOleju;
                        // Jezeli wartosc zmiennej jest minejsza badz rowna 0
                        if (zlodziej6 < 0)
                        {
                            //Przypisz 0 do zmiennej
                            zlodziej6 = 0;
                        }
                    }
                    //  Odejmij od zasobow wody liczbe ukradzionych zasobow
                    LiczbaOleju -= zlodziej6;
                    //Jezeli liczba oleju jest mniejsza od 0
                    if (LiczbaOleju < 0)
                    {
                        //Przypisz 0 do zmiennej
                        LiczbaOleju = 0;

                    }
                    //Wyswietl ilosc oleju w textBoxie
                    textBoxIlośćOleju.Text = LiczbaOleju.ToString();
                    //Przerwij
                    break;

                //okradnij rowne 7
                case 7:
                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int zlodziej7 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowZahartowanegoZelaza jest wieksza od zera
                    if (liczbaStraznikowZahartowanegoZelaza > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowZahartowanegoZelaza
                        zlodziej7 -= liczbaStraznikowZahartowanegoZelaza;
                        // Jezeli wartosc zmiennej jest minejsza badz rowna 0
                        if (zlodziej7 < 0)
                        {
                            //Przypisz 0 do zmiennej
                            zlodziej7 = 0;
                        }
                    }
                    //  Odejmij od zasobow zahartowanegoZelaza liczbe ukradzionych zasobow
                    LiczbaZahartowanegoŻelaza -= zlodziej7;
                    //Jezeli liczba zahartoanego zelaza jest mniejsza od 0
                    if (LiczbaZahartowanegoŻelaza < 0)
                    {
                        //Przypisz 0 do zmiennej
                        LiczbaZahartowanegoŻelaza = 0;

                    }
                    //Wyswietl ilosc zahartowanego zelaza w textBoxie
                    textBoxIlośćZahartowanegoŻelaza.Text = LiczbaZahartowanegoŻelaza.ToString();
                    //Przerwij
                    break;

                //okradnij rowne 8        
                case 8:
                    //lokalna zmienna do ktorej przypisywana jest wartosc zwracana przez metode Okradnij
                    int zlodziej8 = zlodziejZasobow.Okradnij();
                    //Jezeli liczba stranzikowZlota jest wieksza od zera
                    if (liczbaStraznikowZlota > 0)
                    {
                        //odjemij od zmiennej liczbe straznikowZlota
                        zlodziej8 -= liczbaStraznikowZlota;
                        // Jezeli wartosc zmiennej jest minejsza badz rowna 0
                        if (zlodziej8 < 0)
                        {
                            //Przypisz 0 do zmiennej
                            zlodziej8 = 0;
                        }

                    }
                    //  Odejmij od zasobow zlota liczbe ukradzionych zasobow
                    LiczbaZlota -= zlodziej8;
                    //Przypisz wylosowana liczbe do zmiennej
                    zlodziej8 = losowaLiczba.Next(1, 10);
                    //Jezeli wartosc zmiennej jest mniejsza badz rowna 8
                    if (zlodziej8 <= 8)
                    {
                        //Jezeli obiekt klasy ZlodziejZasobow dziedziczy po iinterfejsie IBlokuj
                        if (zlodziejZasobow is IBlokuj)
                        {
                            //Zablokuj zwiekszanie zlota
                            zwiekszZloto = false;
                            // Ustaw ilosc tur na ktora zablokowane bedzie zwiekszanie zasobu
                            zablokujZwiekszanieZlota += zlodziejZasobow.BlokujZasob(zablokujZwiekszanieZlota);
                        }
                    }
                    //Jezeli liczba zlota jest mniejsza badz rowna 0
                    if (LiczbaZlota <= 0)
                    {
                        //Przypisz 0 do zmiennej
                        LiczbaZlota = 0;                       
                    }
                    //Wysweitl wartosc zlota w textBoxie
                    textBoxZłoto.Text = LiczbaZlota.ToString();
                    //Przerwij
                    break;

                // okradnij rowne 9
                case 9:

                    //Jezeli liczba straznikow recept jest wieksza od 0
                    if (liczbaStraznikowRecept > 0)
                    {
                        //Odejmij liczbe straznikow
                        liczbaStraznikowRecept -= 1;
                        //Wysweitl wartosc liczby straznikow recept w labalu
                        labelIloscStraznikowRecept.Text = liczbaStraznikowRecept.ToString();
                    }
                    //W przeciwnym wypadku
                    else
                    {
                        //Zablokuj przycisk recepty
                        zlodziejRecept.Zablokuj(buttonRecepty);
                    }

                    //Przerwij
                    break;

                //Okradnij rowne 10
                case 10:

                    //Jezeli liczba straznikow czasu jest wieksza od 0
                    if (liczbaStraznikowCzasu > 0)
                    {
                        //Odejmij liczbe straznikow o 1
                        liczbaStraznikowCzasu -= 1;
                        // Wysweietl liczbe straznikow czasu w labelu
                        labelIloscStraznikowCzasu.Text = liczbaStraznikowCzasu.ToString();

                    }
                    //W przeciwnym przypadku
                    else
                    {
                        // Wywołanie metody skracania powodująca zmiane wartosci logicznejj na prawde
                        skrocCzas = zlodziejCzasu.SkrocCzas(skrocCzas);
                        // Przypisz do zmiennej lokalnej losową liczbę 
                        int sprawdzZloto = losowaLiczba.Next(1,10);
                        // Jeżeli liczba jest mniejsza równa 3
                        if(sprawdzZloto<=3)
                        {
                            //Jeżeli liczba zlota jest większa od zera
                            if(LiczbaZlota>0)
                            {
                                // Przypisz do zmiennej liczbę zwracaną przez metodę Okradnij
                                sprawdzZloto = zlodziejCzasu.Okradnij();
                                //Odejmij liczbę złota z głównego zasobu od złota do zabrania przez złodzieja
                                LiczbaZlota -= sprawdzZloto;
                                //Jeżeli liczba złota jest mniejsza od 0
                                if(LiczbaZlota<0)
                                {
                                    // Przypisz 0 do zmiennej
                                    LiczbaZlota = 0;
                                }                              
                            }
                            // Wyśweitl wartość aktualnego złota w głównym zasobie w textBoxie
                            textBoxZłoto.Text = LiczbaZlota.ToString();
                        }                      
                    }

                    break;
                default:
                    break;
            }
            // listaZłodzieji[0].Okradnij();

            //Ustaw wartość paska progrsu na 0
            progressBarPasekZłodzieja.Value = 0;
            //Zwiększ licznik progresu o 1
            LicznikKradziezy += 1;
        }
    
        /// <summary>
        /// Metoda losująca jeden z 7 zasobów, dodaje w zależności od wylosowanej liczby dodaje daną ilość do głównego zasobu
        /// </summary>
        private void dodajNagrode()
        {
            //Stwórz lokalna zmienna typu int i wylosuj liczbę pomiędzy 1 a 7
            int losuj = losowaLiczba.Next(1, 7);
            //Sprawdź wartość losuj
            switch (losuj)
            {
                //losuj równe 1
                case 1:
                    //Zzwiększ liczbę żelaza o 5
                    LiczbaŻelaza += 5;
                    //Wyswietl liczbę żelaza w textBox
                    textBoxIlośćŻelaza.Text = LiczbaŻelaza.ToString();
                    //Przerwij
                    break;
                    //losuj równe 2
                case 2:
                    //Zwielsz liczbe drewna o 5
                    LiczbaDrewna += 5;
                    //Wyswietl liczbę drewna w textBox
                    textBoxIlośćDrewna.Text = LiczbaDrewna.ToString();
                    //Przerwij
                    break;
                    //losuj równe 3
                case 3:
                    //Zwiększ liczbę skór o 5
                    LiczbaSkór += 5;
                    //Wysiwetl liczbę skór w textBox
                    textBoxIlośćSkóry.Text = LiczbaSkór.ToString();
                    //Przerwij
                    break;
                //losuj równe 4
                case 4:
                    //Zwiększ liczbe wody o 5
                    LiczbaWody += 5;
                    //Wwyswietl liczbę wody w textBox
                    textBoxIlośćWody.Text = LiczbaWody.ToString();
                    //Przerwij
                    break;
                    //losuj równe 5
                case 5:
                    //Zwieksz liczbę ognia o 5
                    LiczbaOgnia += 5;
                    //Wyswietl liczbę ognia w textBox
                    textBoxIlośćOgnia.Text = LiczbaOgnia.ToString();
                    //Przerwij
                    break;
                    //losuj równe 6
                case 6:
                    //Zwiększ liczbę zahartowanego żelaza o 5
                    LiczbaZahartowanegoŻelaza += 5;
                    //Wyswietl liczbę zahartowanego żelaza w textBox
                    textBoxIlośćZahartowanegoŻelaza.Text = LiczbaZahartowanegoŻelaza.ToString();
                    //Przerwij
                    break;
                //losuj równe 7
                case 7:
                    //Zwiększ liczbę oleju o 5
                    LiczbaOleju += 5;
                    //Wyswietl liczbę oleju w textBox
                    textBoxIlośćOleju.Text = LiczbaOleju.ToString();
                    //Przerwij
                    break;

                default:
                    break;
            }
            // Przypisanie do lokalnej zmiennej wylosowanej liczby
            int zlotoNagroda = losowaLiczba.Next(20, 40);
            // Dodanie wylosowanego zlota do glownego zasobu zlota
            LiczbaZlota += zlotoNagroda;
            //Wyswietlenie liczby zlota w textBoxie
            textBoxZłoto.Text = LiczbaZlota.ToString();

        }
        /// <summary>
        /// Przeznacz 1 ogień do zuzycia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDodajOgnia_Click(object sender, EventArgs e)
        {
            //Jeżeli wartość liczby ognia jest większe od 0 
            if(LiczbaOgnia>0)
            {
                //Zmniejsz liczbę ognia o 1
                LiczbaOgnia -= 1;
                //Zzwiększ liczbe ognia do zużycia o 1
                LiczbaOgniaDoZużycia += 1;
                //Wyświetl wartość  liczby ognia do zuzycia w textBox
                textBoxLiczbaOgniaDoZużycia.Text = LiczbaOgniaDoZużycia.ToString();
                //Wyświetl liczbę ognia w textBox
                textBoxIlośćOgnia.Text = LiczbaOgnia.ToString();
            }
        }
        /// <summary>
        /// Przeznacz jedna wode do zuzycia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDodajWody_Click(object sender, EventArgs e)
        {
            //Jeżeli liczba wody jest większa od 0
            if(LiczbaWody>0)
            {
                //Zzminejsz liczbe wody o 1
                LiczbaWody -= 1;
                //Zwiększ liczbę wody do zużycia o 1
                LiczbaWodyDoZzużycia += 1;
                //Wyświetl liczbę wody do zuzycia w textBox
                textBoxLiczbaWodyDoZużycia.Text = LiczbaWodyDoZzużycia.ToString();
                //Wyświetl ilosc wody w textBox
                textBoxIlośćWody.Text = LiczbaWody.ToString();
            }
        }
        /// <summary>
        /// Przeznacz jedna skórę do zuzycia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDodajSkóry_Click(object sender, EventArgs e)
        {
            //Jezeli liczba skór jest większa od 0
            if(LiczbaSkór>0)
            {
                //Zmiejsz liczbe skór o 1
                LiczbaSkór -= 1;
                //Zmniejsz liczbę skór do zuzycia o 1
                LiczbaSkórDoZużycia += 1;
                //Wyswietl liczbe skor do zuzycia w textBox
                textBoxLiczbaSkórDoZużycia.Text = LiczbaSkórDoZużycia.ToString();
                //Wyswietl liczbe skor w textBox
                textBoxIlośćSkóry.Text = LiczbaSkór.ToString();
            }
        }
        /// <summary>
        /// Przeznacz jedno żelazo do zuzycia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDodajŻelazo_Click(object sender, EventArgs e)
        {
            //Jeżeli liczba zelaza jest wieksz od 0
            if(LiczbaŻelaza>0)
            {
                //Zmiejsz liczbe zelaza o 1;
                LiczbaŻelaza -= 1;
                //Zmiejsz lcizbe zelaza do zuzycia o 1
                LiczbaŻelazaDoZużycia += 1;
                //Wyswietl lcizbe zelaza do zuycia w texBox
                textBoxLiczbaŻelazaDoZuzycia.Text = LiczbaŻelazaDoZużycia.ToString();
                //Wyswietl lcizbe zalaza w textBox
                textBoxIlośćŻelaza.Text = LiczbaŻelaza.ToString();
            }
        }
        /// <summary>
        /// Przeznacz 1 drewno do zużycia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDodajDrewna_Click(object sender, EventArgs e)
        {
            //Jezeli liczba drewna jest wieksza od 0
            if(LiczbaDrewna>0)
            {
                //Zmniejsz liczbe drewna o 1
                LiczbaDrewna -= 1;
                //Zmiejsz liczbe drewna do zuzycia o 1
                LiczbaDrewnaDoZuzycia += 1;
                //Wyswietl liczbe drewna do zuzycia w textBox
                textBoxLiczbaDrewnaDoZużycia.Text = LiczbaDrewnaDoZuzycia.ToString();
                //Wystweitl liczbe drewna w textBox
                textBoxIlośćDrewna.Text = LiczbaDrewna.ToString();
            }
        }

       
        /// <summary>
        /// Stwórz 1 olej
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStwórzOlej_Click(object sender, EventArgs e)
        {
                //Jezeli liczba skor jest wieksza od zera i liczba ognia jest wieksza od 0
                if(LiczbaSkór>0 && LiczbaOgnia>0)
                {
                //Zmiejsz liczbe skor o 1
                    LiczbaSkór -= 1;
                //Zmniejsz liczbe ognia o 1
                    LiczbaOgnia -= 1;
                //Zwieksz liczbe oleju o 1
                    LiczbaOleju += 1;
                //Wyswietl liczbe skor w textBox
                    textBoxIlośćSkóry.Text = LiczbaSkór.ToString();
                //Wyswietl liczbe ognia w texbox
                    textBoxIlośćOgnia.Text = LiczbaOgnia.ToString();
                //Wyswietl liczbe oleju w texBox
                    textBoxIlośćOleju.Text = LiczbaOleju.ToString();

                }
            
        }
        /// <summary>
        /// Stwórz 1 zahartowane żelazo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStwórzZahartowaneŻelazo_Click(object sender, EventArgs e)
        {
            //Jezeli liczba zelaza jest wieksza bądz rowna 2 i liczba wody jest wieksza badz rowna 3 i liczba ognia jest wieksza badz rowna 3
            if(LiczbaŻelaza>=2 && LiczbaWody>=3 && LiczbaOgnia>=3)
            {
                //ZMiejsz liczbe zelaza o 2
                LiczbaŻelaza -= 2;
                //ZMIejsz liczbe wody o 3
                LiczbaWody -= 3;
                //Zmiejsz liczbe ognia o 3
                LiczbaOgnia -= 3;
                //Zwieksz liczbe zahartowanego zelaza o 1
                LiczbaZahartowanegoŻelaza += 1;
                //Wyswietl licbe zelza w texBox
                textBoxIlośćŻelaza.Text = LiczbaŻelaza.ToString();
                //Wyswietl liczbe wody w textBox
                textBoxIlośćWody.Text = LiczbaWody.ToString();
                //Wswietl liczbe ognia w textBox
                textBoxIlośćOgnia.Text = LiczbaOgnia.ToString();
                //Wyswietl liczbe zahartowanego zelaza w textBox
                textBoxIlośćZahartowanegoŻelaza.Text = LiczbaZahartowanegoŻelaza.ToString();
            }
        }
        /// <summary>
        /// Dodaj olej do zużycia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDodajOlej_Click(object sender, EventArgs e)
        {
            //JEzeli lcizba oleju jest wieksza od 0
           if(LiczbaOleju>0)
            {
                //Zmiejsz lcizbe oleju o 1
                LiczbaOleju -= 1;
                //Zwieksz lcizbe oleju do zuzycia o 1
                LiczbaOlejuDoZzużycia += 1;
                //Wyswietl liczbe oleju do zuzycia w textBox
                textBoxLiczbaOlejuDoZużycia.Text = LiczbaOlejuDoZzużycia.ToString();
                //Wysweitl liczbe oleju w textBox
                textBoxIlośćOleju.Text = LiczbaOleju.ToString();
            }
        }
        /// <summary>
        /// Dodaj 1 zahartowane żelazo do zuzycia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDodajZahartowaneŻelazo_Click(object sender, EventArgs e)
        {
            //Jezeli liczba zahartowanego zelaza jest wieksza od 0
            if (LiczbaZahartowanegoŻelaza > 0)
            {
                //Zmniejsz lcizbe zahartowanego zelaza o 1 
                LiczbaZahartowanegoŻelaza -= 1;
                //Zwieksz liczbe zahartowanego zelaza do zuzycia o 1
                LiczbaZahartowanegoŻelazaDoZużycia += 1;
                //Wyswietl liczbe zahartowanego zelaza w textBox
                textBoxLiczbaZahartowanegoŻelazaDoZużycia.Text = LiczbaZahartowanegoŻelazaDoZużycia.ToString();
                //Wyswietl liczbe zelaza w textBox
                textBoxIlośćZahartowanegoŻelaza.Text = LiczbaZahartowanegoŻelaza.ToString();
            }
        }
        /// <summary>
        /// Zwróć olej do głównego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdejmijOlej_Click(object sender, EventArgs e)
        {
            //Jezeli lcizba oleju do zuzycia jest wieksza od 0
            if(LiczbaOlejuDoZzużycia>0)
            {
                //Zmniejsz lcizbe oleju do zuzycia o 1
                LiczbaOlejuDoZzużycia -= 1;
                //Zwieksz liczbe oleju o 1
                LiczbaOleju += 1;
                //WYswietl liczbe oleju do zuzycia w textBox
                textBoxLiczbaOlejuDoZużycia.Text = LiczbaOlejuDoZzużycia.ToString();
                //Wyswieltl liczbe oleju w textBox
                textBoxIlośćOleju.Text = LiczbaOleju.ToString();
            }
        }
        /// <summary>
        /// Zwróć zahartowane żelazo do głównego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdjemijZahartowaneŻelazo_Click(object sender, EventArgs e)
        {
            //Jezli lcizba zaharrtowanego zelaza do zuzycia jest wieksza od 0
            if (LiczbaZahartowanegoŻelazaDoZużycia > 0)
            {
                //Zwieksz liczbe zahartowanego zelaza o 1
                LiczbaZahartowanegoŻelaza += 1;
                //Zminejsz lcizbe zahartowanego zelaza o 1
                LiczbaZahartowanegoŻelazaDoZużycia -= 1;
                //Wyswietl liczbe zahartowanego zelaza do zuycia w textBox
                textBoxLiczbaZahartowanegoŻelazaDoZużycia.Text = LiczbaZahartowanegoŻelazaDoZużycia.ToString();
                //Wwyswietl liczbe zahartowanego zelaza w textBox
                textBoxIlośćZahartowanegoŻelaza.Text = LiczbaZahartowanegoŻelaza.ToString();
            }
        }
        /// <summary>
        /// Zwróć 1 ogień do głównego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdejmij1Ogień_Click(object sender, EventArgs e)
        {
            //Jezeli liczba ognia do zuzycia jest wieksza od 1
            if(LiczbaOgniaDoZużycia>0)
            {
                //Zzmiejsz liczbe ognia do zuzycia o 1
                LiczbaOgniaDoZużycia -= 1;
                //Zwieksz liczbe ognia o 1
                LiczbaOgnia += 1;
                //Wyswietl lcizbe ognia do zuzycia w textBox
                textBoxLiczbaOgniaDoZużycia.Text = LiczbaOgniaDoZużycia.ToString();
                //Wyswietl liczbe ognia w textBox
                textBoxIlośćOgnia.Text = LiczbaOgnia.ToString();
            }
        }
        /// <summary>
        /// Zwróć jedną wodę do głównego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdejmij1Wode_Click(object sender, EventArgs e)
        {
            //Jezeli liczba wody do zuzycia jest wieksza od 1
            if(LiczbaWodyDoZzużycia>0)
            {
                //Zmiejsz lcizbe wody do zuzycia o 1
                LiczbaWodyDoZzużycia -= 1;
                //Zzwieksz lcizbe wody o 1
                LiczbaWody += 1;
                //Wyswietl liczbe wody do zuzycia w textBox
                textBoxLiczbaWodyDoZużycia.Text = LiczbaWodyDoZzużycia.ToString();
                //Wyswietl liczbe wody w textBox
                textBoxIlośćWody.Text = LiczbaWody.ToString();
            }
        }
        /// <summary>
        /// Zwróć jedną skórę do głównego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdejmij1Skórę_Click(object sender, EventArgs e)
        {
            //Jezeli liczba skor do zuzycia jest wieksze od 0
            if(LiczbaSkórDoZużycia>0)
            {
                //Zmiejsz liczbe skor do zuzycia o 1
                LiczbaSkórDoZużycia -= 1;
                //Zwieksz liczbe skor o 1
                LiczbaSkór += 1;
                //Wyswietl lcizbe skor do zuzycia w texBox
                textBoxLiczbaSkórDoZużycia.Text = LiczbaSkórDoZużycia.ToString();
                //Wyswietl liczbe skor w textBox
                textBoxIlośćSkóry.Text = LiczbaSkór.ToString();
            }
        }
        /// <summary>
        /// Zwróć 1 drewno do głównego zasobu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdejmij1Drewno_Click(object sender, EventArgs e)
        {
            //Jezeli liczba drewna do zuzycia jest wieksza od 0
            if(LiczbaDrewnaDoZuzycia>0)
            {
                //ZMijesz lcizbe drewna do zuzycia o 1
                LiczbaDrewnaDoZuzycia -= 1;
                //Zwieksz liczbe drewna o 1 
                LiczbaDrewna += 1;
                //Wysswietl liczbe drewna do zuzycia w textBox
                textBoxLiczbaDrewnaDoZużycia.Text = LiczbaDrewnaDoZuzycia.ToString();
                //Wwyswietl lcizbe drewna w textBox
                textBoxIlośćDrewna.Text = LiczbaDrewna.ToString();
            }
        }
        /// <summary>
        /// Zwróc 1 żelazo do głównego zasobu 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdejmij1Żelazo_Click(object sender, EventArgs e)
        {
            //Jezeli liczba zelaza do zuzycia jest wieksza od 0
            if(LiczbaŻelazaDoZużycia>0)
            {
                //Zmiejsz liczbe zelaza o 1
                LiczbaŻelazaDoZużycia -= 1;
                //Zzwielksz liczbe zelaza o 1
                LiczbaŻelaza += 1;
                //Wyswietl liczbe zelaza do zuzycia w texBox
                textBoxLiczbaŻelazaDoZuzycia.Text = LiczbaŻelazaDoZużycia.ToString();
                //Wyswietl liczbe zelaza w textBox
                textBoxIlośćŻelaza.Text = LiczbaŻelaza.ToString();
            }

        }
        /// <summary>
        /// Wykuj broń
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonWykuj_Click(object sender, EventArgs e)
        {
            //Wywołaj metodę sprawdzZgodnoscMaterialow 
            sprawdzZgodnoscMaterialow();
        }
        /// <summary>
        /// Włącz okno z receptami na itemy
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRecepty_Click(object sender, EventArgs e)
        {
            //Jeżeli wartosc logincza jest true
            if(formRecepta.wroc)
            {
                //Ukryj ten obiekt
                this.Hide();
                //Pokaz obiekt formRecepta
                formRecepta.Show();
            }
        }
        /// <summary>
        /// Wykup straznika zelaza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikZelaza_Click(object sender, EventArgs e)
        {

            // Jezeli liczba zlota jest wieksza od 10
            if(LiczbaZlota >= 10)
            {
                // Zmiejsz liczbe zlota
                LiczbaZlota -= 10;
                // Wysweitl liczbe zlota w textBox
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc przez metode Chron do liczbyStraznikowZelaza
                liczbaStraznikowZelaza += straznikZasobow.Chron();
                // Wwyswietl liczbe straznikow zelaza w labelu
                labelIloscStaznikowZelaza.Text = liczbaStraznikowZelaza.ToString();
                // Ustaw dlugosc trwania ochrony w turach 
                dlugoscOchronyZelaza=straznikZasobow.StrzezZasoby(dlugoscOchronyZelaza);
               
            }
        }
        /// <summary>
        /// Wykup straznika drewna
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStraznikDrewna_Click(object sender, EventArgs e)
        {
            // Jezeli liczba zlota jest wieksza badz rowna 5
            if(LiczbaZlota >= 5)
            {
                // Odejmij liczbe zlota
                LiczbaZlota -= 5;
                // Wysweitl liczbe zlota w textBox
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc przez metode Chron liczbyStraznikowDrewna
                liczbaStraznikowDrewna += straznikZasobow.Chron();
                // Wyswietl liczbeStraznikowDrewna w labelu
                labelIloscStraznikowDrewna.Text = liczbaStraznikowDrewna.ToString();
                // Ustaw dlugosc ochrony drewna w turach
                dlugoscOchornyDrewna = straznikZasobow.StrzezZasoby(dlugoscOchornyDrewna);
            }
        }
        /// <summary>
        /// Wykup straznika skor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikSkór_Click(object sender, EventArgs e)
        {
            // Jezeli liczba zlota jest wieksza badz rowna 4
            if(LiczbaZlota >= 4)
            {
                // Zmniejsz liczbe zlota o 4
                LiczbaZlota -= 4;
                // Wyswietl liczbe zlota w textBoxie
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc z metody Chron do liczbyStraznikowSkor
                liczbaStraznikowSkor += straznikZasobow.Chron();
                // Wyswietl liczbe straznikow skor w labelu 
                labelIloscStraznikowSkor.Text = liczbaStraznikowSkor.ToString();
                // Przypisz dlugosc ochrony w turach do zmiennej dlugoscOchronySkor
                dlugoscOchornySkor = straznikZasobow.StrzezZasoby(dlugoscOchornySkor);
            }
        }
        /// <summary>
        /// Wykup straznika wody
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikWody_Click(object sender, EventArgs e)
        {
            // Jezeli zloto jest wieksze badz rowne 5
            if(LiczbaZlota >= 1)
            {
                // Odejmij liczbe zlota
                LiczbaZlota -= 1;
                // Wyswietl wartosc zlota  w textBoxie
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwaracan wartosc z metody Chron do liczbyStraznikowWwody
                liczbaStraznikowWody += straznikZasobow.Chron();
                // Wyswietl liczbe straznikow wody w labelu
                labelIloscStraznikowWody.Text = liczbaStraznikowWody.ToString();
                // Przypisz dlugosc ochrony w turach do zmiennej dlugoscOchronyWody
                dlugoscOchronyWody = straznikZasobow.StrzezZasoby(dlugoscOchronyWody);
            }
        }
        /// <summary>
        /// Wykup straznika ognia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikOgnia_Click(object sender, EventArgs e)
        {
            // Jezli liczba zlota jest wieksza badz rowna 5
            if(LiczbaZlota >= 5)
            {
                // Zmniejsz liczbe zlota
                LiczbaZlota -= 5;
                // Wyswetl liczbe zlota w texBoxie
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz wartosc zwracana przez metode Chron do liczbaStraznikowOgnia
                liczbaStraznikowOgnia += straznikZasobow.Chron();
                // Wysweitl liczbeStraznikowOgnia w labelu
                labelIloscStraznikowOgnia.Text = liczbaStraznikowOgnia.ToString();
                // Ustaw dlugosc ochrony ognia w turach do zmiennej dlugoscOchronyOgnia
                dlugoscOchronyOgnia = straznikZasobow.StrzezZasoby(dlugoscOchronyOgnia);
            }
        }
        /// <summary>
        /// Wykup straznika oleju
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikOleju_Click(object sender, EventArgs e)
        {
            // Jezeli liczba zlota jest wieksza badz rowna 7
            if(LiczbaZlota >= 7)
            {
                //Odejmij liczbe zlota
                LiczbaZlota -= 7;
                // Wyswietl liczbe zlota w texBoxie
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc przez metode Chron do liiczbyStraznikowOleju
                liczbaStraznikowOleju += straznikZasobow.Chron();
                // Wysweitl liczbe straznikow oleju w labelu
                labelIloscStraznikowOleju.Text = liczbaStraznikowOleju.ToString();
                // Przypisz dlugosc trwania ochrony oleju w turach 
                dlugoscOchronyOleju = straznikZasobow.StrzezZasoby(dlugoscOchronyOleju);
            }
        }
        /// <summary>
        /// Wykup straznika zahartowanego zelaza
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikZzahartowanegoŻelaza_Click(object sender, EventArgs e)
        {
            //Jezeli liczba zlota jest wieksza badz rowna 15
            if(LiczbaZlota >= 15)
            {
                // Odejmij liczbe zlota
                LiczbaZlota -= 15;
                //Wyswietl LiczbaZlota w textBoxei
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc przez metode Chron do liczbyZahartowanegoZelaza
                liczbaStraznikowZahartowanegoZelaza += straznikZasobow.Chron();
                // Wyswietl w labelu liczbeStraznikowZahartowanegoZelaza
                labelIloscStraznikowZahartowanegoZelaza.Text = liczbaStraznikowZahartowanegoZelaza.ToString();
                // Ustaw dlugosc ochrony zahartownego zelza w turach
                dlugoscOchronyZahartowaneZelaza = straznikZasobow.StrzezZasoby(dlugoscOchronyZahartowaneZelaza);
            }
        }
        /// <summary>
        /// Wykup straznika zlota
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikZłota_Click(object sender, EventArgs e)
        {
            //Jezeli liczba zlota jest wieksza badz rowna 6
            if(LiczbaZlota >= 6)
            {
                // Odjemij liczbe zlota
                LiczbaZlota -= 6;
                // Wyswietl liczbe zlota w textBoxie
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc przez metode Chron do liczbyStraznikowZlota
                liczbaStraznikowZlota += straznikZasobow.Chron();
                // Wyswietl liczbe straznikow zlota w labelu
                labelIloscStraznikowZlota.Text = liczbaStraznikowZlota.ToString();
                // Przypisz zwracana wartosc do ochrony zlota w turach 
                dlugoscOchronyZlota = straznikZasobow.StrzezZasoby(dlugoscOchronyZlota);
            }
        }

        /// <summary>
        /// Wytworz straznika recepty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStraznikRecept_Click(object sender, EventArgs e)
        {
            // Jezeli liczba zlota jest wieksza badz rowna 6
            if(LiczbaZlota >= 6)
            {
                // Zmnijesz liczbe zlota o 6
                LiczbaZlota -= 6;
                // Wwyswietl liczbe zlota w texBoxie
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc metody Chron do liczbaStraznikowRecept
                liczbaStraznikowRecept += straznikRecept.Chron();
                // Wyswwietl liczbe straznikow recept w labelu
                labelIloscStraznikowRecept.Text = liczbaStraznikowRecept.ToString();
                // Odblokuj przycisk Recpety
                straznikRecept.Odblokuj(buttonRecepty);
            }
        }
        /// <summary>
        /// Wytworz straznika czasu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStrażnikCzasu_Click(object sender, EventArgs e)
        {
            //Jezeli liczba zlota jest wieksza badz rowna 5
            if(LiczbaZlota >= 5)
            {
                // Odejmij liczbe zlota
                LiczbaZlota -= 5;
                // Wyswietl liczbe zlota w textBoxie
                textBoxZłoto.Text = LiczbaZlota.ToString();
                // Przypisz zwracana wartosc metody Chron do liczbaStraznikowCzasu
                liczbaStraznikowCzasu += straznikCzasu.Chron();
                // Wyswietl liczbe straznikow czasu w labelu
                labelIloscStraznikowCzasu.Text = liczbaStraznikowCzasu.ToString();
            }
        }
    }
}
