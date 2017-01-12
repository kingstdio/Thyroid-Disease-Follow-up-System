USE follw_up_DB

CREATE TABLE tb_patientInfo(
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[name] [varchar](50) NULL,						--患者姓名
	[idcard] [char](18) NULL,						--身份证号
	[address] [varchar](128) NULL,					-- 居住地址
	[mobile] [char](16) NULL,						--移动电话
	[phone] [char](16) NULL,						--备用电话
	[hosnumber] [char](16) NULL,					-- 住院号
	[sex] [bit] NULL,								--性别
	[birthday] [date] NULL,							--出生日期
	[hosage] [int] NULL,							--住院年龄
	[hosindate] [date] NULL,						--住院日期
	[hosoutdate] [date] NULL,						--出院日期
	[resident] [varchar](50) NULL,					--居住区域
	[menophaniaage] [int] NULL,						--初潮年龄
	[pregnancyage] [int] NULL,						--初孕年龄
	[pregnancytimes] [int] NULL,					--怀孕次数
	[abortiontimes] [int] NULL,						--流产次数
	[deliverytimes] [nchar](10) NULL,				--正常分娩次数
	[menopause] [bit] NULL,							--是否绝经
	[smoke] [bit] NULL,								--是否吸烟
	[drink] [nchar](10) NULL,						--是否饮酒
	[occupation] [varchar](50) NULL,				--职业
	[height] [int] NULL,							--身高
	[weight] [int] NULL,							--体重
	[constitutional] [float] NULL,					--体质指数
	[prolactin] [float] NULL,						--泌乳素
	[estradiol] [float] NULL,						--雌二醇
	[pregnendione] [float] NULL,					--孕酮
	[testosterone] [float] NULL,					--睾酮
	[luteinizing] [float] NULL,						--促黄体激素
	[folliclestimulating] [float] NULL,				--促卵泡刺激素
	[cholesterol] [float] NULL,						--胆固醇
	[llipoprotein] [float] NULL,					--低密度脂蛋白
	[hlipoprotein] [float] NULL,					--高密度脂蛋白
	[triglyceride] [float] NULL,					--甘油三酯
	[bloodGlucose] [float] NULL,					--血糖
	[hypertension] [bit] NULL,						--是否为高血压
	[diabetes] [bit] NULL,							--是否为糖尿病
	[coronary] [bit] NULL,							--是否为冠心病
	[radiotherapy] [bit] NULL,						--颈部放射治疗史
	[otherntumour] [bit] NULL,						--是否有其它恶性肿瘤
	[otherntumourtext] [varchar](50) NULL,			--其它恶性肿瘤内容
	[otherptumour] [bit] NULL,						--是否有其它良性肿瘤
	[othernoptumourtext] [varchar](50) NULL,		--其它良性肿瘤内容
	[familyhistory] [bit] NULL,						--是否有家族甲状腺病史
	[familyhistorytext] [varchar](50) NULL,			--家族甲状腺病史内容				
	)
	GO

CREATE TABLE [dbo].[tb_diagnosis](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[tirads] [varchar](50) NULL,					--（二维超声）TI-RADS级
	[part] [varchar](50) NULL,						--部
	[tdlymphnodemetastisis] [bit] NULL,				--淋巴结转移
	[remark] [varchar](256) NULL,					--备注（区）
	[ucthyroidcancer] [bit] NULL,					--（超声造影）是否考虑为甲状腺癌
	[elasticimpactrating] [int] NULL,				--弹性影响评分
	[ctthyroidcancer] [bit] NULL,					--（CT/MRI）是否考虑为甲状腺癌
	[ctlymphnodemetastisis] [bit] NULL,				--是否考虑为淋巴结转移
	[laryngoscope] [varchar](10) NULL,				--（术前喉镜）喉镜情况
	[diagnosis] [varchar](50) NULL,					--诊断
	[Bethesda] [char](5) NULL,						--（甲状腺FNA）Bethesda报告级别
	[thyroidbraf] [char](5) NULL,					--Braf基因
	[thyroidRAS] [char](5) NULL,					--RAS基因
	[thyroidTERT] [char](5) NULL,					--TERT基因
	[thyroidPTC1] [char](5) NULL,					--RET/PTC1
	[thyroidPTC3] [char](5) NULL,					--RET/PTC3
	[thyroidPAX8] [char](5) NULL,					--PAX8/PPARG
	[lymphnodesFNA] [varchar](50) NULL,				--（淋巴结FNA）FNA
	[lymphnodesbraf] [char](5) NULL,				--B-raf基因
	[lymphnodestg] [float] NULL,					--Tg洗脱液
	[TSH] [float] NULL,								--（甲功）TSH
	[ATG] [float] NULL,								--ATG
	[CT] [float] NULL,								--CT
	[FT3] [float] NULL,								--FT3
	[ATPO] [float] NULL,							--A-TPO
	[TG] [float] NULL,								--TG
	[FT4] [float] NULL,								--FT4
	[PTH] [float] NULL,								--PTH
	[CEA] [float] NULL,								--CEA
	[K] [float] NULL,								--（离子）K
	[Ca] [float] NULL,								--Ca
	[Na] [float] NULL,								--Na
	[P] [float] NULL,								--P
	[Cl] [float] NULL,								--Cl
	)
	GO

CREATE TABLE [dbo].[tb_surgeryHistory](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[surgerytime] [date] NULL,						--手术时间
	[surgerytype] [char](10) NULL,					--手术类型
	[surgeryfrequency] [char](10) NULL,				--手术次数
	[doctor] [char](10) NULL,						--术者
	[leftlobe] [char](10) NULL,						--（甲状腺根治术）左叶
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








