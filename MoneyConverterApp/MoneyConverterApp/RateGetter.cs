using System.Xml;
using System.Xml.Serialization;

namespace MoneyConverterApp
{
    class RateGetter
    {
        public static double GetUsd()
        {
            XmlSerializer xs = new XmlSerializer(typeof(ValCurs));
            XmlReader xr = new XmlTextReader(@"https://www.nbrb.by/api/exrates/currencies");

            // перевести строковое представление в объект
            var valuteCurs = (ValCurs)xs.Deserialize(xr);

            // найдем там наш доллар
            for (int i = 0; i < valuteCurs.ValuteList.Length; i++)
            {
                Valute valute = valuteCurs.ValuteList[i];

                if (valute.Cur_Name == "Доллар США")
                {
                    return double.Parse(valute.Cur_OfficialRate);
                }
            }

            return 0;
        }
    }
}
