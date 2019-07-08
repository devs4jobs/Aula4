using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Clasees
{
    class Dicionario< TChave, TValor>
    {
        public List<Verbetes<TChave, TValor>> verbetes;

        public Dicionario() {
            verbetes = new List<Verbetes<TChave, TValor>>();
        }

        public Dicionario (List<Verbetes<TChave, TValor>> verbetes)
        {
            this.verbetes = verbetes;
        }

        public void Add (Verbetes<TChave, TValor> verbete)
        {
            verbetes.Add(verbete);
        }

        //public Tturma GetTturma (TlstProf lstProfessor, TlsAluno lstAluno)
        //{
        //    Tturma valorProcurado = default(Tturma);

        //    for(int i = 0; i < verbetes.Count; i++)
        //    {
        //        if (verbetes[i].TlsAluno_.Equals(lstAluno))
                
        //            valorProcurado = verbetes[i].TlsAluno_;
                
        //    }
        //    return valorProcurado; 

        //}

        public override string ToString()
        {
            string dicionario = "";
            for (int i = 0; i < verbetes.Count; i++)
            {
                dicionario += verbetes[i].ToString() + "";
            }
            return dicionario ; 
        }

        //https://www.youtube.com/watch?v=ALLSIVMhwYw&t=42s <=== dicionario !!
    }
}
