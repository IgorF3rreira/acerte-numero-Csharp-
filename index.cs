 //JOGO ACERTAR O NÚMERO

        Random random = new Random();
        int num;
        int usuario = 0;
        int comp = 0;
        int tent;
        string nome;

        Console.WriteLine("Digite seu nome de usuario: ");
        nome= Console.ReadLine(); 

        for (int i = 0; i < 5; i++)
        {

            Console.WriteLine("    PLACAR     ");
            Console.WriteLine( nome+" " + (usuario)+ "X" +(comp)+ " computador");
            Console.WriteLine("");
            

            num = random.Next(1, 11);
            Console.Write("tente acertar o número: ");
            tent = Convert.ToInt32(Console.ReadLine());

            

            if (tent == num) 
            {
                Console.WriteLine("você ACERTOU!!!");
                usuario =usuario + 1;
            }
            else
            {
                Console.WriteLine("você ERRO!!!!");
                comp= comp + 1;
            }
        }
        Console.Clear();

        if (usuario > comp)
        {
            Console.WriteLine("PLACAR");
            Console.WriteLine(nome + " " + (usuario) + "X" + (comp) + " computador");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("VOCê FOI O CAMPEÃO");
        }
        else
        {
            Console.WriteLine("PLACAR");
            Console.WriteLine(nome + " " + (usuario) + "X" + (comp) + " computador");
            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("O COMPUTADOR FOI O CAMPEÃO");
        }