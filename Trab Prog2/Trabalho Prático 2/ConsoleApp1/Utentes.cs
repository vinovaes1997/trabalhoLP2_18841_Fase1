/*
    Autor: Victor Abreu.
    Funcionalidade: Gestão de Pessoas Infetadas.
    Classe: Utentes (Classe filho herdada de Classe: "Pessoas".)
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
    class Utentes : Pessoa
    {
        #region Atributos de classe

        bool infection;
        string typeInfection;

        #endregion

        #region Construtor de classe

        public Utentes(string nome, string typeInfection, string regiao, string sexo, int idade) : base(nome, regiao, sexo, idade)
        {
            this.infection = true;
            this.typeInfection = typeInfection;
        }

        #endregion

        #region Propriedades

        public bool Infection
        {
            get { return infection; }
            set { infection = value; }
        }

        public string TypeInfection
        {
            get { return typeInfection; }
            set { typeInfection = value; }
        }
        #endregion
    }
}
