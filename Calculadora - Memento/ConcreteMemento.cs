using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
    //Concrete memento é responsavel por implementar a interface memento
    
    public class ConcreteMemento: Memento
    {
        // O objeto irá conter duas pilhas

        //uma para armazenar e recuperar os objetos ao fazer novas alteraçõies
        private Stack<Calculadora> UndoPile;

        //e outra para armazenar os objetos quando recuperamos o estado anterior
        //mas tendo a possibilidade de voltar ao estado atual
        private Stack<Calculadora> RedoPile;

        public ConcreteMemento()
        {
            this.UndoPile = new Stack<Calculadora>();
            this.RedoPile = new Stack<Calculadora>();
        }

        //o metodo desfazer consiste em recuperar os estados anteriores do objeto
        public Calculadora desfazer()
        {
            if (RedoPile.Count() == 0 && UndoPile.Count() == 0) return null; //verifimos se as pulhas estão vazias
            if (UndoPile.Count() > 0)//verificamos novamente se a pilha de desfazer está vazia
                RedoPile.Push(UndoPile.Pop());//inserimos o estado atual do objeto na pilha de refazer, para recuperar depois caso necessario
            if (UndoPile.Count() == 0)//verificamos se a pilha esvaziou após transferir seu estado para a pilha de refazer;
                return null;
            return UndoPile.Peek();//retornamos o estado anterior do objeto
            
        }

        //como o proprio nome já diz, o objeto salva o estado atual
        public void Salvar(Calculadora dados)//recebemos o objeto ao chamar a função
        {
           
            UndoPile.Push(dados);//inserimos ele na pilha
            RedoPile.Clear();//limpamos o refazer, já que os objetos posteriores n]ao existem mais
            
        }

        //A função refazer funciona exatamente como a desfazer, mas neste caso recuperamos os estados futuros do objeto
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
