using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM.Data.DAO
{
   public class Fournisseur
    {
        public int Id { get; set; }
        public string Designation { get; set; }
        public string Numero { get; set; }
        public string Mail { get; set; }
    }
}
