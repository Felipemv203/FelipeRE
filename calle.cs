namespace Obraspublicas
{
    public class Calle
    {
        private string tipodete;
        private string tipoCalle;
        private int cantidadAlimento;

        public Calle()
        {
            tipoCalle = string.Empty;
            tipodete = string.Empty;
        }
        public string tipodeterioro
        {
            get { return tipodete; }
            set { tipodete = value; }
        }
        public string TipoCalle
        {
            get { return tipoCalle; }
            set { tipoCalle = value; }
        }
    }
}