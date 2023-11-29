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
        private string fWord; //찾기 문자열
        private string fWord_c; //바꾸기 폼에서 쓸 찾기 문자열
        private string cWord_c; //바꾸기 폼에서 쓸 바꾸기 문자열

        private Boolean txtNoteChange; //내용 변경 체크
        private Boolean fWordIs = false; //바꿀 문자열이 존재하는지
        private Boolean allchangeIs = false; //'모두 바꾸기' 버튼 클릭 여부

        private Form_find frmF; //'찾기' 폼 생성
        private Form_change frmC; //'바꾸기' 폼 생성
        private Form_move frmM; //'이동' 폼 생성


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
                    updown = str.LastIndexOf(findWord, this.txtNote.SelectionStart - 1); //last index of -> 지정 위치부터 역순 체크(마지막 단어 시작 위치 반환)
                }
            }
            else //아래쪽 체크
            {
                updown = str.IndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength); //index of -> 지정 위치부터 순서대로 체크(첫 단어 시작 위치 반환)

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

        }

        private void 바꾸기RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(frmC == null || !frmC.Visible)) //form_find가 정상적으로 보인다면
            {
                frmC.Focus();
                return;
            }

            frmC = new Form_change();

            if (this.txtNote.SelectionLength == 0) //텍스트가 선택되지 않았다면
            {
                frmC.txt_find.Text = this.fWord_c;
                frmC.txt_change.Text = this.cWord_c;
            }
            else //텍스트가 선택되었다면
            {
                frmC.txt_find.Text = this.txtNote.SelectedText;
                frmC.txt_change.Text = this.cWord_c;
            }

            //핸들러 만들기
            frmC.btn_nxt.Click += new System.EventHandler(this.btn_nxt_Click); //바꾸기 폼의 '다음 찾기' 버튼 핸들러 만들기
            frmC.btn_change.Click += new System.EventHandler(this.btn_change_Click); //바꾸기 폼의 '바꾸기' 버튼 핸들러 만들기
            frmC.btn_all_change.Click += new System.EventHandler(this.btn_all_change_Click); //바꾸기 폼의 '모두 바꾸기' 버튼 핸들러 만들기
            frmC.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click); //바꾸기 폼의 '모두 바꾸기' 버튼 핸들러 만들기

            frmC.Show();

        }

        // 바꾸기 핸들러

        private void btn_nxt_Click(object sender, EventArgs e) //바꾸기 폼의 '다음 찾기' 버튼 핸들러
        {
            var findIndex = -1; //찾을 문자열의 시작 인덱스(-1일 경우 == (존재 안 함 or empty))

            var str = this.txtNote.Text; //본문 문자열
            var findWord = frmC.txt_find.Text; //찾을 문자열

            if (!frmC.ckbox.Checked) //대소문자 체크 x
            {
                str = str.ToUpper(); //본문을 대문자로 변환
                findWord = findWord.ToUpper(); //찾을 문자열 대문자로 변환
            }

            findIndex = str.IndexOf(findWord, this.txtNote.SelectionStart + this.txtNote.SelectionLength); //index of -> 지정 위치부터 순서대로 체크(첫 단어 시작 위치 반환)

            if (findIndex == -1)
            {
                if(allchangeIs == false) //모두 바꾸기는 메시지 출력 x
                {
                    MessageBox.Show("더 이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                fWordIs = false; //존재하지 않음
                return;
            }

            fWordIs = true; //존재함

            this.txtNote.Select(findIndex, findWord.Length);
            fWord_c = frmC.txt_find.Text;
            this.txtNote.Focus();
            this.txtNote.ScrollToCaret();
        }

        private void btn_change_Click(object sender, EventArgs e) //바꾸기 폼의 '바꾸기' 버튼 핸들러
        {
            var changeWord = frmC.txt_change.Text; //바꿀 문자열
            var findWord = frmC.txt_find.Text; //찾을 문자열

            if (fWordIs == false) //바꿀 부분을 아직 찾지 않았다면
            {
                btn_nxt_Click(this, null); //바꿀 부분 찾기
                return;
            }

            //바꿀 부분이 선택되어 있다면
            var startIndex = this.txtNote.SelectionStart; //선택된 부분 첫번째 인덱스

            this.txtNote.SelectedText = ""; //선택된 텍스트 지우기

            this.txtNote.Text = this.txtNote.Text.Insert(startIndex, changeWord); //커서 있는 부분에 바꿀 문자열 추가

            btn_nxt_Click(this, null); //다음 바꿀 부분 찾기
            this.txtNote.Focus();

            //전역 변수 설정
            fWord_c = frmC.txt_find.Text;
            cWord_c = frmC.txt_change.Text;

        }

        private void btn_all_change_Click(object sender, EventArgs e) //바꾸기 폼의 '모두 바꾸기' 버튼 핸들러
        {
            allchangeIs = true; //'모두 바꾸기' 선택 여부 수정

            var changeWord = frmC.txt_change.Text; //바꿀 문자열
            var findWord = frmC.txt_find.Text; //찾을 문자열

            do
            {
                btn_nxt_Click(this, null); //바꿀 부분 찾기

                if(fWordIs == true)
                {
                    var startIndex = this.txtNote.SelectionStart; //선택된 부분 첫번째 인덱스

                    this.txtNote.SelectedText = ""; //선택된 텍스트 지우기

                    this.txtNote.Text = this.txtNote.Text.Insert(startIndex, changeWord); //커서 있는 부분에 바꿀 문자열 추가
                    this.txtNote.Select(startIndex, changeWord.Length); //선택하기
                }
                
            } while (fWordIs == true);

            //모두 바꾼 후 동작
            this.txtNote.Select(0, 0); //커서 위치 정비
            frmC.btn_all_change.Focus();

            //전역 변수 설정
            fWord_c = frmC.txt_find.Text;
            cWord_c = frmC.txt_change.Text;

            allchangeIs = false; //'모두 바꾸기' 선택 여부 초기화
        }


        private void btn_cancel_Click(object sender, EventArgs e) //바꾸기 폼의 '취소' 버튼 핸들러
        {
            //전역변수 초기화
            fWord_c = null; //바꾸기 폼에서 쓸 찾기 문자열
            cWord_c = null; //바꾸기 폼에서 쓸 바꾸기 문자열
            fWordIs = false; //바꿀 문자열이 존재하는지
            allchangeIs = false; //'모두 바꾸기' 버튼 클릭 여부

            frmC.Close();
        }

        // 바꾸기 핸들러 END

        private void 이동GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(frmM == null || !frmM.Visible)) //form_move가 정상적으로 보인다면
            {
                frmM.Focus();
                return;
            }
            frmM = new Form_move();

            //현재 커서 위치의 줄 번호 가져오기
            int line_num = this.txtNote.GetLineFromCharIndex(this.txtNote.SelectionStart) + 1; //0번부터 시작하므로 +1

            frmM.txt_line.Text = line_num.ToString(); //줄 번호 폼에 설정

            //핸들러 만들기
            frmM.btn_move.Click += new System.EventHandler(this.btn_move_Click); //바꾸기 폼의 '다음 찾기' 버튼 핸들러 만들기

            frmM.Show();

        }

        //이동 핸들러

        private void btn_move_Click(object sender, EventArgs e) //줄 이동 폼의 '이동' 버튼 핸들러
        {
            if (!(frmM == null || !frmM.Visible)) //form_move가 정상적으로 보인다면
            {
                int move_line = int.Parse(frmM.txt_line.Text); //이동할 라인 가져오기

                if (this.txtNote.GetLineFromCharIndex(this.txtNote.Text.Length) + 1 < move_line || move_line == 0) //입력된 라인수가 현재 존재하는 라인보다 많거나, 0인 경우
                {
                    if(move_line == 0)
                    {
                        MessageBox.Show("줄 번호는 0이 될 수 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    } else
                    {
                        MessageBox.Show("줄 번호가 전체 줄 수를 넘습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                    return;
                }

                //입력된 라인수가 올바른 경우
                int find_idx = 0;
                string str = this.txtNote.Text; //본문 가져오기

                this.txtNote.Select(0, 0); //커서 위치 정비

                if(move_line != 1) //첫줄은 커서 위치를 변경할 필요 없음
                {
                    for (int i = 1; i < move_line; i++) //원하는 줄 번호보다 1개 적은 개행문자를 만날 때까지
                    {
                        find_idx = str.IndexOf("\n", this.txtNote.SelectionStart); //index of -> 지정 위치부터 순서대로 체크
                        this.txtNote.SelectionStart = find_idx + 1;
                    }
                }
                this.txtNote.Focus();
            }
            
        }

        //이동 핸들러 END

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
