using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin_MetroEvents.Models
{
    public class Item
    { 
        public Item(string na, string de) {
            name = na;
            detail = de;
        }
        string name, detail;

        public string Name {
            get=>name;set=>name=value;
        }
        public string Detail {
            get=>detail;set=>detail=value;
        }
    }
}
