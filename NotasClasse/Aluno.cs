using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasClasse
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double Faltou()
        {
            return 60-NotaFinal();
        }
        public override string ToString()
        {
            if (NotaFinal() < 60)
            {
                return "REPROVADO. FALTARAM " + Faltou() + " PONTOS";
               
            }
            else
            {
                return "APROVADO";
            }
        }


    }
}
