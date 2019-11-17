using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MidtermTest
{
    public static class O_Dien
    {
        public static bool KetNoi(PhichCam2Chan phichCam2Chan)
        {
            // Nếu các chân cắm đều hoạt động => cắm vào ổ điện => hoạt động
            if(phichCam2Chan.Inject() == true)
            {
                return true;
            }
            return false;
        }
    }
}
