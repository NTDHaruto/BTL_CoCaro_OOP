using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Caro
{
    public partial class frmCOCARO : Form
    {
        private CaroChess caroChess;
        private Graphics grs;
        public frmCOCARO()
        {
            InitializeComponent();
            caroChess = new CaroChess();
            grs = pnCOCARO.CreateGraphics();
            caroChess.KhoiTaoMangOCo();
        }

        private void frmCOCARO_Load(object sender, EventArgs e)
        {
            lbCHUCHAY.Text = "Luật chơi:\n" +
                "- Player nào đánh được 5 quân liên tiếp trước\n" +
                "sẽ thắng\n" +
                "- Nếu đã đủ 5 quân liên tiếp mà bị chặn 2 đầu\n" +
                "sẽ không tính là thắng cuộc\n" +
                "- Không được Undo khi là quân cờ đầu tiên\n" +
                "được đánh trên bàn cờ\n" +
                "_______________________________________\n" +
                "14 - 21133021 - Nguyễn Trọng Dũng \n" +
                "16 - 21133095 - Lê Thái Dương\n";
            tmCHUCHAY.Enabled = true;
            //caroChess.VeBanCo(grs);
        }

        private void tmCHUCHAY_Tick(object sender, EventArgs e)
        {
            lbCHUCHAY.Location = new Point(lbCHUCHAY.Location.X, lbCHUCHAY.Location.Y - 1);
            if (lbCHUCHAY.Location.Y + lbCHUCHAY.Height < 0)
            {
                lbCHUCHAY.Location = new Point(lbCHUCHAY.Location.X, pnCHUCHAY.Height);
            }
        }

        private void pnCOCARO_Paint(object sender, PaintEventArgs e)
        {
            caroChess.VeBanCo(grs);     
            caroChess.VeLaiQuanCo(grs);
        }

        private void pnCOCARO_MouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.SanSang)
            {
                MessageBox.Show("Hãy chọn chế độ chơi trước!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            caroChess.DanhCo(e.X, e.Y, grs);
            if(caroChess.Che_Do_Choi==1)
            {
                if (caroChess.Kiem_Tra_Chien_Thang(grs) == true)
                {
                    caroChess.Ket_Thuc_Tro_Choi();
                }
            }
            if(caroChess.Che_Do_Choi==2)
            {
                caroChess.Khoi_Dong_Computer_De(grs);
                if (caroChess.Kiem_Tra_Chien_Thang(grs) == true)
                {
                    caroChess.Ket_Thuc_Tro_Choi();
                }
            }
            if (caroChess.Che_Do_Choi == 3)
            {
                caroChess.KhoiDongComputer_Kho(grs);
                if (caroChess.Kiem_Tra_Chien_Thang(grs) == true)
                {
                    caroChess.Ket_Thuc_Tro_Choi();
                }
            }

        }

        private void onThisPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grs.Clear(pnCOCARO.BackColor);
            caroChess.StartPvPOnThisPC(grs);
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //grs.Clear(pnCOCARO.BackColor);
            if(caroChess.Che_Do_Choi==1)
            {
                caroChess.Undo(grs);
            }
            if(caroChess.Che_Do_Choi==2)
            {
                caroChess.Undo_In_PvC(grs);
            }
            if (caroChess.Che_Do_Choi == 3)
            {
                caroChess.Undo_In_PvC(grs);
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (caroChess.Che_Do_Choi == 1)
            {
                caroChess.Redo(grs);
            }
            if (caroChess.Che_Do_Choi == 2)
            {
                caroChess.Redo_In_PvC(grs);
            }
            if (caroChess.Che_Do_Choi == 3)
            {
                caroChess.Redo_In_PvC(grs);
            }
        }

        private void musicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMP3 MP3 = new frmMP3();
            MP3.Show();
            /*if (MP3.Enabled == false)
            {
                MP3.Close();
            }*/
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*private void playerVsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grs.Clear(pnCOCARO.BackColor);
            caroChess.StartPlayerVsComputer_De(grs);
        }*/


        private void hardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            grs.Clear(pnCOCARO.BackColor);
            caroChess.StartPlayerVsComputer_Kho(grs);
            MessageBox.Show("Yêu cầu click vào đúng ô cờ muốn đánh, nếu không sẽ phát sinh lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void easyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            grs.Clear(pnCOCARO.BackColor);
            caroChess.StartPlayerVsComputer_De(grs);
            MessageBox.Show("Yêu cầu click vào đúng ô cờ muốn đánh, nếu không sẽ phát sinh lỗi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
