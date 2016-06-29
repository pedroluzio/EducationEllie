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
        void exibirdesign();
        void fazerJogada();
        void validarJogada();
        void calcularResultado();
        void encerrar();
        
    }
}
