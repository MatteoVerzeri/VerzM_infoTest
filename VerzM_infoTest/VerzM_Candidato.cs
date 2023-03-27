using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzM_infoTest
{
    public abstract class VerzM_Candidato
    {
        private int VerzM_matricola;
        private string VerzM_nome;
        public int VerzM_Matricola { get; set; }
        public string VerzM_Nome { get; set; }
        public VerzM_Candidato()
        {
            VerzM_matricola = 0;
            VerzM_Nome = "";
        }
        public VerzM_Candidato(int VerzM_matricola)
        {
            this.VerzM_matricola = VerzM_matricola;
            VerzM_Nome = "";
        }
        public VerzM_Candidato(string VerzM_nome)
        {
            this.VerzM_nome = VerzM_nome;
            VerzM_matricola = 0;
        }
        public VerzM_Candidato(int VerzM_matricola, string VerzM_nome)
        {
            this.VerzM_Matricola = VerzM_matricola;
            this.VerzM_Nome = VerzM_nome;
        }
        public abstract bool isIdoneo();
        public abstract int punteggio();
    }
}
