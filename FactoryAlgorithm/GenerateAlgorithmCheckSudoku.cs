using System;

namespace FactoryAlgorithm
{
    public class GenerateAlgorithmCheckSudoku
    {
        public ISudokuCheckAlgoritme.ISudokuCheckAlgorithme GetCheckAlgorithme => new SudokuControlAlgorithme.SudokuAlgorithm();
    }
}
