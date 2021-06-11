using System;

namespace AppSigno 
{
	class Program 
	{
		static void Main(string[] args) 
		{
			Signo signo = new Signo();
			Interpretador interpretador = new Interpretador();

			Console.Write("Em que dia você nasceu: ");
			int dia = int.Parse(Console.ReadLine());
			Console.Write("Em que mês você nasceu: ");
			int mes = int.Parse(Console.ReadLine());

			signo = interpretador.Interpretar(dia, mes);

			Console.Clear();

			Console.WriteLine("O seu signo é: " + signo.nome);
			Console.WriteLine("Caracteristicas: " + signo.caracteristicas);
		}
	}
}
