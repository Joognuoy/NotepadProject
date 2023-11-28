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
    public partial class Form_change : Form
    {
        //전역 변수
        PrivateFontCollection privateFonts; //외부 폰트 적용을 위한 클래스

        public Form_change()
        {
            InitializeComponent();

            //디자인 적용
            fontLoad();
            setFont();
            setBackColor();

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
            this.lbl_find.Font = new Font(privateFonts.Families[0], 11f);
            this.lbl_change.Font = new Font(privateFonts.Families[0], 11f);
            this.txt_find.Font = new Font(privateFonts.Families[0], 11f);
            this.txt_change.Font = new Font(privateFonts.Families[0], 11f);
            this.btn_nxt.Font = new Font(privateFonts.Families[0], 11f);
            this.btn_change.Font = new Font(privateFonts.Families[0], 11f);
            this.btn_all_change.Font = new Font(privateFonts.Families[0], 11f);
            this.btn_cancel.Font = new Font(privateFonts.Families[0], 11f);
            this.ckbox.Font = new Font(privateFonts.Families[0], 11f);
        }

        private void setBackColor() //백그라운드 컬러 설정
        {
            this.BackColor = Color.FromArgb(217, 225, 232); //전체 배경 (하늘색)

            this.btn_nxt.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
            this.btn_change.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
            this.btn_all_change.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
            this.btn_cancel.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
        }

        // <디자인 함수> END
    }
}
