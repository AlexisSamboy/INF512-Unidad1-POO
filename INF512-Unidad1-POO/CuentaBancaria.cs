class CuentaBancaria
{
    private string NombreTitular;
    private int NumeroCuenta;
    private decimal saldo;

    public CuentaBancaria(string nombreTitular, int numeroCuenta)
    {
        this.NombreTitular = nombreTitular;
        this.NumeroCuenta = numeroCuenta;
        this.saldo = 0;
    }

    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            saldo += monto;
            Console.WriteLine($"Depósito exitoso. \n Nuevo saldo: {saldo:F2}");
        }
        else
        {
            Console.WriteLine("El monto a depositar debe ser mayor que cero.");
        }
    }

    public void Retirar(decimal monto)
    {
        if (monto > 0 && monto <= saldo)
        {
            saldo -= monto;
            Console.WriteLine($"Retiro exitoso. \n  Nuevo saldo: {saldo:F2}");
        }
        else
        {
            Console.WriteLine("Monto de retiro inválido o saldo insuficiente.");
        }
    }

    public void MostrarSaldo()
    {
        Console.WriteLine($"Número de cuenta: {NumeroCuenta}, Saldo: {saldo:F2}");
    }
}