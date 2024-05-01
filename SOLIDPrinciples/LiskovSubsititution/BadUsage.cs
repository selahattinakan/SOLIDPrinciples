using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubsititutionBadUsage
{
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }

        public abstract void TakePhoto();
    }

    public class IPhone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Foto çekildi");
        }
    }


    public class Nokia3310 : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }

    public class SampleUsage()
    {
        public void Usage()
        {
            BasePhone phone = new IPhone();

            phone.Call(); 
            phone.TakePhoto();


            phone = new Nokia3310();

            phone.Call();
            phone.TakePhoto(); //nokia3310'da kamera olmadığı için bu methodun implementation'ınında exception fırlatır.
        }
    }


    /*
     * Bir class miras aldığı classın tüm özelliklerini kullanabilmeli, bu presibe Liskov Substitution prensibi denir.
     */
}
