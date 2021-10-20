using System;

namespace ExerciciosCsharpGama
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            double peso,
                   altura,
                   imc;
            decimal salario,
                    salarioMin,
                    qtdsalario;
            double raio,
                   esferaV;
            double n1,
                   n2,
                   n3,
                   exame,
                   med,
                   medExame;
            bool validacao = true;
            Program program = new Program();

            Console.WriteLine("### Exercícios C# ###");

            do
            {
                Console.WriteLine("(1) IMC");
                Console.WriteLine("(2) Salário");
                Console.WriteLine("(3) Raio");
                Console.WriteLine("(4) Média");
                Console.WriteLine("(5) PETs");
                Console.WriteLine("(6) Sair dos exercícios");

                Console.WriteLine("Escolha um exercício: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o peso: ");
                        peso = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a altura: ");
                        altura = Convert.ToDouble(Console.ReadLine());

                        imc = program.IMC(peso, altura);
                        if (imc < 20)
                        {
                            Console.WriteLine("IMC: " + imc + "Pessoa abaixo do peso");
                        }
                        if (20 <= imc && imc < 25)
                        {
                            Console.WriteLine("IMC: " + imc + "Pessoa no peso idela");
                        }
                        if (imc > 25)
                        {
                            Console.WriteLine("IMC: " + imc + "Pessoa acima do peso");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Informe o salário: ");
                        salario = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Informe o salário mínimo: ");
                        salarioMin = Convert.ToDecimal(Console.ReadLine());

                        qtdsalario = program.Salario(salario, salarioMin);
                        Console.WriteLine("O funcionário recebe " + qtdsalario + " salarios mínimos");
                        break;
                    case 3:
                        Console.WriteLine("Informe o R da esfera: ");
                        raio = Convert.ToDouble(Console.ReadLine());
                        esferaV = program.Volume(raio);
                        Console.WriteLine("O volume da esfera é " + esferaV);
                        break;
                    case 4:
                        Console.WriteLine("Informe a nota da primeira avaliação: ");
                        n1 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a nota da segunda avaliação: ");
                        n2 = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Informe a nota da terceira avaliação: ");
                        n3 = Convert.ToDouble(Console.ReadLine());

                        med = program.Media(n1, n2, n3);
                        if(med >= 7.0)
                        {
                            Console.WriteLine("ALUNO APORVADO");
                        } else {
                            Console.WriteLine("Informe a nota do exame: ");
                            exame = Convert.ToDouble(Console.ReadLine());

                            medExame = program.MediaExame(med, exame);

                            if(medExame >= 5.0)
                            {
                                Console.WriteLine("ALUNO APROVADO EM EXAME");
                            } else {
                                Console.WriteLine("ALUNO REPROVADO");
                            }
                        }

                        break;
                    case 5:
                        Animal animal1 = new Animal();
                        Animal animal2 = new Animal();
                        Animal animal3 = new Animal();
                        Animal animal4 = new Animal();
                        Animal animal5 = new Animal();

                        Console.WriteLine("Qual o nome do primeiro animal?");
                        animal1.nome = Console.ReadLine());
                        Console.WriteLine("Qual o tipo do primeiro animal?");
                        animal1.tipo = Console.ReadLine();
                        break;
                    case 6:
                        validacao = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

                Console.WriteLine("Aperte Enter para continuar");
                Console.ReadLine();
                Console.Clear();
            } while (validacao);
        }

        public double IMC(double peso, double altura)
        {
            return peso / (altura * altura);

        }

        public decimal Salario(decimal salario, decimal salarioMin)
        {
            return salario / salarioMin;
        }
        public double Volume(double raio)
        {
            return (4 / 3) * 3.14 * (Math.Pow (raio,3));
        }

        public double Media(double n1, double n2, double n3)
        {
            return (n1 + n2 + n3) / 3;
        }

        public double MediaExame(double med, double exame)
        {
            return (med + exame) / 2;
        }
    }
}
