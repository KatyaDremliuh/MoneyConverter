using System.Xml.Serialization;

namespace MoneyConverterApp
{
    public class ValCurs
    {
        [XmlAnyElementAttribute("Valute")]
        public Valute[] ValuteList;
    }
}
