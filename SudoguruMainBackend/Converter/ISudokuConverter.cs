using SudoguruMainBackend.ViewModels;

namespace SudoguruMainBackend.Converter
{
    public interface ISudokuConverter
    {
        SudokuBoard.SudokuBoard BoardConverter(BoardViewModel receivedboard);
    }
}