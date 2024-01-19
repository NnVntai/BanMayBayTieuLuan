/*==============================================================*/
/* DBMS name:      Microsoft SQL Server 2012                    */
/* Created on:     11/29/2021 10:28:12 PM                       */
/*==============================================================*/
create database banvemaybay
go
use banvemaybay



/*==============================================================*/
/* Table: ChitietSL                                             */
/*==============================================================*/
create table ChitietSL (
   MaSLghe              char(5)              not null,
   MaHangVe             char(5)              not null,
   Machuyenbay          char(5)              not null,
   Soluong              int                  null,
   constraint PK_CHITIETSL primary key nonclustered (MaSLghe)
)
go

/*==============================================================*/
/* Index: PK_CB_SL_FK                                           */
/*==============================================================*/
create index PK_CB_SL_FK on ChitietSL (
Machuyenbay ASC
)
go

/*==============================================================*/
/* Index: PK_HV_SL_FK                                           */
/*==============================================================*/
create index PK_HV_SL_FK on ChitietSL (
MaHangVe ASC
)
go

/*==============================================================*/
/* Table: ChuyenBay                                             */
/*==============================================================*/
create table ChuyenBay (
   Machuyenbay          char(5)              not null,
   NgayGio              datetime             null,
   ThoiGian             time(7)            null,
   Gia                  numeric              null,
	MaSanBayDen char(5) null,
	MaSanBayDi char(5) null,
   constraint PK_CHUYENBAY primary key nonclustered (Machuyenbay)
)
go

/*==============================================================*/
/* Table: HangVe                                                */
/*==============================================================*/
create table HangVe (
   MaHangVe             char(5)              not null,
   TenHangVe            char(254)            null,
   constraint PK_HANGVE primary key nonclustered (MaHangVe)
)
go

/*==============================================================*/
/* Table: PhieuDatCho                                           */
/*==============================================================*/
create table PhieuDatCho (
   MaPhieuDatCho        char(5)              not null,
   Machuyenbay          char(5)              null,
   SDT                  char(11)             null,
	MaHangVe char(5) null,
   NgayDat              datetime             null,
   constraint PK_PHIEUDATCHO primary key nonclustered (MaPhieuDatCho)
)
go

/*==============================================================*/
/* Index: PK_USER_PHIEU_FK                                      */
/*==============================================================*/
create index PK_USER_PHIEU_FK on PhieuDatCho (
SDT ASC
)
go

/*==============================================================*/
/* Index: PK_CB_PHIEU_FK                                        */
/*==============================================================*/
create index PK_CB_PHIEU_FK on PhieuDatCho (
Machuyenbay ASC
)
go

/*==============================================================*/
/* Table: SanBay                                                */
/*==============================================================*/
create table SanBay (
   MaSanBay             char(5)              not null,
   TenSanBay            char(254)            null,
   constraint PK_SANBAY primary key nonclustered (MaSanBay)
)
go

/*==============================================================*/
/* Table: SanBayTrungGian                                       */
/*==============================================================*/
create table SanBayTrungGian (
   MaSanbayTrungGiang   char(5)              not null,
   MaSanBay             char(5)              null,
   Machuyenbay          char(5)              not null,
   ThoiGianDung         time(7)            null,
   constraint PK_SANBAYTRUNGGIAN primary key nonclustered (MaSanbayTrungGiang)
)
go

/*==============================================================*/
/* Index: PK_SA_TG_FK                                           */
/*==============================================================*/
create index PK_SA_TG_FK on SanBayTrungGian (
MaSanBay ASC
)
go

/*==============================================================*/
/* Index: PK_CB_TG_FK                                           */
/*==============================================================*/
create index PK_CB_TG_FK on SanBayTrungGian (
Machuyenbay ASC
)
go


go

/*==============================================================*/
/* Table: "User"                                                */
/*==============================================================*/
create table "User" (
   SDT                  char(11)             not null,
   MaVaiTro             char(5)              not null,
   CMND                 char(13)             null,
   Ten                  char(254)            null,
   constraint PK_USER primary key nonclustered (SDT)
)
go

/*==============================================================*/
/* Index: PK_USER_VAITRO_FK                                     */
/*==============================================================*/
create index PK_USER_VAITRO_FK on "User" (
MaVaiTro ASC
)
go

/*==============================================================*/
/* Table: VaiTro                                                */
/*==============================================================*/
create table VaiTro (
   MaVaiTro             char(5)              not null,
   TenVaiTro            char(254)            null,
   constraint PK_VAITRO primary key nonclustered (MaVaiTro)
)
go

/*==============================================================*/
/* Table: VechuyenBay                                           */
/*==============================================================*/
create table VechuyenBay (
   MaVeChuyenBay        char(5)              not null,
   SDT                  char(11)             null,
   Machuyenbay          char(5)              null,
	MaHangve char(5) null,
   constraint PK_VECHUYENBAY primary key nonclustered (MaVeChuyenBay)
)
go

/*==============================================================*/
/* Index: PK_CB_VE_FK                                           */
/*==============================================================*/
create index PK_CB_VE_FK on VechuyenBay (
Machuyenbay ASC
)
go

/*==============================================================*/
/* Index: PK_USER_VE_FK                                         */
/*==============================================================*/
create index PK_USER_VE_FK on VechuyenBay (
SDT ASC
)
go

alter table ChitietSL
   add constraint FK_CHITIETS_PK_CB_SL_CHUYENBA foreign key (Machuyenbay)
      references ChuyenBay (Machuyenbay)
go

alter table ChitietSL
   add constraint FK_CHITIETS_PK_HV_SL_HANGVE1 foreign key (MaHangVe)
      references HangVe (MaHangVe)
go
alter table vechuyenbay
   add constraint FK_CHITIETS_PK_HV_SL_HANGVE2 foreign key (MaHangVe)
      references HangVe (MaHangVe)
go
alter table PhieuDatCho
   add constraint FK_CHITIETS_PK_HV_SL_HANGVE foreign key (MaHangVe)
      references HangVe (MaHangVe)
go

alter table PhieuDatCho
   add constraint FK_PHIEUDAT_PK_CB_PHI_CHUYENBA foreign key (Machuyenbay)
      references ChuyenBay (Machuyenbay)
go

alter table PhieuDatCho
   add constraint FK_PHIEUDAT_PK_USER_P_USER foreign key (SDT)
      references "User" (SDT)
go

alter table SanBayTrungGian
   add constraint FK_SANBAYTR_PK_CB_TG_CHUYENBA foreign key (Machuyenbay)
      references ChuyenBay (Machuyenbay)
go

alter table SanBayTrungGian
   add constraint FK_SANBAYTR_PK_SA_TG_SANBAY foreign key (MaSanBay)
      references SanBay (MaSanBay)
go

alter table ChuyenBay
   add constraint FK_SANBAY_D_PK_CB_DEN_CHUYENBA foreign key (MaSanBayDi)
      references SanBay (MaSanBay)
go

alter table ChuyenBay
   add constraint FK_SANBAY_D_PK_SA_DEN_SANBAY foreign key (MaSanBayDen)
      references SanBay (MaSanBay)
go



alter table "User"
   add constraint FK_USER_PK_USER_V_VAITRO foreign key (MaVaiTro)
      references VaiTro (MaVaiTro)
go

alter table VechuyenBay
   add constraint FK_VECHUYEN_PK_CB_VE_CHUYENBA foreign key (Machuyenbay)
      references ChuyenBay (Machuyenbay)
go

alter table VechuyenBay
   add constraint FK_VECHUYEN_PK_USER_V_USER foreign key (SDT)
      references "User" (SDT)
go

