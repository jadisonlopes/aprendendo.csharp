﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrientacaoAhObjetos
{
    class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int agencia;
        public int numero;
        private double _saldo = 100;

        public double Saldo {
            get {
                return this._saldo;
            }
            set {
                if (value > 0)
                {
                    this._saldo = value;
                }
            }
        }

        public bool Sacar(double valor) {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            return true;
        }

        public void Depositar(double valor) {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino) {
            if (this._saldo < valor)
            {
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
