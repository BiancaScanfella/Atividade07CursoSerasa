
		double dinheiro;
		string cafes;
		double expresso = 3.00;
		double cappu = 4.50;
		double moca = 6.00;
		double aguaquente = 1.00;
		double valor;
		
		Console.WriteLine("Insira o dinheiro!:");
		dinheiro = double.Parse(Console.ReadLine());
		if (expresso == 3.00 || cappu == 4.50 || moca == 6.00 || aguaquente == 1.00 ) 
		{
			Console.WriteLine("O valor inserido é invalido!");
	
		}
		Console.WriteLine("Escolha o café:");
		cafes = Console.ReadLine();
		valor = double.Parse(Console.ReadLine());
		if ( valor == expresso || valor == cappu || valor == moca || valor == aguaquente) 
		{
			Console.WriteLine("Valor insuficiente");
		}
		Console.WriteLine("Seu café está pronto!");
		
		return;
