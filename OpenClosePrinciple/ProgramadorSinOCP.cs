using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpenClosePrinciple
{
    public class ProgramadorSinOCP
    {
        private const int DiasTrabajados = 15;
        private const decimal SueldoNovel = 300;
        private const decimal SueldoJr = 400;
        private const decimal SueldoSr = 550;

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public TipoProgramador Tipo { get; set; }
        public decimal CalcularPago()
        {
            switch(Tipo){
                case  TipoProgramador.Novel:
                    return (DiasTrabajados * SueldoNovel) * 1.10M;  
                case TipoProgramador.Jr:
                    return (DiasTrabajados * SueldoJr) * 1.15M;
                case TipoProgramador.Sr:
                    return (DiasTrabajados * SueldoSr) * 1.25M;
                default:
                    throw new Exception("El programador no pertenece a una categoria");
            }
        }
    }
    public enum TipoProgramador
    {
        Novel=1,
        Jr = 2,
        Sr = 3
    }
}
