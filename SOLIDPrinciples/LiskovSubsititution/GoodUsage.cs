using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrinciples.LiskovSubsititutionGoodUsage
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }

    }

    public class IPhone : BasePhone, ITakePhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Foto çekildi");
        }
    }


    public class Nokia3310 : BasePhone
    {
       
    }

    public class SampleUsage()
    {
        public void Usage()
        {
            BasePhone phone = new IPhone();

            phone.Call(); 
            ((ITakePhoto)phone).TakePhoto();


            phone = new Nokia3310();

            phone.Call();
            //phone.TakePhoto(); //nokia3310'da böyle bi özellik olmadığı için metoda erişemiyor, ayrıca kod compile edilemiyor zaten

            /*
             * TakePhoto metodu artık sadece ITakePhoto interface'ini miras alan classlar tarafından erişilebiliyor
             */
        }
    }


}
