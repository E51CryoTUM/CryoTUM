// PpmsExternalDlg.cpp : implementation file
//

#include "stdafx.h"
#include "PpmsExternal.h"
#include "PpmsExternalDlg.h"

#include "ppmsuser.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif


long WM_ADVISORY = WM_USER + 0x0101;


/////////////////////////////////////////////////////////////////////////////
// CPpmsExternalDlg dialog

CPpmsExternalDlg::CPpmsExternalDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CPpmsExternalDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CPpmsExternalDlg)
	m_PpmsCommand = _T("");
	m_PpmsReply = _T("");
	m_AdvisoryReply = _T("");
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CPpmsExternalDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CPpmsExternalDlg)
	DDX_Text(pDX, IDC_EDIT1, m_PpmsCommand);
	DDX_Text(pDX, IDC_EDIT2, m_PpmsReply);
	DDX_Text(pDX, IDC_EDIT3, m_AdvisoryReply);
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CPpmsExternalDlg, CDialog)
	//{{AFX_MSG_MAP(CPpmsExternalDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_WM_CLOSE()
	//}}AFX_MSG_MAP
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CPpmsExternalDlg message handlers

BOOL CPpmsExternalDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here

	m_hAdvisory = RegisterForAdvisories( this->m_hWnd, WM_ADVISORY, 0 );
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CPpmsExternalDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CPpmsExternalDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}


void CPpmsExternalDlg::OnOK() 
{
	// TODO: Add extra validation here
	int device=15;              // device number
	char command[4096];        // command buffer
	long bytesToSend;          // size of command
	char response[4096];       // response buffer
	long responseSize=4096;    // sizeof response buffer
	long bytesRead;            // pointer to actual bytes read
	int pPpmsError;            // command error
	char errorStr[256];        // error string
	long errorSize=256;        // sizeof error string
	int swap=0;                // swap bytes (FALSE)
	DWORD mutexTimeout=10000;  // millisecond timeout for communication mutex

	UpdateData( TRUE );
	
	strcpy( command, m_PpmsCommand );
	bytesToSend = strlen( command );

	GpibSend( device, command, bytesToSend, response, responseSize,
		&bytesRead, &pPpmsError, errorStr, errorSize, swap,
		mutexTimeout );

	response[ bytesRead ] = 0;
	m_PpmsReply = response;

	UpdateData( FALSE );

}

void CPpmsExternalDlg::OnClose() 
{
	// TODO: Add your message handler code here and/or call default

	if ( !m_hAdvisory ) 
		UnregisterFromAdvisories( m_hAdvisory );
	
	CDialog::OnClose();
}


LRESULT CPpmsExternalDlg::WindowProc(UINT message, WPARAM wParam, LPARAM lParam) 
{
	// TODO: Add your specialized code here and/or call the base class
	
	// check for the Advisory message
	if (message == (UINT)WM_ADVISORY) 
		ProcessAdvisory(message, wParam, lParam);

	return CDialog::WindowProc(message, wParam, lParam);
}

void CPpmsExternalDlg::ProcessAdvisory(UINT message, WPARAM wParam, LPARAM lParam)
{
	int device=15;              // device number
	char command[4096];        // command buffer
	long bytesToSend;          // size of command
	char response[4096];       // response buffer
	long responseSize=4096;    // sizeof response buffer
	long bytesRead;            // pointer to actual bytes read
	int pPpmsError;            // command error
	char errorStr[256];        // error string
	long errorSize=256;        // sizeof error string
	int swap=0;                // swap bytes (FALSE)
	DWORD mutexTimeout=10000;  // millisecond timeout for communication mutex

	// pause the 6000 sequence until done processing (timeout = 1440 min)
	strcpy( command, "HOLDOFF 1 1440" );
	bytesToSend = strlen( command );

	GpibSend( device, command, bytesToSend, response, responseSize,
		&bytesRead, &pPpmsError, errorStr, errorSize, swap,
		mutexTimeout );


	// here is where the software will run it's measurements
	
	CString csTemp;
	csTemp.Format( "%s %ld %ld %ld", "Advisory message received ", message, wParam, lParam );
	m_AdvisoryReply = csTemp;
	UpdateData( FALSE );

	// resume the 6000 sequence
	strcpy( command, "HOLDOFF -1" );
	bytesToSend = strlen( command );

	GpibSend( device, command, bytesToSend, response, responseSize,
		&bytesRead, &pPpmsError, errorStr, errorSize, swap,
		mutexTimeout );

}
