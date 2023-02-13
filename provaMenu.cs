using System;

namespace exercicio
{
    public class provaMenu {
  public static void Main(String[] args) {  //throws IOException
     bubbleSort sort = new bubbleSort(); // instanciando objeto BubbleSort
     FileUtils utils = new FileUtils(); // instanciando objeto FileUtils

    int[] numeros = utils.getNumerosFromFileAsArray("./naoOrdenado.txt"); // buscando numeros declarados no arquivo

    Console.WriteLine("ARRAY Desordenado");
    printList(numeros); // imprimindo valores

    Console.WriteLine("------ARRAY Ordenado------");
    sort.ordenar(numeros); //ordenando o array
    printList(numeros);// imprimindo valores

    List<int> numerosAsList = utils.getNumerosFromFileAsList("./naoOrdenado.txt");
    Console.WriteLine("------List Desordenado------");
    printList(numerosAsList);// imprimindo valores

    Console.WriteLine("------List Ordenado------");
    sort.ordenar(numerosAsList); //ordenando a lista
    printList(numerosAsList);// imprimindo valores
    utils.writeDocument(numerosAsList); // salvando a lista em arquivo
  }

  //imprimir valor
  static void printList(int[] numeros) {
    for (int i = 0; i < numeros.Length; i++) {
      Console.WriteLine(numeros[i]);
    }
  }

  //imprimir valor
  static void printList(List<int> numeros) {
    for (int i = 0; i < numeros.Count(); i++) {
      Console.WriteLine(numeros[i]);
     }
    }
  }
}
