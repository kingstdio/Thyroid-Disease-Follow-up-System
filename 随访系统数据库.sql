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






