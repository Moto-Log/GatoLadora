using System
    ;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public class ConcreteMemento: Memento
    {
        private Stack<Calculadora> UndoPile;
        private Stack<Calculadora> RedoPile;

        public ConcreteMemento()
        {
            this.UndoPile = new Stack<Calculadora>();
            this.RedoPile = new Stack<Calculadora>();
        }

        public Calculadora desfazer()
        {
            if (RedoPile.Count() == 0 && UndoPile.Count() == 0) return null;
            if (UndoPile.Count() > 0)
                RedoPile.Push(UndoPile.Pop());
            if (UndoPile.Count() == 0)
                return null;
            return UndoPile.Peek();
            
        }

        public void Salvar(Calculadora dados)
        {
           
            UndoPile.Push(dados);
            RedoPile.Clear();
            
        }

        public Calculadora refazer()
        {
            if (RedoPile.Count() == 0 && UndoPile.Count() == 0) return null;
            if (RedoPile.Count() > 0)
                UndoPile.Push(RedoPile.Pop());
            if (RedoPile.Count() == 0)
                return null;
            return RedoPile.Peek();
        }
    }
}
