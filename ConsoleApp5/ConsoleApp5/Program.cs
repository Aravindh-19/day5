using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Photobook
    {
        class photobook
        {
            protected int numpages;
            public int GetNumberpages()
            {            
                return numpages;
            }
            public photobook(int n)
            {
                
                Console.WriteLine("No of pages:"+n);
                
            }
            public photobook()
            {
                numpages = 16;

            }
        }
        class Bigphotobook : photobook
        {
            public  Bigphotobook()
            {
                numpages = 64;
               

            }
        }
        class PhotobookTest
        {
            static void Main(string[] args)
            {
                photobook photobook = new photobook();
                Console.WriteLine(photobook.GetNumberpages());
                photobook a = new photobook(24);
                Console.WriteLine(a.GetNumberpages());
                Bigphotobook album1 = new Bigphotobook();
                Console.WriteLine(album1.GetNumberpages());


                
                
                
                Console.ReadLine();
            }
        }
    }
}