using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnkietaNastroju
{
    class KalkulatorZadowolenia
    {
        int[] pytania;
        
        public KalkulatorZadowolenia()
        {
            this.pytania = new int[5];
        }

        public string Pytanie1
        {
            set
            {
                this.pytania[0] = ObliczZadowoleniePyt1(value);
            }
        }

        public List<string> Pytanie2
        {
            set
            {
                int wynik = 0;
                foreach(string text in value)
                {
                    wynik += ObliczZadowoleniePyt2(text);
                }
                this.pytania[1] = wynik;
            }
        }

        public bool Pytanie3
        {
            set
            {
                if(value)
                {
                    this.pytania[2] = 5;
                }
                else
                {
                    this.pytania[2] = 0;
                }
            }
        }


        public string Pytanie3Bis
        {
            set
            {
                this.pytania[3] = ObliczZadowoleniePyt3Bis(value);
            }
        }

        public decimal Pytanie4
        {
            set
            {
                this.pytania[4] = ObliczZadowoleniePyt4(value);
            }
        }


        private int ObliczZadowoleniePyt1(string text)
        {
            switch(text)
            {
                case "jestem bardzo zadowolony/a": return 2;
                case "jestem zadowolony/ a": return 1;
                case "jestem średnio zadowolony / a": return 0;
                case "jestem niezadowolony/ a": return -1;
                case "jestem bardzo niezadowolony / a": return -2;
            }
            return 0;
        }

        private int ObliczZadowoleniePyt2(string text)
        {
            switch (text)
            {
                case "radość": return 6;
                case "zadowolenie": return 4;
                case "podekscytowanie": return 5;
                case "zdenerwowanie": return -3;
                case "złość": return -5;
                case "obojętność": return -1;
                case "strach": return -6;
            }
            return 0;
        }

        private int ObliczZadowoleniePyt3Bis(string text)
        {
            switch (text)
            {
                case "Lepsza oferta od innego pracodawcy": return -1;
                case "Dobry pomysł na własny biznes": return 0;
                case "Zmiana życiowa": return 0;
                case "Brak możliwości rozwoju w danej firmie": return -3;
                case "Brak motywacji": return -4;
                case "Zbyt stresująca praca": return -5;
            }
            return 0;
        }

        private int ObliczZadowoleniePyt4(decimal value)
        {
            if(value < 8)
            {
                return 2;
            }

            if(value == 8)
            {
                return 0;
            }
            
            if (value > 8)
            {
                return -2;
            }

            return 0;
        }

        public PoziomZadowolenia WyliczPoziomZadowolenia()
        {
            int sum = 0;
            for(int i=0; i<this.pytania.Length; i++)
            {
                sum += pytania[i];
            }

            if (sum <-5)
            {
                return PoziomZadowolenia.Źle;
            }
            if (sum >= -5 && sum <= 5)
            {
                return PoziomZadowolenia.Średnio;
            }
            if (sum > 5)
            {
                return PoziomZadowolenia.Dobrze;
            }

            return PoziomZadowolenia.Średnio;
            
        }

    }
}
