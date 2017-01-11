using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.model
{
    public class SpecialRiskFactors
    {


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
    }
}
