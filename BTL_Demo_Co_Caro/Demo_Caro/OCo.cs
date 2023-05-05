using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Demo_Caro
{
    class OCo
    {
        public const int _ChieuRong = 25;
        public const int _ChieuCao = 25;
        private int _Dong;
        private int _Cot;

        public int Dong
        {
            get { return _Dong; }
            set { _Dong = value; }
        }
        public int Cot
        {
            get { return _Cot; }
            set { _Cot = value; }
        }
        private Point _ViTri;
        public Point ViTri
        {
            get { return _ViTri; }
            set { _ViTri = value; }
        }

        private int _SoHuu;
        public int SoHuu
        {
            get { return _SoHuu; }
            set { _SoHuu = value; }
        }
        public OCo(int dong, int cot, Point vitri, int sohuu)
        {
            _Dong = dong;
            _Cot = cot;
            _SoHuu = sohuu;
            _ViTri = vitri;
        }
        public OCo()
        {

        }
    }
}
