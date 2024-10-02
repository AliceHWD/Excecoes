using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_exceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try //Bloco onde faz a tentativa
            {
                string[] linhas = File.ReadAllLines("Yo.txt");

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            catch(FileNotFoundException especifico) //Se der um erro epecífico vai tratar ele aqui
            {
                Console.WriteLine("Erro específico | " + especifico.Message);
            }
            catch(Exception ex) //Bloco onde passa se der erro É GENÉRICO
            {
                Console.WriteLine(ex.Source);
                Console.WriteLine(ex.Message);
            }
            finally //Aqui vai passar independente se der erro ou não
            {
                Console.WriteLine("Bloco finally");
            }

            Console.WriteLine("Chega até aqui");

            Console.ReadKey();
            



        }
    }
}
