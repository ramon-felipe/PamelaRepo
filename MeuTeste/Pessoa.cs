using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuTeste
{
    public class Pessoa
    {

        // propriedades
        public double Altura { get; set; } = 1.75;

        // comportamentos

        // private
        // protected
        // internal
        // 
        public string Andar()
        {
            var s = "Estou andando";
            

            return s;
        } 

        public void ExibirAltura()
        {
            Console.WriteLine("Esta pessoa tem {0} de altura", this.Altura);
        }


    }
}
