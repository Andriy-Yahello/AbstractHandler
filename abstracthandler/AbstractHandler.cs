using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractHandler
{
    public abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Chenge();
        public abstract void Save();
    }

    class XMLHandler : AbstractHandler
    {
        public override void Open() {
            Console.WriteLine("XML document opened.");
        }
        
        public override void Create() {
            Console.WriteLine("XML document created.");
        }

        public override void Chenge() {
            Console.WriteLine("XML document changed.");
        }

        public override void Save() {
            Console.WriteLine("XML document saved.");
        }
    }

    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT document opened.");
        }

        public override void Create()
        {
            Console.WriteLine("TXT document created.");
        }

        public override void Chenge()
        {
            Console.WriteLine("TXT document changed.");
        }

        public override void Save()
        {
            Console.WriteLine("TXT document saved.");
        }
    }

    class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("WORD document opened.");
        }

        public override void Create()
        {
            Console.WriteLine("WORD document created.");
        }

        public override void Chenge()
        {
            Console.WriteLine("WORD document changed.");
        }

        public override void Save()
        {
            Console.WriteLine("WORD document saved.");
        }
    }
}
