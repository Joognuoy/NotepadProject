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
    public partial class Form_find : Form
    {
        //전역 변수
        PrivateFontCollection privateFonts; //외부 폰트 적용을 위한 클래스

        public Form_find()
        {
            InitializeComponent();
            fontLoad();
            setFont();
            setBackColor();
        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (this.txtWord.Text == "")
            {
                this.btnOk.Enabled = false; //버튼 비활성화 
            }
            else
            {
                this.btnOk.Enabled = true; //버튼 활성화 
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 종료
        }



        // <디자인 함수>
        /// 꾸미기 적용: 아이콘, 외부 폰트, rgb 색상

        private void fontLoad() //외부 폰트 로드
        {
            privateFonts = new PrivateFontCollection();

            //폰트 넣기
            privateFonts.AddFontFile("Fonts/SUITE-Regular.ttf"); //[0]
        }

        private void setFont() //폰트 설정
        {
            this.lblWord.Font = new Font(privateFonts.Families[0], 10f);
            this.txtWord.Font = new Font(privateFonts.Families[0], 10f);
            this.btnOk.Font = new Font(privateFonts.Families[0], 10f);
            this.btnCancel.Font = new Font(privateFonts.Families[0], 10f);
            this.chOption.Font = new Font(privateFonts.Families[0], 10f);
            this.groupBox.Font = new Font(privateFonts.Families[0], 10f);
            this.rdb_up.Font = new Font(privateFonts.Families[0], 10f);
            this.rdb_down.Font = new Font(privateFonts.Families[0], 10f);
        }

        private void setBackColor() //백그라운드 컬러 설정
        {
            this.BackColor = Color.FromArgb(217, 225, 232); //전체 배경 (하늘색)
            this.btnOk.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
            this.btnCancel.BackColor = Color.FromArgb(155, 174, 200); //버튼 (연한 파란색)
        }

        // <디자인 함수> END
    }
}
