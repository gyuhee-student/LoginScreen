# (C# 코딩) 로그인 스크린
## 개요
- C# 프로그래밍 학습
- 1줄 소개: 사용자의 아이디와 패스워드를 입력받는 로그인 화면
- 사용한 플랫폼:
	- C#, .NET Windows Forms, Visual Studio, GitHub
- 사용한 컨트롤:
	- Label (lblAppName, lblErrorMsg), TextBox (txtID, txtPW), Button (btnLogin)
- 사용한 기술과 구현한 기능:
	- Visual Studio를 이용하여 UI 디자인
	- string 클래스를 이용한 사용자 입력 데이터 처리
	- UseSystemPasswordChar를 이용하여 패스워드 입력 내용을 숨기는 기능 구현
	- Enter / Leave 이벤트를 이용한 Placeholder 기능 구현
	- TabIndex를 이용하여, 프로그램을 켰을 때 포커스가 btnLogin에 가도록 설정
	- Label.Visible 속성을 이용한 인라인 에러 메시지 표시/숨기기
	- KeyDown 이벤트와 e.SuppressKeyPress를 이용한 Enter키 포커스 흐름 제어



## 실행 화면 (과제1)
- 과제1 코드의 실행 스크린샷

![과제1 실행화면](img/work1_1.png)

![과제1 실행화면](img/work1_2.png)

![과제1 실행화면](img/work1_3.png)

- 과제 내용
	- Label(표시), TextBox(입력), Button(전송)을 적절히 배치합니다.
	- 아이디와 패스워드를 입력받아, 적절한지 확인합니다.
	- TextBox에 PlaceHolder 기능을 구현하여 안내 문구를 보여줍니다. 
	- 패스워드가 사용자에게 보이지 않도록 설정.


- 구현 내용과 기능 설명
	- TabIndex = 0을 btnLogin에 설정하여, 프로그램 시작 시 포커스가 btnLogin에 가도록 함.
	- txtID와 txtPW에 각각 Enter 이벤트 핸들러를 연결하여, 포커스가 들어올 때 Placeholder 텍스트("아이디", "패스워드")를 지우고 글자색을 검정으로 변경.
	- Leave 이벤트에서 string.IsNullOrWhiteSpace()로 빈 입력 여부를 확인하여, 비어있으면 Placeholder 텍스트와 은색 글자색을 복원.
	- txtPW는 포커스를 받을 때 UseSystemPasswordChar = true로 설정하고, 포커스를 잃고 빈 상태이면 false로 되돌려 Placeholder 텍스트가 보이도록 함.
	- myID = "admin", myPW = "superman"과 비교하여, && 연산자로 둘 다 일치할 때만 로그인 성공 메시지 박스를 띄움.
	- 로그인 실패 시 lblErrorMsg.Visible = true로 에러 메시지를 화면에 표시, 성공 시 false로 숨김.


## 실행 화면 (과제2)
- 과제2 코드의 실행 스크린샷
 
![과제2 실행화면](img/work2_1.png)

- 과제 내용
	- 로그인 성공 시 성공 메시지를 메시지 박스를 통해 표시.
	- 로그인 실패 시 실패 메시지를 표시함. 
	- 로그인 실패 후 다음 시도에서 성공한다면, 기존에 보이던 로그인 실패 메시지를 다시 안보이게 수정.
	- txtID에서 엔터를 치면 txtPW로, txtPW에서 엔터를 치면 btnLogin으로 포커스 이동.

- 구현 내용과 기능 설명
	- lblErrorMsg("아이디 또는 패스워드가 잘못되었습니다.")를 초기 Visible = false로 숨겨두고, 로그인 실패 시 true로 전환하여 화면에 표시.
	- 로그인 성공 시 MessageBox.Show("로그인 성공!")을 띄우고, 기존에 보이던 lblErrorMsg를 Visible = false로 다시 숨김.
	- txtID_KeyDown에서 Enter 입력 시 e.SuppressKeyPress = true로 비프음을 막고 txtPW.Focus()로 포커스 이동.
	- txtPW_KeyDown에서 Enter 입력 시 e.SuppressKeyPress = true로 비프음을 막고 btnLogin.PerformClick()으로 로그인 버튼 클릭 동작을 실행.
