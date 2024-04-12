using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Memento
{
    internal partial class Person : ObservableObject, ICloneable, IRestorable<Person>
    {
        [ObservableProperty]
        private string lastName;
        [ObservableProperty]
        private string firstName;


        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Restore(Person state)
        {
            firstName = state.FirstName;
            lastName = state.LastName;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
