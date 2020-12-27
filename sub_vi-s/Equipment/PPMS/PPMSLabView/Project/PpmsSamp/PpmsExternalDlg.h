// PpmsExternalDlg.h : header file
//

#if !defined(AFX_PPMSEXTERNALDLG_H__2C20BED6_1FC5_11D5_81F9_00C04F59D1BF__INCLUDED_)
#define AFX_PPMSEXTERNALDLG_H__2C20BED6_1FC5_11D5_81F9_00C04F59D1BF__INCLUDED_

#if _MSC_VER > 1000
#pragma once
#endif // _MSC_VER > 1000



/////////////////////////////////////////////////////////////////////////////
// CPpmsExternalDlg dialog


class CPpmsExternalDlg : public CDialog
{
// Construction
public:
	CPpmsExternalDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	//{{AFX_DATA(CPpmsExternalDlg)
	enum { IDD = IDD_PPMSEXTERNAL_DIALOG };
	CString	m_PpmsCommand;
	CString	m_PpmsReply;
	CString	m_AdvisoryReply;
	//}}AFX_DATA

	// ClassWizard generated virtual function overrides
	//{{AFX_VIRTUAL(CPpmsExternalDlg)
	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support
	virtual LRESULT WindowProc(UINT message, WPARAM wParam, LPARAM lParam);
	//}}AFX_VIRTUAL

// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	//{{AFX_MSG(CPpmsExternalDlg)
	virtual BOOL OnInitDialog();
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	virtual void OnOK();
	afx_msg void OnClose();
	//}}AFX_MSG
	DECLARE_MESSAGE_MAP()
private:
	void ProcessAdvisory(UINT message, WPARAM wParam, LPARAM lParam);
	HANDLE m_hAdvisory;
};

//{{AFX_INSERT_LOCATION}}
// Microsoft Visual C++ will insert additional declarations immediately before the previous line.

#endif // !defined(AFX_PPMSEXTERNALDLG_H__2C20BED6_1FC5_11D5_81F9_00C04F59D1BF__INCLUDED_)
