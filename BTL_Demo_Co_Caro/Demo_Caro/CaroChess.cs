using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace Demo_Caro
{
    public enum ketthuc
    {
        HoaCo,
        Player1,
        Player2,
        Com,
        Player
    }
    class CaroChess
    {
        public static Pen pen;
        public static SolidBrush sbWhite;
        public static SolidBrush sbBlack;
        public static SolidBrush sbGreen;
        private OCo[,] _MangOCo;
        private BanCo _BanCo;
        private Stack<OCo> stack_CacNuocDaDi;
        private Stack<int> stack_LuuVetLuotDi;
        private Stack<OCo> stack_CacNuocUndo;
        private Stack<int> stack_LuuVetLuotDiUndo;
        private int _LuotDi;
        private bool _SanSang;
        private int _Che_Do_Choi;
        private ketthuc _Ket_Thuc;
        public bool SanSang
        {
            get { return _SanSang; }
            set { _SanSang = value; }
        }
        public int Che_Do_Choi 
        { 
            get
            {
                return this._Che_Do_Choi;
            }
            set
            {
                this._Che_Do_Choi = value;
            }
        }
        public CaroChess()
        {
            _BanCo = new BanCo(20, 20);
            _MangOCo = new OCo[_BanCo.SoDong, _BanCo.SoCot];
            pen = new Pen(Color.Black);
            sbWhite = new SolidBrush(Color.White);
            sbBlack = new SolidBrush(Color.Black);
            sbGreen = new SolidBrush(Color.SeaGreen);
            stack_CacNuocDaDi = new Stack<OCo>();
            stack_LuuVetLuotDi = new Stack<int>();
            stack_CacNuocUndo = new Stack<OCo>();
            stack_LuuVetLuotDiUndo = new Stack<int>();
            _LuotDi = 1;

        }
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }
        public void KhoiTaoMangOCo()
        {
            for (int i = 0; i < _BanCo.SoDong; i++)
            {
                for (int j = 0; j < _BanCo.SoCot; j++)
                {
                    _MangOCo[i, j] = new OCo(i, j, new Point(j * OCo._ChieuRong, i * OCo._ChieuCao), 0);
                }
            }
        }
        public bool DanhCo(int MouseX, int MouseY, Graphics g)
        {
            int Cot = MouseX / OCo._ChieuRong;
            int Dong = MouseY / OCo._ChieuCao;
            if (MouseX % OCo._ChieuRong == 0 || MouseY % OCo._ChieuCao == 0)
            {
                return false;
            }
            if (_MangOCo[Dong, Cot].SoHuu != 0)
            {
                return false;
            }
            switch (_LuotDi)
            {
                case 1:
                    _MangOCo[Dong, Cot].SoHuu = 1;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbBlack);
                    _LuotDi = 2;
                    stack_LuuVetLuotDi.Push(_LuotDi);
                    break;
                case 2:
                    _MangOCo[Dong, Cot].SoHuu = 2;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbWhite);
                    _LuotDi = 1;
                    stack_LuuVetLuotDi.Push(_LuotDi);
                    break;
                default:
                    MessageBox.Show("Đã có lỗi!", "Thông Báo", MessageBoxButtons.OK);
                    break;
            }
            OCo oco = new OCo(_MangOCo[Dong, Cot].Dong, _MangOCo[Dong, Cot].Cot, _MangOCo[Dong, Cot].ViTri, _MangOCo[Dong, Cot].SoHuu);
            stack_CacNuocDaDi.Push(oco);
            stack_CacNuocUndo = new Stack<OCo>();
            stack_LuuVetLuotDiUndo = new Stack<int>();
            return true;
        }
        public void VeLaiQuanCo(Graphics g)
        {
            foreach (OCo oco in stack_CacNuocDaDi)
            {
                if (oco.SoHuu == 1)
                {
                    _BanCo.VeQuanCo(g, oco.ViTri, sbBlack);
                }
                else if (oco.SoHuu == 2)
                {
                    _BanCo.VeQuanCo(g, oco.ViTri, sbWhite);
                }
            }
        }
        public void StartPvPOnThisPC(Graphics g)
        {
            _SanSang = true;
            stack_CacNuocDaDi = new Stack<OCo>();
            stack_LuuVetLuotDi = new Stack<int>();
            stack_CacNuocUndo = new Stack<OCo>();
            stack_LuuVetLuotDiUndo = new Stack<int>();
            _LuotDi = 1;
            _Che_Do_Choi = 1;
            KhoiTaoMangOCo();
            VeBanCo(g);

        }
        public void StartPlayerVsComputer_De(Graphics g)
        {
            _SanSang = true;
            stack_CacNuocDaDi = new Stack<OCo>();
            stack_LuuVetLuotDi = new Stack<int>();
            stack_CacNuocUndo = new Stack<OCo>();
            stack_LuuVetLuotDiUndo = new Stack<int>();
            _LuotDi = 1;
            _Che_Do_Choi = 2;
            KhoiTaoMangOCo();
            VeBanCo(g);
            Khoi_Dong_Computer_De(g);
        }
        public void StartPlayerVsComputer_Kho(Graphics g)
        {
            _SanSang = true;
            stack_CacNuocDaDi = new Stack<OCo>();
            stack_LuuVetLuotDi = new Stack<int>();
            stack_CacNuocUndo = new Stack<OCo>();
            stack_LuuVetLuotDiUndo = new Stack<int>();
            _LuotDi = 1;
            _Che_Do_Choi = 3;
            KhoiTaoMangOCo();
            VeBanCo(g);
            KhoiDongComputer_Kho(g);
        }

        #region Undo và Redo
        public void Undo(Graphics g)
        {
            if (stack_CacNuocDaDi.Count != 0)
            {
                if (stack_CacNuocDaDi.Count == 1)
                {
                    MessageBox.Show("Không thể Undo vì Luật Chơi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                OCo oco = stack_CacNuocDaDi.Pop();
                stack_CacNuocUndo.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                _BanCo.XoaQuanCo(g, oco.ViTri, sbGreen);
                int XoaLuotDiUndo = stack_LuuVetLuotDi.Pop();
                stack_LuuVetLuotDiUndo.Push(XoaLuotDiUndo);
                _LuotDi = stack_LuuVetLuotDi.Peek();
            }
            if (stack_CacNuocDaDi.Count == 0)
            {
                MessageBox.Show("Hãy tạo 1 Game mới!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*VeBanCo(g);
            VeLaiQuanCo(g);*/

        }
        public void Redo(Graphics g)
        {
            if (stack_CacNuocUndo.Count != 0)
            {
                OCo oco = stack_CacNuocUndo.Pop();
                stack_CacNuocDaDi.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = oco.SoHuu;
                _BanCo.VeQuanCo(g, oco.ViTri, oco.SoHuu == 1 ? sbBlack : sbWhite);
                int XoaLuotDiUndo = stack_LuuVetLuotDiUndo.Pop();
                stack_LuuVetLuotDi.Push(XoaLuotDiUndo);
                _LuotDi = stack_LuuVetLuotDi.Peek();
            }
            else
            {
                MessageBox.Show("Không thể Redo thêm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void Undo_In_PvC(Graphics g)
        {
            if (stack_CacNuocDaDi.Count != 0)
            {
                if (stack_CacNuocDaDi.Count == 1)
                {
                    MessageBox.Show("Không thể Undo vì Luật Chơi!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int i = 0;
                while(i<2)
                {
                    OCo oco = stack_CacNuocDaDi.Pop();
                    stack_CacNuocUndo.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                    _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                    _BanCo.XoaQuanCo(g, oco.ViTri, sbGreen);
                    int XoaLuotDiUndo = stack_LuuVetLuotDi.Pop();
                    stack_LuuVetLuotDiUndo.Push(XoaLuotDiUndo);
                    _LuotDi = stack_LuuVetLuotDi.Peek();
                    i++;
                }
            }
            if (stack_CacNuocDaDi.Count == 0)
            {
                MessageBox.Show("Hãy tạo 1 Game mới!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*VeBanCo(g);
            VeLaiQuanCo(g);*/

        }
        public void Redo_In_PvC(Graphics g)
        {
            if (stack_CacNuocUndo.Count != 0)
            {
                int i = 0;
                while(i<2)
                {
                    OCo oco = stack_CacNuocUndo.Pop();
                    stack_CacNuocDaDi.Push(new OCo(oco.Dong, oco.Cot, oco.ViTri, oco.SoHuu));
                    _MangOCo[oco.Dong, oco.Cot].SoHuu = oco.SoHuu;
                    _BanCo.VeQuanCo(g, oco.ViTri, oco.SoHuu == 1 ? sbBlack : sbWhite);
                    int XoaLuotDiUndo = stack_LuuVetLuotDiUndo.Pop();
                    stack_LuuVetLuotDi.Push(XoaLuotDiUndo);
                    _LuotDi = stack_LuuVetLuotDi.Peek();
                }
            }
            else
            {
                MessageBox.Show("Không thể Redo thêm!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Duyệt Chiến Thắng
        public void Ket_Thuc_Tro_Choi()
        {
            switch(_Ket_Thuc)
            {
                case ketthuc.HoaCo:
                    MessageBox.Show("Hòa Cờ!","Kết Thúc",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ketthuc.Player1:
                    MessageBox.Show("Player 1 Win!", "Kết Thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ketthuc.Player2:
                    MessageBox.Show("Player 2 Win!", "Kết Thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ketthuc.Com:
                    MessageBox.Show("Computer Win!", "Kết Thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case ketthuc.Player:
                    MessageBox.Show("Player Win!", "Kết Thúc", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            
            stack_CacNuocDaDi = new Stack<OCo>();
            _SanSang = false;
        }
        public bool Kiem_Tra_Chien_Thang(Graphics g)
        {
            if(stack_CacNuocDaDi.Count == _BanCo.SoDong*_BanCo.SoCot)
            {
                _Ket_Thuc = ketthuc.HoaCo;
                return true;
            }
            foreach(OCo oco in stack_CacNuocDaDi)
            {
                if(Duyet_Doc(oco.Dong,oco.Cot,oco.SoHuu)==true || Duyet_Ngang(oco.Dong, oco.Cot, oco.SoHuu)==true || Duyet_Cheo_Xuoi(oco.Dong, oco.Cot, oco.SoHuu)==true || Duyet_Cheo_Nguoc(oco.Dong, oco.Cot, oco.SoHuu)==true)
                {
                    if(_Che_Do_Choi==2)
                    {
                        Undo(g);
                        _Ket_Thuc = oco.SoHuu == 1 ? ketthuc.Com : ketthuc.Player;
                    }
                    else if(_Che_Do_Choi == 3)
                    {
                        Undo(g);
                        _Ket_Thuc = oco.SoHuu == 1 ? ketthuc.Com : ketthuc.Player;
                    }
                    else
                    {
                        _Ket_Thuc = oco.SoHuu == 1 ? ketthuc.Player1 : ketthuc.Player2;
                    }
                    return true;
                }
            }

            return false;
        }
        /*public bool Kiem_Tra_Chien_Thang_PvC()
        {
            if (stack_CacNuocDaDi.Count == _BanCo.SoDong * _BanCo.SoCot)
            {
                _Ket_Thuc = ketthuc.HoaCo;
                return true;
            }
            foreach (OCo oco in stack_CacNuocDaDi)
            {
                if (Duyet_Doc(oco.Dong, oco.Cot, oco.SoHuu) == true || Duyet_Ngang(oco.Dong, oco.Cot, oco.SoHuu) == true || Duyet_Cheo_Xuoi(oco.Dong, oco.Cot, oco.SoHuu) == true || Duyet_Cheo_Nguoc(oco.Dong, oco.Cot, oco.SoHuu) == true)
                {
                    _Ket_Thuc = oco.SoHuu == 1 ? ketthuc.Com : ketthuc.Player;
                    return true;
                }
            }
            return false;
        }*/
        private bool Duyet_Doc(int currentDong, int currentCot, int currentSoHuu)
        {
            if(currentDong> _BanCo.SoDong - 5)
            {
                return false;
            }
            int dem;
            for(dem=1;dem<5;dem++)
            {
                if (_MangOCo[currentDong+dem,currentCot].SoHuu!=currentSoHuu)
                {
                    return false;
                }
            }
            if(currentDong==0||currentDong+dem==_BanCo.SoDong)
            {
                return true;
            }
            if (_MangOCo[currentDong-1,currentCot].SoHuu==0 || _MangOCo[currentDong+dem,currentCot].SoHuu==0)
            {
                return true;
            }
            return false;
        }
        private bool Duyet_Ngang(int currentDong, int currentCot, int currentSoHuu)
        {
            if (currentCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int dem;
            for (dem = 1; dem < 5; dem++)
            {
                if (_MangOCo[currentDong, currentCot+dem].SoHuu != currentSoHuu)
                {
                    return false;
                }
            }
            if (currentCot == 0 || currentCot + dem == _BanCo.SoCot)
            {
                return true;
            }
            if (_MangOCo[currentDong, currentCot-1].SoHuu == 0 || _MangOCo[currentDong, currentCot + dem].SoHuu == 0)
            {
                return true;
            }
            return false;
        }
        private bool Duyet_Cheo_Xuoi(int currentDong, int currentCot, int currentSoHuu)
        {
            if (currentDong> _BanCo.SoDong - 5 || currentCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int dem;
            for (dem = 1; dem < 5; dem++)
            {
                if (_MangOCo[currentDong + dem, currentCot + dem].SoHuu != currentSoHuu)
                {
                    return false;
                }
            }
            if (currentDong == 0 || currentDong + dem == _BanCo.SoDong || currentCot == 0 || currentCot + dem == _BanCo.SoCot)
            {
                return true;
            }
            if (_MangOCo[currentDong - 1, currentCot - 1].SoHuu == 0 || _MangOCo[currentDong = dem, currentCot + dem].SoHuu == 0)
            {
                return true;
            }
            return false;
        }
        private bool Duyet_Cheo_Nguoc(int currentDong, int currentCot, int currentSoHuu)
        {
            if (currentDong < 4 || currentCot > _BanCo.SoCot - 5)
            {
                return false;
            }
            int dem;
            for (dem = 1; dem < 5; dem++)
            {
                if (_MangOCo[currentDong - dem, currentCot + dem].SoHuu != currentSoHuu)
                {
                    return false;
                }
            }
            if (currentDong == 4 || currentDong == _BanCo.SoDong - 1 || currentCot == 0 || currentCot + dem == _BanCo.SoCot)
            {
                return true;
            }
            if (_MangOCo[currentDong + 1, currentCot - 1].SoHuu == 0 || _MangOCo[currentDong - dem, currentCot + dem].SoHuu == 0)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region AI Easy
        private long[] _Mang_Diem_Tan_Cong = new long[7] { 0, 1, 1, 1, 1, 1, 1 };
        //0, 3, 24, 192, 1536, 12288, 98304 ( cấp độ 1 - dễ )
        //0, 9, 54, 162, 1458, 13112, 118008 ( cấp độ 2 - khó )
        //0, 1, 1, 1, 1, 1, 1 - máy ngu
        private long[] _Mang_Diem_Phong_Ngu = new long[7] { 0, 1, 1, 1, 1, 1, 1 };
        //0, 1, 9, 81, 729, 6561, 59049 ( cấp độ 1 - dễ )
        //0, 3, 27, 99, 729, 6561, 59049 ( cấp độ 2 - khó )

        public void Khoi_Dong_Computer_De(Graphics g)
        {
            if(stack_CacNuocDaDi.Count==0)
            {
                DanhCo((_BanCo.SoCot / 2) * OCo._ChieuCao + 1, (_BanCo.SoDong / 2) * OCo._ChieuRong + 1, g); 
            }
            else
            {
                OCo oco = Tim_Kiem_Nuoc_Di();
                DanhCo(oco.ViTri.X+1,oco.ViTri.Y+1,g);
            }
        }
        private OCo Tim_Kiem_Nuoc_Di()
        {
            OCo ocoResult = new OCo();
            long DiemMAX = 0;
            for(int i=0;i<_BanCo.SoDong; i++)
            {
                for(int j=0; j<_BanCo.SoCot;j++)
                {
                    if (_MangOCo[i,j].SoHuu==0)
                    {
                        long Diem_Tan_Cong = Diem_TC_DuyetDoc(i,j) + Diem_TC_DuyetNgang(i, j) + Diem_TC_DuyetCheoNguoc(i, j) + Diem_TC_DuyetCheoXuoi(i, j);
                        long Diem_Phong_Ngu = Diem_PN_DuyetDoc(i, j) + Diem_PN_DuyetNgang(i, j) + Diem_PN_DuyetCheoNguoc(i, j) + Diem_PN_DuyetCheoXuoi(i, j);
                        long Diem_Temp=Diem_Tan_Cong > Diem_Phong_Ngu ? Diem_Tan_Cong : Diem_Phong_Ngu;
                        if(DiemMAX < Diem_Temp)
                        {
                            DiemMAX = Diem_Temp;
                            ocoResult = new OCo(_MangOCo[i, j].Dong, _MangOCo[i, j].Cot, _MangOCo[i, j].ViTri, _MangOCo[i,j].SoHuu);
                        }
                    }
                }
            }
            return ocoResult;
        }
        #region Tấn Công

        private long Diem_TC_DuyetDoc(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for(int dem=1;dem<6&&curentDong+dem<_BanCo.SoDong;dem++)
            {
                if(_MangOCo[curentDong+dem,currentCot].SoHuu==1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong+dem,currentCot].SoHuu==2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && curentDong - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong - dem, currentCot].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong - dem, currentCot].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            if(SoQuanDich==2)
            {
                return 0;
            }
            DiemTong -= _Mang_Diem_Phong_Ngu[SoQuanDich+1];
            DiemTong += _Mang_Diem_Tan_Cong[SoQuanTa];

            return DiemTong;
        }
        private long Diem_TC_DuyetNgang(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && currentCot + dem < _BanCo.SoCot; dem++)
            {
                if (_MangOCo[curentDong, currentCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong, currentCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && currentCot - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong, currentCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong, currentCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            if (SoQuanDich == 2)
            {
                return 0;
            }
            DiemTong -= _Mang_Diem_Phong_Ngu[SoQuanDich + 1];
            DiemTong += _Mang_Diem_Tan_Cong[SoQuanTa];

            return DiemTong;
        }
        private long Diem_TC_DuyetCheoNguoc(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && curentDong - dem >= 0 && currentCot + dem < _BanCo.SoCot; dem++)
            {
                if (_MangOCo[curentDong - dem, currentCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong - dem, currentCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && curentDong + dem < _BanCo.SoDong && currentCot - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong + dem, currentCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong + dem, currentCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            if (SoQuanDich == 2)
            {
                return 0;
            }
            DiemTong -= _Mang_Diem_Phong_Ngu[SoQuanDich + 1];
            DiemTong += _Mang_Diem_Tan_Cong[SoQuanTa];

            return DiemTong;
        }
        private long Diem_TC_DuyetCheoXuoi(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && curentDong + dem < _BanCo.SoDong && currentCot + dem < _BanCo.SoCot; dem++)
            {
                if (_MangOCo[curentDong + dem, currentCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong + dem, currentCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && curentDong - dem >= 0 && currentCot - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong - dem, currentCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                }
                else if (_MangOCo[curentDong - dem, currentCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
            }
            if (SoQuanDich == 2)
            {
                return 0;
            }
            DiemTong -= _Mang_Diem_Phong_Ngu[SoQuanDich + 1];
            DiemTong += _Mang_Diem_Tan_Cong[SoQuanTa];

            return DiemTong;
        }
        #endregion

        #region Phòng Ngự
        private long Diem_PN_DuyetDoc(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && curentDong + dem < _BanCo.SoDong; dem++)
            {
                if (_MangOCo[curentDong + dem, currentCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong + dem, currentCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && curentDong - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong - dem, currentCot].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong - dem, currentCot].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            if (SoQuanTa == 2)
            {
                return 0;
            }
            DiemTong += _Mang_Diem_Phong_Ngu[SoQuanDich];

            return DiemTong;
        }
        private long Diem_PN_DuyetNgang(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && currentCot + dem < _BanCo.SoCot; dem++)
            {
                if (_MangOCo[curentDong, currentCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong, currentCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && currentCot - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong, currentCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong, currentCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            if (SoQuanTa == 2)
            {
                return 0;
            }
            DiemTong += _Mang_Diem_Phong_Ngu[SoQuanDich];

            return DiemTong;
        }
        private long Diem_PN_DuyetCheoNguoc(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && curentDong - dem >= 0 && currentCot + dem < _BanCo.SoCot; dem++)
            {
                if (_MangOCo[curentDong - dem, currentCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong - dem, currentCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && curentDong + dem < _BanCo.SoDong && currentCot - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong + dem, currentCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong + dem, currentCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            if (SoQuanDich == 2)
            {
                return 0;
            }
            DiemTong += _Mang_Diem_Phong_Ngu[SoQuanDich];

            return DiemTong;
        }
        private long Diem_PN_DuyetCheoXuoi(int curentDong, int currentCot)
        {
            long DiemTong = 0;
            int SoQuanTa = 0;
            int SoQuanDich = 0;
            for (int dem = 1; dem < 6 && curentDong + dem < _BanCo.SoDong && currentCot + dem < _BanCo.SoCot; dem++)
            {
                if (_MangOCo[curentDong + dem, currentCot + dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong + dem, currentCot + dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            for (int dem = 1; dem < 6 && curentDong - dem >= 0 && currentCot - dem >= 0; dem++)
            {
                if (_MangOCo[curentDong - dem, currentCot - dem].SoHuu == 1)
                {
                    SoQuanTa++;
                    break;
                }
                else if (_MangOCo[curentDong - dem, currentCot - dem].SoHuu == 2)
                {
                    SoQuanDich++;
                }
                else
                {
                    break;
                }
            }
            if (SoQuanDich == 2)
            {
                return 0;
            }
            DiemTong += _Mang_Diem_Phong_Ngu[SoQuanDich];

            return DiemTong;
        }
        #endregion

        #endregion


        #region AI Hard

        private long[] MangDiemTanCong = new long[7] { 0, 9, 54, 162, 1458, 13112, 118008 };
        private long[] MangDiemPhongNgu = new long[7] { 0, 3, 27, 99, 729, 6561, 59049 };
        public void KhoiDongComputer_Kho(Graphics g)
        {
            if (stack_CacNuocDaDi.Count == 0)
            {
                DanhCo(_BanCo.SoCot / 2 * OCo._ChieuRong + 1, _BanCo.SoDong / 2 * OCo._ChieuCao + 1, g);

            }
            else
            {
                OCo oCo = TimKiemNuocDi();
                DanhCo(oCo.ViTri.X + 1, oCo.ViTri.Y + 1, g);
            }
        }
        private OCo TimKiemNuocDi()
        {
            OCo oCoKetQua = new OCo();
            long DiemMax = 0;
            for (int i = 0; i < _BanCo.SoDong; i++)
            {
                for (int j = 0; j < _BanCo.SoCot; j++)
                {
                    if (_MangOCo[i, j].SoHuu == 0)
                    {
                        long DiemTanCong = DiemTC_DuyetDoc(i, j) + DiemTC_DuyetNgang(i, j) + DiemTC_DuyetCheoNguoc(i, j) + DiemTC_DuyetCheoXuoi(i, j);
                        long DiemPhongNgu = DiemPN_DuyetDoc(i, j) + DiemPN_DuyetNgang(i, j) + DiemPN_DuyetCheoNguoc(i, j) + DiemPN_DuyetCheoXuoi(i, j);
                        long DiemTam = DiemTanCong > DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if (DiemMax < DiemTam)
                        {
                            DiemMax = DiemTam;
                            oCoKetQua = new OCo(_MangOCo[i, j].Dong, _MangOCo[i, j].Cot, _MangOCo[i, j].ViTri, _MangOCo[i, j].SoHuu);
                        }
                    }
                }
            }
            return oCoKetQua;
        }
        private long DiemTC_DuyetDoc(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong + Dem, currCot].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            for (int Dem = 1; Dem < 6 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong - Dem, currCot].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            if (soQuanDich == 2)
                return 0;
            diemTong -= MangDiemPhongNgu[soQuanDich + 1];
            diemTong += MangDiemTanCong[soQuanTa];
            return diemTong;
        }
        private long DiemTC_DuyetNgang(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[currDong, currCot + Dem].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong, currCot + Dem].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong, currCot - Dem].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong, currCot - Dem].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            if (soQuanDich == 2)
                return 0;
            diemTong -= MangDiemPhongNgu[soQuanDich + 1];
            diemTong += MangDiemTanCong[soQuanTa];
            return diemTong;
        }
        private long DiemTC_DuyetCheoNguoc(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            if (soQuanDich == 2)
                return 0;
            diemTong -= MangDiemPhongNgu[soQuanDich + 1];
            diemTong += MangDiemTanCong[soQuanTa];
            return diemTong;
        }
        private long DiemTC_DuyetCheoXuoi(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 1)
                    soQuanTa++;
                else if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 2)
                {
                    soQuanDich++;
                    break;
                }
                else
                {
                    break;
                }
                soQuanDich++;
            }
            if (soQuanDich == 2)
                return 0;
            diemTong -= MangDiemPhongNgu[soQuanDich + 1];
            diemTong += MangDiemTanCong[soQuanTa];
            return diemTong;
        }
        private long DiemPN_DuyetDoc(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                {
                    break;
                }
            }
            if (soQuanTa == 2)
                return 0;
            diemTong += MangDiemPhongNgu[soQuanDich];
            return diemTong;
        }
        private long DiemPN_DuyetNgang(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[currDong, currCot + Dem].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong, currCot + Dem].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong, currCot - Dem].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong, currCot - Dem].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                {
                    break;
                }
            }
            if (soQuanDich == 2)
                return 0;
            diemTong += MangDiemPhongNgu[soQuanDich];
            return diemTong;
        }
        private long DiemPN_DuyetCheoNguoc(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot + Dem].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot - Dem].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                {
                    break;
                }
            }
            if (soQuanDich == 2)
                return 0;
            diemTong += MangDiemPhongNgu[soQuanDich];
            return diemTong;
        }
        private long DiemPN_DuyetCheoXuoi(int currDong, int currCot)
        {
            long diemTong = 0;
            int soQuanTa = 0;
            int soQuanDich = 0;
            for (int Dem = 1; Dem < 6 && currCot + Dem < _BanCo.SoCot && currDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong + Dem, currCot + Dem].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                {
                    break;
                }
            }
            for (int Dem = 1; Dem < 6 && currCot - Dem >= 0 && currDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 1)
                {
                    soQuanTa++;
                    break;
                }
                else if (_MangOCo[currDong - Dem, currCot - Dem].SoHuu == 2)
                {
                    soQuanDich++;
                }
                else
                {
                    break;
                }
            }

            if (soQuanDich == 2)
                return 0;
            diemTong += MangDiemPhongNgu[soQuanDich];
            return diemTong;
        }
        #endregion
    }
}
