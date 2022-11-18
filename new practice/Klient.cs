using System.ComponentModel.DataAnnotations;

namespace Misha1
{
    public class Klient
    {
        [Key]
        public int Client_ID { get; set; }

        public string FIO_clienta { get; set; }

        public string Telefon_clienta { get; set; }

        public int? ZakazID { get; set; }

        public Zakaz? Zakaz { get; set; }

    }
}