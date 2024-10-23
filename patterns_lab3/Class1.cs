using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace patterns_lab3
{
    internal class House
    {
        public string addres {  get; set; }
        public int residents { get; set; }
        public int id = 0;
        public House(string addres, int residents)
        {
            this.addres = addres;
            this.residents = residents;
            this.id = id++;
        }
        public override string ToString()
        {
            return $"Addres: {this.addres}, residents: {this.residents}";
        }

    }
}
