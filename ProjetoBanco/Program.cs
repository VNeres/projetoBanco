using System;



namespace ProjetoBanco
{
    internal class Program
    {
        private static readonly Banco banco = new Banco();
        private static readonly Conta contaDestino;

        static Program()
        {
            var cidade = new Cidade("Jundiaí", "SP");
            var endereco = new Endereco("Rua Gen. Osório", "Centro", "13219-000", 100, cidade);
            var cliente = new Cliente("Vanderlei Neres da Silva", "123456789-00", new DateTime(1994, 09, 17), endereco);

            contaDestino = banco.AbrirConta(cliente);
        }
        private static void Main(string[] args)
        {
            try
            {
                var cidade = new Cidade("Jundiai", "SP");
                var endereco = new Endereco("Rua esquina", "Bairro qualquer", "13221-400", 123, cidade);
                var cliente = new Cliente("Vandão", "123456987-11", new DateTime(1994, 09, 17), endereco);
                
                var contaVandao = banco.AbrirConta(cliente);

                contaVandao.Depositar(2500);

                contaVandao.Sacar(350);

                contaVandao.TirarExtrato();

                contaVandao.Transferir(1, 1, 1200);

                contaVandao.TirarExtrato();

                contaDestino.TirarExtrato();


            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
            }
            Console.ResetColor();
            Console.WriteLine(string.Empty);
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
