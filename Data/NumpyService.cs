using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Numpy;

namespace numpyblzsrvr.Data
{
    public class NumpyService
    {
       

        public string GetNumbers(int num)
        {
            try
            {
                var ss = np.arange(num);
                return ss.sum().repr.ToString();
            }
            catch (Exception e)
            {

                return e.ToString();
            }
           

        }

        public int GetNumbers2(int num)
        {

            var o= JsonConvert.SerializeObject(1);
            var u = JsonConvert.DeserializeObject(o);

            return num + 1;

        }

    }
}
