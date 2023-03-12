using static System.Console;

class Aula2
{
    static void Demo2()
    {
          var nomes = new string[]{"João","Paula","Renata","Lucas","Geovana","Pedro"};
         WriteLine($@"A lista com os nomes é:
        {string.Join(", \n", nomes)}
        ");


        WriteLine("Digite o nome que você deseja trocar");
        var nome = ReadLine();
        WriteLine("Digite o nome novo");
        var nomeNovo = ReadLine();


        AlterarNome(nomes, nome, nomeNovo);
        
        WriteLine($@"A lista com o nome alterado é:
        {string.Join(", \n", nomes)}");
    }
    static void Demo1()
    {
         int a = 5;
        Adicionar20(ref a);        
        WriteLine($"O valor de a é {a}"!);
    }
    static void Adicionar20(ref int a)
    {
        a +=20;
    }
    static void AlterarNome(string[] nomes, string nome, string nomeNovo)
    {
        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            {
                nomes[i] = nomeNovo;
            }
        }
    }

    static ref string LocalizarNome(string[] nomes, string nome)
    {
        for(int i = 0; i < nomes.Length; i++)
        {
            if(nomes[i] == nome)
            return ref nomes[i];
        }
        throw new Exception("Nome não encontrado");
    }
    static void Main()
    {
        var nomes = new string[]{"João","Paula","Renata","Lucas","Geovana","Pedro"};
         WriteLine($@"A lista com os nomes é:
        {string.Join(", \n", nomes)}
        ");


        WriteLine("Digite o nome que você deseja trocar");
        var nome = ReadLine();
        WriteLine("Digite o nome novo");
        var nomeNovo = ReadLine();

        ref var nomeAchado = ref LocalizarNome(nomes, nome);
        if(! string.IsNullOrWhiteSpace(nomeAchado))
        {
            nomeAchado = nomeNovo;

        WriteLine($@"A lista com o nome alterado é:
            {string.Join(", \n", nomes)}
        ");
        }

        else
        {
            WriteLine("Nome não encontrado;");
        }
    }

}
