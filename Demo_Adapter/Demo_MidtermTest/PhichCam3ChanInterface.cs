using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MidtermTest
{
    interface PhichCam3ChanInterface
    {
        int GetChanCamSo01();
        void setChanCamSo01(int OnOff);
        int GetChanCamSo02();
        void setChanCamSo02(int OnOff);
        int GetChanCamSo03();
        void setChanCamSo03(int OnOff);
        bool Inject();

    }
}
