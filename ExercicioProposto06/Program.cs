using System;

namespace ExerciciosProposto06 {
    class URI {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];


            for(int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                nome[i] = vet[0];
                idade[i] = int.Parse(vet[1]);
            }

            int pessoaMaisVelha = idade[0];
            int posicaoMaior = 0;

            for(int i = 1; i < n; i++) {
                if(idade[i] > pessoaMaisVelha) {
                    pessoaMaisVelha = idade[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(nome[posicaoMaior]);


        }
    }
}



