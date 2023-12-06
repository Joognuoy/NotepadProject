namespace NotePad
{
    partial class Form_memo
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새로만들기NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.열기OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.저장SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다른이름으로저장AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.페이지설정UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.실행취소UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.잘라내기TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.복사CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.붙여넣기PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.삭제LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.google로검색SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.찾기FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다음찾기NpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이전찾기VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.바꾸기RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이동GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.모두선택AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.시간날짜DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.서식ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.자동줄바꿈WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.글꼴FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대하기축소하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.축소OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.확대하기축소하기기본값복원ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.상태표시줄SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말보기HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.메모장정보AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.fdText = new System.Windows.Forms.FontDialog();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdFile = new System.Windows.Forms.SaveFileDialog();
            this.ssBar = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLine = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelColumn = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelZoom = new System.Windows.Forms.ToolStripStatusLabel();
            this.pageSet = new System.Windows.Forms.PageSetupDialog();
            this.pDoc = new System.Drawing.Printing.PrintDocument();
            this.printDlg = new System.Windows.Forms.PrintDialog();
            this.menuBar.SuspendLayout();
            this.ssBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.서식ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuBar.Size = new System.Drawing.Size(784, 27);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새로만들기NToolStripMenuItem,
            this.새창WToolStripMenuItem,
            this.열기OToolStripMenuItem,
            this.저장SToolStripMenuItem,
            this.다른이름으로저장AToolStripMenuItem,
            this.toolStripSeparator1,
            this.페이지설정UToolStripMenuItem,
            this.인쇄PToolStripMenuItem,
            this.toolStripSeparator2,
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.파일ToolStripMenuItem.Text = "파일(F)";
            // 
            // 새로만들기NToolStripMenuItem
            // 
            this.새로만들기NToolStripMenuItem.Name = "새로만들기NToolStripMenuItem";
            this.새로만들기NToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.새로만들기NToolStripMenuItem.Text = "새로 만들기(N)";
            this.새로만들기NToolStripMenuItem.Click += new System.EventHandler(this.새로만들기NToolStripMenuItem_Click);
            // 
            // 새창WToolStripMenuItem
            // 
            this.새창WToolStripMenuItem.Name = "새창WToolStripMenuItem";
            this.새창WToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.새창WToolStripMenuItem.Text = "새 창(W)";
            this.새창WToolStripMenuItem.Click += new System.EventHandler(this.새창WToolStripMenuItem_Click);
            // 
            // 열기OToolStripMenuItem
            // 
            this.열기OToolStripMenuItem.Name = "열기OToolStripMenuItem";
            this.열기OToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.열기OToolStripMenuItem.Text = "열기(O)...";
            this.열기OToolStripMenuItem.Click += new System.EventHandler(this.열기OToolStripMenuItem_Click);
            // 
            // 저장SToolStripMenuItem
            // 
            this.저장SToolStripMenuItem.Name = "저장SToolStripMenuItem";
            this.저장SToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.저장SToolStripMenuItem.Text = "저장(S)";
            this.저장SToolStripMenuItem.Click += new System.EventHandler(this.저장SToolStripMenuItem_Click);
            // 
            // 다른이름으로저장AToolStripMenuItem
            // 
            this.다른이름으로저장AToolStripMenuItem.Name = "다른이름으로저장AToolStripMenuItem";
            this.다른이름으로저장AToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.다른이름으로저장AToolStripMenuItem.Text = "다른 이름으로 저장(A)...";
            this.다른이름으로저장AToolStripMenuItem.Click += new System.EventHandler(this.다른이름으로저장AToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(200, 6);
            // 
            // 페이지설정UToolStripMenuItem
            // 
            this.페이지설정UToolStripMenuItem.Name = "페이지설정UToolStripMenuItem";
            this.페이지설정UToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.페이지설정UToolStripMenuItem.Text = "페이지 설정(U)...";
            this.페이지설정UToolStripMenuItem.Click += new System.EventHandler(this.페이지설정UToolStripMenuItem_Click);
            // 
            // 인쇄PToolStripMenuItem
            // 
            this.인쇄PToolStripMenuItem.Name = "인쇄PToolStripMenuItem";
            this.인쇄PToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.인쇄PToolStripMenuItem.Text = "인쇄(P)...";
            this.인쇄PToolStripMenuItem.Click += new System.EventHandler(this.인쇄PToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(200, 6);
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기(X)";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 편집ToolStripMenuItem
            // 
            this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.실행취소UToolStripMenuItem,
            this.toolStripSeparator3,
            this.잘라내기TToolStripMenuItem,
            this.복사CToolStripMenuItem,
            this.붙여넣기PToolStripMenuItem,
            this.삭제LToolStripMenuItem,
            this.toolStripSeparator4,
            this.google로검색SToolStripMenuItem,
            this.찾기FToolStripMenuItem,
            this.다음찾기NpToolStripMenuItem,
            this.이전찾기VToolStripMenuItem,
            this.바꾸기RToolStripMenuItem,
            this.이동GToolStripMenuItem,
            this.toolStripSeparator5,
            this.모두선택AToolStripMenuItem,
            this.시간날짜DToolStripMenuItem});
            this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
            this.편집ToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.편집ToolStripMenuItem.Text = "편집(E)";
            // 
            // 실행취소UToolStripMenuItem
            // 
            this.실행취소UToolStripMenuItem.Name = "실행취소UToolStripMenuItem";
            this.실행취소UToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.실행취소UToolStripMenuItem.Text = "실행 취소(U)";
            this.실행취소UToolStripMenuItem.Click += new System.EventHandler(this.실행취소UToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(173, 6);
            // 
            // 잘라내기TToolStripMenuItem
            // 
            this.잘라내기TToolStripMenuItem.Name = "잘라내기TToolStripMenuItem";
            this.잘라내기TToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.잘라내기TToolStripMenuItem.Text = "잘라내기(T)";
            this.잘라내기TToolStripMenuItem.Click += new System.EventHandler(this.잘라내기TToolStripMenuItem_Click);
            // 
            // 복사CToolStripMenuItem
            // 
            this.복사CToolStripMenuItem.Name = "복사CToolStripMenuItem";
            this.복사CToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.복사CToolStripMenuItem.Text = "복사(C)";
            this.복사CToolStripMenuItem.Click += new System.EventHandler(this.복사CToolStripMenuItem_Click);
            // 
            // 붙여넣기PToolStripMenuItem
            // 
            this.붙여넣기PToolStripMenuItem.Name = "붙여넣기PToolStripMenuItem";
            this.붙여넣기PToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.붙여넣기PToolStripMenuItem.Text = "붙여넣기(P)";
            this.붙여넣기PToolStripMenuItem.Click += new System.EventHandler(this.붙여넣기PToolStripMenuItem_Click);
            // 
            // 삭제LToolStripMenuItem
            // 
            this.삭제LToolStripMenuItem.Name = "삭제LToolStripMenuItem";
            this.삭제LToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.삭제LToolStripMenuItem.Text = "삭제(L)";
            this.삭제LToolStripMenuItem.Click += new System.EventHandler(this.삭제LToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(173, 6);
            // 
            // google로검색SToolStripMenuItem
            // 
            this.google로검색SToolStripMenuItem.Name = "google로검색SToolStripMenuItem";
            this.google로검색SToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.google로검색SToolStripMenuItem.Text = "Google로 검색(S)...";
            this.google로검색SToolStripMenuItem.Click += new System.EventHandler(this.google로검색SToolStripMenuItem_Click);
            // 
            // 찾기FToolStripMenuItem
            // 
            this.찾기FToolStripMenuItem.Name = "찾기FToolStripMenuItem";
            this.찾기FToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.찾기FToolStripMenuItem.Text = "찾기(F)...";
            this.찾기FToolStripMenuItem.Click += new System.EventHandler(this.찾기FToolStripMenuItem_Click);
            // 
            // 다음찾기NpToolStripMenuItem
            // 
            this.다음찾기NpToolStripMenuItem.Name = "다음찾기NpToolStripMenuItem";
            this.다음찾기NpToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.다음찾기NpToolStripMenuItem.Text = "다음 찾기(N)";
            this.다음찾기NpToolStripMenuItem.Click += new System.EventHandler(this.다음찾기NpToolStripMenuItem_Click);
            // 
            // 이전찾기VToolStripMenuItem
            // 
            this.이전찾기VToolStripMenuItem.Name = "이전찾기VToolStripMenuItem";
            this.이전찾기VToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.이전찾기VToolStripMenuItem.Text = "이전 찾기(V)";
            this.이전찾기VToolStripMenuItem.Click += new System.EventHandler(this.이전찾기VToolStripMenuItem_Click);
            // 
            // 바꾸기RToolStripMenuItem
            // 
            this.바꾸기RToolStripMenuItem.Name = "바꾸기RToolStripMenuItem";
            this.바꾸기RToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.바꾸기RToolStripMenuItem.Text = "바꾸기(R)...";
            this.바꾸기RToolStripMenuItem.Click += new System.EventHandler(this.바꾸기RToolStripMenuItem_Click);
            // 
            // 이동GToolStripMenuItem
            // 
            this.이동GToolStripMenuItem.Name = "이동GToolStripMenuItem";
            this.이동GToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.이동GToolStripMenuItem.Text = "이동(G)...";
            this.이동GToolStripMenuItem.Click += new System.EventHandler(this.이동GToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(173, 6);
            // 
            // 모두선택AToolStripMenuItem
            // 
            this.모두선택AToolStripMenuItem.Name = "모두선택AToolStripMenuItem";
            this.모두선택AToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.모두선택AToolStripMenuItem.Text = "모두 선택(A)";
            this.모두선택AToolStripMenuItem.Click += new System.EventHandler(this.모두선택AToolStripMenuItem_Click);
            // 
            // 시간날짜DToolStripMenuItem
            // 
            this.시간날짜DToolStripMenuItem.Name = "시간날짜DToolStripMenuItem";
            this.시간날짜DToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.시간날짜DToolStripMenuItem.Text = "시간/날짜(D)";
            this.시간날짜DToolStripMenuItem.Click += new System.EventHandler(this.시간날짜DToolStripMenuItem_Click);
            // 
            // 서식ToolStripMenuItem
            // 
            this.서식ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.자동줄바꿈WToolStripMenuItem,
            this.글꼴FToolStripMenuItem});
            this.서식ToolStripMenuItem.Name = "서식ToolStripMenuItem";
            this.서식ToolStripMenuItem.Size = new System.Drawing.Size(60, 19);
            this.서식ToolStripMenuItem.Text = "서식(O)";
            // 
            // 자동줄바꿈WToolStripMenuItem
            // 
            this.자동줄바꿈WToolStripMenuItem.Checked = true;
            this.자동줄바꿈WToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.자동줄바꿈WToolStripMenuItem.Name = "자동줄바꿈WToolStripMenuItem";
            this.자동줄바꿈WToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.자동줄바꿈WToolStripMenuItem.Text = "자동 줄 바꿈(W)";
            this.자동줄바꿈WToolStripMenuItem.Click += new System.EventHandler(this.자동줄바꿈WToolStripMenuItem_Click);
            // 
            // 글꼴FToolStripMenuItem
            // 
            this.글꼴FToolStripMenuItem.Name = "글꼴FToolStripMenuItem";
            this.글꼴FToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.글꼴FToolStripMenuItem.Text = "글꼴(F)...";
            this.글꼴FToolStripMenuItem.Click += new System.EventHandler(this.글꼴FToolStripMenuItem_Click);
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대하기축소하기ToolStripMenuItem,
            this.상태표시줄SToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(59, 19);
            this.보기ToolStripMenuItem.Text = "보기(V)";
            // 
            // 확대하기축소하기ToolStripMenuItem
            // 
            this.확대하기축소하기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.확대IToolStripMenuItem,
            this.축소OToolStripMenuItem,
            this.확대하기축소하기기본값복원ToolStripMenuItem});
            this.확대하기축소하기ToolStripMenuItem.Name = "확대하기축소하기ToolStripMenuItem";
            this.확대하기축소하기ToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.확대하기축소하기ToolStripMenuItem.Text = "확대하기/축소하기";
            // 
            // 확대IToolStripMenuItem
            // 
            this.확대IToolStripMenuItem.Name = "확대IToolStripMenuItem";
            this.확대IToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.확대IToolStripMenuItem.Text = "확대(I)";
            this.확대IToolStripMenuItem.Click += new System.EventHandler(this.확대IToolStripMenuItem_Click);
            // 
            // 축소OToolStripMenuItem
            // 
            this.축소OToolStripMenuItem.Name = "축소OToolStripMenuItem";
            this.축소OToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.축소OToolStripMenuItem.Text = "축소(O)";
            this.축소OToolStripMenuItem.Click += new System.EventHandler(this.축소OToolStripMenuItem_Click);
            // 
            // 확대하기축소하기기본값복원ToolStripMenuItem
            // 
            this.확대하기축소하기기본값복원ToolStripMenuItem.Name = "확대하기축소하기기본값복원ToolStripMenuItem";
            this.확대하기축소하기기본값복원ToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.확대하기축소하기기본값복원ToolStripMenuItem.Text = "확대하기/축소하기 기본값 복원";
            this.확대하기축소하기기본값복원ToolStripMenuItem.Click += new System.EventHandler(this.확대하기축소하기기본값복원ToolStripMenuItem_Click);
            // 
            // 상태표시줄SToolStripMenuItem
            // 
            this.상태표시줄SToolStripMenuItem.Checked = true;
            this.상태표시줄SToolStripMenuItem.CheckOnClick = true;
            this.상태표시줄SToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.상태표시줄SToolStripMenuItem.Name = "상태표시줄SToolStripMenuItem";
            this.상태표시줄SToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.상태표시줄SToolStripMenuItem.Text = "상태 표시줄(S)";
            this.상태표시줄SToolStripMenuItem.Click += new System.EventHandler(this.상태표시줄SToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말보기HToolStripMenuItem,
            this.toolStripSeparator6,
            this.메모장정보AToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(72, 19);
            this.도움말ToolStripMenuItem.Text = "도움말(H)";
            // 
            // 도움말보기HToolStripMenuItem
            // 
            this.도움말보기HToolStripMenuItem.Name = "도움말보기HToolStripMenuItem";
            this.도움말보기HToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.도움말보기HToolStripMenuItem.Text = "도움말 보기(H)";
            this.도움말보기HToolStripMenuItem.Click += new System.EventHandler(this.도움말보기HToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(152, 6);
            // 
            // 메모장정보AToolStripMenuItem
            // 
            this.메모장정보AToolStripMenuItem.Name = "메모장정보AToolStripMenuItem";
            this.메모장정보AToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.메모장정보AToolStripMenuItem.Text = "메모장 정보(A)";
            this.메모장정보AToolStripMenuItem.Click += new System.EventHandler(this.메모장정보AToolStripMenuItem_Click);
            // 
            // txtNote
            // 
            this.txtNote.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtNote.Location = new System.Drawing.Point(0, 27);
            this.txtNote.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNote.Size = new System.Drawing.Size(784, 510);
            this.txtNote.TabIndex = 1;
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // ofdFile
            // 
            this.ofdFile.FileName = "openFileDialog1";
            this.ofdFile.Filter = "텍스트 파일(*.txt)|*.txt|모 든  파 일 (*.*)|*.*";
            // 
            // sfdFile
            // 
            this.sfdFile.FileName = "텍스트";
            this.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt|모 든  파 일 (*.*)|*.*";
            // 
            // ssBar
            // 
            this.ssBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLine,
            this.toolStripStatusLabelColumn,
            this.toolStripStatusLabelZoom});
            this.ssBar.Location = new System.Drawing.Point(0, 539);
            this.ssBar.Name = "ssBar";
            this.ssBar.Size = new System.Drawing.Size(784, 22);
            this.ssBar.TabIndex = 2;
            this.ssBar.Text = "statusStrip1";
            // 
            // toolStripStatusLabelLine
            // 
            this.toolStripStatusLabelLine.Name = "toolStripStatusLabelLine";
            this.toolStripStatusLabelLine.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabelLine.Text = "Ln 1,";
            // 
            // toolStripStatusLabelColumn
            // 
            this.toolStripStatusLabelColumn.DoubleClickEnabled = true;
            this.toolStripStatusLabelColumn.Name = "toolStripStatusLabelColumn";
            this.toolStripStatusLabelColumn.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabelColumn.Text = "Col 1";
            // 
            // toolStripStatusLabelZoom
            // 
            this.toolStripStatusLabelZoom.Name = "toolStripStatusLabelZoom";
            this.toolStripStatusLabelZoom.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabelZoom.Text = "100%";
            // pageSet
            // 
            this.pageSet.Document = this.pDoc;
            // 
            // pDoc
            // 
            this.pDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pDoc_PrintPage);
            // 
            // printDlg
            // 
            this.printDlg.Document = this.pDoc;
            this.printDlg.UseEXDialog = true;
            // 
            // Form_memo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ssBar);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.menuBar);
            this.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_memo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "제목 없음";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_memo_FormClosing);
            this.Load += new System.EventHandler(this.Form_memo_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ssBar.ResumeLayout(false);
            this.ssBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새로만들기NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 열기OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 저장SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장AToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 페이지설정UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 실행취소UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 잘라내기TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 복사CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 붙여넣기PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 삭제LToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem google로검색SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 찾기FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다음찾기NpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이전찾기VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 서식ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 바꾸기RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이동GToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 모두선택AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 시간날짜DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 자동줄바꿈WToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 글꼴FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대하기축소하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 축소OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 확대하기축소하기기본값복원ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 상태표시줄SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말보기HToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 메모장정보AToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.FontDialog fdText;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.SaveFileDialog sfdFile;
        private System.Windows.Forms.StatusStrip ssBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelZoom;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLine;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelColumn;
        private System.Windows.Forms.PageSetupDialog pageSet;
        private System.Drawing.Printing.PrintDocument pDoc;
        private System.Windows.Forms.PrintDialog printDlg;
    }
}

