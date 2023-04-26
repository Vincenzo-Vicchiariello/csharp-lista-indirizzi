using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    internal class Address
    {
        private string Name;
        private string Surname;
        private string Street;
        private string City;
        private string Province;
        private string ZIP;
    
        public Address(string Name, string Surname, string Street, string City, string Province, string ZIP) { 
            this.Name = Name;
            this.Surname = Surname; 
            this.Street = Street;
            this.City = City;
            this.Province = Province;
            this.ZIP = ZIP;
        }
    public override string ToString()
    {
            return ($"Nome:{this.Name}");
     
    }

    }


}
