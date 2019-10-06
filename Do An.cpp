
// DSLK QLSV 3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include "pch.h"
#include <iostream>
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <string.h>
#include <Windows.h>
#include <fstream>
#include <time.h>
#include <iomanip>

using namespace std;


//cau truc mon hoc
struct MONHOC {
	char mmh[9];
	char tenmh[50];
	int sotc;
	float diem;
	char stt[5];
	
};

//cau truc 1 node trong danh sach mon hoc
typedef struct MH_node MH_ptr;
struct MH_node
{
	MONHOC MH;
	MH_ptr *next;
};

//cau truc danh sach mon hoc
typedef struct MH_ds DSMH_ptr;
struct MH_ds
{
	int MH_numnode;
	MH_ptr *MH_HEAD, *MH_TAIL;
};

// cau truc sinh vien
struct SINHVIEN {
	char Mssv[10];
	char Hoten[35];
	int ngay, thang, nam;
	DSMH_ptr MH_ds;
	int tongtc;
	int tctl;
	float tbc;
	float tbtl;
	char hdt[10];
	int hp;
	char lop[12];
	char nganh[25];
	int drl;
	char xlhl[20];
	char xldd[20];
};

// cau truc mot node trong danh sach sinh vien
typedef struct SV_node SV_ptr;
struct SV_node
{
	SINHVIEN SV;
	SV_ptr *next;
};
// cau truc danh sach sinh vien
typedef struct SV_ds DSSV_ptr;
struct SV_ds
{
	int SV_numnode;
	SV_ptr *SV_head, *SV_tail;
};
void taoDSMH(SV_node *&p);
void taoDSSV(DSSV_ptr *&List);
void taoTemp(DSSV_ptr *&List);
void nhapMH(SV_ptr *&MH_newnode);
void nhapSV(DSSV_ptr *&List);
void insv(SV_ptr *P);
void intt(SV_ptr *P);
void Output(DSSV_ptr* List); //xuat danh sach;
void Output2(SV_ptr *p);
void tinhdtb(SV_ptr *&p);
void lietkemax(DSSV_ptr* List);
float maxdtb(DSSV_ptr* List);
void XoaNode(DSSV_ptr *&List, SV_node *q);
void DelTail(DSSV_ptr *&List);
void xoatheoma(DSSV_ptr *&List, char x[]);
void AddHead(DSSV_ptr *&List, SV_ptr *P);
void AddTail(DSSV_ptr *&List, SV_ptr *P);
void AddTail2(SV_ptr *&P, MH_ptr *PMH);
void SXdtb1(DSSV_ptr *&List);
void SXdtb2(DSSV_ptr *&List);
void xethb(DSSV_ptr *&List);
void clc(DSSV_ptr *&List);
void tinhhp(DSSV_ptr *&List);
SV_ptr *timSV(DSSV_ptr *List, char x[]);
void SXmssv1(DSSV_ptr *&List);
void SXmssv2(DSSV_ptr *&List);
bool doctt(const char* filename, DSSV_ptr *&List);
bool doctt2(const char* filename, DSSV_ptr *&List);
bool ghitt(const char* filename, DSSV_ptr *&List);
void MENU(DSSV_ptr *&List);
void fix(char chuoi[]);
void dieuchinhdrl(SV_ptr *&P);
void xlhl(SV_ptr *&P);
void xldd(SV_ptr *&P);
void xeploai(DSSV_ptr *&List);
void DRL(DSSV_ptr *&List);
void indsrg(DSSV_ptr *List);
void indsrg2(DSSV_ptr *List);
void indiemso(SV_ptr *P);
void inhb(SV_ptr *P);
void TextColor(int color);
void ClearConsoleToColors(int ForgC, int BackC);
void chonmau(int &x, int &y);


int main()
{
	int x ;
	int y ;
	chonmau(x, y);
	system("cls");
	DSSV_ptr *List = new DSSV_ptr;
	taoDSSV(List);
	MENU(List);
}
void taoDSMH(SV_node *&p)
{
	p->SV.MH_ds.MH_numnode = 0;
	p->SV.MH_ds.MH_HEAD = NULL;
	p->SV.MH_ds.MH_TAIL = NULL;
}
void taoDSSV(DSSV_ptr *&List)
{
	List->SV_head = NULL;
	List->SV_tail = NULL;
	List->SV_numnode = 0;

}
void taoTemp(DSSV_ptr *&List)
{
	List->SV_head = NULL;
	List->SV_tail = NULL;
	List->SV_numnode = 0;
	SV_ptr *p;
	taoDSMH(p);

}
void nhapMH(SV_ptr *&MH_newnode)
{
	int temp = 1;
		MH_ptr *p = new MH_ptr;
		p->next = NULL;
		p->MH.sotc = 0;

		if (MH_newnode->SV.MH_ds.MH_numnode > 0)
		{
			MH_newnode->SV.MH_ds.MH_TAIL->next = p;
			MH_newnode->SV.MH_ds.MH_TAIL = p;

		}
		else
		{
			p->next = MH_newnode->SV.MH_ds.MH_HEAD;
			MH_newnode->SV.MH_ds.MH_HEAD = p;
			MH_newnode->SV.MH_ds.MH_TAIL = p;
		}

		cin.ignore();
		cout << "   " << temp << ".Ma mon hoc: ";
		cin.getline(p->MH.mmh, 9);
		cout << "    Ten mon hoc: ";
		cin.getline(p->MH.tenmh, 50);
		cout << "       So tin chi: ";
		cin >> p->MH.sotc;
		cout << "       Diem:";
		cin >> p->MH.diem;
		temp++;
		MH_newnode->SV.MH_ds.MH_numnode++;
		
}

void nhapSV(DSSV_ptr *&List)
{
	SV_ptr *SV_newnode = new SV_ptr;
	SV_newnode->next = NULL;
	
	cin.ignore();
	cout << "Nhap MSSV: " << endl;
	cin.getline(SV_newnode->SV.Mssv, 10);
	char tam[10];
	strcpy_s(tam, SV_newnode->SV.Mssv);
	SV_ptr * Ptemp = timSV(List, tam);

	if (Ptemp != NULL)
	{
		MessageBox(
			NULL,
			(LPCWSTR)L"Sinh vien da ton tai",
			(LPCWSTR)L"Bao loi",
			MB_OK | MB_ICONERROR);
		DelTail(List);
		return;
	}

	cout << "Nhap ho ten sinh vien: ";
	cin.getline(SV_newnode->SV.Hoten, 35);
	cout << "Nhap ngay/thang/nam sinh: ";
	cin >> SV_newnode->SV.ngay;
	cin >> SV_newnode->SV.thang;

	cin >> SV_newnode->SV.nam;
	cout << "Nhap lop: ";
	cin.ignore();
	cin.getline(SV_newnode->SV.lop, 12);
	cout << "Nhap nganh hoc: ";
	cin.getline(SV_newnode->SV.nganh, 25);
	cout << "Nhap diem ren luyen: ";
	cin >> SV_newnode->SV.drl;
	int somh;
	cout << "Nhap so mon hoc cua sinh vien: ";
	cin >> somh;
	taoDSMH(SV_newnode);
	for (int i = 0; i < somh; i++)
	{
		cout << "Nhap thong tin mon hoc thu " << i + 1 << " : " << endl;
		nhapMH(SV_newnode);

	}
	char tieptuc2;
	cout << endl << "Nhap them mon hoc? [Y/N]" << endl;
	cin >> tieptuc2;
	while (tieptuc2 == 'Y' || tieptuc2 == 'y')
	{
		nhapMH(SV_newnode);
		cout << endl << "Nhap them mon hoc? [Y/N]" << endl;
		cin >> tieptuc2;

	}
	if (List->SV_numnode > 0)
	{
		List->SV_tail->next = SV_newnode;
		List->SV_tail = SV_newnode;
	}
	else
	{
		SV_newnode->next = List->SV_head;
		List->SV_head = SV_newnode;
		List->SV_tail = SV_newnode;
	}
	List->SV_numnode++;
	tinhdtb(SV_newnode);
	clc(List);
	return;
	
	
}
void insv(SV_ptr *P)
{
	system("cls");
	cout << "                  ------------------------------------------------------" << endl;
	cout << "                  *****************/Thong tin sinh vien/****************" << endl;
	cout << "MSSV: " << P->SV.Mssv << endl;
	cout << "Ten sinh vien: " << P->SV.Hoten << endl;
	cout << "Ngay sinh: " << P->SV.ngay << "/" << P->SV.thang << "/" << P->SV.nam << endl;
	cout << "Lop: " << P->SV.lop << endl;
	cout << "He dao tao: " << P->SV.hdt << endl;
	Output2(P);
	cout << "----------------------------" << endl;
	cout << "Tong tin chi sinh vien dang ki: " << P->SV.tongtc << endl;
	cout << "Diem trung binh cua sinh vien: " << P->SV.tbc << endl;
	cout << "So tin chi tich luy: " << P->SV.tctl << endl;
	cout << "Diem trung binh tich luy: " << P->SV.tbtl << endl;
	cout << "Diem ren luyen: " << P->SV.drl<<endl;
	cout << "***********************" << endl;
	cout << endl;
}
void intt(SV_ptr *P)
{
	system("cls");
	cout << "------------------------------------------------------" << endl;
	cout << "Thong tin sinh vien: " << endl;
	cout.width(15);
	cout << left << "MSSV: ";
	cout.width(25);
	cout <<left<< "Ten sinh vien: "  ;
	cout.width(25);
	cout <<left << "Ngay sinh: " ;
	cout.width(15);
	cout <<left << "Lop: " ;
	cout.width(15);
	cout << left<< "He dao tao: ";
	cout << endl;

	cout.width(15);
	cout << left << P->SV.Mssv;
	cout.width(25);
	cout << left << P->SV.Hoten;
	cout << left <<setw(2)<< P->SV.ngay<<left<<setw(1)<<"/"<<left<<setw(2)<< P->SV.thang<<left<<setw(1)<< "/"<< left<<setw(19)<<P->SV.nam;
	cout.width(15);
	cout << left << P->SV.lop;
	cout.width(15);
	cout << left << P->SV.nganh;
	cout << endl;
}
void inhb(SV_ptr *P)
{
	cout.width(15);
	cout << left << "MSSV: ";
	cout.width(25);
	cout << left << "Ten sinh vien: ";
	cout.width(25);
	cout << left << "Ngay sinh: ";
	cout.width(15);
	cout << left << "Lop: ";
	cout.width(25);
	cout << left << "He dao tao: ";
	cout.width(15);
	cout << left << "Diem TB";
	cout.width(15);
	cout << left << "Diem ren luyen";
	cout << endl;

	cout.width(15);
	cout << left << P->SV.Mssv;
	cout.width(25);
	cout << left << P->SV.Hoten;
	cout << left << setw(2) << P->SV.ngay << left << setw(1) << "/" << left << setw(2) << P->SV.thang << left << setw(1) << "/" << left << setw(19) << P->SV.nam;
	cout.width(15);
	cout << left << P->SV.lop;
	cout.width(25);
	cout << left << P->SV.nganh;
	cout.width(15);
	cout << left << P->SV.tbc;
	cout.width(15);
	cout << left << P->SV.drl;
	cout << endl;
}
void indiemso(SV_ptr *P)
{
	MH_ptr *PMH = new MH_ptr;
	PMH = P->SV.MH_ds.MH_HEAD;
	cout << "                                   *************Bang Diem**************" << endl;
	while (PMH != NULL)
	{
		if (PMH->MH.diem > 5)
		{
			strcpy_s(PMH->MH.stt, "PASS");
		}
		else
		{
			strcpy_s(PMH->MH.stt, "FAIL");
		}
		cout.width(15);
		cout << left << "Ma mon hoc : ";
		cout.width(25);
		cout << left << "Ten mon hoc: ";
		cout.width(15);
		cout << left << "So tin chi: ";
		cout.width(5);
		cout << left << "Diem: ";
		cout.width(5);
		cout << endl;

		cout.width(15);
		cout << left <<PMH->MH.mmh;
		cout.width(25);
		cout << left << PMH->MH.tenmh;
		cout.width(15);
		cout << left << PMH->MH.sotc;
		cout.width(5);
		cout << left <<PMH->MH.diem;
		cout.width(5);
		cout << left << PMH->MH.stt;
		cout << endl;
		PMH = PMH->next;
	}
}


void Output2(SV_ptr *p)
{
	MH_ptr *PMH = new MH_ptr;
	PMH = p->SV.MH_ds.MH_HEAD;
	while (PMH != NULL)
	{
		cout << "***********************" << endl;
		cout << "Ma mon hoc: " << PMH->MH.mmh << endl;
		cout << "Ten mon hoc: " << PMH->MH.tenmh << endl;
		cout << "So tin chi: " << PMH->MH.sotc << endl;
		cout << "Diem: " << PMH->MH.diem << endl;
		PMH = PMH->next;
	}
	PMH = p->SV.MH_ds.MH_TAIL;
	cout << "***********************" << endl;
}
void Output(DSSV_ptr* List) //xuat danh sach
{
	
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	while (P != NULL)
	{
		
		cout << "----------------------------------------------------" << endl;
		cout << "Thong tin sinh vien: " << endl;
		cout << "MSSV: " << P->SV.Mssv << endl;
		cout << "Ten sinh vien: " << P->SV.Hoten << endl;
		cout << "Ngay sinh: " << P->SV.ngay << "/" << P->SV.thang << "/" << P->SV.nam << endl;
		Output2(P);
		cout << "----------------------------" << endl;
		cout << "Tong tin chi sinh vien dang ki: " << P->SV.tongtc<< endl;
		cout << "Diem trung binh cua sinh vien: " << P->SV.tbc << endl;
		cout <<"So tin chi tich luy: "<< P->SV.tctl << endl;
		cout << "Diem trung binh tich luy: " << P->SV.tbtl << endl;
		cout << "Diem ren luyen: " << P->SV.drl << endl;
		cout << "***********************" << endl;
		P = P->next;
	}
	cout << "----------------------------" << endl;
	printf("\n");

	delete(P);
}

void tinhdtb(SV_ptr *&P)
{
	
	MH_ptr *mh_ptr = new MH_ptr;
	mh_ptr = P->SV.MH_ds.MH_HEAD;
	float sum = 0;
	float sum2 = 0;
	int tongtc = 0;
	int tctl = 0;
	while (mh_ptr != NULL)
	{
		sum += mh_ptr->MH.diem * mh_ptr->MH.sotc;
		tongtc += mh_ptr->MH.sotc;
		if (mh_ptr->MH.diem > 5)
		{
			sum2 += mh_ptr->MH.diem * mh_ptr->MH.sotc;
			tctl += mh_ptr->MH.sotc;
		}
		mh_ptr = mh_ptr->next;
	}
	P->SV.tongtc = tongtc;
	P->SV.tbc = sum / tongtc;
	P->SV.tctl = tctl;
	P->SV.tbtl = sum2 / tctl;
	delete mh_ptr;
}
void lietkemax(DSSV_ptr *List)
{
	system("cls");
	SV_ptr *P = List->SV_head;
	float max = maxdtb(List);
	cout << "                                   ****************SINH VIEN DAT HANG NHAT**************" << endl;
	cout << "                                   -----------------------------------------------------" << endl;
	while (P != NULL)
	{
		if (P->SV.tbc == max) inhb(P);
		P = P->next;
	}
	delete P;
}	  
float maxdtb(DSSV_ptr *List)
{
	SV_ptr *P = List->SV_head;
	float max = P->SV.tbc;
	while (P != NULL)
	{
		if (P->SV.tbc > max) max = P->SV.tbc;
		P = P->next;
	}
	delete P;
	return max;
}
void XoaNode(DSSV_ptr *&List, SV_node *q)
{
	SV_ptr *P = q->next;
	if (P == NULL) cout << "Khong xoa duoc!";
	else
	{
		q->next = P->next;
		if (P == List->SV_tail) List->SV_tail = q;
		delete P;
	}
}
void xoatheoma(DSSV_ptr *&List, char x[])
{
	SV_ptr *P, *q;
	int dem = 0;
	P = List->SV_head;
	q = NULL;
	while (P != NULL)
	{
		if (strcmp(x, P->SV.Mssv) == 0)
		{
			dem++;
			break;
		}
		
		q = P;
		P = P->next;

	}
	if (q != NULL)
	{
		if (P != NULL)
		{
			XoaNode(List, q);
		}
	}
	else
	{
		List->SV_head = P->next;
		delete(P);
		if (List->SV_head == NULL)  List->SV_tail = NULL;
	}
	if (dem == 0)
	{
		MessageBox(
			NULL,
			(LPCWSTR)L"Khong tim thay sinh vien",
			(LPCWSTR)L"Bao loi",
			MB_OK | MB_ICONERROR);

	}
	else
	{
		MessageBox(
			NULL,
			(LPCWSTR)L"Da xoa sinh vien !!",
			(LPCWSTR)L"Thong bao",
			MB_OK | MB_ICONINFORMATION);
	}
}
void AddHead(DSSV_ptr *&List, SV_ptr *P)
{
	if (List->SV_head == NULL)
	{
		List->SV_head = List->SV_tail = P;
	}
	else
	{
		P->next = List->SV_head;
		List->SV_head = P;
	}
}
void AddTail(DSSV_ptr *&List,SV_ptr *P)
{
	if (List->SV_head == NULL)
	{
		List->SV_head = List->SV_tail = P;
	}
	else
	{
		List->SV_tail->next = P;
		List->SV_tail = P;
	}
}
void AddTail2(SV_ptr *&P, MH_ptr *PMH)
{
	if (P->SV.MH_ds.MH_HEAD == NULL)
	{
		P->SV.MH_ds.MH_HEAD = P->SV.MH_ds.MH_TAIL = PMH;
	}
	else
	{
		P->SV.MH_ds.MH_TAIL->next = PMH;
		P->SV.MH_ds.MH_TAIL = PMH;
	}
}
/*void QuickSort(DSSV_ptr *&List)
{
	DSSV_ptr *L1,*L2 = new DSSV_ptr;
	SV_ptr *tag, *p;
	if (List->SV_head == List->SV_tail) return;
	taoDSSV(L1);
	taoDSSV(L2);
	tag = List->SV_head;
	List->SV_head = List->SV_head->next;
	tag->next = NULL;
	while (List->SV_head != NULL)
	{
		p = List->SV_head;
		List->SV_head = List->SV_head ->next;
		p->next = NULL;
		if (p->SV.tbc <= tag->SV.tbc) AddHead(L1, p);
		else AddHead(L2, p);
	}
	QuickSort(L1);
	QuickSort(L2);
	if (L1->SV_head != NULL)
	{
		List->SV_head = L1->SV_head;
		L1->SV_tail->next = tag;
	}
	else List->SV_head = tag;
	tag->next = L2->SV_head;
	if (L2->SV_head != NULL) List->SV_tail = L2->SV_tail;
	else List->SV_tail = tag;
}*/
void SXdtb1(DSSV_ptr *&List)
{
	SV_ptr *p, *q, *min;
	p = List->SV_head;
	SINHVIEN temp;
	while (p != List->SV_tail)
	{
		min = p;
		q = p->next;
		while (q != NULL)
		{
			if (q->SV.tbc < min->SV.tbc)  min = q;
			q = q->next;
		}
		temp = p->SV;
		p->SV = min->SV;
		min->SV = temp;
		p = p->next;
	}
}
void SXdtb2(DSSV_ptr *&List)
{
	SV_ptr *p, *q, *max;
	p = List->SV_head;
	SINHVIEN temp;
	while (p != List->SV_tail)
	{
		max = p;
		q = p->next;
		while (q != NULL)
		{
			if (q->SV.tbc > max->SV.tbc)  max = q;
			q = q->next;
		}
		temp = p->SV;
		p->SV = max->SV;
		max->SV = temp;
		p = p->next;
	}
}

/*void tachten(SV_ptr *p,char ten[])
{
	char hoten[35];
	int l = strlen(p->SV.Hoten);
	for (int i = 0; i < l; i++)
	{
		hoten[i] = p->SV.Hoten[i];
	}
	
	for (int i = l - 1; i >= 0; i--)
	{
		if (hoten[i] == ' ')
		{
			cout << "1" << endl;
			strcpy_s(ten,i+ 1,hoten);
		}
	}
}*/
void xethb(DSSV_ptr *&List)
{
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	system("cls");
	cout << "                                  ********DANH SACH SINH VIEN DU DIEU KIEN XET HOC BONG************" << endl;
	cout << "                                  -----------------------------------------------------------------" << endl;
	while (P != NULL)
	{
		if (P->SV.tongtc != P->SV.tctl)
		{
			P = P->next;
		}
		else if (P->SV.tbc < 7)
		{
			P = P->next;
			
		}
		else
		{
			inhb(P);
			P = P->next;
		}
	}

}
void clc(DSSV_ptr *&List)
{
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;

	while (P != NULL)
	{
		
		for (int i = 0; i < strlen(P->SV.lop) -1;i++)
		{
			if (P->SV.lop[i] == 'C' && P->SV.lop[i + 1] == 'L')
			{
				strcpy_s(P->SV.hdt,"CLC");
				break;

			}
			strcpy_s(P->SV.hdt, "DAI TRA");
			
		}
		P = P->next;
	}
}
void tinhhp(DSSV_ptr *&List)
{

	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	while (P != NULL)
	{
		if (P->SV.hdt == "CLC")
		{
			P->SV.hp = 666000 * P->SV.tongtc;
		}
		else
		{
			P->SV.hp = 453000 * P->SV.tongtc;
		}
		P = P->next;
	}
}
SV_ptr *timSV (DSSV_ptr *List,char x[])
{
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	while (P != NULL)
	{
		if (strcmp(x,P->SV.Mssv) == 0)
		{
			return P;
		}
		P = P->next;
	}
	return NULL;
}
SV_ptr *GetNode(SINHVIEN a)
{
	SV_ptr *P = new SV_ptr;
	if (P == NULL)
	{
		return NULL;
	}
	P->SV = a;
	P->next = NULL;
	return P;

}
MH_ptr *GetNode2(MONHOC b)
{
	MH_ptr *PMH = new MH_ptr;
	if (PMH == NULL)
	{
		return NULL;
	}
	PMH->MH = b;
	PMH->next = NULL;
	return PMH;
}
void SXmssv1(DSSV_ptr *&List)
{
	SV_ptr *p, *q, *min;
	p = List->SV_head;
	SINHVIEN temp;
	while (p != List->SV_tail)
	{
		min = p;
		q = p->next;
		while (q != NULL)
		{
			if (strcmp(q->SV.Mssv,min->SV.Mssv) == -1)  min = q;
			q = q->next;
		}
		temp = p->SV;
		p->SV = min->SV;
		min->SV = temp;
		p = p->next;
	}
}
void SXmssv2(DSSV_ptr *&List)
{
	SV_ptr *p, *q, *max;
	p = List->SV_head;
	SINHVIEN temp;
	while (p != List->SV_tail)
	{
		max = p;
		q = p->next;
		while (q != NULL)
		{
			if (strcmp(q->SV.Mssv, max->SV.Mssv) == 1)  max = q;
			q = q->next;
		}
		temp = p->SV;
		p->SV = max->SV;
		max->SV = temp;
		p = p->next;
	}
}
void DRL(DSSV_ptr *&List)
{
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	while (P != NULL)
	{
		if (P->SV.tbc >= 8.5)
		{
			P->SV.drl = 65 ;
		}
		else if (P->SV.tbc < 8.5 && P->SV.tbc > 7)
		{
			P->SV.drl = 60;
		}
		else
		{
			P->SV.drl = 55;
		}
		P = P->next;
	}
}

void MENU(DSSV_ptr *&List)
{
	
	int select;
	cout << "                                     *******CHUONG TRINH QUAN LI SINH VIEN********" << endl;
	cout << "                                     *********************************************" << endl ;
	cout << "                                     --------------------/MENU/-------------------" << endl<<endl;
	cout << "1. Nhap thong tin sinh vien" << endl;
	cout << "2. In danh sach sinh vien" << endl;
	cout << "3. Liet ke cac sinh vien co diem cao nhat nganh" << endl;
	cout << "4. Dieu chinh diem ren luyen" << endl;
	cout << "5. Tim va in ra sinh vien theo MSSV" << endl;
	cout << "6. Xoa sinh vien da thoi hoc" << endl;
	cout << "7. In danh sach cac sinh vien du dieu kien nhan hoc bong" << endl;
	cout << "8. Tra cuu cac thong tin sinh vien (Thong tin ca nhan,Xem Diem,Thanh toan hoc phi,Diem ren luyen)" << endl;
	cout << "9. Sap xep danh sach sinh vien theo diem trung binh" << endl;
	cout << "10. Sap xep danh sach sinh vien theo ma so sinh vien" << endl;
	cin >> select;
	switch (select)
	{
		
		
		case 1:
		{
			system("cls");
			cout << "******Nhap thong tin sinh vien******" << endl << endl;

			int choose;
			cout << "1. Lay thong tin sinh vien tu file co san" << endl;
			cout << "2. Nhap thong tin sinh vien" << endl;
			cout << "3. Nhap lai tu dau" << endl;
			cin >> choose;
			switch (choose)
			{
			case 1:
			{

				bool t = doctt("QLSV2.txt", List);
				if (t == false)
				{
					system("cls");
					MessageBox(
						NULL,
						(LPCWSTR)L"Khong tim thay file !!!",
						(LPCWSTR)L"Bao loi",
						MB_OK | MB_ICONERROR);
					break;
				}
				else
				{
					system("cls");

					MessageBox(
						NULL,
						(LPCWSTR)L"Doc File Thanh Cong !!!",
						(LPCWSTR)L"Thong bao",
						MB_OK| MB_ICONINFORMATION);
					system("cls");
					break;
				}
			}
			case 2:
			{
				
				int n;
				cout << "Nhap so sinh vien can luu thong tin: ";
				cin >> n;
				for (int i = 0; i < n; i++)
				{
					cout << "Nhap thong tin sinh vien thu " << i + 1 << " : " << endl;
					nhapSV(List);

				}
				char tieptuc;
				cout << endl << "Nhap them sinh vien? [Y/N]" << endl;
				cin >> tieptuc;
				while (tieptuc == 'Y' || tieptuc == 'y')
				{
					cout << tieptuc << endl;
					nhapSV(List);
					cout << endl << "Nhap them sinh vien? [Y/N]" << endl;
					cin >> tieptuc;

				}
				
				break;

			}
			case 3:
			{
				doctt2("QLSV.txt", List);
				ghitt("QLSV2.txt", List);
				break;
			}
			
			}
			break;
		}
		case 2:
		{
			system("cls");
			cout << "1.In danh sach rut gon" << endl;
			cout << "2.In danh sach chi tiet" << endl;
			int chon;
			cin >> chon;
			switch (chon)
			{
			
			case 1:
			{
				indsrg(List);
				break;
			}
			case 2:
			{
				Output(List);
				break;
			}
			
			}
			break;
		}
		case 3:
		{
			lietkemax(List);
			break;
		}
		case 4:
		{
			system("cls");
			cout << "1.Dieu chinh theo danh sach" << endl;
			cout << "2.Dieu chinh theo ca nhan" << endl;
			cin >> select;
			switch (select)
			{
			case 1:
			{
				SV_ptr *P = new SV_ptr;
				P = List->SV_head;
				while (P != NULL)
				{
					system("cls");
					cout << "Dieu chinh diem ren luyen cho sinh vien " << P->SV.Hoten << "(" << P->SV.Mssv << ")" << endl;
					Sleep(1500);
					dieuchinhdrl(P);
					P = P->next;
				}
				
				break;
			}
			case 2 :
			{
				SV_ptr *P = new SV_ptr;
				char x[10];
				cout << "Nhap MSSV ban muon tim kiem: ";
				cin.ignore();
				gets_s(x, 10);
				P = timSV(List, x);
				if (P == NULL)
				{
					MessageBox(
						NULL,
						(LPCWSTR)L"Khong tim thay sinh vien",
						(LPCWSTR)L"Bao loi",
						MB_OK | MB_ICONERROR);
					break;
				}
				else
				{
					intt(P);
					system("pause");
					cout << endl;
					dieuchinhdrl(P);
					cout << endl;
					xldd(P);
					break;
				}
				break;
			}
			
			}
			
			break;
		}
		case 5:
		{
			SV_ptr *P = new SV_ptr;
			char x[10];
			cout << "Nhap MSSV ban muon tim kiem: ";
			cin.ignore();
			gets_s(x,10);
			P = timSV(List, x);
			if (P == NULL)
			{
				MessageBox(
					NULL,
					(LPCWSTR)L"Khong tim thay sinh vien",
					(LPCWSTR)L"Bao loi",
					MB_OK | MB_ICONERROR);
				break;
			}
			else
			{

				cout << endl;
				insv(P);
				cout << endl;
				break;
			}
		}
		case 6:
		{
			char x[10];
			cout << "Nhap MSSV da thoi hoc: " << endl;
			cin.ignore();
			cin.getline(x, 10);
			xoatheoma(List, x);
			break;
		}
		case 7:
		{
			cout << "Danh sach sinh vien du dieu kien nhan hoc bong: " << endl;
			xethb(List);
			break;
		}
		case 8:
		{
			SV_ptr *P = new SV_ptr;
			char x[10];
			cout << "Moi ban nhap MSSV ma ban muon tra cuu thong tin: " << endl;
			cin.ignore();
			cin.getline(x, 10);
			P = timSV(List, x);
			if (P == NULL)
			{
				MessageBox(
					NULL,
					(LPCWSTR)L"Khong tim thay sinh vien",
					(LPCWSTR)L"Bao loi",
					MB_OK | MB_ICONERROR);
				break;
			}
			else
			{

				intt(P);
				int tracuu;
				do
				{
					system("pause");
					system("cls");
					cout << "Chon thong tin ma ban muon tra cuu: " << endl;
					cout << "1. Thong tin ca nhan" << endl;
					cout << "2. Xem diem" << endl;
					cout << "3. Thanh toan hoc phi" << endl;
					cout << "4. Diem ren luyen" << endl;
					cout << "5.Thoat" << endl;
					cin >> tracuu;
					system("cls");
					switch (tracuu)
					{
					case 1:
					{
						intt(P);
						break;
					}
					case 2:
					{
						indiemso(P);
						xlhl(P);
						cout << "Xep loai:" << P->SV.xlhl << endl;
						break;
					}
					case 3:
					{
						tinhhp(List);
						cout << "Hoc phi cua sinh vien" << P->SV.Hoten << " : " << P->SV.hp << "d" << endl;
						break;
					}
					case 4:
					{
						cout << "Diem ren luyen :" << P->SV.drl << endl;
						xldd(P);
						cout << "Xep loai: " << P->SV.xldd << endl;
						break;
					}
					break;
					}

				} while (tracuu <= 4);

				break;
			}
		}

		case 9:
		{
			int sapxep;
			cout << "Chon cach sap xep danh sach: " << endl;
			cout << "1. Tang dan" << endl;
			cout << "2. Giam dan" << endl;
			cin >> sapxep;
			
			switch (sapxep)
			{
			case 1:
			{
				
				SXdtb1(List);
				indsrg2(List);
				break;
			}
			case 2:
			{
				
				SXdtb2(List);
				indsrg2(List);
				break;
			}
			}
			break;
		}
		case 10:
		{
			int sapxep;
			cout << "Chon cach sap xep danh sach: " << endl;
			cout << "1. Tang dan" << endl;
			cout << "2. Giam dan" << endl;
			cin >> sapxep;
			switch (sapxep)
			{
			case 1:
			{
				
				SXmssv1(List);
				indsrg(List);
				break;
			}
			case 2:
			{
				
				SXmssv2(List);
				indsrg(List);
				break;
			}
			}
			break;
		}
		default:
		{
			break;
		}

	}

	int tt;
	cout << "1.Tro lai menu" << endl;
	cout << "2.Thoat" << endl;
	cin >> tt;
	if (tt == 1)
	{
		system("cls");
		MENU(List);
	}
	else
	{
		ghitt("QLSV2.txt", List);
	
	}
}
bool ghitt(const char* filename, DSSV_ptr *&List)
{
	errno_t f;
	FILE *fp;
	f = fopen_s(&fp, filename, "wt");
	if (!fp)
	{
		return false;
	}
	else
	{
		SV_ptr *P = new SV_ptr;
		P = List->SV_head;
		fprintf_s(fp, "%d\n", List->SV_numnode);
		cin.ignore();
		while (P != NULL)
		{
			fprintf_s(fp, "%s\n", P->SV.Mssv);
			fprintf_s(fp, "%s\n", P->SV.Hoten);
			fprintf_s(fp, "%d %d %d\n", P->SV.ngay,P->SV.thang,P->SV.nam);
			fprintf_s(fp, "%s\n", P->SV.lop);
			fprintf_s(fp, "%s\n", P->SV.nganh);
			fprintf_s(fp, "%d\n", P->SV.drl);
			MH_ptr *PMH = new MH_ptr;
			PMH = P->SV.MH_ds.MH_HEAD;
			fprintf_s(fp, "%d\n", P->SV.MH_ds.MH_numnode);
			while (PMH != NULL)
			{
				fprintf_s(fp, "%s\n", PMH->MH.mmh);
				fprintf_s(fp, "%s\n", PMH->MH.tenmh);
				fprintf_s(fp, "%d %2.f\n", PMH->MH.sotc, PMH->MH.diem);
				PMH = PMH->next;
			}
			
			P = P->next;

		}

	}
	fclose(fp);
	
}
bool doctt(const char* filename,DSSV_ptr *&List)
{
	errno_t f;
	FILE *fp;
	f = fopen_s(&fp,filename,"rt");
	SINHVIEN sv;
	if (!fp)
	{
		return false;
	}
	else
	{
		int N, n;
		taoDSSV(List);
		SV_ptr *P = new SV_ptr;
		P = List->SV_head;
		fscanf_s(fp, "%d\n", &List->SV_numnode);
		N = List->SV_numnode;

		for (int i = 0; i < N; i++)
		{

			fgets(sv.Mssv, 10, fp);
			fix(sv.Mssv);
			fgets(sv.Hoten, 35, fp);
			fix(sv.Hoten);
			fscanf_s(fp, "%d %d %d\n",&sv.ngay,&sv.thang,&sv.nam);
			fgets(sv.lop, 12, fp);
			fix(sv.lop);
			fgets(sv.nganh, 25, fp);
			fix(sv.nganh);
			fscanf_s(fp, "\n%2d\n", &sv.drl);
			
			P = GetNode(sv);
			AddTail(List, P);
			MH_ptr *p = new MH_ptr;
			p = P->SV.MH_ds.MH_HEAD;
			taoDSMH(P);
			fscanf_s(fp, "\n%d\n", &P->SV.MH_ds.MH_numnode);
			n = P->SV.MH_ds.MH_numnode;
			MONHOC mh;
			for (int j = 0; j < n; j++)
			{
				fgets(mh.mmh, 9, fp);
				fix(mh.mmh);
				fgets(mh.tenmh, 50, fp);
				fix(mh.tenmh);
				fscanf_s(fp, "%d %f\n",&mh.sotc,&mh.diem);
				p = GetNode2(mh);
				AddTail2(P, p);
				/*P->SV.MH_ds.MH_numnode++;*/
				p = p->next;
			}
			
			tinhdtb(P);
			clc(List);
			/*DRL(List);*/
			/*List->SV_numnode++;*/
			P = P->next;
			
		}
		xeploai(List);
		fclose(fp);
		return true;
	}

	
}
bool doctt2(const char* filename, DSSV_ptr *&List)
{
	errno_t f;
	FILE *fp;
	f = fopen_s(&fp, filename, "rt");
	SINHVIEN sv;
	if (!fp)
	{
		return false;
	}
	else
	{
		int N, n;
		taoDSSV(List);
		SV_ptr *P = new SV_ptr;
		P = List->SV_head;
		List->SV_numnode = 0;
		fscanf_s(fp, "%d\n", &List->SV_numnode);
		N = List->SV_numnode;

		for (int i = 0; i < N; i++)
		{

			fgets(sv.Mssv, 10, fp);
			fix(sv.Mssv);
			fgets(sv.Hoten, 35, fp);
			fix(sv.Hoten);
			fscanf_s(fp, "%d %d %d\n", &sv.ngay, &sv.thang, &sv.nam);
			fgets(sv.lop, 12, fp);
			fix(sv.lop);
			fgets(sv.nganh, 25, fp);
			fix(sv.nganh);
			fscanf_s(fp, "\n%2d\n", &sv.drl);

			P = GetNode(sv);
			AddTail(List, P);
			MH_ptr *p = new MH_ptr;
			p = P->SV.MH_ds.MH_HEAD;
			taoDSMH(P);
			fscanf_s(fp, "\n%d\n", &P->SV.MH_ds.MH_numnode);
			n = P->SV.MH_ds.MH_numnode;
			MONHOC mh;
			for (int j = 0; j < n; j++)
			{
				fgets(mh.mmh, 9, fp);
				fix(mh.mmh);
				fgets(mh.tenmh, 50, fp);
				fix(mh.tenmh);
				fscanf_s(fp, "%d %f\n", &mh.sotc, &mh.diem);
				p = GetNode2(mh);
				AddTail2(P, p);
				/*P->SV.MH_ds.MH_numnode++;*/
				p = p->next;
			}

			tinhdtb(P);
			clc(List);
			/*DRL(List);*/
			/*List->SV_numnode++;*/
			P = P->next;

		}
		xeploai(List);
		fclose(fp);
		return true;
	}


}
void fix(char chuoi[])
{
	int len = strlen(chuoi) - 1;
	if (chuoi[len] == '\n')
	{
		chuoi[len] = '\0';
	}

}
void dieuchinhdrl(SV_ptr *&P)
{
	system("cls");
	cout << "*****Diem ren luyen*****" << endl;
	cout << "1. Tham du cac buoi hoi thao, bao cao chuyen de (+3)" << endl;
	cout << "2. La Dang vien, Doan vien, Hoi vien HSV, thanh vien CLB/Doi/Nhom (+4)" << endl;
	cout << "3. Sinh vien, doan vien, hoi vien hoan thanh nhiem vu cua lop, chi doan, chi hoi (+2)" << endl;
	cout << "4. Tich cuc tham gia cac hoat dong bao ve trat tu, tri an va an toan xa hoi trong va ngoai truong (+3)" << endl;
	cout << "5. Chap hanh chu truong, chinh sach phap luat cua nha nuoc (+5)" << endl;
	cout << "6. Thuc hien tot noi quy sinh hoat ngoai tru, noi tru ky tuc xa (+5)" << endl;
	cout << "7. Co de tai nghien cuu khoa hoc cap truong, co bai viet duoc dang tren tap chi khoa hoc chuyen nganh cap truong (+10)" << endl;
	cout << "8. Du thi cac cuoc thi, hoi thi hoc thuat cap truong (+10)" << endl;
	cout << "9. Tham du, co vu, thuong thuc cac hoat dong cap truong (+3)" << endl;
	cout << "10. Tham gia thi, thi dau, bieu dien cac cuoc thi, hoi thao, hoi dien van nghe cap truong; tham du cac hoat dong chinh tri - xa hoi cap truong (+8)" << endl;
	cout << "11. Kich hoat va su dung dia chi Email do truong cap (+5)" << endl;
	cout << "12. Tham gia danh gia hoat dong giang day cua Giang vien (+5)" << endl;
	cout << "13. Bi cam thi (-5)" << endl;
	cout << "14. Tre han bao cao de tai nghien cuu mon hoc (-5)" << endl;
	cout << "15. Vi pham quy che kiem tra, thi hoc ky (-5)" << endl;
	cout << "16. Vi pham thuc hien dao duc tac phong trong truong (-3)" << endl;
	cout << "17. Vi pham quy dinh ve dong Bao hiem y te (-3)" << endl;
	cout << "18. Sinh vien dang ki ma khong tham gia chuong trinh, cac buoi hoi thao (-2)" << endl;
	cout << "19. Vi pham quy dinh dong hoc phi (-5)" << endl;
	cout << "20. Vi pham sinh hoat dau khoa, cuoi khoa, dau nam hoc (-3)" << endl;
	cout << "21.Thoat" << endl;
	int select;
	cin >> select;
	while(select < 21)
	{
		cin >> select;
		switch (select)
		{
		case 1:
			{
			P->SV.drl += 3;
				break;
			}
		case 2:
		{
			P->SV.drl += 4;
			break;
		}
		case 3:
		{
			P->SV.drl += 2;
			break;
		}
		case 4:
		{
			P->SV.drl += 3;
			break;
		}
		case 5:
		{
			P->SV.drl += 5;
			break;
		}
		case 6:
		{
			P->SV.drl += 5;
			break;
		}
		case 7:
		{
			P->SV.drl += 10;
			break;
		}
		case 8:
		{
			P->SV.drl += 10;
			break;
		}
		case 9:
		{
			P->SV.drl += 3;
			break;
		}
		case 10:
		{
			P->SV.drl += 8;
			break;
		}
		case 11:
		{
			P->SV.drl += 5;
			break;
		}
		case 12:
		{
			P->SV.drl += 5;
			break;
		}
		case 13:
		{
			P->SV.drl -= 5;
			break;
		}
		case 14:
		{
			P->SV.drl -= 5;
			break;
		}
		case 15:
		{
			P->SV.drl -= 5;
			break;
		}
		case 16:
		{
			P->SV.drl -= 3;
			break;
		}
		case 17:
		{
			P->SV.drl -= 3;
			break;
		}
		case 18:
		{
			P->SV.drl -= 2;
			break;
		}
		case 19:
		{
			P->SV.drl -= 5;
			break;
		}
		case 20:
		{
			P->SV.drl -= 3;
			break;
		}
		break;
		}

	}
	return;
}
void xlhl(SV_ptr *&P)
{
	if (P->SV.tbc >= 8.5)
	{
		strcpy_s(P->SV.xlhl, "Gioi");
		return;
	}
	else if (P->SV.tbc < 8.5 && P->SV.tbc >= 7)
	{
		strcpy_s(P->SV.xlhl, "Kha");
		return;
	}
	else if (P->SV.tbc < 7 && P->SV.tbc >= 5.5)
	{
		strcpy_s(P->SV.xlhl, "Trung binh");
		return;
	}
	else if (P->SV.tbc < 5.5 && P->SV.tbc >= 4)
	{
		strcpy_s(P->SV.xlhl, "Yeu");
		return;
	}
	else
	{
		strcpy_s(P->SV.xlhl, "Kem");
		return;
	}
	return;
}
void xldd(SV_ptr *&P)
{

	if (P->SV.drl <= 100 && P->SV.drl >= 90)
	{
		strcpy_s(P->SV.xldd, "Xuat sac");
		return;
		
	}
	else if (P->SV.drl < 90 && P->SV.drl >= 80)
	{
		strcpy_s(P->SV.xldd, "Tot");
		return;
		
	}
	else if (P->SV.drl < 80 && P->SV.drl >= 70)
	{
		strcpy_s(P->SV.xldd, "Kha");
		return;
	}
	else if (P->SV.drl < 70 && P->SV.drl >= 60)
	{
		strcpy_s(P->SV.xldd, "Trung binh kha");
		return;
	}
	else if (P->SV.drl < 60 && P->SV.drl >= 50)
	{
		strcpy_s(P->SV.xldd, "Trung binh");
		return;
	}	
	else if (P->SV.drl < 50 && P->SV.drl >= 30)
	{
		strcpy_s(P->SV.xldd, "Yeu");
		return;
	}
	else
	{
		strcpy_s(P->SV.xldd, "Kem");
		return;
	}
	return;

}
void xeploai(DSSV_ptr *&List)
{
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	while (P != NULL)
	{
		xlhl(P);
		xldd(P);
		P = P->next;
	}
	return;
}
void indsrg(DSSV_ptr *List)
{
	system("cls");
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	cout << "                         ******************Danh sach sinh vien**************** " << endl << endl;
	cout.width(15);
	cout << left << "MSSV: ";
	cout.width(25);
	cout << left << "Ten sinh vien: ";
	cout.width(25);
	cout << left << "Ngay sinh: ";
	cout.width(15);
	cout << left << "Lop: ";
	cout.width(15);
	cout << left << "Nganh: ";
	cout << endl;
	while (P != NULL)
	{
		cout.width(15);
		cout << left << P->SV.Mssv;
		cout.width(25);
		cout << left << P->SV.Hoten;
		cout << left << setw(2) << P->SV.ngay << left << setw(1) << "/" << left << setw(2) << P->SV.thang << left << setw(1) << "/" << left << setw(19) << P->SV.nam;
		cout.width(15);
		cout << left << P->SV.lop;
		cout.width(15);
		cout << left << P->SV.nganh;
		cout << endl;
		P = P->next;
	}
}
void indsrg2(DSSV_ptr *List)
{
	system("cls");
	SV_ptr *P = new SV_ptr;
	P = List->SV_head;
	cout << "                                  ******************Danh sach sinh vien**************** " << endl << endl;
	cout.width(15);
	cout << left << "MSSV: ";
	cout.width(25);
	cout << left << "Ten sinh vien: ";
	cout.width(25);
	cout << left << "Ngay sinh: ";
	cout.width(15);
	cout << left << "Lop: ";
	cout.width(25);
	cout << left << "Nganh: ";
	cout.width(15);
	cout << left << "Diem TB";
	cout.width(15);
	cout << left << "Diem ren luyen";
	cout << endl;
	while (P != NULL)
	{
		cout.width(15);
		cout << left << P->SV.Mssv;
		cout.width(25);
		cout << left << P->SV.Hoten;
		cout << left << setw(2) << P->SV.ngay << left << setw(1) << "/" << left << setw(2) << P->SV.thang << left << setw(1) << "/" << left << setw(19) << P->SV.nam;
		cout.width(15);
		cout << left << P->SV.lop;
		cout.width(25);
		cout << left << P->SV.nganh;
		cout.width(15);
		cout << left << P->SV.tbc;
		cout.width(15);
		cout << left << P->SV.drl;
		cout << endl;
		P = P->next;
	}
}
/*int DisplayResourceNAMessageBox()
{
	int msgboxID = MessageBox(
		NULL,
		(LPCWSTR)L"Doc File Thanh Cong !!!",
		(LPCWSTR)L"Thong bao",
		MB_OK 
	);
		switch (msgboxID)
		{
		case IDOK:
			// TODO: add code
			break;
		}

	return msgboxID;

}*/
void DelTail(DSSV_ptr *&List)
{
	if (List->SV_head == NULL) cout << "Danh sach rong" << endl;
	else
	{
		SV_ptr *q = List->SV_tail;
		if (List->SV_head == List->SV_tail)List->SV_head = List->SV_tail = NULL;
		else
		{
			SV_ptr *p = List->SV_head;
			while (p->next != List->SV_tail) p = p->next;
			List->SV_tail= p;
			p->next = NULL;
		}
		delete q;
	}
}

void TextColor(int color)
{
	SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE), color);
}
void ClearConsoleToColors(int ForgC, int BackC)
{
	WORD wColor = ((BackC & 0x0F) << 4) + (ForgC & 0x0F);
	//Get the handle to the current output buffer...
	HANDLE hStdOut = GetStdHandle(STD_OUTPUT_HANDLE);
	//This is used to reset the carat/cursor to the top left.
	COORD coord = { 0, 0 };
	//A return value... indicating how many chars were written
	  //   not used but we need to capture this since it will be
		//   written anyway (passing NULL causes an access violation).
	DWORD count;

	//This is a structure containing all of the console info
// it is used here to find the size of the console.
	CONSOLE_SCREEN_BUFFER_INFO csbi;
	//Here we will set the current color
	SetConsoleTextAttribute(hStdOut, wColor);
	if (GetConsoleScreenBufferInfo(hStdOut, &csbi))
	{
		//This fills the buffer with a given character (in this case 32=space).
		FillConsoleOutputCharacter(hStdOut, (TCHAR)32, csbi.dwSize.X * csbi.dwSize.Y, coord, &count);

		FillConsoleOutputAttribute(hStdOut, csbi.wAttributes, csbi.dwSize.X * csbi.dwSize.Y, coord, &count);
		//This will set our cursor position for the next print statement.
		SetConsoleCursorPosition(hStdOut, coord);
	}
	return;
}
void chonmau(int &x, int &y)
{
	cout << "               ********************************/BANG MAU/**************************************" << endl;
	cout << "                                    ";
	cout.width(15);
	cout << left << " Name"; cout << left << "|     Value" << endl;
	cout << "                                    ";

	cout.width(16);
	cout << right << "|" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Black"; cout << left << "|     0" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Blue"; cout << left << "|     1" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Green"; cout << left << "|     2" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Cyan"; cout << left << "|     3" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Red"; cout << left << "|     4" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Magenta"; cout << left << "|     5" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Brown"; cout << left << "|     6" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Light Gray"; cout << left << "|     7" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Dark Gray"; cout << left << "|     8" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Light Blue"; cout << left << "|     9" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Light Green"; cout << left << "|     10" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Light Cyan"; cout << left << "|     11" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Light Red"; cout << left << "|     12" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Light Magenta"; cout << left << "|     13" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "Yellow"; cout << left << "|     14" << endl;
	cout << "                                    ";

	cout.width(15);
	cout << left << "White"; cout << left << "|     15" << endl << endl;


	cout << "Chon mau nen cho chuong trinh cua ban: ";
	cin >> y;
	cout << "Chon mau chu cho chuong trinh cua ban: ";
	cin >> x;
	ClearConsoleToColors(x,y);
}
