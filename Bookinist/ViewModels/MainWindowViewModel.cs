using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathCore.Values;
using MathCore.WPF.ViewModels;

namespace Bookinist.ViewModel
{
    internal class MainWindowViewModel : TitledViewModel
    {
		private string _title = "Main program window";

		public string Title { get => _title; set => Set(ref _title, value); }

	}
}
