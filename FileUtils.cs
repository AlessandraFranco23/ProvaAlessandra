using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace exercicio{
    public class FileUtils {

    public int[] getNumerosFromFileAsArray(String path) { // argumento 'path' é o local do arquivo
        try {
            // lendo um arquivo de texto com os numeros sem ordem
            StreamReader sr = new StreamReader(path);

            // buscando a quantidade de linhas para poder criar o array
            int tamanho = getNumeroLinhas(path);

            //declarando array
            int[] numeros = new int[tamanho];

            //declarando contador
            int posicao = 0;

            //declando valor da linha
            String line;
            
            // buscando o valor da linha
            // utilizando a atribuição no while para poder garantir que a variavel line não seja nula
            while ((line = sr.ReadLine()) != null) {
                // salvando o valor o valor no array
                numeros[posicao] = Int32.Parse(sr.ReadLine());

                //contador
                posicao++;
            }

            //fechando o leitor
            sr.Close();
            return numeros;
        } catch (Exception e) {
            Console.WriteLine(e.Message);

            //retornando lista vazia
            return new int[0];
        }
    }

    private int getNumeroLinhas(String path) {
        try {
            // lendo um arquivo de texto com os numeros sem ordem
            StreamReader sr = new StreamReader(path);
            // declando variavel tamanho
            int tamanho = 0;

            // loop para recuperar as linhas
            while (sr.ReadLine() != null) {
                //contador
                tamanho++;
            }
            //retornando o total das linhas
            return tamanho;
        } catch (Exception e) {
            //capturando a exceção
            //caso de erro na leitura do arquivo é retornado o tamanho 0
            return 0;
        }
    }

    public List<int> getNumerosFromFileAsList(String path) {
        try {

            StreamReader sr = new StreamReader(path);
            ArrayList numeros = new ArrayList();
            String line;
            while ((line = sr.ReadLine()) != null) {
                numeros.add(Int32.Parse(sr.ReadLine()));
            }
            sr.Close();
            return numeros;
        } catch (Exception e) {
            Console.WriteLine(e.Message);
            return Collections.emptyList();
        }
    }

    public void writeDocument(List<int> numeros)  { //throws IOException
        // buscando o aquivo
        File file = new File ("list_ordenado.txt"); 
        // caso o arquivo exista ele apaga
        if (file.exists()) {
            file.delete(); // apagando o arquivo
        }

        // delcarando e instanciando o BufferedWriter para escrever no arquivo
        StreamWriter sw = new StreamWriter(path);
        for (int i = 0; i < numeros.Count(); i++) {
            writer.write(string.valueOf(numeros[i])); // escrevendo no arquivo
            writer.write("\n"); // quebra de linha
        }
        sw.Close(); // fechando o bufferedWriter
        }
    }
}