using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.model
{
    class Patient
    {
        /// <summary>
        /// 系统编号
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// 患者姓名
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// 患者身份证号
        /// </summary>
        public string idcard { get; set; }


        /// <summary>
        /// 居住地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        /// 移动电话
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 备用电话
        /// </summary>
        public string phone { get; set; }

        /// <summary>
        /// 住院号
        /// </summary>
        public string hosnumber { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public bool sex { get; set; }

        /// <summary>
        /// 住院日期
        /// </summary>
        public DateTime birthday { get; set; }

        /// <summary>
        /// 出院日期
        /// </summary>
        public DateTime hosoutdate { get; set; }

        /// <summary>
        /// 居住区域
        /// </summary>
        public string resident { get; set; }

        /// <summary>
        /// 初潮年龄
        /// </summary>
        public int menophaniaage { get; set; }

        /// <summary>
        /// 初孕年龄
        /// </summary>
        public int pregnancyage { get; set; }

        /// <summary>
        /// 怀孕次数
        /// </summary>
        public int pregnancytimes { get; set; }

        /// <summary>
        /// 流产次数
        /// </summary>
        public int abortiontimes { get; set; }

        /// <summary>
        /// 正常分娩次数
        /// </summary>
        public string deliverytimes { get; set; }

        /// <summary>
        /// 是否绝经
        /// </summary>
        public bool menopause { get; set; }


        /// <summary>
        /// 是否吸烟
        /// </summary>
        public bool smoke { get; set; }

        /// <summary>
        /// 是否饮酒
        /// </summary>
        public bool drink { get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        public string occupation { get; set; }

        /// <summary>
        /// 身高
        /// </summary>
        public int height { get; set; }

        /// <summary>
        /// 体重
        /// </summary>
        public int weight { get; set; }

        /// <summary>
        /// 体质指数
        /// </summary>
        public float onstitutional { get; set; }

        /// <summary>
        /// 泌乳素
        /// </summary>
        public float prolactin { get; set; }

        /// <summary>
        /// 雌二醇
        /// </summary>
        public float estradiol { get; set; }

        /// <summary>
        /// 孕酮
        /// </summary>
        public float pregnendione { get; set; }

        /// <summary>
        /// 睾酮
        /// </summary>
        public float testosterone { get; set; }

        /// <summary>
        /// 促黄体激素
        /// </summary>
        public float luteinizing { get; set; }

        /// <summary>
        /// 促卵泡刺激素
        /// </summary>
        public float folliclestimulating { get; set; }

        /// <summary>
        /// 胆固醇
        /// </summary>
        public float cholesterol { get; set; }

        /// <summary>
        /// 低密度脂蛋白
        /// </summary>
        public float llipoprotein { get; set; }

        /// <summary>
        /// 高密度脂蛋白
        /// </summary>
        public float hlipoprotein { get; set; }

        /// <summary>
        /// 甘油三酯
        /// </summary>
        public float triglyceride { get; set; }

        /// <summary>
        /// 血糖
        /// </summary>
        public float bloodGlucose { get; set; }

        /// <summary>
        /// 是否为高血压
        /// </summary>
        public bool hypertension { get; set; }

        /// <summary>
        /// 是否为糖尿病
        /// </summary>
        public bool diabetes { get; set; }

        /// <summary>
        /// 是否为冠心病
        /// </summary>
        public bool coronary { get; set; }

        /// <summary>
        /// 颈部放射治疗史
        /// </summary>
        public bool radiotherapy { get; set; }

        /// <summary>
        /// 是否有其它恶性肿瘤
        /// </summary>
        public bool otherntumour { get; set; }

        /// <summary>
        /// 其它恶性肿瘤内容
        /// </summary>
        public string otherntumourtext { get; set; }

        /// <summary>
        /// 是否有其它良性肿瘤
        /// </summary>
        public int otherptumour { get; set; }

        /// <summary>
        /// 其它良性肿瘤内容
        /// </summary>
        public string othernoptumourtext { get; set; }

        /// <summary>
        /// 是否有家族甲状腺病史
        /// </summary>
        public int familyhistory { get; set; }

        /// <summary>
        /// 家族甲状腺病史内容
        /// </summary>
        public string familyhistorytext { get; set; }




    }
}
