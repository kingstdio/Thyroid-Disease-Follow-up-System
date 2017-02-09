USE follw_up_DB

CREATE TABLE [dbo].[tb_patientInfo](
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
	[pid] [int] NOT NULL,							--���߱��
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
	[pid] [int] NOT NULL,							--���߱��
	[surgerytime] [date] NULL,						--����ʱ��
	[surgerytype] [char](10) NULL,					--��������
	[surgeryfrequency] [char](10) NULL,				--��������
	[doctor] [char](10) NULL,						--����
	[leftlobe] [char](10) NULL,						--����״�ٸ���������Ҷ
	[rightlobe] [char](10) NULL,					--��Ҷ
	[leftVI] [char](10) NULL,						--��VI��
	[rightVI] [char](10) NULL,						--��VI��
	[leftneck] [char](10) NULL,						--��ྱ
	[rightneck] [char](10) NULL,					--�Ҳྱ
	[PCmaxtumordiameter] [float] NULL,				--����ͷ״�����������ֱ��
	[PCalltumordiameter] [float] NULL,				--��������ֱ����
	[PCalltumorrange] [float] NULL,					--��������ֱ����Χ
	[PCmulifocality] [bit] NULL,					--������
	[PCbilateralcancer] [bit] NULL,					--˫�఩
	[PCcapsuleinvasion] [char](10) NULL,			--��Ĥ�ַ�
	[PClymphaticmetastasis] [bit] NULL,				--�ܰͽ�ת��
	[PClymphocytic��thyroiditis] [bit] NULL,			--���ܰ�ϸ����״����
	[PChypotype] [char](20) NULL,					--����
	[FCmaxtumordiameter] [float] NULL,				--�������԰����������ֱ��
	[FCalltumordiameter] [float] NULL,				--��������ֱ����
	[FCalltumorrange] [float] NULL,					--��������ֱ����Χ
	[FCmulifocality] [bit] NULL,					--������
	[FCbilateralcancer] [bit] NULL,					--˫�఩
	[FCcapsuleinvasion] [char](10) NULL,			--��Ĥ�ַ�
	[FClymphaticmetastasis] [bit] NULL,				--�ܰͽ�ת��
	[FClymphocyticthyroiditis] [bit] NULL,			--���ܰ�ϸ����״����
	[Ileftn] [int] NULL,							--I����
	[Ileftd] [int] NULL,							
	[Irightn] [int] NULL,							--I����
	[Irightd] [int] NULL,
	[IIleftn] [int] NULL,							--II����
	[IIleftd] [int] NULL,
	[IIrightn] [int] NULL,							--II����
	[IIrightd] [int] NULL,
	[IIIleftn] [int] NULL,							--III����
	[IIIleftd] [int] NULL,
	[IIIrightn] [int] NULL,							--III����
	[IIIrightd] [int] NULL,
	[IVleftn] [int] NULL,							--IV����
	[IVleftd] [int] NULL,
	[IVrightn] [int] NULL,							--IV����
	[IVrightd] [int] NULL,
	[Vleftn] [int] NULL,							--V����
	[Vleftd] [int] NULL,
	[Vrightn] [int] NULL,							--V����
	[Vrightd] [int] NULL,
	[VIleftn] [int] NULL,							--VI����
	[VIleftd] [int] NULL,
	[VIrightn] [int] NULL,							--VIȥ��
	[VIrightd] [int] NULL,
	[prelaryngealn] [int] NULL,						--��ǰ
	[prelaryngeald] [int] NULL,
	[region] [varchar](50) NULL,					--��
	[regionleftn] [int] NULL,						--����
	[regionleftd] [int] NULL,
	[regionrightn] [int] NULL,						--����
	[regionrightd] [int] NULL,
	[carbonnano] [bit] NULL,						--�Ƿ�ʹ��̼����
	[primarytumors] [char](10) NULL,				--ԭ��������T
	[RLNM] [char](10) NULL,							--�����ܰ�ת��N
	[distantmetastasis] [char](10) NULL,			--Զ��ת��M
	[PTNM] [char](10) NULL,							--PTNM����
	[otherthyroidcancer] [char](20) NULL,			--������״�ٰ�
	[melecularneuropathology] [bit] NULL,			--���Ӳ���
	[TGT] [char](10) NULL,							--�������黯��TGT/TG
	[CK] [char](10) NULL,							--CK
	[CK19] [char](10) NULL,							--CK19
	[CD151] [char](10) NULL,						--CD151
	[galecins3] [char](10) NULL,					--��������-3
	[calctionin] [char](10) NULL,					--������
	[braf] [char](10) NULL,							--Braf
	[Ki67] [varchar](50) NULL,						--Ki67��%��
	[cyclinD1] [char](10) NULL,						--Cycling D1
	[HBME1] [char](10) NULL,						--HBME-1
	[TTF1] [char](10) NULL,							--TTF-1
	[VEGF] [varchar](50) NULL,						--VEGF
	[others] [varchar](256) NULL,					--����
	)
	GO

CREATE TABLE [dbo].[tb_postOperative](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[pid] [int] NULL,								--���߱��
	[euthyrox] [float] NULL,						--��ҩ�����ƣ��ż���
	[chemotherapy] [varchar](256) NULL,				--���Ʒ���������
	[radiotherapy] [varchar](256) NULL,				--���Ʒ���������
	[hoarseness] [char](10) NULL,					--�����������˻��
	[dyspnea] [char](10) NULL,						--��������
	[drinkchok] [char](10) NULL,					--��ˮǺ��
	[hyperspasmia] [char](10) NULL,					--�鴤
	[galactorrhea] [bit] NULL,						--�ܰ�©����©
	[infection] [bit] NULL,							--��Ⱦ
	[Bparalysis] [char](10) NULL,					--����������B�������
	[Bhypomotility] [char](10) NULL,				--�˶�����
	[PLparalysis] [char](10) NULL,					--������������
	[PLhypomotility] [char](10) NULL,				--�˶�����
	[VocalChange] [char](10) NULL,				    --����ı�
	[bleed] [bit] NULL,								--��Ѫ
	
CREATE TABLE [dbo].[tb_followUp](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[pid] [int] NOT NULL,							--���߱��
	[lastconnect] [date] NULL,						--�����ϵʱ��
	[distantmetastasislocation] [char](10) NULL,	--Զ��ת��λ��
	[vitalstatus] [char](10) NULL,					--����״̬
	[deathdate] [date] NULL,						--��������
	[distantmetastasis] [char](10) NULL,			--Զ��ת��
	[deathcause] [char](10) NULL,					--����ԭ��
	[diatantmetasisdate] [date] NULL,				--Զ��ת������
	)
	GO


CREATE TABLE [dbo].[tb_recurrencecs](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[TG] [varchar](50) NULL,						--��Ѫ��ѧָ�꣩TG
	[TGAB] [varchar](50) NULL,						--TGAB
	[CEA] [varchar](50) NULL,						--CEA
	[calcitonin] [varchar](50) NULL,				--������
	[CT] [varchar](50) NULL,						--��Ӱ��ѧָ�꣩CT
	[MRI] [varchar](50) NULL,						--MRI
	[I131] [varchar](50) NULL,						--I131
	[PETCT] [varchar](50) NULL,						--PET-CT
	[FNA] [varchar](50) NULL,						--����֯����ѧ��FNA
	[braf] [bit] NULL,								--B-raf
	[TGeluant] [varchar](50) NULL,					--TGϴ��Һ
	[tumorlocation] [varchar](50) NULL,				--��������λ��
	[tumorsize] [varchar](50) NULL,					--����������С
	[lymphadenlocation] [varchar](50) NULL,			--���ܰͽᣩλ��
	[lymphadensize] [varchar](50) NULL,				--���ܰͽᣩ��С
	)
	GO

CREATE TABLE [dbo].[tb_inspectionAfterSurgery](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[pid] [int] NOT NULL,							--���߱��
	[days] [float] NULL,							--����
	[PTH] [float] NULL,								--PTH
	[Ca] [float] NULL,								--Ca
	[P] [float] NULL,								--P
	[alkalinephosphatase] [float] NULL,				--��������ø
	[D] [float] NULL,								--25-ǿ��ά����D
	[D2] [float] NULL,								--D2
	[D3] [float] NULL,								--D3
	)
	GO

CREATE TABLE [dbo].[tb_radioactiveIodine](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[pid] [int] NOT NULL,							--���߱��
	[TS] [float] NULL,								--TS
	[FT3] [float] NULL,								--FT3
	[FT4] [float] NULL,								--FT4
	[sTG] [float] NULL,								--sTG
	[ATG] [float] NULL,								--A-TG
	[iodineuptakerate] [float] NULL,				--�����ʣ�%��
	)
	GO

CREATE TABLE [dbo].[tb_visit](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--�������
	[pid] [int] NOT NULL,							--���߱��
	[Vdate] [date] NULL,								--�������
	[TSH] [float] NULL,								--TSH
	[FT3] [float] NULL,								--FT3
	[FT4] [float] NULL,								--FT4
	[TPO] [float] NULL,								--TPO
	[PTH] [float] NULL,								--PTH
	[ATG] [float] NULL,								--A-TG
	[TG] [float] NULL,								--TG
	[TGAb] [float] NULL,							--TG-Ab
	[Ca] [float] NULL,								--Ca
	[P] [float] NULL,								--P
	[euthyrox] [float] NULL,						--�ż��ּ���
	[Cadosage] [float] NULL,						--�Ƽ���
	[sideeffect] [varbinary](50) NULL,				--������
	)
	GO








