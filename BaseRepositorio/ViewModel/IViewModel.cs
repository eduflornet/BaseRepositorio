using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseRepositorio.ViewModel
{
    public interface IViewModel<TModelo> where TModelo : class
    {
        TModelo ToBaseDatos();
        void FromBaseDatos(TModelo modelo);
        void UpdateBaseDatos(TModelo modelo);
        object[] GetKeys();
    }
}
