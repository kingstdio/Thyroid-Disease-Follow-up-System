USE follw_up_DB

CREATE TABLE [dbo].[tb_patientInfo](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[name] [varchar](50) NULL,						--患者姓名
	[idcard] [varchar](18) NULL,						--身份证号
	[address] [varchar](128) NULL,					-- 居住地址
	[mobile] [varchar](11) NULL,						--移动电话
	[phone] [varchar](11) NULL,						--备用电话
	[hosnumber] [varchar](8) NULL,					-- 住院号
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
	[deliverytimes] [int] NULL,						--正常分娩次数
	[menopause] [bit] NULL,							--是否绝经
	[smoke] [bit] NULL,								--是否吸烟
	[drink] [bit] NULL,								--是否饮酒
	[occupation] [varchar](50) NULL,				--职业
	[height] [int] NULL,							--身高
	[weight] [float] NULL,							--体重
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
	[pid] [int] NOT NULL,							--患者编号
	[tirads] [varchar](50) NULL,					--（二维超声）TI-RADS级
	[part] [varchar](50) NULL,						--部
	[tdlymphnodemetastisis] [bit] NULL,				--淋巴结转移
	[remark] [varchar](256) NULL,					--备注（区）
	[ucthyroidcancer] [varchar](10) NULL,			--（超声造影）是否考虑为甲状腺癌
	[elasticimpactrating] [varchar](10) NULL,		--弹性影响评分
	[ctthyroidcancer] [bit] NULL,					--（CT/MRI）是否考虑为甲状腺癌
	[ctlymphnodemetastisis] [bit] NULL,				--是否考虑为淋巴结转移
	[laryngoscope] [varchar](10) NULL,				--（术前喉镜）喉镜情况
	[diagnosis] [varchar](50) NULL,					--诊断
	[Bethesda] [varchar](10) NULL,				    --（甲状腺FNA）Bethesda报告级别
	[thyroidbraf] [varchar](10) NULL,			    --Braf基因
	[thyroidRAS] [varchar](10) NULL,				--RAS基因
	[thyroidTERT] [varchar](10) NULL,				--TERT基因
	[thyroidPTC1] [varchar](10) NULL,				--RET/PTC1
	[thyroidPTC3] [varchar](10) NULL,				--RET/PTC3
	[thyroidPAX8] [varchar](10) NULL,				--PAX8/PPARG
	[lymphnodesFNA] [varchar](50) NULL,				--（淋巴结FNA）FNA
	[lymphnodesbraf] [varchar](10) NULL,			--B-raf基因
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
	[pid] [int] NOT NULL,							--患者编号
	[surgerytime] [date] NULL,						--手术时间
	[surgerytype] [varchar](10) NULL,				--手术类型
	[surgeryfrequency] [varchar](10) NULL,			--手术次数
	[doctor] [varchar](10) NULL,					--术者
	[leftlobe] [varchar](10) NULL,					--（甲状腺根治术）左叶
	[rightlobe] [varchar](10) NULL,					--右叶
	[leftVI] [varchar](10) NULL,					--左VI区
	[rightVI] [varchar](10) NULL,					--右VI区
	[leftneck] [varchar](10) NULL,					--左侧颈
	[rightneck] [varchar](10) NULL,					--右侧颈
	[PCmaxtumordiameter] [float] NULL,				--（乳头状癌）最大肿瘤直径
	[PCalltumordiameter] [float] NULL,				--所有肿瘤直径和
	[PCalltumorrange] [float] NULL,					--所有肿瘤直径范围
	[PCmulifocality] [bit] NULL,					--多灶性
	[PCbilateralcancer] [bit] NULL,					--双侧癌
	[PCcapsuleinvasion] [varchar](10) NULL,			--被膜侵犯
	[PClymphaticmetastasis] [bit] NULL,				--淋巴结转移
	[PClymphocytic。thyroiditis] [bit] NULL,		--伴淋巴细胞甲状腺炎
	[PChypotype] [varchar](20) NULL,				--亚型
	[FCmaxtumordiameter] [float] NULL,				--（滤泡性癌）最大肿瘤直径
	[FCalltumordiameter] [float] NULL,				--所有肿瘤直径和
	[FCalltumorrange] [float] NULL,					--所有肿瘤直径范围
	[FCmulifocality] [bit] NULL,					--多灶性
	[FCbilateralcancer] [bit] NULL,					--双侧癌
	[FCcapsuleinvasion] [varchar](10) NULL,			--被膜侵犯
	[FClymphaticmetastasis] [bit] NULL,				--淋巴结转移
	[FClymphocyticthyroiditis] [bit] NULL,			--伴淋巴细胞甲状腺炎
	[Ileftn] [int] NULL,							--I区左
	[Ileftd] [int] NULL,							
	[Irightn] [int] NULL,							--I区右
	[Irightd] [int] NULL,
	[IIleftn] [int] NULL,							--II区左
	[IIleftd] [int] NULL,
	[IIrightn] [int] NULL,							--II区右
	[IIrightd] [int] NULL,
	[IIIleftn] [int] NULL,							--III区左
	[IIIleftd] [int] NULL,
	[IIIrightn] [int] NULL,							--III区右
	[IIIrightd] [int] NULL,
	[IVleftn] [int] NULL,							--IV区左
	[IVleftd] [int] NULL,
	[IVrightn] [int] NULL,							--IV区右
	[IVrightd] [int] NULL,
	[Vleftn] [int] NULL,							--V区左
	[Vleftd] [int] NULL,
	[Vrightn] [int] NULL,							--V区右
	[Vrightd] [int] NULL,
	[VIleftn] [int] NULL,							--VI区左
	[VIleftd] [int] NULL,
	[VIrightn] [int] NULL,							--VI去右
	[VIrightd] [int] NULL,
	[prelaryngealn] [int] NULL,						--喉前
	[prelaryngeald] [int] NULL,
	[region] [varchar](50) NULL,					--区
	[regionleftn] [int] NULL,						--区左
	[regionleftd] [int] NULL,
	[regionrightn] [int] NULL,						--区右
	[regionrightd] [int] NULL,
	[carbonnano] [bit] NULL,						--是否使用碳纳米
	[primarytumors] [varchar](10) NULL,				--原发性肿瘤T
	[RLNM] [varchar](10) NULL,						--区域淋巴转移N
	[distantmetastasis] [varchar](10) NULL,			--远处转移M
	[PTNM] [varchar](10) NULL,						--PTNM分期
	[otherthyroidcancer] [varchar](50) NULL,		--其它甲状腺癌
	[melecularneuropathology] [bit] NULL,			--分子病理
	[TGT] [varchar](10) NULL,						--（免疫组化）TGT/TG
	[CK] [varchar](10) NULL,						--CK
	[CK19] [varchar](10) NULL,						--CK19
	[CD151] [varchar](10) NULL,						--CD151
	[galecins3] [varchar](10) NULL,					--半乳凝素-3
	[calctionin] [varchar](10) NULL,				--降钙素
	[braf] [varchar](10) NULL,						--Braf
	[Ki67] [varchar](50) NULL,						--Ki67（%）
	[cyclinD1] [varchar](10) NULL,					--Cycling D1
	[HBME1] [varchar](10) NULL,						--HBME-1
	[TTF1] [varchar](10) NULL,						--TTF-1
	[VEGF] [varchar](50) NULL,						--VEGF
	[others] [varchar](256) NULL,					--其它
	)
	GO

CREATE TABLE [dbo].[tb_postOperative](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[pid] [int] NOT NULL,								--患者编号
	[euthyrox] [float] NULL,						--（药物治疗）优甲乐
	[chemotherapy] [varchar](256) NULL,				--化疗方案及计量
	[radiotherapy] [varchar](256) NULL,				--放疗方案及计量
	[hoarseness] [varchar](10) NULL,				--（常规项）声音嘶哑
	[dyspnea] [varchar](10) NULL,					--呼吸困难
	[drinkchok] [varchar](10) NULL,					--饮水呛咳
	[hyperspasmia] [varchar](10) NULL,				--抽搐
	[galactorrhea] [bit] NULL,						--淋巴漏或乳漏
	[infection] [bit] NULL,							--感染
	[Bparalysis] [varchar](10) NULL,				--（术后声带B超）麻痹
	[Bhypomotility] [varchar](10) NULL,				--运动减弱
	[PLparalysis] [varchar](10) NULL,				--（术后喉镜）麻痹
	[PLhypomotility] [varchar](10) NULL,			--运动减弱
	[VocalChange] [varchar](10) NULL,			    --语调改变
	[bleed] [bit] NULL,								--出血
	)
	GO
	
CREATE TABLE [dbo].[tb_followUp](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[pid] [int] NOT NULL,							--患者编号
	[lastconnect] [date] NULL,						--最后联系时间
	[distantmetastasislocation] [varchar](10) NULL,	--远处转移位置
	[vitalstatus] [varchar](10) NULL,				--生死状态
	[deathdate] [date] NULL,						--死亡日期
	[distantmetastasis] [varchar](10) NULL,			--远处转移
	[deathcause] [varchar](10) NULL,				--死亡原因
	[diatantmetasisdate] [date] NULL,				--远处转移日期
	)
	GO


CREATE TABLE [dbo].[tb_recurrencecs](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[pid] [int] NOT NULL,							--患者编号
	[TG] [varchar](50) NULL,						--（血清学指标）TG
	[TGAB] [varchar](50) NULL,						--TGAB
	[CEA] [varchar](50) NULL,						--CEA
	[calcitonin] [varchar](50) NULL,				--降钙素
	[CT] [varchar](50) NULL,						--（影响学指标）CT
	[MRI] [varchar](50) NULL,						--MRI
	[I131] [varchar](50) NULL,						--I131
	[PETCT] [varchar](50) NULL,						--PET-CT
	[FNA] [varchar](50) NULL,						--（组织病理学）FNA
	[braf] [bit] NULL,								--B-raf
	[TGeluant] [varchar](50) NULL,					--TG洗脱液
	[tumorlocation] [varchar](50) NULL,				--（肿瘤）位置
	[tumorsize] [varchar](50) NULL,					--（肿瘤）大小
	[lymphadenlocation] [varchar](50) NULL,			--（淋巴结）位置
	[lymphadensize] [varchar](50) NULL,				--（淋巴结）大小
	)
	GO

CREATE TABLE [dbo].[tb_inspectionAfterSurgery](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[pid] [int] NOT NULL,							--患者编号
	[days] [float] NULL,							--天数
	[PTH] [float] NULL,								--PTH
	[Ca] [float] NULL,								--Ca
	[P] [float] NULL,								--P
	[AP] [float] NULL,								--碱性磷酸酶
	[D] [float] NULL,								--25-强及维生素D
	[D2] [float] NULL,								--D2
	[D3] [float] NULL,								--D3
	)
	GO

CREATE TABLE [dbo].[tb_radioactiveIodine](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[pid] [int] NOT NULL,							--患者编号
	[TS] [float] NULL,								--TS
	[FT3] [float] NULL,								--FT3
	[FT4] [float] NULL,								--FT4
	[sTG] [float] NULL,								--sTG
	[ATG] [float] NULL,								--A-TG
	[iodrate] [float] NULL,				--吸碘率（%）
	)
	GO

CREATE TABLE [dbo].[tb_visit](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[pid] [int] NOT NULL,							--患者编号
	[Vdate] [date] NULL,							--随访日期
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
	[euthyrox] [float] NULL,						--优甲乐剂量
	[Cadosage] [float] NULL,						--钙剂量
	[sideeffect] [varchar](50) NULL,				--副作用
	[others] [varchar](256) NULL,
	)
	GO

CREATE TABLE [dbo].[tb_user](
	[id] [int] IDENTITY(1,1) NOT NULL primary key,	--编号自增
	[username] [varchar](50) NULL,					--用户名
	[password] [varchar](50) NULL,					--密码
	[privilege] [int] NULL,							--权限
	[forbidden] [int] NULL,							--是否禁用
	[lastlogintime] [datetime] NULL					--最后登录时间
) ON [PRIMARY]

GO






