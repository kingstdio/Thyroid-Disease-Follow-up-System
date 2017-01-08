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






