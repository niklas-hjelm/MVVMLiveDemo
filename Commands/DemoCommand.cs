using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMLiveDemo.Models;
using MVVMLiveDemo.ViewModels;

namespace MVVMLiveDemo.Commands
{
    /// <summary>
    /// Vårat eget command med implementation av Execute
    /// </summary>
    public class DemoCommand: CommandBase
    {
        private readonly DemoModel _demoModel;
        private readonly DemoViewModel _demoViewModel;

        public DemoCommand(DemoModel demoModel, DemoViewModel demoViewModel)
        {
            _demoModel = demoModel;
            _demoViewModel = demoViewModel;
        }
        /// <summary>
        /// koden som körs om commandet körs.
        /// </summary>
        /// <param name="parameter"></param>
        public override void Execute(object? parameter)
        {
            var textReversed = _demoModel.ReverseMyText();
            _demoViewModel.MyTextReversed = textReversed;
        }
    }
}
