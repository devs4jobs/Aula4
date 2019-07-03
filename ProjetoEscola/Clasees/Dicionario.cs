using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Clasees
{
    class Dicionario< Tturma, TlstProf, Tprof, TlsAluno, Taluno>
    {
        public List<Verbetes< Tturma , TlstProf , Tprof , TlsAluno ,Taluno >> verbetes;

        public Dicionario() {
            verbetes = new List<Verbetes<Tturma, TlstProf, Tprof, TlsAluno, Taluno>>();
        }

        public Dicionario (List<Verbetes<Tturma, TlstProf, Tprof, TlsAluno, Taluno>> verbetes)
        {
            this.verbetes = verbetes;
        }

        public void Add (Verbetes<Tturma, TlstProf, Tprof, TlsAluno, Taluno> verbete)
        {
            verbetes.Add(verbete);
        }

        public Tturma GetTturma (TlstProf lstProfessor, TlsAluno lstAluno)
        {
            Tturma valorProcurado = default(Tturma);

            for(int i = 0; i < verbetes.Count; i++)
            {
                if (verbetes[i].TlsAluno_.Equals(lstAluno))
                
                    valorProcurado = verbetes[i].TlsAluno_;
                
            }
            return valorProcurado;

        }

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
