using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVMLiveDemo.ViewModels;

/// <summary>
/// Basklass för våra Vymodeller
/// Detta är autogenererad kod från när vi implementerar INotifyPropertyChanged
/// INotifyPropertyChanged finns inbyggt i .NET
/// </summary>
public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// Metoden vi anropar i set på de metoder som ska uppdatera Vyer
    /// </summary>
    /// <param name="propertyName">namnet på propertyn som har uppdaterats</param>
    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}