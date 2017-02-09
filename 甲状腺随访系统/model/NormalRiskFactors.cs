using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
    public class NormalRiskFactors
    {

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
        public int deliverytimes { get; set; }

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
        public Double weight { get; set; }

        /// <summary>
        /// 体质指数
        /// </summary>
        public Double constitutional { get; set; }
    }
}
