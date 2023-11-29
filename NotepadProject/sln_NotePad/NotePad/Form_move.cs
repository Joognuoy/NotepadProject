using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form_move : Form
    {
        //전역 변수
        PrivateFontCollection privateFonts; //외부 폰트 적용을 위한 클래스

        public Form_move()
        {
            InitializeComponent();

            //디자인 적용
            fontLoad();
            setFont();
            setBackColor();
        }

        //key event
        private void txt_line_KeyPress(object sender, KeyPressEventArgs e) //숫자만 입력받기 위한 설정
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back))) //숫자와 백스페이스 제외 나머지
            {
                e.Handled = true; //이벤트가 처리되었는지를 나타내는 값 > true로 설정하면 작업을 안하고 건너 뜀
            }
        }

        //click
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 종료
        }



        // <디자인 함수>
        /// 꾸미기 적용: 외부 폰트, rgb 색상

        private void fontLoad() //외부 폰트 로드
        {
            privateFonts = new PrivateFontCollection();

            //폰트 넣기
            privateFonts.AddFontFile("Fonts/SUITE-Regular.ttf"); //[0]
        }

        private void setFont() //폰트 설정
        {
            this.lbl_line.Font = new Font(privateFonts.Families[0], 11f);
            this.txt_line.Font = new Font(privateFonts.Families[0], 11f);
            this.btn_move.Font = new Font(privateFonts.Families[0], 11f);
            this.btn_cancel.Font = new Font(privateFonts.Families[0], 11f);
        }

        private void setBackColor() //백그라운드 컬러 설정
        {
            this.BackColor = Color.FromArgb(217, 225, 232); //전체 배경 (하늘색)

            this.btn_move.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
            this.btn_cancel.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
        }

        // <디자인 함수> END
    }
}
