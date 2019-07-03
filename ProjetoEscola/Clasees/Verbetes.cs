using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEscola.Clasees
{
    class Verbetes<Tturma, TlstProf, Tprof, TlsAluno, Taluno>
    {

        //public TlstTurmas TlstTurmas_ { get; set; }
        public Tturma turma_ { get; set; }
        public TlstProf TlstProf_ { get; set; }
        public Tprof Tprof_ { get; set; }
        public TlsAluno TlsAluno_ { get; set;}

        public Taluno Taluno_ { get; set; }

        public Verbetes(Tturma turma_, TlstProf tlstProf_, Tprof tprof_, TlsAluno tlsAluno_, Taluno taluno_)
        {
           // this.TlstTurmas_ = tlstTurmas_;
            this.turma_ = turma_;
            this.TlstProf_ = tlstProf_;
            this.Tprof_ = tprof_;
            this.TlsAluno_ = tlsAluno_;
            this.Taluno_ = taluno_;
        }

        public override string ToString()
        {
            return $"Turma : {turma_} Tem {TlstProf_} Professores e seus nomes são {Tprof_} e tem {TlsAluno_} e seus nomes são {Taluno_} \n";
        }
    }
}
