class CuentaBancaria
{
    public string Titular
    {
        get;
        set => field = value?.Trim() ?? "";
    } = "";

    public decimal Saldo { get; private set; }

    public void Depositar(decimal monto)
    {
        if (monto <= 0)
            throw new ArgumentException("El monto debe ser positivo");
        Saldo += monto;
    }

    public bool Retirar(decimal monto)
    {
        if (monto <= 0 || monto > Saldo) return false;
        Saldo -= monto;
        return true;
    }
}