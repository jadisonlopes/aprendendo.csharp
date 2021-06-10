using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleOrientacaoAhObjetos
{
    class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        private int _agencia;
        private int _numero;
        private double _saldo = 100;
        public Cliente Titular { get; set; }
        public int Agencia {
            get
            {
                return this._agencia;
            }
            set
            {
                if (value > 0)
                {
                    this._agencia = value;
                }
            }
        }
        public int Numero {
            get
            {
                return this._numero;
            }
            set
            {
                if (value > 0)
                {
                    this._numero = value;
                }
            }
        }
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

        public ContaCorrente(Cliente titular, int agencia, int numero) {
            this.Titular = titular;
            this._agencia = agencia;
            this._numero = numero;
            TotalDeContasCriadas++;
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
