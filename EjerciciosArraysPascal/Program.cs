using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosArraysPascal
{
    //El ejercicio consiste en mostrar diferentes nombres de ciudad por consola en función de una matriz y modificar los nombres cambiando letras.
    //FASE 1
    //-          Crea seis variables de tipo cadena vacías.
    //-          Pide por la consola que escriban los nombres.
    //-          Introduce los siguientes nombres de ciudades (Barcelona, Madrid, Valencia, Málaga, Cádiz, Santander) por teclado.
    //-          Muestra por consola el nombre de las 6 ciudades.
    //FASE 2
    //-          Una vez que tengamos los nombres de las ciudades almacenadas en variables tendremos que pasar la información a una matriz (arrayCiudades).
    //-          Cuando tengamos la matriz completa, tendremos que mostrar por consola el nombre de las ciudades ordenadas en orden alfabético.
    //FASE 3
    //-         Cambia las vocales "a" de los nombres de ciudad por el número “4” y guarda los nombres modificados en una nueva matriz (ArrayModified).
    //-          Mostrar por la consola la matriz modificada y ordenada por orden alfabético.
    //FASE 4
    //-          Crea una nueva matriz para cada una de las ciudades que tenemos. El tamaño de las nuevas matrices será la longitud de cada cadena (nameCiutat.Length).
    //-          Rellene las nuevas matrices letra por letra.
    //-         Mostrar por consola las nuevas matrices con los nombres invertidos (Por ejemplo: Barcelona - anolecraB).

    class Program
    {
        static void Main(string[] args)
        {
            //Declaro las 6 variables donde introduciremos las ciudades por consola
            string c1, c2, c3, c4, c5, c6;
            Console.WriteLine("Escribe el nombre de 6 ciudades (presiona enter después de cada ciudad)");  //Barcelona, Madrid, Valencia, Málaga, Cádiz, Santander (valores a introducir)
            c1 = Console.ReadLine();
            c2 = Console.ReadLine();
            c3 = Console.ReadLine();        //pedimos el nombre de las ciudades 
            c4 = Console.ReadLine();
            c5 = Console.ReadLine();
            c6 = Console.ReadLine();

            //mostramos las ciudades por consola
            Console.WriteLine("Las ciudades son \n{0} \n{1} \n{2} \n{3} \n{4} \n{5} ", c1, c2, c3, c4, c5, c6);

            //Creamos el array e introducimos los valores de las variables en las 6 posicioines
            string[] arrayCiudades = new string [6] {c1, c2, c3, c4, c5, c6};

            //ordenamos alfabéticamente el array
            Array.Sort<string>(arrayCiudades);

            //mostramos por consola las  6 ciudades ya ordenadas.
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arrayCiudades[i]);            
            }

            //Reemplazamos las "a" por "4" en cada variable
            c1 = c1.Replace("a", "4"); c2 = c2.Replace("a", "4"); c3 = c3.Replace("a", "4"); 
            c4 = c4.Replace("a", "4"); c5 = c5.Replace("a", "4"); c6 = c6.Replace("a", "4");

            //Introducimos las variables con el valor alterado en una ueva array.
            string[] arrayCiudadesModify = new string[6] { c1, c2, c3, c4, c5, c6 };

            //ordenamos alfabéticamente este nuevo array
            //mostramos por consola las  6 ciudades ya ordenadas.
            Array.Sort<string>(arrayCiudadesModify);      
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(arrayCiudadesModify[i]);        // a partir de aquí no tocar variable.    
            }

            //Creamos un array para cada variable, con la longitud  de cada palabra introducida:
            //Crear todos los arrays con un unico bucle

            string[] arrayBarcelona = new string[c1.Length];
            //Introducimos las letras en las posiciones
            for (int i = 0; i < c1.Length; i++)             
            {
                arrayBarcelona[i] = c1.Substring(i,1);
            }
            //giramos y mostramos array
            Array.Reverse(arrayBarcelona);
            for (int i = 0; i < c1.Length; i++)
            {
                Console.Write(arrayBarcelona[i]);
            }
            Console.WriteLine();

            string[] arrayMadrid = new string[c2.Length];
            for (int i = 0; i < c2.Length; i++)
            {
                arrayMadrid[i] = c2.Substring(i, 1);
            }
            Array.Reverse(arrayMadrid);
            for (int i = 0; i < c2.Length; i++)
            {
                Console.Write(arrayMadrid[i]);
            }
            Console.WriteLine();

            string[] arrayValencia = new string[c3.Length];
            for (int i = 0; i < c3.Length; i++)
            {
                arrayValencia[i] = c3.Substring(i, 1);
            }
            Array.Reverse(arrayValencia);
            for (int i = 0; i < c3.Length; i++)
            {
                Console.Write(arrayValencia[i]);
            }
            Console.WriteLine();

            char[] arrayMálaga = new char[c4.Length];
            for (int i = 0; i < c4.Length; i++)   //array.lenght (no lengt de variable)
            {
                arrayMálaga[i] = c4[i]; // en todos.
            }
            Array.Reverse(arrayMálaga);
            for (int i = 0; i < c4.Length; i++)
            {
                Console.Write(arrayMálaga[i]);
            }
            Console.WriteLine();

            string[] arrayCadiz = new string[c5.Length];
            for (int i = 0; i < c5.Length; i++)
            {
                arrayCadiz[i] = c5.Substring(i, 1);
            }
            Array.Reverse(arrayCadiz);
            for (int i = 0; i < c5.Length; i++)
            {
                Console.Write(arrayCadiz[i]);
            }
            Console.WriteLine();

            string[] arraySantander = new string[c6.Length];
            for (int i = 0; i < c6.Length; i++)
            {
                arraySantander[i] = c6.Substring(i, 1);
            }
            Array.Reverse(arraySantander);
            for (int i = 0; i < c6.Length; i++)
            {
                Console.Write(arraySantander[i]);
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
