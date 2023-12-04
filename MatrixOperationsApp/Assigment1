using System;

class Matrices


//Main-metodissa ensin luodaan satunnaislukugeneraattori (Random-olio) ja määritellään satunnaiset rivien ja sarakkeiden määrät matriiseille MatrixA ja MatrixB.
//Rivien ja sarakkeiden määrät määräytyvät satunnaisesti väliltä 1-4.
//Näitä arvoja käytetään matriisien luomiseen ja muiden toimintojen suorittamiseen.
{
    private static void Main(string[] args)
    {
        // Luo satunnaislukugeneraattori
        Random random = new Random();

        int rowsA = random.Next(1, 5);
        int columnsA = random.Next(1, 5);

        int rowsB = random.Next(1, 5);
        int columnsB = random.Next(1, 5);

        // Luodaan satunnaiset matriisit MatrixA ja MatrixB
        int[,] MatrixA = CreateRandomMatrix(random, rowsA, columnsA);
        int[,] MatrixB = CreateRandomMatrix(random, rowsB, columnsB);

        Console.WriteLine("Matrix A :");
        PrintMatrix(MatrixA);

        Console.WriteLine("Matrix B :");
        PrintMatrix(MatrixB);

        // Suoritetaan laskutoimitukset
        if (AdditionCompatibility(MatrixA, MatrixB))
        {
            int[,] additionResult = AddMatrices(MatrixA, MatrixB); // Tallennetaan tulos matriisina
            Console.WriteLine("Matriisin A + Matriisin B tulos:");
            PrintMatrix(additionResult); // Tulosta tulosmatriisi
        }
        else
        {
            Console.WriteLine("Matriiseja ei voi lisätä, koska ne eivät ole yhteensopivia.");
        }
;

        if (SubtractionCompatibility(MatrixA, MatrixB))
        {
            int[,] subtractionResult = SubtractMatrices(MatrixA, MatrixB); // Tallennetaan tulos matriisina
            Console.WriteLine("Matriisin A - Matriisin B tulos:");
            PrintMatrix(subtractionResult); // Tulosta tulosmatriisi
        }
        else
        {
            Console.WriteLine("Matriiseja ei voi vähentää, koska ne eivät ole yhteensopivia.");
        }


        if (MultiplicationCompatibility(MatrixA, MatrixB))
        {
            int[,] multiplicationResult = MultiplyMatrices(MatrixA, MatrixB);
            Console.WriteLine("Matriisin A * Matriisin B tulos:");
            PrintMatrix(multiplicationResult);
        }
        else
        {
            Console.WriteLine("Matriiseja ei voi kertoa keskenään, koska ne eivät ole yhteensopivia.");
        }
    }

    //Tämä funktio luo satunnaisen matriisin annetuilla rivien ja sarakkeiden määrillä.
    //Näissä matriiseissa olevat arvot ovat satunnaisia kokonaislukuja väliltä 1-100.
    //Matriisien luomisen perusta on kahden sisäkkäisen for-silmukan käyttö, joka täyttää matriisin satunnaisilla arvoilla.

    //static int-metodit suorittavat laskentaa ja palauttavat kokonaislukuja.
    private static int[,] CreateRandomMatrix(Random random, int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];

        //for ([alkuarvo]; [jatkamisehto]; [muutos])
        //alussa for silmukan muuttuja i alustetaan arvoon 0
        //for silmukka pyörii niin kauan kunnes muuttuja i,j on yhtäsuuri kuin rowsA,B ja columnsA,B
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                //Täyttää matriisin satunnaisilla arvoilla väliltä 1-100.
                matrix[i, j] = random.Next(1, 100);
            }
        }

        return matrix;
    }


    //Tämä Metodi tulostaa matriisin konsoliin.
    //Se käyttää kaksi sisäkkäistä for-silmukkaa matriisin läpikäymiseen ja tulostamiseen.

    //static void-metodit suorittavat toimintoja, mutta eivät palauta arvoa.
    private static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        //matrix.GetLength(0) palauttaa taulukon ensimmäisen ulottuvuuden (rivien) koon.
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            //matrix.GetLength(1) palauttaa taulukon toisen ulottuvuuden (sarakkeiden) koon.
            {
                // Tulosta matriisin yhden rivin konsoliin, varmistaen viiden merkin levyisen kentän
                Console.Write("{0,5}", matrix[i, j]);
            }
            //Tällä siirryttään seuraavalle riville rivin tulostuksen jälkeen.
            Console.WriteLine();
        }
    }
    private static bool AdditionCompatibility(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int columnsB = matrixB.GetLength(1);

        // Tarkistetaan, ovatko matriisit samankokoisia eli niiden rivien ja sarakkeiden määrät ovat samat
        return rowsA == rowsB && columnsA == columnsB;
    }

    // Metodi, joka laskee matriisin elementtien summan
    private static int[,] AddMatrices(int[,] matrixA, int[,] matrixB)
    {
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);

        int[,] resultMatrix = new int[rows, columns]; // Luodaan tulosmatriisi

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j]; // Lisätään matriisien arvot ja asetetaan tulosmatriisiin
            }
        }

        return resultMatrix; // Palautetaan tulosmatriisi
    }



    // Metodi, joka tarkistaa, ovatko matriisit yhteensopivia vähennyslaskulle

    //static bool-metodit tarkistavat ehtoja ja palauttavat totuusarvoja.
    private static bool SubtractionCompatibility(int[,] matrixA, int[,] matrixB)
    {
        //asetetaan muuttujat matriisien rivien ja sarakkeiden määrille
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int columnsB = matrixB.GetLength(1);

        //Tämä kohta koodissa tarkistaa, ovatko kaksi matriisia yhteensopivia eli saman kokoisia.
        return rowsA == rowsB && columnsA == columnsB;
    }


    //Tämä metodi suorittaa matriisien vähennyslaskun.
    //Se käyttää for-silmukoita matriisien elementtien vähentämiseen toisistaan.


    private static int[,] SubtractMatrices(int[,] matrixA, int[,] matrixB)
    {
        //paikalliset muuttujat saavat arvokseen matrixA:n rivien ja sarakkeiden määrät.
        int rows = matrixA.GetLength(0);
        int columns = matrixA.GetLength(1);

        int[,] resultMatrix = new int[rows, columns]; // Luodaan tulosmatriisi

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] - matrixB[i, j]; // Vähennetään matriisien arvot ja asetetaan tulosmatriisiin
            }
        }

        return resultMatrix; // Palautetaan tulosmatriisi
    }


    // Metodi, joka tarkistaa, ovatko matriisit yhteensopivia kertolaskulle
    private static bool MultiplicationCompatibility(int[,] matrixA, int[,] matrixB)
    {
        //Haetaan paikalliseen muuttujaan matriisien rivien ja sarakkeiden määrät.
        int columnsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);

        //tarkastetaan että onko matriisien sarakkeiden määrä yhtäsuuri kuin rivien määrä ja onko kertolasku mahdollinen.
        return columnsA == rowsB;
    }

    // Metodi, joka suorittaa matriisien kertolaskun
   private static int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
    {
        //Haetaan paikallisiin muuttujiin matriisien rivien ja sarakkeiden määrät.
        int rowsA = matrixA.GetLength(0);
        int columnsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int columnsB = matrixB.GetLength(1);

        //Tässä luodaan uusi matriisi resultMatrix, jonka koko määräytyy matrixA-matriisin rivien määrän (rowsA) ja matrixB-matriisin sarakkeiden määrän (columnsB) perusteella.
        //Tämä uusi matriisi säilyttää kertolaskun tuloksen.

        int[,] resultMatrix = new int[rowsA, columnsB];

        //Käydään läpi matriisien rivit ja sarakkeet.
        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < columnsB; j++)
            {
                for (int k = 0; k < columnsA; k++)
                {
                    //Tässä kerrotaan matriisien arvot keskenään ja asetetaan ne resultMatrix-matriisiin.
                    resultMatrix[i, j] += matrixA[i, k] * matrixB[k, j];
                }
            }
        }

        return resultMatrix;
    }
}

