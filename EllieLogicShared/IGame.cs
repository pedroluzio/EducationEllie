using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EllieLogicShared
{
    public interface IGame
    {
        void inicializar();        
        void fazerJogada(object valor1, object valor2);
        Placar.RESULTADO_JOGADA validarJogada(object valor1, object valor2);
        void calcularResultadoFinal();
        void encerrar();
        
    }
}
