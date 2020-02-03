using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сокращенный_синтаксис
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class MenuItem
    {
        public string Caption;
        public string HotKey;
        public MenuItem[] Items;
    }

    public static MenuItem[] GeneateMenu()
    {
        return new[]
        {
            new MenuItem()
        {
            Caption="File", HotKey="F",Items = new MenuItem[] { new MenuItem { Caption = "New", HotKey="N" }, new MenuItem { Caption="Save", HotKey="S"} }
        },
        new MenuItem()
        {
            Caption="Edit", HotKey="E", Items = new MenuItem[] {new MenuItem { Caption="Copy", HotKey="C"},new MenuItem { Caption="Paste", HotKey="V"} }
        }
        };

    }
}
