using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MidtermTest
{
    public class PhichCam3Chan : PhichCam3ChanInterface
    {
        private int ChanCamSo01;

        private int ChanCamSo02;

        private int ChanCamSo03;


        public PhichCam3Chan(int chanCamSo01, int chanCamSo02, int chanCamSo03)
        {
            this.ChanCamSo01 = chanCamSo01;
            this.ChanCamSo02 = chanCamSo02;
            this.ChanCamSo03 = chanCamSo03;
        }

        public int GetChanCamSo01()
        {
            return this.ChanCamSo01;
        }
        public int GetChanCamSo02()
        {
            return this.ChanCamSo02;
        }

        public int GetChanCamSo03()
        {
            return this.ChanCamSo03;
        }

        public bool Inject()
        {
            // kiểm tra 1: vì 01 có nghĩa là chân cắm đó hoạt động được.
            if( ChanCamSo02 != 1 || ChanCamSo01 != 1 || ChanCamSo03 != 1)     
            {
                // có một chân cắm không hoạt động;
                return false;
            }
            // tất cả đều hoạt động
            return true;
        }

        public void setChanCamSo01(int OnOff)
        {
            this.ChanCamSo01 = OnOff;
        }

        public void setChanCamSo02(int OnOff)
        {
            this.ChanCamSo02 = OnOff;
        }

        public void setChanCamSo03(int OnOff)
        {
            this.ChanCamSo03 = OnOff;
        }
    }
}
