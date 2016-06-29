using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EllieLogicShared
{
    public class GameControl : IGame
    {
        String nome_jogo;
        Int32 erros, acertos;
        Boolean _sound;

        public GameControl()
        {
            inicializar();
        }

        public void inicializar()
        {
            this.nome_jogo = "";
            this.erros = 0;
            this.acertos = 0;
            this._sound = true;
        }


        public void encerrar()
        {
            throw new NotImplementedException();
        }

        public void exibirdesign()
        {
            throw new NotImplementedException();
        }

        public void fazerJogada()
        {
            throw new NotImplementedException();
        }

        

        public void validarJogada()
        {
            if (true)
            {
                if (_sound)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(EllieLogicShared.Properties.Resources.som_erro);
                    player.Play();
                    Thread.Sleep(2000);
                }
            }
            else {
                if (_sound)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(EllieLogicShared.Properties.Resources.som_acerto);
                    player.Play();
                    Thread.Sleep(2000);
                }
            }
        }

        public void calcularResultado()
        {
            throw new NotImplementedException();
        }
    }
}
