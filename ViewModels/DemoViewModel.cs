using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVMLiveDemo.Models;

namespace MVVMLiveDemo.ViewModels;

public class DemoViewModel : ObservableObject
{
    //Fält för att hålla i en insans av DemoModel
    private readonly DemoModel _demoModel;

    //Property som DemoView binder till
    public string MyText
    {
        get { return _demoModel.MyText; }
        set
        {
            //_demoModel.MyText = value;
            //Skickar notis till alla som lyssnar på förändringar av denna propertyn
            //OnPropertyChanged(nameof(MyText));
            //OnPropertyChanged("MyText");
            //OnPropertyChanged();
            SetProperty(_demoModel.MyText, value, (v)=> _demoModel.MyText = v);
        }
    }

    private string _myTextReversed;

    //Property som DemoView binder till
    public string MyTextReversed
    {
        get { return _myTextReversed; }
        set
        {
            //_myTextReversed = value;
            //Skickar notis till alla som lyssnar på förändringar av denna propertyn
            //OnPropertyChanged(nameof(MyTextReversed));
            //OnPropertyChanged("MyTextReversed");
            //OnPropertyChanged();
            SetProperty(ref _myTextReversed, value);
        }
    }

    //Konstruktorn för DemoViewModel som tar in en instans av en DemoModel
    public DemoViewModel(DemoModel demoModel)
    {
        //Sätter fältet _demoModel till den inskickade instansen av DemoModel så den blir åtkomlig
        _demoModel = demoModel;
        //Tilldelar en instans av DemoCommand till propertyn UpdateCommand
        UpdateCommand = new RelayCommand(()=>MyTextReversed = demoModel.ReverseMyText(), () => true);
    }

    //En property för ett Command som knappar kan binda till
    public ICommand UpdateCommand { get; }
}