<<<<<<< HEAD
﻿using System;
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
        public Boolean EfeitoSonoroHabilitado {
        get { return this._sound; }
            set { this._sound = value; }
        }

        Placar _placar;
        int _jogadas;
        int _jogadas_permitidas;
        public EventHandler clickJogada;

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
            this._jogadas = 0;
            this._jogadas_permitidas = 50;

        }
        /// <summary>
        /// Inicializa a jogada, configurando o componente de placar do jogo
        /// </summary>
        /// <param name="placar"></param>
        public void inicializar(Placar placar)
        {
            this.nome_jogo = "";
            this.erros = 0;
            this.acertos = 0;
            this._sound = true;
            this._placar = placar != null ? placar:new Placar();
            this._jogadas_permitidas = 50;
         
        }

        public void configurarPlacar(Placar placar)
        {
            this._placar = placar != null ? placar : new Placar();
        }

        public void encerrar()
        {

            // TODO: Tocar som de encerramento


            calcularResultadoFinal();

            // TODO: Salvar no banco de dados
        }

        public void fazerJogada(object valor1, object valor2)
        {

            if (_jogadas < this._jogadas_permitidas)
            {
                this.validarJogada(valor1,valor2);
                this._jogadas++;
            }
            
        }

        public Placar.RESULTADO_JOGADA validarJogada(object valor1, object valor2)
        {

            if (valor1 == valor2)
            {
                if (_sound)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(EllieLogicShared.Properties.Resources.som_acerto);
                    player.Play();
                    Thread.Sleep(2000);
                }

                _placar.atualizarPlacar(Placar.RESULTADO_JOGADA.ACERTO);
                return Placar.RESULTADO_JOGADA.ACERTO;
            }
            else
            {
                if (_sound)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(EllieLogicShared.Properties.Resources.som_erro);
                    player.Play();
                    Thread.Sleep(2000);                  
                }

                _placar.atualizarPlacar(Placar.RESULTADO_JOGADA.ERRO);
                return Placar.RESULTADO_JOGADA.ERRO;
            }           
            
        }

        public void calcularResultadoFinal()
        {
            //
        }

        public int obterQuantidadeJogadasRealizadas()
        {
            return this._jogadas;
        }


        public int obterQuantidadeJogadasRestantes()
        {
            return this._jogadas_permitidas- this._jogadas;
        }



    }
}
=======
﻿using System;
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
        public Boolean EfeitoSonoroHabilitado {
        get { return this._sound; }
            set { this._sound = value; }
        }

        Placar _placar;
        int _jogadas;
        int _jogadas_permitidas;
        public EventHandler clickJogada;

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
            this._jogadas = 0;
            this._jogadas_permitidas = 5;
            
        }
        /// <summary>
        /// Inicializa a jogada, configurando o componente de placar do jogo
        /// </summary>
        /// <param name="placar"></param>
        public void inicializar(Placar placar)
        {
            this.nome_jogo = "";
            this.erros = 0;
            this.acertos = 0;
            this._sound = true;
            this._placar = placar != null ? placar:new Placar();
            this._jogadas_permitidas = 5;
         
        }

        public void configurarPlacar(Placar placar)
        {
            this._placar = placar != null ? placar : new Placar();
        }

        public void encerrar()
        {

            // TODO: Tocar som de encerramento


            calcularResultadoFinal();

            // TODO: Salvar no banco de dados
        }

        public void fazerJogada(object valor1, object valor2)
        {

            if (_jogadas < this._jogadas_permitidas)
            {
                this.validarJogada(valor1,valor2);
                this._jogadas++;
            }
            
        }

        public Placar.RESULTADO_JOGADA validarJogada(object valor1, object valor2)
        {

            if (valor1 == valor2)
            {
                if (_sound)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(EllieLogicShared.Properties.Resources.som_acerto);
                    player.Play();
                    Thread.Sleep(2000);
                }

                _placar.atualizarPlacar(Placar.RESULTADO_JOGADA.ACERTO);
                return Placar.RESULTADO_JOGADA.ACERTO;
            }
            else
            {
                if (_sound)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(EllieLogicShared.Properties.Resources.som_erro);
                    player.Play();
                    Thread.Sleep(2000);                  
                }

                _placar.atualizarPlacar(Placar.RESULTADO_JOGADA.ERRO);
                return Placar.RESULTADO_JOGADA.ERRO;
            }           
            
        }

        public void calcularResultadoFinal()
        {
            //
        }

        public int obterQuantidadeJogadasRealizadas()
        {
            return this._jogadas;
        }


        public int obterQuantidadeJogadasRestantes()
        {
            return this._jogadas_permitidas- this._jogadas;
        }



    }
}
>>>>>>> refs/remotes/origin/master
