using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    // Класс "Узел синтаксического дерева".
    class SyntaxTreeNode
    {
        private string name; // Наименование узла.

        private List<SyntaxTreeNode> subNodes; // Подчиненные узлы.

        // Конструктор узла.
        public SyntaxTreeNode(string name)
        {
            this.name = name;
            subNodes = new List<SyntaxTreeNode>();
        }

        // Добавить узел в список подчиненных узлов.
        public void AddSubNode(SyntaxTreeNode subNode)
        {
            this.subNodes.Add(subNode);
        }

        // Наименование узла - свойство только для чтения.
        public string Name
        {
            get { return name; }
        }

        // Список подчиненных узлов - свойство только для чтения.
        public List<SyntaxTreeNode> SubNodes
        {
            get { return subNodes; }
        }
    }
}
