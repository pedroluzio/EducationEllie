﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EllieLogicShared
{
    public partial class Placar : UserControl
    {
        Int32 _erros;
        Int32 _acertos;
        Int32 _jogadas;

        public Placar()
        {
            InitializeComponent();
            this._erros = 0;
            this._acertos = 0;
            this._jogadas = 0;
        }

        public void atualizarPlacar(RESULTADO_JOGADA resultado)
        {
            if(resultado == RESULTADO_JOGADA.ACERTO)
            {
                this._acertos++;
            }
            else if(resultado == RESULTADO_JOGADA.ERRO)
            {
                this._erros++;
            }

            this._jogadas++;

            lblCertas.Text = _acertos.ToString();
            lblErradas.Text = _erros.ToString();
            lblTotalJogadas.Text = _jogadas.ToString();
        }

        public enum RESULTADO_JOGADA
        {
            ACERTO,
            ERRO
        }
    }
}
