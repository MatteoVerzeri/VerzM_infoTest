using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzM_infoTest
{
    public abstract class VerzM_Candidato : IEquatable<VerzM_Candidato>
    {
        private int VerzM_matricola;
        private string VerzM_nome;
        public int VerzM_Matricola { get; set; }
        public string VerzM_Nome { get; set; }
        public VerzM_Candidato()
        {
            VerzM_Matricola = 0;
            VerzM_Nome = null;
        }
        public VerzM_Candidato(int VerzM_matricola)
        {
            VerzM_Matricola = VerzM_matricola;
            VerzM_Nome = null;
        }
        public VerzM_Candidato(string VerzM_nome)
        {
            VerzM_Nome = VerzM_nome;
            VerzM_Matricola = 0;
        }
        public VerzM_Candidato(int VerzM_matricola, string VerzM_nome)
        {
            VerzM_Matricola = VerzM_matricola;
            VerzM_Nome = VerzM_nome;
        }
        public abstract bool isIdoneo();
        public abstract int punteggio();
        public override string ToString()
        {
            string a = VerzM_matricola.ToString() + " " + VerzM_nome;
            return a;
        }
        public virtual bool Equals(VerzM_Candidato candidato)
        {
            if (candidato == null)
            {
                return false;
            }
            if (candidato.VerzM_nome == this.VerzM_nome && candidato.VerzM_matricola == this.VerzM_matricola)
            {
                return true;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (VerzM_matricola, VerzM_nome).GetHashCode();
        }
    }
}
