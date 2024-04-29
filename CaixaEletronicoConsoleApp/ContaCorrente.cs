using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoConsoleApp
{
    public class CCorrente
    {
        public string numero;
        public double limite;
        public bool status;
        public bool especial;
        public double saldo;
        public List<Transacao> transacoes;

        //Construtores
        public CCorrente(string numero, double limite) : this()
        {
            this.numero = numero;
            this.limite = limite;
        }
        public CCorrente()
        {
            this.saldo = 0.0;
            this.status = true;
            transacoes = new List<Transacao>();
        }

        public bool Depositar(double valor)
        {
            transacoes.Add(new Transacao(valor, 'D'));
            if (valor > 0)
            {
                saldo += valor;
                return true;
            }
            return false;
        }

        public bool Sacar(double valor)
        {
            transacoes.Add(new Transacao(valor, 'S'));
            if (saldo - valor > -limite)
            {
                saldo -= valor;
                return true;
            }
                return false;
        }

        public bool Transferir(CCorrente destino, double valor)
        {
            if(destino.status && Sacar(valor) && destino.Depositar(valor)) {
                transacoes[transacoes.Count - 1].duplicata = destino.transacoes[destino.transacoes.Count - 1];
                destino.transacoes[destino.transacoes.Count-1].duplicata = transacoes[transacoes.Count-1];
                return true;
            }
            return false;
        }
    }
}

