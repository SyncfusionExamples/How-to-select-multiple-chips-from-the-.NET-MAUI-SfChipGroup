using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChipGroupMultiSelection
{
    public class ViewModel
    {

        public ObservableCollection<Language> Languages { get; set; }

        public ObservableCollection<Language> SelectedItems { get; set; }

        public ViewModel()
        {
            this.Languages = new ObservableCollection<Language>();

            Languages.Add(new Language() { Name = "C#" });
            Languages.Add(new Language() { Name = "Python" });
            Languages.Add(new Language() { Name = "Java" });
            Languages.Add(new Language() { Name = "Js" });

            SelectedItems = new ObservableCollection<Language>() { Languages[0], Languages[1] };
        }

    }
}
