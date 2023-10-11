using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EjerciciosPracticos3
{
    internal class Matrices
    {
        public void Ejercicio1()
        {
            int[,] valoresEnteros = new int[3, 3];

            //I PARA FILA Y J PARA COLUMNAS
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Escribe los numeros");
                    valoresEnteros[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Los valores son " + valoresEnteros[i, j]);
                }
            }


        }


        public void Ejercicio2()
        {
            string[,] colores = new string[2, 2];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Introduzca los colores ");
                    colores[i, j] = Convert.ToString(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Los colores son " + colores[i, j]);

                }
            }
        }



        public void Ejercicio3()
        {
            double[,] sumaBidimensional = new double[4, 3];
            double sumar = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingresa los numeros ");
                    sumaBidimensional[i, j] = Convert.ToDouble(Console.ReadLine());


                    sumar += sumaBidimensional[i, j];

                }
            }

            Console.WriteLine("La suma del todo el arreglo es  " + sumar);





            /*
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(sumaBidimensional[i,j]);
                   
                }
            }
            */
        }




        public void Ejercicio4()
        {
            char[,] letras = new char[2, 4];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Escribe las letras");
                    letras[i, j] = Convert.ToChar(Console.ReadLine());
                }
            }


            Console.WriteLine($"{letras[0, 0]} {letras[1, 0]}");
            Console.WriteLine();
            Console.WriteLine($"{letras[0, 1]} {letras[1, 1]}");
            Console.WriteLine();
            Console.WriteLine($"{letras[0, 2]} {letras[1, 2]}");
            Console.WriteLine();
            Console.WriteLine($"{letras[0, 3]} {letras[1, 3]}");
            Console.WriteLine();



        }

    }
}
