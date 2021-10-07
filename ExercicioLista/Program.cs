using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employee = new List<Employee>();

            Console.Write("Quantos empregados serão registrados? ");
            int quantidade = int.Parse(Console.ReadLine());

            for(int i=1; i <= quantidade; i++)
            {
                Console.WriteLine($"Empregado # {i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.Add(new Employee(id, nome, salario));
                Console.WriteLine();
            }

            Console.Write("Entre com o ID do empregado que terá aumento de salário: ");
            int buscaId = int.Parse(Console.ReadLine());

            Employee emp = employee.Find(x => x.Id == buscaId);

            if(emp != null)
            {
                Console.Write("Entre com a porcentagem do aumento: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentaSalario(porc);
            }
            else
            {
                Console.WriteLine("Este ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de Empregado atualizada: ");

            foreach(Employee empregado in employee)
            {
                Console.WriteLine(empregado.ToString());
            }

            Console.ReadLine();
        }
    }
}
