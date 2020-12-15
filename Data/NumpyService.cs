using System;
using System.Collections.Generic;
using System.Linq;
using NumpyDotNet;
namespace numpyblzsrvr.Data
{
    public class NumpyService
    {
       

        public int GetNumbers(int num)
        {
            try
            {
                var ss = np.arange(num);
                var kk = ss.Sum().AsInt32Array();
                return kk.First();

                
            }
            catch (Exception e)
            {

                return 1;
            }
           

        }

       

    }
}
