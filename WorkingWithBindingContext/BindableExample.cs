using System;
using System.Collections.Generic;
using System.Text;

namespace WorkingWithBindingContext
{
  public  class BindableExample
    {
        private int index=0;
        private string[] names = { "tal", "Romi", "Shnieder" };
        public int Index { get { return index; } set { if (value >= names.Length) index = 0; else index = value; } }
        public string Names { get { return names[index]; } } 
    }
}
