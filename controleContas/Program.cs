namespace controleContas
{
    class Program
    {
        public static void Main()
        {
            Conta conta1 = new(2323, 100.5m);
            Console.WriteLine(conta1.saldo);
            Console.Read();
        }
    }
}