using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{

    /// <summary>
    /// 메모장 폼
    /// </summary>
    
    public partial class Form_memo : Form
    {
        //전역 변수1
        PrivateFontCollection privateFonts; //외부 폰트 적용을 위한 클래스

        public Form_memo()
        {
            InitializeComponent();

            //디자인 적용
            setIcon();
            fontLoad();
            setFont();
            setBackColor();

        }

        //전역 변수2
        private Boolean txtNoteChange; //내용 변경 체크
        private string fWord; //찾기 문자열
        private Form_find frmF; //'찾기' 폼 생성
        private int searchStartPosition = 0;
        private Form help;


        // <파일(F) 탭>
        /// 새로 만들기, 새 창, 열기, 저장, 다른 이름으로 저장
        /// 페이지 설정, 인쇄
        /// 끝내기


        //click

        private void 새로만들기NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.txtNoteChange == true) //문서가 변경되었다면
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";
                
                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //경고창 띄우기

                if (dlr == DialogResult.Yes) //저장하고 리셋
                {
                    textSave();
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
                else if (dlr == DialogResult.No) //저장 안 하고 리셋
                {
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
                else if (dlr == DialogResult.Cancel) //취소
                {
                    return;
                }
                else
                {
                    this.txtNote.ResetText();
                    this.Text = "제목 없음";
                    this.txtNoteChange = false;
                }
            }
            else //문서가 변경되지 않았다면
            {
                this.txtNote.ResetText();
                this.Text = "제목 없음";
                this.txtNoteChange = false;
            }

        }

        private void 새창WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_memo newForm = new Form_memo();
            newForm.Show();
        }


        private void 열기OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.txtNoteChange == true) //문서가 변경되었다면
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";

                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //경고창 띄우기

                if (dlr == DialogResult.Yes) //저장하고 오픈
                {
                    textSave();
                    textOpen();
                }
                else if (dlr == DialogResult.No) //저장 안 하고 오픈
                {
                    textOpen();
                }
                else if (dlr == DialogResult.Cancel) //취소
                {
                    return;
                }
            }
            else //문서가 변경되지 않았다면
            {
                textOpen();
            }
        }

        private void 저장SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textSave();
        }

        private void 다른이름으로저장AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlr = this.sfdFile.ShowDialog(); //save file dialog

            if (dlr != DialogResult.Cancel) //취소를 누르지 않았다면
            {
                var str = this.sfdFile.FileName; //파일 경로
                var sw = new StreamWriter(str, false, System.Text.Encoding.Default); //StreamWriter 생성자를 이용하여 개체 생성
                sw.Write(this.txtNote.Text); // Write 메서드를 이용하여 지정된 경로에 txtNote 컨트롤의 입력 문자열 저장
                sw.Flush();
                sw.Close();
                this.Text = str;
                this.txtNoteChange = false; //입력 데이터 입력 및 수정 초기화 
            }
        }

        private void 페이지설정UToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 인쇄PToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //폼 종료
        }

        //click END



        //함수

        private void textSave() //데이터 저장
        {
            if (this.Text == "제목 없음")
            {
                var dlr = this.sfdFile.ShowDialog(); //save file dialog

                if (dlr != DialogResult.Cancel) //취소를 누르지 않는다면
                {
                    var str = this.sfdFile.FileName;
                    var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                    sw.Write(this.txtNote.Text);
                    sw.Flush();
                    sw.Close();
                    this.Text = str;
                    this.txtNoteChange = false;
                }
            }
            else
            {
                var strt = this.Text;
                var sw = new StreamWriter(strt, false, System.Text.Encoding.Default);
                sw.Write(this.txtNote.Text);
                sw.Flush();
                sw.Close();
                this.Text = strt;
                this.txtNoteChange = false;
            }
        }


        private void textOpen() //열기
        {
            var dr = this.ofdFile.ShowDialog(); //open file dialog

            if (dr != DialogResult.Cancel) //취소를 누르지 않았다면
            {
                var str = this.ofdFile.FileName;
                var sr = new StreamReader(str, System.Text.Encoding.UTF8); //파일 불러올 때 깨져서 바꿈
                this.txtNote.Text = sr.ReadToEnd();
                sr.Close();
                this.Text = str;
                this.txtNoteChange = false;
            }
        }

        //함수 END

            // <파일(F) 탭> END



            // <편집(E) 탭>
        /// 실행 취소
        /// 잘라내기, 복사, 붙여넣기, 삭제
        /// Google로 검색, 찾기, 다음 찾기, 이전 찾기, 바꾸기, 이동
        /// 모두 선택, '시간/날짜'    

        private void 실행취소UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Undo(); //텍스트 박스의 변경사항을 취소하고 이전 상태로 되돌려줌
        }

        private void 잘라내기TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Cut(); //선택된 텍스트를 잘라낸다.
        }

        private void 복사CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Copy(); //선택된 텍스트를 복사한다.
        }

        private void 붙여넣기PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.Paste(); //텍스트 데이터 붙여넣기
        }

        private void 삭제LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.SelectedText = ""; //선택된 텍스트 지우기
        }

        private void google로검색SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txtNote.SelectionLength != 0) //선택이 되어 있다면
            {
                string search_str = this.txtNote.SelectedText.Replace(" ", "+");
                string target = "https://www.google.com/search?q=" + search_str + "&ie=UTF-8";

                try
                {
                    System.Diagnostics.Process.Start(target);
                }
                catch (System.ComponentModel.Win32Exception noBrowser)
                {
                    if (noBrowser.ErrorCode == -2147467259) { MessageBox.Show(noBrowser.Message); }
                }
                catch (System.Exception other)
                {
                    MessageBox.Show(other.Message);
                }
            }
        }

        private void 찾기FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!(frmF == null || !frmF.Visible)) //form_find가 정상적으로 보인다면
            {
                frmF.Focus();
                return;
            }
            frmF = new Form_find();

            if(this.txtNote.SelectionLength == 0) //텍스트가 선택되지 않았다면
            {
                frmF.txtWord.Text = this.fWord;
            }
            else //텍스트가 선택되었다면
            {
                frmF.txtWord.Text = this.txtNote.SelectedText;
            }
            frmF.btnOk.Click += new System.EventHandler(this.btnOk_Click); //찾기 폼의 ok 버튼 핸들러 만들기
            frmF.Show();
        }

        private void btnOk_Click(object sender, EventArgs e) //찾기 폼의 ok 버튼 클릭 이벤트
        {
            var updown = -1;
            var str = this.txtNote.Text; //본문 문자열
            var findWord = frmF.txtWord.Text; //찾을 문자열

            if (!frmF.chOption.Checked) //대소문자 체크 x
            {
                str = str.ToUpper(); //본문을 대문자로 변환
                findWord = findWord.ToUpper(); //찾을 문자열 대문자로 변환
            }

            if(frmF.rdb_up.Checked) //위쪽 체크
            {
                if (this.txtNote.SelectionStart != 0)
                {
                    updown = str.LastIndexOf(findWord, this.txtNote.SelectionStart - 1);
                }
            }
            else //아래쪽 체크
            {
                updown = str.IndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength);
            }

            if (updown == -1)
            {
                MessageBox.Show("더 이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.txtNote.Select(updown, findWord.Length);
            fWord = frmF.txtWord.Text;
            this.txtNote.Focus();
            this.txtNote.ScrollToCaret();
        }

        private void 다음찾기NpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(frmF == null || !frmF.Visible)) //form_find가 정상적으로 보인다면
            {
                frmF.txtWord.Text = this.fWord;
                this.btnOk_Click(this, null);
            }
        }

        private void 이전찾기VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fWord)) return;

            // Get the current selection start position
            int currentSelectionStart = this.txtNote.SelectionStart;

            // Calculate the startIndex to search for the text before the current selection
            int startIndex = (currentSelectionStart > fWord.Length) ? currentSelectionStart - fWord.Length : 0;

            // Perform the search
            int index = this.txtNote.Text.LastIndexOf(fWord, startIndex, StringComparison.CurrentCultureIgnoreCase);

            if (index != -1)
            {
                this.txtNote.Select(index, fWord.Length);
                searchStartPosition = index;
            }
            else
            {
                MessageBox.Show("더 이전에 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void 바꾸기RToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 이동GToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 모두선택AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.SelectAll(); //메모장의 텍스트 모두 선택
        }

        private void 시간날짜DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var time = DateTime.Now.ToShortTimeString(); //현재 시간 얻기 
            var date = DateTime.Today.ToShortDateString(); //오늘 날짜 얻기
            this.txtNote.AppendText(time + "/" + date); //입력 데이터 맨 뒤에 이어서 시간/날짜 정보 추가
        }

            // <편집(E) 탭> END




            // <서식(O) 탭>
        /// 자동 줄 바꿈, 글꼴 

        private void 자동줄바꿈WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtNote.WordWrap = !(this.txtNote.WordWrap);
            자동줄바꿈WToolStripMenuItem.Checked = !(자동줄바꿈WToolStripMenuItem.Checked);
        }

        private void 글꼴FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.fdText.ShowDialog() != DialogResult.Cancel) //폰트 다이알로그 호출
            {
                this.txtNote.Font = this.fdText.Font; //텍스트 박스 폰트 변경
            }
        }

            // <서식(O) 탭> END



            // <보기(V) 탭>
        /// '확대하기/축소하기'(확대, 축소, 확대축소 기본값 복원), 상태 표시줄

        private void 확대IToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 축소OToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 확대하기축소하기기본값복원ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 상태표시줄SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

            // <보기(V) 탭> END



            // <도움말(H) 탭>
        /// 도움말 보기
        /// 메모장 정보

        private void 도움말보기HToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 메모장정보AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            help = new Form_help();
            help.Show();
        }

            // <도움말(H) 탭> END




            // <txtNote>
        private void txtNote_TextChanged(object sender, EventArgs e)
        {
            this.txtNoteChange = true; //데이터 추가
        }

            // <txtNote> END



            // <Form_memo>
        private void Form_memo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

            if(this.txtNoteChange == true) //문서가 변경되었다면
            {
                var msg = this.Text + " 파일의 내용이 변경되었습니다. \r\n 변경된 내용을 저장하시겠습니까?";

                var dlr = MessageBox.Show(msg, "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning); //경고창 띄우기

                if (dlr == DialogResult.Yes) //
                {
                    if (this.Text == "제목 없음")
                    {
                        var dr = this.sfdFile.ShowDialog(); //save file dialog

                        if (dr != DialogResult.Cancel) //취소를 누르지 않는다면
                        {
                            var str = this.sfdFile.FileName;
                            var sw = new StreamWriter(str, false, System.Text.Encoding.Default);
                            sw.Write(this.txtNote.Text);
                            sw.Flush();
                            sw.Close();
                            this.Text = str;
                            this.txtNoteChange = false;
                        }
                    }
                    else
                    {
                        var strt = this.Text;
                        var sw = new StreamWriter(strt, false, System.Text.Encoding.Default);
                        sw.Write(this.txtNote.Text);
                        sw.Flush();
                        sw.Close();
                        this.Text = strt;
                        this.txtNoteChange = false;
                    }
                    this.Dispose();
                }
                else if (dlr == DialogResult.No)
                {
                    this.Dispose();
                }
                else if (dlr == DialogResult.Cancel)
                {
                    return;
                }

            }
            else //문서가 변경되지 않았다면
            {
                this.Dispose();
            }
        }

            // <Form_memo> END



            // <디자인 함수>
        /// 꾸미기 적용: 아이콘, 외부 폰트, rgb 색상

        private void setIcon() //아이콘 설정
        {
            this.Icon = Icon.ExtractAssociatedIcon("icon/notepad.ico");
        }

        private void fontLoad() //외부 폰트 로드
        {
            privateFonts = new PrivateFontCollection();

            //폰트 넣기
            privateFonts.AddFontFile("Fonts/SUITE-SemiBold.ttf"); //[1]
            privateFonts.AddFontFile("Fonts/SUITE-Regular.ttf"); //[0]
        }

        private void setFont() //폰트 설정
        {
            this.menuBar.Font = new Font(privateFonts.Families[1], 10f); //메뉴바 폰트 설정([1], 10point)
            this.txtNote.Font = new Font(privateFonts.Families[0], 12f); //노트 폰트 설정([0], 12point)
        }

        private void setBackColor() //백그라운드 컬러 설정
        {
            this.menuBar.BackColor = Color.FromArgb(155, 174, 200); //메뉴바 (연한 파란색)
            this.txtNote.BackColor = Color.FromArgb(217, 225, 232); //노트 (하늘색)
            //this.ssBar.BackColor = Color.FromArgb(40, 44, 55); //상태 표시줄(남색)
        }

            // <디자인 함수> END

    }
}
