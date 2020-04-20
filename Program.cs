using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {

            char[,] matrixLetter = new char[3,9];
            string word = "";
            string[] index = new string[100];
            char[] characters = new char[100];

            //Filling Matrix
            matrixLetter[0, 0] = 'a';
            matrixLetter[0, 1] = 'b';
            matrixLetter[0, 2] = 'c';
            matrixLetter[0, 3] = 'd';
            matrixLetter[0, 4] = 'e';
            matrixLetter[0, 5] = 'f';
            matrixLetter[0, 6] = 'g';
            matrixLetter[0, 7] = 'h';
            matrixLetter[0, 8] = 'i';
            matrixLetter[1, 0] = 'j';
            matrixLetter[1, 1] = 'k';
            matrixLetter[1, 2] = 'l';
            matrixLetter[1, 3] = 'm';
            matrixLetter[1, 4] = 'n';
            matrixLetter[1, 5] = 'ñ';
            matrixLetter[1, 6] = 'o';
            matrixLetter[1, 7] = 'p';
            matrixLetter[1, 8] = 'q';
            matrixLetter[2, 0] = 'r';
            matrixLetter[2, 1] = 's';
            matrixLetter[2, 2] = 't';
            matrixLetter[2, 3] = 'u';
            matrixLetter[2, 4] = 'v';
            matrixLetter[2, 5] = 'w';
            matrixLetter[2, 6] = 'x';
            matrixLetter[2, 7] = 'y';
            matrixLetter[2, 8] = 'z';


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(" " + matrixLetter[i, j]);
                }
                Console.Write(" \n");
            }
            Console.Write(" \n");

            Console.WriteLine(" Write the word:");
            word = Console.ReadLine();

            //converting the word to an arrangement
            characters = word.ToCharArray();

            //touring the arrangement
            for(int x = 0; x < characters.Count(); x++)
            {
                //touring to matriz
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 9; j++)
                    {
                        if(characters[x] == matrixLetter[i,j])
                        {
                            index[x] = " " + Convert.ToString(i + 1) + "," + Convert.ToString(j + 1) + " ";
                        }
                    }
                }
            }

            //showing de char array
            for(int i = 0; i < index.Count(); i++)
            {
                Console.Write(index[i]);
            }

            Console.ReadKey();
        }
    }
}
