using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    //Interface utilizada para encapsular o codigo e evitar
    //que os clientes alterem os dados do objeto memento
    public interface Memento
    {
        void Salvar(Calculadora dados);
        Calculadora desfazer();
        Calculadora refazer();
    }


}
