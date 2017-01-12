USE follw_up_DB

CREATE TABLE tb_patientInfo(
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[name] [varchar](50) NULL,						--��������
	[idcard] [char](18) NULL,						--���֤��
	[address] [varchar](128) NULL,					-- ��ס��ַ
	[mobile] [char](16) NULL,						--�ƶ��绰
	[phone] [char](16) NULL,						--���õ绰
	[hosnumber] [char](16) NULL,					-- סԺ��
	[sex] [bit] NULL,								--�Ա�
	[birthday] [date] NULL,							--��������
	[hosage] [int] NULL,							--סԺ����
	[hosindate] [date] NULL,						--סԺ����
	[hosoutdate] [date] NULL,						--��Ժ����
	[resident] [varchar](50) NULL,					--��ס����
	[menophaniaage] [int] NULL,						--��������
	[pregnancyage] [int] NULL,						--��������
	[pregnancytimes] [int] NULL,					--���д���
	[abortiontimes] [int] NULL,						--��������
	[deliverytimes] [nchar](10) NULL,				--�����������
	[menopause] [bit] NULL,							--�Ƿ����
	[smoke] [bit] NULL,								--�Ƿ�����
	[drink] [nchar](10) NULL,						--�Ƿ�����
	[occupation] [varchar](50) NULL,				--ְҵ
	[height] [int] NULL,							--���
	[weight] [int] NULL,							--����
	[constitutional] [float] NULL,					--����ָ��
	[prolactin] [float] NULL,						--������
	[estradiol] [float] NULL,						--�ƶ���
	[pregnendione] [float] NULL,					--��ͪ
	[testosterone] [float] NULL,					--غͪ
	[luteinizing] [float] NULL,						--�ٻ��弤��
	[folliclestimulating] [float] NULL,				--�����ݴ̼���
	[cholesterol] [float] NULL,						--���̴�
	[llipoprotein] [float] NULL,					--���ܶ�֬����
	[hlipoprotein] [float] NULL,					--���ܶ�֬����
	[triglyceride] [float] NULL,					--��������
	[bloodGlucose] [float] NULL,					--Ѫ��
	[hypertension] [bit] NULL,						--�Ƿ�Ϊ��Ѫѹ
	[diabetes] [bit] NULL,							--�Ƿ�Ϊ����
	[coronary] [bit] NULL,							--�Ƿ�Ϊ���Ĳ�
	[radiotherapy] [bit] NULL,						--������������ʷ
	[otherntumour] [bit] NULL,						--�Ƿ���������������
	[otherntumourtext] [varchar](50) NULL,			--����������������
	[otherptumour] [bit] NULL,						--�Ƿ���������������
	[othernoptumourtext] [varchar](50) NULL,		--����������������
	[familyhistory] [bit] NULL,						--�Ƿ��м����״�ٲ�ʷ
	[familyhistorytext] [varchar](50) NULL,			--�����״�ٲ�ʷ����				
	)
	GO

CREATE TABLE [dbo].[tb_diagnosis](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[tirads] [varchar](50) NULL,					--����ά������TI-RADS��
	[part] [varchar](50) NULL,						--��
	[tdlymphnodemetastisis] [bit] NULL,				--�ܰͽ�ת��
	[remark] [varchar](256) NULL,					--��ע������
	[ucthyroidcancer] [bit] NULL,					--��������Ӱ���Ƿ���Ϊ��״�ٰ�
	[elasticimpactrating] [int] NULL,				--����Ӱ������
	[ctthyroidcancer] [bit] NULL,					--��CT/MRI���Ƿ���Ϊ��״�ٰ�
	[ctlymphnodemetastisis] [bit] NULL,				--�Ƿ���Ϊ�ܰͽ�ת��
	[laryngoscope] [varchar](10) NULL,				--����ǰ���������
	[diagnosis] [varchar](50) NULL,					--���
	[Bethesda] [char](5) NULL,						--����״��FNA��Bethesda���漶��
	[thyroidbraf] [char](5) NULL,					--Braf����
	[thyroidRAS] [char](5) NULL,					--RAS����
	[thyroidTERT] [char](5) NULL,					--TERT����
	[thyroidPTC1] [char](5) NULL,					--RET/PTC1
	[thyroidPTC3] [char](5) NULL,					--RET/PTC3
	[thyroidPAX8] [char](5) NULL,					--PAX8/PPARG
	[lymphnodesFNA] [varchar](50) NULL,				--���ܰͽ�FNA��FNA
	[lymphnodesbraf] [char](5) NULL,				--B-raf����
	[lymphnodestg] [float] NULL,					--Tgϴ��Һ
	[TSH] [float] NULL,								--���׹���TSH
	[ATG] [float] NULL,								--ATG
	[CT] [float] NULL,								--CT
	[FT3] [float] NULL,								--FT3
	[ATPO] [float] NULL,							--A-TPO
	[TG] [float] NULL,								--TG
	[FT4] [float] NULL,								--FT4
	[PTH] [float] NULL,								--PTH
	[CEA] [float] NULL,								--CEA
	[K] [float] NULL,								--�����ӣ�K
	[Ca] [float] NULL,								--Ca
	[Na] [float] NULL,								--Na
	[P] [float] NULL,								--P
	[Cl] [float] NULL,								--Cl
	)
	GO

CREATE TABLE [dbo].[tb_surgeryHistory](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[surgerytime] [date] NULL,						--����ʱ��
	[surgerytype] [char](10) NULL,					--��������
	[surgeryfrequency] [char](10) NULL,				--��������
	[doctor] [char](10) NULL,						--����
	[leftlobe] [char](10) NULL,						--����״�ٸ���������Ҷ
	[rightlobe] [char](10) NULL,					--
	[leftVI] [char](10) NULL,
	[rightVI] [char](10) NULL,
	[leftneck] [char](10) NULL,
	[rightneck] [char](10) NULL,
	[PCmaxtumordiameter] [float] NULL,
	[PCalltumordiameter] [float] NULL,
	[PCalltumorrange] [float] NULL,
	[PCmulifocality] [bit] NULL,
	[PCbilateralcancer] [bit] NULL,
	[PCcapsuleinvasion] [char](10) NULL,
	[PClymphaticmetastasis] [bit] NULL,
	[PClymphocyticthyroiditis] [bit] NULL,
	[PChypotype] [char](20) NULL,
	[FCmaxtumordiameter] [float] NULL,
	[FCalltumordiameter] [float] NULL,
	[FCalltumorrange] [float] NULL,
	[FCmulifocality] [bit] NULL,
	[FCbilateralcancer] [bit] NULL,
	[FCcapsuleinvasion] [char](10) NULL,
	[FClymphaticmetastasis] [bit] NULL,
	[FClymphocyticthyroiditis] [bit] NULL,
	[Ileftn] [int] NULL,
	[Ileftd] [int] NULL,
	[Irightn] [int] NULL,
	[Irightd] [int] NULL,
	[IIleftn] [int] NULL,
	[IIleftd] [int] NULL,
	[IIrightn] [int] NULL,
	[IIrightd] [int] NULL,
	[IIIleftn] [int] NULL,
	[IIIleftd] [int] NULL,
	[IIIrightn] [int] NULL,
	[IIIrightd] [int] NULL,
	[IVleftn] [int] NULL,
	[IVleftd] [int] NULL,
	[IVrightn] [int] NULL,
	[IVrightd] [int] NULL,
	[Vleftn] [int] NULL,
	[Vleftd] [int] NULL,
	[Vrightn] [int] NULL,
	[Vrightd] [int] NULL,
	[VIleftn] [int] NULL,
	[VIleftd] [int] NULL,
	[VIrightn] [int] NULL,
	[VIrightd] [int] NULL,
	[prelaryngealn] [int] NULL,
	[prelaryngeald] [int] NULL,
	[region] [varchar](50) NULL,
	[regionleftn] [int] NULL,
	[regionleftd] [int] NULL,
	[regionrightn] [int] NULL,
	[regionrightd] [int] NULL,
	[carbonnano] [bit] NULL,
	[primarytumors] [char](10) NULL,
	[RLNM] [char](10) NULL,
	[distantmetastasis] [char](10) NULL,
	[PTNM] [char](10) NULL,
	[otherthyroidcancer] [char](20) NULL,
	[melecularneuropathology] [bit] NULL,
	[TGT] [char](10) NULL,
	[CK] [char](10) NULL,
	[CK19] [char](10) NULL,
	[CD151] [char](10) NULL,
	[galecins3] [char](10) NULL,
	[calctionin] [char](10) NULL,
	[braf] [char](10) NULL,
	[Ki67] [varchar](50) NULL,
	[cyclinD1] [char](10) NULL,
	[HBME1] [char](10) NULL,
	[TTF1] [char](10) NULL,
	[VEGF] [varchar](50) NULL,
	[others] [varchar](256) NULL,
	)
	GO

CREATE TABLE [dbo].[tb_followUp](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,
	[lastconnect] [date] NULL,
	[distantmetastasislocation] [char](10) NULL,
	[vitalstatus] [char](10) NULL,
	[deathdate] [date] NULL,
	[distantmetastasis] [char](10) NULL,
	[deathcause] [char](10) NULL,
	[diatantmetasisdate] [date] NULL,
	)
	GO


CREATE TABLE [dbo].[tb_recurrencecs](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,
	[TG] [varchar](50) NULL,
	[TGAB] [varchar](50) NULL,
	[CEA] [varchar](50) NULL,
	[calcitonin] [varchar](50) NULL,
	[CT] [varchar](50) NULL,
	[MRI] [varchar](50) NULL,
	[I131] [varchar](50) NULL,
	[PETCT] [varchar](50) NULL,
	[FNA] [varchar](50) NULL,
	[braf] [bit] NULL,
	[TGeluant] [varchar](50) NULL,
	[tumorlocation] [varchar](50) NULL,
	[tumorsize] [varchar](50) NULL,
	[lymphadenlocation] [varchar](50) NULL,
	[lymphadensize] [varchar](50) NULL,
	)
	GO

CREATE TABLE [dbo].[tb_inspectionAfterSurgery](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,
	[days] [float] NULL,
	[PTH] [float] NULL,
	[Ca] [float] NULL,
	[P] [float] NULL,
	[alkalinephosphatase] [float] NULL,
	[D] [float] NULL,
	[D2] [float] NULL,
	[D3] [float] NULL,
	)
	GO

CREATE TABLE [dbo].[tb_radioactiveIodine](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,
	[TS] [float] NULL,
	[FT3] [float] NULL,
	[FT4] [float] NULL,
	[sTG] [float] NULL,
	[ATG] [float] NULL,
	[iodineuptakerate] [float] NULL,
	)
	GO

CREATE TABLE [dbo].[tb_visit](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,
	[date] [date] NULL,
	[TSH] [float] NULL,
	[FT3] [float] NULL,
	[FT4] [float] NULL,
	[TPO] [float] NULL,
	[PTH] [float] NULL,
	[ATG] [float] NULL,
	[TG] [float] NULL,
	[TGAb] [float] NULL,
	[Ca] [float] NULL,
	[P] [float] NULL,
	[euthyrox] [float] NULL,
	[Cadosage] [float] NULL,
	[sideeffect] [varbinary](50) NULL,
	)
	GO








