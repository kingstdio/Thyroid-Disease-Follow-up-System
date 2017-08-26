using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 甲状腺随访系统.MODEL
{
   public class Complication
    {
        /// <summary>
        /// （常规项）声音嘶哑
        /// </summary>
        public string hoarseness { get; set; }

        /// <summary>
        /// 呼吸困难
        /// </summary>
        public string dyspnea { get; set; }

        /// <summary>
        /// 语调变化
        /// </summary>
        public string VocalChange { get; set; }

        /// <summary>
        /// 饮水呛咳
        /// </summary>
        public string drinkchok { get; set; }

        /// <summary>
        /// 抽搐
        /// </summary>
        public string hyperspasmia { get; set; }

        /// <summary>
        /// 麻木
        /// </summary>
        public bool numb { get; set; }

        /// <summary>
        /// 出血
        /// </summary>
        public bool bleed { get; set; }

        /// <summary>
        /// 淋巴漏或乳漏
        /// </summary>
        public bool galactorrhea { get; set; }

        /// <summary>
        /// 感染
        /// </summary>
        public bool infection { get; set; }

        /// <summary>
        /// （术后声带B超）麻痹
        /// </summary>
        public string Bparalysis { get; set; }

        /// <summary>
        /// 运动减弱
        /// </summary>
        public string Bhypomotility { get; set; }

        /// <summary>
        /// （术后喉镜）麻痹
        /// </summary>
        public string PLparalysis { get; set; }

        /// <summary>
        /// 运动减弱
        /// </summary>
        public string PLhypomotility { get; set; }

        
    }
}
