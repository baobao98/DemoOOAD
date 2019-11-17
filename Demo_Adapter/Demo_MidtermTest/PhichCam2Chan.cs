using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MidtermTest
{
    public class PhichCam2Chan: PhichCam2ChanInterface
    {
        private int ChanCamSo01;
        private int ChanCamSo02;

        public PhichCam2Chan(int chanCamSo01, int chanCamSo02)
        {
            this.ChanCamSo01 = chanCamSo01;
            this.ChanCamSo02 = chanCamSo02;
        }
        public PhichCam2Chan() { }
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
    }
}
