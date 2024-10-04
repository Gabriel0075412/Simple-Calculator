using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Calculadora");

        Console.WriteLine("Selecione uma operacao para fazer o calculo: ");

        Console.WriteLine("1. Soma");
        Console.WriteLine("2. Subtracao");
        Console.WriteLine("3. Multiplicacao");
        Console.WriteLine("4. Divisao");
        
        int resposta_do_user = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro numero: ");

        float numero1 = float.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo numero: ");

        float numero2 = float.Parse(Console.ReadLine());

        if (resposta_do_user == 1)
        {
            float resultado = soma(numero1, numero2);
            Console.WriteLine("O resultado da soma e " + resultado);
        }

        else if (resposta_do_user == 2)
        {
            float resultado = sub(numero1, numero2);
            Console.WriteLine("O resultado da subtracao e " + resultado);
        }

        else if (resposta_do_user == 3)
        {
            float resultado = multi(numero1, numero2);
            Console.WriteLine("O resultado da multiplicacao e " + resultado);
        }

        else if (resposta_do_user ==4)
        {
            float resultado = div(numero1, numero2);
            Console.WriteLine("O resultado da divisao e " + resultado);
        }
        else
        {
            Console.WriteLine("Nenhuma das opcoes foi selecionada!");
        }

        



    }

    static float soma(float a, float b)
    {
        float Soma = a + b;
        return Soma;

    }

    static float sub(float a, float b)
    {
        float Sub = a - b;
        return Sub;
    }

    static float multi(float a, float b)
    {
        float Multi = a * b;
        return Multi;
    }

    static float div(float a, float b)
    {
        float Div = a / b;
        return Div;
    }
}