using System;

// Como o Objeto02 está em um outro projeto é importantíssimo você informar isto para o programa
// Pior que só informar não adianta acredita ? Você precisa também clicar com o botão esquerdo do mouse sobre o projeto
// Objeto01, selecionar a opção "Add", e então "Reference", confirme se na tela está escolhido a opção "Solution"
// e então marque a opção do projeto "Objeto02", é assim que 2 projetos se conversam !
using Objeto02;

namespace Objeto01
{
    public class Program
    {
        static void Cabecalho()
        {
            // É assim que escrevemos um texto e já pulamos de linha ! :)
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------Scania Mesas e Cadeiras LTDA-----------------------------------------------------");
            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            // Estou pulando uma linha para não deixar o programa grudado no cabeçalho :)
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            // Vamos criar um sistema para trabalhar com novos objetos de uma Mesa e de uma Cadeira

            // Aqui temos um método olha só ! Sempre que eu quiser trazer o cabeçalho eu chamo ele desta forma
            Cabecalho();

            // Assim que pulamos 1 linha pra deixar mais bonitinho na tela
            Console.WriteLine();

            Console.WriteLine("Vamos criar uma instância de uma mesa e cadeira novas baseadas nas classes Mesa e Cadeira ?");
            Console.WriteLine();

            // Assim você escreve um texto sem pular linha !
            Console.Write("Pressione alguma tecla para prosseguir...");

            // Quando você quiser que a aplicação espere para o usuário pressionar alguma tecla, o comando abaixo pode te ajudar !
            Console.ReadKey();

            // Aqui estou pulando 2 linhas. Será que você consegue me dizer o por que estou fazendo isto ?
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Baseado nas minhas classes Mesa e Cadeira vou criar instâncias destes dois objetos assim que você pressionar alguma tecla...");

            Console.ReadKey();

            // Agora vou criar instâncias novas de uma mesa e cadeira só pra mim :)
            Mesa minhaMesa = new Mesa();
            Cadeira minhaCadeira = new Cadeira();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Mesa e cadeira criadas com sucesso !");
            Console.WriteLine();

            // Uma vez que eu tenho uma mesa e uma cadeira novas através das variáveis minhaMesa e minhaCadeira
            // vamos mostrar em tela a cor inicial destes novos objetos ?
            // Ah... um detalhe importante: o sinal + concatena textos... como a propriedade Cor é do tipo texto está tudo certo !
            // Você pode colocar quantos + você quiser para concatenar mais textos
            Console.WriteLine("O tamanho padrão de uma mesa nova é " + minhaMesa.Cor);
            Console.WriteLine();
            Console.WriteLine("O tamanho padrão de uma cadeira nova é " + minhaCadeira.Cor);
            Console.WriteLine();

            Console.Write("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Cabecalho();

            Console.Write("Vou alterar dentro do código a cor da mesa para Prata e da cadeira para Roxo assim que você pressionar alguma tecla...");
            Console.ReadKey();

            // Agora vou cumprir com o prometido acima
            minhaMesa.Cor = "Prata";
            minhaCadeira.Cor = "Roxo";

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Conforme prometido a nova cor da mesa é: " + minhaMesa.Cor);
            Console.WriteLine();
            Console.WriteLine("Conforme prometido a nova cor da cadeira é: " + minhaCadeira.Cor);
            Console.WriteLine();

            Console.Write("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Cabecalho();

            // Agora vou pedir ao usuário que personalize sua mesa e sua cadeira
            Console.Write("Querido usuário por favor informe uma nova cor que você quer para a sua mesa: ");

            // Esta é uma forma bem simples de você pedir ao usuário para colocar uma cor nova nesta mesa
            minhaMesa.Cor = Console.ReadLine();

            Console.WriteLine();
            Console.Write("Querido usuário por favor informe  também uma nova cor que você quer para a sua cadeira: ");

            // Esta é uma forma de você pedir ao usuário para colocar uma cor nova nesta cadeira usando uma variável !
            string vCorMinhaCadeira;
            vCorMinhaCadeira = Console.ReadLine();
            // Não esqueça de colocar a cor da variável na sua cadeira né ?
            minhaCadeira.Cor = vCorMinhaCadeira;

            Console.WriteLine();
            Console.WriteLine("A nova cor que você escolheu para a sua mesa é: " + minhaMesa.Cor);
            Console.WriteLine();
            Console.WriteLine("A nova cor que você escolheu para a sua cadeira é: " + minhaCadeira.Cor);
            Console.WriteLine();

            Console.Write("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Cabecalho();

            Console.WriteLine("TÓPICO AVANÇADO AGORA - CONVERSÃO DE VALORES");
            Console.WriteLine();

            // Perceba que estou exibindo normalmente o tamanho de uma cadeira que é do tipo int
            Console.WriteLine("O tamanho inicial da minha cadeira é: " + minhaCadeira.Tamanho);
            Console.WriteLine();
            Console.Write("Informe um novo tamanho para a sua cadeira: ");
            // Olha o que eu tive que fazer aqui, se eu não transformo o texto digitado pelo usuário para inteiro, a propriedade do meu objeto
            // quebra... isto vale para outros tipos tb ! Claro que para DateTime tem mais algumas historinhas né...
            minhaCadeira.Tamanho = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("O tamanho que você escolheu para a sua cadeira é: " + minhaCadeira.Tamanho);
            Console.WriteLine();
            Console.Write("Pressione alguma tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Por que você não tenta criar um fogão agora com temperatura e descrição de seu funcionamento em um projeto de nome Objeto03 ?");

            Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------E por hoje é só PESSOAL----------------------------------------------------------------");
            Console.Write("-----------------------------------------------------------------------------------------------------------------------");

            Console.ReadKey();
        }
    }
}