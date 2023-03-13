using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosFaculdade.Exercicios
{
    internal abstract class Exercicio
    {
        abstract public string GetDescricao();
        
        abstract public void Executar();
    }
}
