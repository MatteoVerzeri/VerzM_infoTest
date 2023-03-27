using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerzM_infoTest
{
    public class VerzM_Disoccupato : VerzM_Candidato
    {
        private int VerzM_voto;
        private bool VerzM_lode;
        public int VerzM_Voto
        {
            get { return VerzM_voto; }
            set 
            { 
                if (VerzM_voto <= 110) 
                { 
                    VerzM_voto = value; 
                }
            }
        }
        
        public bool VerzM_Lode { get { return VerzM_lode; } set { if (VerzM_voto == 110) { VerzM_lode = value; } } }
        public VerzM_Disoccupato() : base()
        {
            VerzM_Voto = 0;
            VerzM_Lode = false;

        }
        public VerzM_Disoccupato(int VerzM_voto, bool VerzM_lode, int VerzM_Matricola, string VerzM_Nome) : base(VerzM_Matricola, VerzM_Nome)
        {
            VerzM_Voto = VerzM_voto;
            VerzM_Lode = VerzM_lode;
        }
        public override int punteggio()
        {
            int tmp = VerzM_voto;
            if (VerzM_Lode == true)
            {
                return ((tmp * 100) / 110) + 5;
            }
            else
            {
                return ((tmp * 100) / 110);
            }
        }
        public override bool isIdoneo()
        {
            if (punteggio() >= 72)
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
