using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VerzM_infoTest
{
    public partial class Form1 : Form
    {
        List<VerzM_Candidato> candidati;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        public void aggiunta(VerzM_Candidato candidato)
        {
            candidati.Add(candidato);
        }
        public string[] visualizza()
        {
            
            int x = candidati.Count;
            string[] c = new string[x];
            int cont = 0;
            foreach(VerzM_Candidato candidato in candidati)
            {
                c[cont] = candidato.ToString();
                cont++;
            }
            return c;
        }
        public void modifica(string nome, int matricola)
        {
            for(int i=0; i < candidati.Count; i++)
            {
                if(candidati[i].VerzM_Matricola == matricola)
                {
                    candidati[i].VerzM_Nome = nome;
                }
            }
        }
        public void elimina(int matricola)
        {
            candidati.RemoveAt(matricola);
        }
        public string[] visualizzaidonei()
        {
            int x = candidati.Count;
            string[] c = new string[x];
            int cont = 0;
            foreach (VerzM_Candidato candidato in candidati)
            {
                if (candidato.isIdoneo() == true)
                {
                    c[cont] = candidato.ToString();
                }
                cont++;
            }
            return c;
        }
        public void ordinadecrscente()
        { 
            candidati.Sort();
            candidati.Reverse(); 
        }
    }
}
