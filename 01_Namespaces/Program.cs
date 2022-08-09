using T = Toto;
using T2 = Toto2;

Console.WriteLine("Hello, World!");

T2.MaClasse maClasse = new T2.MaClasse();

maClasse.Hello();

T.MaStruct maStruct = new T.MaStruct();

maStruct.Hello();

T2.MaClasse2 maClasse2 = new T2.MaClasse2();
maClasse2.Hello();


namespace Toto
{
    class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Hello de MaClasse de Toto");
        }
    }

    struct MaStruct
    {
        public void Hello()
        {
            Console.WriteLine("Hello de MaStruct de Toto");
        }
    }
}

namespace Toto2
{
    class MaClasse
    {
        public void Hello()
        {
            Console.WriteLine("Hello de MaClasse de Toto2");
        }
    }
}

namespace Toto2
{
    class MaClasse2
    {
        public void Hello()
        {
            Console.WriteLine("Hello de MaClasse2 de Toto2");
        }
    }
}