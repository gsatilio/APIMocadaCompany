namespace APIMocadaCompany.Models
{
    public class Company
    {
        public string Cnpj { get; set; }
        public string Name { get; set; }
        public string NameOpt { get; set; }
        public DateTime DtOpen { get; set; }
        public bool Restricted { get; set; }
        public Address Address { get; set; }
    }
}
