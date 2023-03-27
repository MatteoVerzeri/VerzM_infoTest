using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzM_infoTest
{
    internal class VerzM_Lavoratore : VerzM_Candidato, IEquatable<VerzM_Lavoratore>, IComparable<VerzM_Lavoratore>
    {
        private int VerzM_esperienze;
        public int VerzM_Esperienze { get { return VerzM_esperienze; } set { if (value <= 5 && value >=0) { VerzM_esperienze = value; } } }
        public VerzM_Lavoratore() : base()
        {
            VerzM_Esperienze = 0;
        }
        public VerzM_Lavoratore(int VerzM_esperienze, int VerzM_Matricola, string VerzM_Nome) : base(VerzM_Matricola, VerzM_Nome)
        {
            VerzM_Esperienze = VerzM_esperienze;
        }
        public override int punteggio()
        {
            return VerzM_Esperienze*20;
        }
        public override bool isIdoneo()
        {
            if(punteggio() >= 60)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
        public override string ToString()
        {
            string a = VerzM_esperienze.ToString();
            return a;
        }
        public bool Equals(VerzM_Lavoratore candidato)
        {
            if (base.Equals(candidato) == true && candidato.VerzM_esperienze == this.VerzM_esperienze)
                return true;
            else
                return false;
        }
        public virtual int CompareTo(VerzM_Lavoratore candidato)
        {
            if (this.punteggio() == candidato.punteggio())
            {
                return 0;
            }
            else if (this.punteggio() > candidato.punteggio())
            {
                return 1;
            }
            else
            {
                return -1;
            }

        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
