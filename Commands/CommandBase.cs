using System;
using System.Windows.Input;

namespace MVVMLiveDemo.Commands;

/// <summary>
/// Basklass för våra commands
/// All kod har genererats när vi implementerar ICommand
/// </summary>
public abstract class CommandBase : ICommand
{
    /// <summary>
    /// Metod för att avgöra om ett command kan köras eller ej
    /// Om denna metod returnerar false så kommer Execute inte kunna köras
    /// </summary>
    /// <param name="parameter"></param>
    /// <returns></returns>
    public bool CanExecute(object? parameter)
    {
        return true;
    }

    /// <summary>
    /// Abstrakt metod som måste implementeras i klasser som ärver av CommandBase
    /// </summary>
    /// <param name="parameter"></param>
    public abstract void Execute(object? parameter);

    public event EventHandler? CanExecuteChanged;

    protected void OnCanExecuteChanged()
    {
        CanExecuteChanged?.Invoke(this, new EventArgs());
    }
}