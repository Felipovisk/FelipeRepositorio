using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade6.Exercicios_Complementares
{
    class Exercicio2
    {
        public static string Password = "";
        public static string NomeUsuario = "";
        public static int DataAlteracao = 0;
        public static string PasswordDigitado = "";
        
        public static void Main1(String []args)
        {
            CadastroSenha();
            VerificaSenha();
        }

        private static void CadastroSenha()
        {
            Console.WriteLine("Digite o nome de usuário.");
            NomeUsuario = Console.ReadLine();
            Password = NomeUsuario + "123";
            Console.WriteLine("Sua senha de usuario é: " + Password);
            Console.WriteLine("Digite somente o dia da data de hoje.");
            DataAlteracao = int.Parse(Console.ReadLine());
        }
        private static void VerificaSenha()
        {
            Console.WriteLine("Digite a senha de usuario para entrar no programa.");
            PasswordDigitado = Console.ReadLine();
            var dataAtual = DateTime.Now.Day;
            if (Password == PasswordDigitado)
            {
                if (dataAtual - DataAlteracao < 15)
                {
                    Console.WriteLine("Acesso Permitido.");
                }
                else
                {
                    Console.WriteLine("Senha expirada.");
                    AtualizaSenha();
                    VerificaSenha();
                }
            }
            else
            {
                Console.WriteLine("Acesso Negado, Senha Incorreta.");
                VerificaSenha();
            }
            Console.ReadKey();
        }
        private static void AtualizaSenha()
        {
            var senhaAntiga = Password;
            Console.WriteLine("Digite uma nova senha.");
            Password = Console.ReadLine();
            DataAlteracao = DateTime.Now.Day;
            if (senhaAntiga != Password)
            {
                Console.WriteLine("Senha atualizada com sucesso.");
            }
            else
            {
                Console.WriteLine("A senha nova deve ser diferente da anterior.");
                AtualizaSenha();
            }
        }
    }
}

