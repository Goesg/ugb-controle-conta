using System;

namespace controleContas;

public class Conta
{
    private int numero;
    public decimal saldo {get;}

    public Conta(int numero, decimal saldo)
    {
        this.numero = numero;
        this.saldo = saldo;
    }

    
}   
