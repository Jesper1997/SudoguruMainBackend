using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryAlgorithm
{
    public class SudokuSolutionCreatorFactory
    {
        public ISudokuCheckAlgoritme.ISudokuSolutionCreator GetCheckAlgorithme => new SudokuControlAlgorithme.SudokuSolutionCreator();
    }
}
