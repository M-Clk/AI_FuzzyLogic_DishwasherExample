using System.Collections.Generic;

namespace Fuzzy_Logic_Lib
{
    public static class RulesBase
    {
        public enum InputFunctionIndexesInRuleFormat
        {
            Hassaslik = 0,
            Miktar = 1,
            Kirlilik = 2
        }
        public enum OutputFunctionIndexesInRuleFormat
        {
            DonusHizi = 0,
            Sure = 1,
            DeterjanMiktari = 2
        }
        //Format : Key = Hassaslik,Miktar,Kirlilik Value = Donus Hizi, Sure, Deterjan Miktari
        public static Dictionary<string, string> Rules = new Dictionary<string, string>
        {
            {"Hassas,Küçük,Küçük","Hassas,Kısa,Çok Az" },
            {"Hassas,Küçük,Orta","Normal Hassas,Kısa,Az"},
            {"Hassas,Küçük,Büyük","Orta,Normal Kısa,Orta"},

            {"Hassas,Orta,Küçük","Hassas,Kısa,Orta"},
            {"Hassas,Orta,Orta","Normal Hassas,Normal Kısa,Orta"},
            {"Hassas,Orta,Büyük","Orta,Orta,Fazla"},

            {"Hassas,Büyük,Küçük","Normal Hassas,Normal Kısa,Orta"},
            {"Hassas,Büyük,Orta","Normal Hassas,Orta,Fazla"},
            {"Hassas,Büyük,Büyük","Orta,Normal Uzun,Fazla"},

            {"Orta,Küçük,Küçük","Normal Hassas,Normal Kısa,Az"},
            {"Orta,Küçük,Orta","Orta,Kısa,Orta"},
            {"Orta,Küçük,Büyük","Normal Güçlü,Orta,Fazla"},

            {"Orta,Orta,Küçük","Normal Hassas,Normal Kısa,Orta"},
            {"Orta,Orta,Orta","Orta,Orta,Orta"},
            {"Orta,Orta,Büyük","Hassas,Uzun,Fazla"},

            {"Orta,Büyük,Küçük","Hassas,Orta,Orta"},
            {"Orta,Büyük,Orta","Hassas,Normal Uzun,Fazla"},
            {"Orta,Büyük,Büyük","Hassas,Uzun,Çok Fazla"},

            {"Sağlam,Küçük,Küçük","Orta,Orta,Az"},
            {"Sağlam,Küçük,Orta","Normal Güçlü,Orta,Orta"},
            {"Sağlam,Küçük,Büyük","Güçlü,Normal Uzun,Fazla"},

            {"Sağlam,Orta,Küçük","Orta,Orta,Orta"},
            {"Sağlam,Orta,Orta","Normal Güçlü,Normal Uzun,Orta"},
            {"Sağlam,Orta,Büyük","Güçlü,Orta,Çok Fazla"},

            {"Sağlam,Büyük,Küçük","Normal Güçlü,Normal Uzun,Fazla"},
            {"Sağlam,Büyük,Orta","Normal Güçlü,Uzun,Fazla"},
            {"Sağlam,Büyük,Büyük","Güçlü,Uzun,Çok Fazla"},
        };
    }
}


