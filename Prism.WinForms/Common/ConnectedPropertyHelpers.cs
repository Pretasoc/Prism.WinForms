using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.Common
{
    internal static class ConnectedPropertyHelpers
    {
        public static T TryGet<T>(object carrier, string name)
        {
            try
            {
                return Nito.ConnectedProperties.ConnectedProperty.Get(carrier, name);
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        public static void TrySet<T>(object carrier, string name, T value)
        {
            try
            {
                Nito.ConnectedProperties.ConnectedProperty.Set(carrier, name, value);
            }
            catch (Exception)
            {
                //ignored 
            }
        }


    }
}
