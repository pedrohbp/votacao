using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votacao
{
    class ClasseUtil
    {
        string[] votos = new string[208];

        public int resultadochapa1()
        {
            int qtdVotochapa1 = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] == "Chapa 1")
                {
                    qtdVotochapa1++;
                }
                if (votos[i] == "Procuração Chapa 1")
                {
                    qtdVotochapa1++;
                }
            }
            return (qtdVotochapa1);

        }
        public int resultadochapa2()
        {
            int qtdVotochapa2 = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] == "Chapa 2")
                {
                    qtdVotochapa2++;
                }
                if (votos[i] == "Procuração Chapa 2")
                {
                    qtdVotochapa2++;
                }
            }
            return (qtdVotochapa2);
        }
        public int resultadoinadimplentes()
        {
            int qtdinadimplentes = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] == "Inadimplente")
                {
                    qtdinadimplentes++;
                }
            }
            return (qtdinadimplentes);
        }

        public int resultadofaltosos()
        {
            int qtdfaltosos = 0;
            for (int i = 0; i < votos.Length; i++)
            {
                if (votos[i] == "Faltoso")
                {
                    qtdfaltosos++;
                }
            }
            return (qtdfaltosos);
        }
        public bool valorcmd(string refvalorcmd)
        {
            bool retorno = true;
            try
            {
                votos[0] = refvalorcmd;
                Form2 instanciaDoForm22 = new Form2();
                Form1 instanciaDoForm11 = new Form1();
                instanciaDoForm11.Show();
                string varresultadochapa1 = resultadochapa1().ToString();
                string varresultadochapa2 = resultadochapa2().ToString();
                instanciaDoForm22.labelchapa11.Text = varresultadochapa1;
                instanciaDoForm22.labelchapa22.Text = varresultadochapa2;
                instanciaDoForm11.labelchapa111.Text = varresultadochapa1;
                instanciaDoForm11.labelchapa222.Text = varresultadochapa2;
                instanciaDoForm11.labelfaltosos.Text = resultadofaltosos().ToString();
                instanciaDoForm11.labelinadimplentes.Text = resultadoinadimplentes().ToString();
            }
            catch
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
