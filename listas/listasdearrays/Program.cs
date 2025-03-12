using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace listasdearrays
{
    internal class Program
    {


        static void Main(string[] args)
        {

            // Lista para armazenar os alunos cadastrados
            List<CadastroAlunos> alunos = new List<CadastroAlunos>();

            while (true)
            {
                // Coletar dados do aluno
                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine();

                Console.Write("Digite a matrícula do aluno: ");
                int matricula;
                while (!int.TryParse(Console.ReadLine(), out matricula))
                {
                    Console.WriteLine("Matrícula inválida. Por favor, digite um número.");
                    Console.Write("Digite a matrícula do aluno: ");
                }

                Console.Write("Digite a série do aluno: ");
                string série = Console.ReadLine();

                Console.Write("Digite o gênero do aluno: ");
                string gênero = Console.ReadLine();

                // Criar objeto aluno e adicionar à lista
                CadastroAlunos aluno = new CadastroAlunos(nome, matricula, série, gênero);
                alunos.Add(aluno);

                // Perguntar se deseja cadastrar outro aluno
                Console.Write("Deseja cadastrar outro aluno? (s/n): ");
                string resposta = Console.ReadLine().ToLower();

                if (resposta != "s")
                {
                    break;
                }
               


            }





        }
    }
}
          


        
    

