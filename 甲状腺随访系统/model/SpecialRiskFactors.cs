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
        public Double prolactin { get; set; }

        /// <summary>
        /// 雌二醇
        /// </summary>
        public Double estradiol { get; set; }

        /// <summary>
        /// 孕酮
        /// </summary>
        public Double pregnendione { get; set; }

        /// <summary>
        /// 睾酮
        /// </summary>
        public Double testosterone { get; set; }

        /// <summary>
        /// 促黄体激素
        /// </summary>
        public Double luteinizing { get; set; }

        /// <summary>
        /// 促卵泡刺激素
        /// </summary>
        public Double folliclestimulating { get; set; }

        /// <summary>
        /// 胆固醇
        /// </summary>
        public Double cholesterol { get; set; }

        /// <summary>
        /// 低密度脂蛋白
        /// </summary>
        public Double llipoprotein { get; set; }

        /// <summary>
        /// 高密度脂蛋白
        /// </summary>
        public Double hlipoprotein { get; set; }

        /// <summary>
        /// 甘油三酯
        /// </summary>
        public Double triglyceride { get; set; }

        /// <summary>
        /// 血糖
        /// </summary>
        public Double bloodGlucose { get; set; }
    }
}
