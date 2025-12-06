Dictionary<String, List<int>> Alunosinfo = new Dictionary<String, List<int>>();// Criar lista de dicionário com valores e também com chaves
Alunosinfo.Add("Davy", new List<int> { 10, 9, 8 });// Relacionando um item a lista
Alunosinfo.Add("Luana", new List<int> { 11, 9, 9 });

Console.WriteLine("Para continuar digite qualquer coisa");
Console.ReadLine();
tela1();




void tela1() // screen1 of welcome 
{
    Console.Clear();
    Console.WriteLine("Olá seja bem vindo, Mrs.Teacher!!\n");
    Console.Write("- Pressione qualquer tecla para prosseguir -\n");
    Console.ReadLine();
    Console.Clear();
    ExibirMenu();
    
}
void dadosalunos()
{
    Console.WriteLine("Qual aluno você deseja ver a nota ?");
    string nome = Console.ReadLine()!;
    Console.Clear();
    double notamedia = Alunosinfo[$"{nome}"].Average();// O formator de busca que foi usado aqui é o do LINQ, que já vem integrada ao sistema
    Console.WriteLine($"A nota de Davy é {notamedia}");
}

void veralunos()
{
    foreach( var item in Alunosinfo )
    {
        Console.WriteLine(item.Key);
    }
}

void vernotas()
{
    foreach (var item in Alunosinfo)
    {
        string notas = string.Join(",",item.Value);
        Console.WriteLine($"{item.Key}: {notas}");
    }
}


void ExibirMenu() 
{

    Console.WriteLine("1.Mostrar Notas dos Alunos");
    Console.WriteLine("2.Ver alunos");
    Console.WriteLine("3.Ver notas");

    string opçãoescolhida = Console.ReadLine()!;// Isso coleta o que a pessoa escreveu
    int opçãonumerica = int.Parse(opçãoescolhida); // Isso converte o que a pessoa digitou para um número inteiro para a condição Switch/Case entender isso na língua dela
    Console.Clear();

    switch(opçãonumerica)
    {
        case 1: dadosalunos();
            Console.WriteLine();
            break;

        case 2: veralunos();
            Console.WriteLine();
            break;

        case 3:vernotas();
            Console.WriteLine();
            break;
    }


}