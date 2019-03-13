using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.WinForms.Mvvm
{
    /// <summary>
    /// Replaces the AutoWire Property
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class AutoWireViewModelAttribute : Attribute
    {
        public AutoWireViewModelAttribute(bool autoWire = false)
        {
            AutoWire = autoWire;
        }

        public bool AutoWire { get; }
    }
}
