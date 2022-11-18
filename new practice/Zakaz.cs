using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Misha1
{
    public class Zakaz
    {
        [Column("Kodzakazauslugi")]
        public int ID { get; set; }

        public int IDyslugi { get; set; }

        public int IDclenta { get; set; }

        public int IDtipazakaza { get; set; }

        public int IDsotrudnika { get; set; }

        public LinkedList<Klient> Klient { get; set; } = new();
    }
}
 