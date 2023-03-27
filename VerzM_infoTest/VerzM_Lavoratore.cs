using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzM_infoTest
{
    internal class VerzM_Lavoratore : VerzM_Candidato
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
    }
}
