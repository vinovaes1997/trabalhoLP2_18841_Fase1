/*
    Autor: Victor Abreu.
    Funcionalidade: Gestão de Pessoas Infetadas.
    Classe: Hospital.
    Data: 25/04/2020.
    Versão: 1.0 .
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfectionManager
{
    class Hospital
    {
        #region Atributos Hospital

        const int MAX = 100;
        static int totalUtentes = 0;
        Utentes[] utenteInfc;

        #endregion

        #region Construtor Classe

        public Hospital()
        {
            utenteInfc = new Utentes[MAX];
        }

        #endregion

        #region Metodos Hospital

        public void InsereUtentes(Utentes utenteEx)
        {
            if(totalUtentes < MAX)
            {
                utenteInfc[totalUtentes] = utenteEx;
                totalUtentes++;
                utenteEx.Id = totalUtentes;
            }
        }
        
        public void ExibirFichaUtente()
        {
            Console.WriteLine(".......FICHAS DE UTENTE.......\n");

            for (int i = 0; i <totalUtentes; i++)
            {
                Console.WriteLine("Nome Utente:.................. " + utenteInfc[i].Nome);
                Console.WriteLine("ID de Utente:................. " + utenteInfc[i].Id);
                Console.WriteLine("Região de Residência:......... " + utenteInfc[i].Regiao);
                Console.WriteLine("Sexo:......................... " + utenteInfc[i].Sexo);
                Console.WriteLine("Idade:........................ " + utenteInfc[i].Idade);
                Console.WriteLine("Infetado(true)|Curado(false).. " + utenteInfc[i].Infection);
                Console.WriteLine("Tipo de Infeção............... " + utenteInfc[i].TypeInfection + "\n");
            }
            Console.WriteLine("Total de Utentes:............. " + totalUtentes);
        }

        public void ExibirFichaRegiao(string regiaoEx)
        {
            int totalRegion = 0;

            for(int i = 0; i<totalUtentes; i++)
            {
                if(String.Compare(regiaoEx, utenteInfc[i].Regiao) == 0)
                {
                    totalRegion++;

                    Console.WriteLine("Nome Utente:.................. " + utenteInfc[i].Nome);
                    Console.WriteLine("ID de Utente:................. " + utenteInfc[i].Id);
                    Console.WriteLine("Região de Residência:......... " + utenteInfc[i].Regiao);
                    Console.WriteLine("Sexo:......................... " + utenteInfc[i].Sexo);
                    Console.WriteLine("Idade:........................ " + utenteInfc[i].Idade);
                    Console.WriteLine("Infetado(true)|Curado(false).. " + utenteInfc[i].Infection);
                    Console.WriteLine("Tipo de Infeção............... " + utenteInfc[i].TypeInfection + "\n");
                    Console.WriteLine("Total de Infetados na Região:. " + totalRegion + "\n");
                }
            }
            
        }

        public void ExibirFichaSexo(string sexoEx)
        {
            int totalInfcSex = 0;

            for (int i = 0; i < totalUtentes; i++)
            {
                if (String.Compare(sexoEx, utenteInfc[i].Sexo) == 0)
                {
                    totalInfcSex++;

                    Console.WriteLine("Nome Utente:.................. " + utenteInfc[i].Nome);
                    Console.WriteLine("ID de Utente:................. " + utenteInfc[i].Id);
                    Console.WriteLine("Região de Residência:......... " + utenteInfc[i].Regiao);
                    Console.WriteLine("Sexo:......................... " + utenteInfc[i].Sexo);
                    Console.WriteLine("Idade:........................ " + utenteInfc[i].Idade);
                    Console.WriteLine("Infetado(true)|Curado(false).. " + utenteInfc[i].Infection);
                    Console.WriteLine("Tipo de Infeção............... " + utenteInfc[i].TypeInfection + "\n");
                }
            }
            Console.WriteLine("Total de Infetados sexo " + sexoEx +": "+ totalInfcSex + "\n");
        }
        public void ExibirFichaIdade(int idadeEx)
        {
            int totalInfcIdade = 0;

            for (int i = 0; i < totalUtentes; i++)
            {
                if (idadeEx == utenteInfc[i].Idade)
                {
                    totalInfcIdade++;

                    Console.WriteLine("Nome Utente:.................. " + utenteInfc[i].Nome);
                    Console.WriteLine("ID de Utente:................. " + utenteInfc[i].Id);
                    Console.WriteLine("Região de Residência:......... " + utenteInfc[i].Regiao);
                    Console.WriteLine("Sexo:......................... " + utenteInfc[i].Sexo);
                    Console.WriteLine("Idade:........................ " + utenteInfc[i].Idade);
                    Console.WriteLine("Infetado(true)|Curado(false).. " + utenteInfc[i].Infection);
                    Console.WriteLine("Tipo de Infeção............... " + utenteInfc[i].TypeInfection + "\n");
                }
            }
            Console.WriteLine("Total de Infetados com " + idadeEx + " anos: " + totalInfcIdade + "\n");
        }
        public void ExibirFichaCasos(string casoEx)
        {
            int totalCasosEx = 0;

            for (int i = 0; i < totalUtentes; i++)
            {
                if (String.Compare(casoEx, utenteInfc[i].TypeInfection) == 0)
                {
                    totalCasosEx++;

                    Console.WriteLine("Nome Utente:.................. " + utenteInfc[i].Nome);
                    Console.WriteLine("ID de Utente:................. " + utenteInfc[i].Id);
                    Console.WriteLine("Região de Residência:......... " + utenteInfc[i].Regiao);
                    Console.WriteLine("Sexo:......................... " + utenteInfc[i].Sexo);
                    Console.WriteLine("Idade:........................ " + utenteInfc[i].Idade);
                    Console.WriteLine("Infetado(true)|Curado(false).. " + utenteInfc[i].Infection);
                    Console.WriteLine("Tipo de Infeção............... " + utenteInfc[i].TypeInfection + "\n");
                }
            }
            Console.WriteLine("Total de Infetados com " + casoEx + ": " + totalCasosEx + "\n");
        }
        #endregion
    }
}
