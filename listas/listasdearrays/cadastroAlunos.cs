using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listasdearrays
{
    internal class CadastroAlunos
    {
        // Atributos da classe
        public string Nome;
        public int Matricula;
        public string Série;
        public string Gênero;

        // Construtor da classe
        public CadastroAlunos(string nome, int matricula, string série, string gênero)
        {
            Nome = nome;
            Matricula = matricula;
            Série = série;
            Gênero = gênero;
        }

        // Método para imprimir as informações do aluno
        public void ImprimirAluno()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Série: {Série}, Gênero: {Gênero}");
        }
    }
}



            
        

    

        
 
       
            
           

   

        

        
       
               
            
        
    


