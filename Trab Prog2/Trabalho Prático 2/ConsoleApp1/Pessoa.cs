/*
    Autor: Victor Abreu.
    Funcionalidade: Gestão de Pessoas Infetadas.
    Classe: Pessoas.
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
    // Classe pai de pessoas
    public class Pessoa
    {
        #region Atributos Pessoa

        string nome;
        int id;
        string regiao;
        string sexo;
        int idade;

        #endregion

        #region Construtor de Classe

        public Pessoa(string nome, string regiao, string sexo, int idade)
        {
            this.nome = nome;
            this.regiao = regiao;
            this.sexo = sexo;
            this.idade = idade;
        }

        #endregion

        #region Propriedades Pessoa

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Regiao
        {
            get { return regiao; }
            set { regiao = value; }
        }
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        #endregion
    }
}
