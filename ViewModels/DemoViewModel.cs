using System.Windows.Input;
using MVVMLiveDemo.Commands;
using MVVMLiveDemo.Models;

namespace MVVMLiveDemo.ViewModels;

public class DemoViewModel : ViewModelBase
{
    //Fält för att hålla i en insans av DemoModel
    private readonly DemoModel _demoModel;

    //Property som DemoView binder till
    public string MyText
    {
        get { return _demoModel.MyText; }
        set
        {
            _demoModel.MyText = value;
            //Skickar notis till alla som lyssnar på förändringar av denna propertyn
            //OnPropertyChanged(nameof(MyText));
            //OnPropertyChanged("MyText");
            OnPropertyChanged();
        }
    }

    private string _myTextReversed;

    //Property som DemoView binder till
    public string MyTextReversed
    {
        get { return _myTextReversed; }
        set
        {
            _myTextReversed = value;
            //Skickar notis till alla som lyssnar på förändringar av denna propertyn
            //OnPropertyChanged(nameof(MyTextReversed));
            //OnPropertyChanged("MyTextReversed");
            OnPropertyChanged();
        }
    }

    //Konstruktorn för DemoViewModel som tar in en instans av en DemoModel
    public DemoViewModel(DemoModel demoModel)
    {
        //Sätter fältet _demoModel till den inskickade instansen av DemoModel så den blir åtkomlig
        _demoModel = demoModel;
        //Tilldelar en instans av DemoCommand till propertyn UpdateCommand
        UpdateCommand = new DemoCommand(demoModel, this);
    }

    //En property för ett Command som knappar kan binda till
    public ICommand UpdateCommand { get; }
}