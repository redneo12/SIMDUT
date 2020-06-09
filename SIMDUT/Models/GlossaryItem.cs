namespace SIMDUT.Models
{
    public class GlossaryItem
    {
        public string Element { get; set; }
        public string Definition { get; set; }
        public string ElementSort => Element[0].ToString();
    }


}
