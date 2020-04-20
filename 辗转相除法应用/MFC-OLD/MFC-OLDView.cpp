
// MFC-OLDView.cpp: CMFCOLDView 类的实现
//

#include "pch.h"
#include "framework.h"
// SHARED_HANDLERS 可以在实现预览、缩略图和搜索筛选器句柄的
// ATL 项目中进行定义，并允许与该项目共享文档代码。
#ifndef SHARED_HANDLERS
#include "MFC-OLD.h"
#endif

#include "MFC-OLDDoc.h"
#include "MFC-OLDView.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CMFCOLDView

IMPLEMENT_DYNCREATE(CMFCOLDView, CView)

BEGIN_MESSAGE_MAP(CMFCOLDView, CView)
	// 标准打印命令
	ON_COMMAND(ID_FILE_PRINT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_DIRECT, &CView::OnFilePrint)
	ON_COMMAND(ID_FILE_PRINT_PREVIEW, &CMFCOLDView::OnFilePrintPreview)
	ON_WM_CONTEXTMENU()
	ON_WM_RBUTTONUP()
END_MESSAGE_MAP()

// CMFCOLDView 构造/析构

CMFCOLDView::CMFCOLDView() noexcept
{
	// TODO: 在此处添加构造代码

}

CMFCOLDView::~CMFCOLDView()
{
}

BOOL CMFCOLDView::PreCreateWindow(CREATESTRUCT& cs)
{
	// TODO: 在此处通过修改
	//  CREATESTRUCT cs 来修改窗口类或样式

	return CView::PreCreateWindow(cs);
}

// CMFCOLDView 绘图

void CMFCOLDView::OnDraw(CDC* /*pDC*/)
{
	CMFCOLDDoc* pDoc = GetDocument();
	ASSERT_VALID(pDoc);
	if (!pDoc)
		return;

	// TODO: 在此处为本机数据添加绘制代码
}


// CMFCOLDView 打印


void CMFCOLDView::OnFilePrintPreview()
{
#ifndef SHARED_HANDLERS
	AFXPrintPreview(this);
#endif
}

BOOL CMFCOLDView::OnPreparePrinting(CPrintInfo* pInfo)
{
	// 默认准备
	return DoPreparePrinting(pInfo);
}

void CMFCOLDView::OnBeginPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 添加额外的打印前进行的初始化过程
}

void CMFCOLDView::OnEndPrinting(CDC* /*pDC*/, CPrintInfo* /*pInfo*/)
{
	// TODO: 添加打印后进行的清理过程
}

void CMFCOLDView::OnRButtonUp(UINT /* nFlags */, CPoint point)
{
	ClientToScreen(&point);
	OnContextMenu(this, point);
}

void CMFCOLDView::OnContextMenu(CWnd* /* pWnd */, CPoint point)
{
#ifndef SHARED_HANDLERS
	theApp.GetContextMenuManager()->ShowPopupMenu(IDR_POPUP_EDIT, point.x, point.y, this, TRUE);
#endif
}


// CMFCOLDView 诊断

#ifdef _DEBUG
void CMFCOLDView::AssertValid() const
{
	CView::AssertValid();
}

void CMFCOLDView::Dump(CDumpContext& dc) const
{
	CView::Dump(dc);
}

CMFCOLDDoc* CMFCOLDView::GetDocument() const // 非调试版本是内联的
{
	ASSERT(m_pDocument->IsKindOf(RUNTIME_CLASS(CMFCOLDDoc)));
	return (CMFCOLDDoc*)m_pDocument;
}
#endif //_DEBUG


// CMFCOLDView 消息处理程序
