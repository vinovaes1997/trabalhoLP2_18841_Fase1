/*
    Autor: Victor Abreu.
    Funcionalidade: Gestão de Pessoas Infetadas.
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
    // Classe programa Main
    class Program
    {
        static void Main(string[] args)
        {
            // Variáveis auxiliares Main
            string region, sexEx1, casoEx1;
            int idade1;

            // Criação de novos Utentes com atributos de Pessoas
            Utentes u1 = new Utentes("Vlad", "Covid-19", "Minho", "Masculino", 19);
            Utentes u2 = new Utentes("Diogo", "Influenza-H1N1", "Porto", "Masculino", 21);
            Utentes u3 = new Utentes("Joana", "Gripe-H3N2", "Porto", "Feminino", 21);
            Utentes u4 = new Utentes("Rita", "Covid-19", "Minho", "Feminino", 19);
            Utentes u5 = new Utentes("Carlos", "Influeza-H1N1", "Porto", "Masculino", 21);

            // Criação de Hospital
            Hospital h = new Hospital();

            // Inserção de Utentes no hospital "h"
            h.InsereUtentes(u1);
            h.InsereUtentes(u2);
            h.InsereUtentes(u3);
            h.InsereUtentes(u4);
            h.InsereUtentes(u5);

            // Exibição de todas as fichas de utentes
            h.ExibirFichaUtente();

            // Consulta pelo utlizador de casos por Região
            Console.Write("Insira a região que deseja consultar : ");
            region = Console.ReadLine();

            Console.Clear();

            // Exbição de fichas de utentes da Região escolhida pelo utilizador
            h.ExibirFichaRegiao(region);

            //Consulta pelo utilizador de casos por sexo
            Console.Write("Insira o sexo que deseja consultar : ");
            sexEx1 = Console.ReadLine();

            Console.Clear();

            // Exibição de ficha de utentes do sexo escolhido pelo utilizador
            h.ExibirFichaSexo(sexEx1);

            //Consulta pelo utilizador de casos por idade
            Console.Write("Insira a idade que deseja consultar : ");
            idade1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            //Exibição de ficha de utentes por idade escolhida pelo utilizador
            h.ExibirFichaIdade(idade1);

            // Consulta de ficha de utentes por caso escolhido pelo utilizador
            Console.Write("Insira o Tipo de Infeção que deseja consultar : ");
            casoEx1 = Console.ReadLine();

            Console.Clear();

            // Exibição de ficha de utentes por caso escolhido pelo utilizador
            h.ExibirFichaCasos(casoEx1);
        }
    }
}
