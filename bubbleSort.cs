using System;

namespace exercicio{
    public class bubbleSort {
    public void ordenar(int[] v) { // metodo
        Console.WriteLine("BubbleSort:");
        // for utilizado para controlar a quantidade de vezes que o vetor será ordenado.
        // v.length é o tamanho do vetor, sendo assim ele assume o tamanho do array
        for (int i = 0; i < v.Length - 1; i++) {                                 
            // for utilizado para ordenar o array.
            for (int j = 0; j < v.Length - 1 - i; j++) {
                /*
                 * Se o valor da posição atual do vetor for maior que o proximo valor,
                 * então troca os valores de lugar no vetor.
                 */
                if (v[j] > v[j + 1]) {
                    int ordenador = v[j];
                    v[j] = v[j + 1];
                    v[j + 1] = ordenador;
                    Console.WriteLine("posicao inicial: " + i + " ordenador: " + j + ": " + v[j]);
                }
            }
        }
    }

    public void ordenar(List<int> list) {
        Console.WriteLine("BubbleSort:");
        int temp;
        // for utilizado para controlar a quantidade de vezes que o vetor será ordenado.
        // v.length é o tamanho do vetor, sendo assim ele assume o tamanho do array
        for (int x = 0; x < list.Count(); x++) {
            // for utilizado para ordenar o array.
            for (int i = 0; i < list.Count() - x - 1; i++) {
                /*
                 * Se a comparação da posição atual com a proxima posição for maior que 0
                 * ou seja, os valores não forem iguais
                 */
                if (list.[i]== list[i+1]) {
                    temp = list[i];
                    list[i, list[i + 1]];
                    list[i + 1, temp];
                    Console.WriteLine("posicao inicial: " + x + " ordenador: " + i + ": " + list[i]);
                }
            }
        }
    }
}
}