using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MidtermTest
{
    public class Adapter_03Phich_to_02Phich : PhichCam2ChanInterface
    {
        private PhichCam3Chan phichCam3Chan;
        private int ChanCamSo01;
        private int ChanCamSo02;

        public Adapter_03Phich_to_02Phich(PhichCam3Chan phichCam3Chan)
        {
            this.phichCam3Chan = phichCam3Chan;

            // mirigate chân cắm
            setChanCamSo01(phichCam3Chan.GetChanCamSo01());
            setChanCamSo02(phichCam3Chan.GetChanCamSo02());
        }

        public int GetChanCamSo01()
        {
            return ChanCamSo01;
        }

        public void setChanCamSo01(int OnOff)
        {
            this.ChanCamSo01 = OnOff;
        }

        public int GetChanCamSo02()
        {
            return ChanCamSo02;
        }

        public void setChanCamSo02(int OnOff)
        {
            this.ChanCamSo02 = OnOff;
        }

        public bool Inject()
        {
            // kiểm tra 1: vì 01 có nghĩa là chân cắm đó hoạt động đượ
            if( ChanCamSo02 != 1 || ChanCamSo01 != 1)
            {
                // có một chân cắm không hoạt động;
                return false;
            }
            // tất cả đều hoạt động
            return true;
        }

        public PhichCam2Chan convert()
        {
            if(this.Inject()== true)
            {
                return new PhichCam2Chan(1, 1);
            }
            else
            {
                return new PhichCam2Chan(0, 0);
            }
        }

    }
}
