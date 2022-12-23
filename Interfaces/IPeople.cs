using SmartMaJiang.Enums;
using SmartMaJiang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMaJiang.Interfaces
{
    public interface IPeople
    {
        /// <summary>
        /// 手上的牌
        /// </summary>
        public List<MaJiang> MaJiangsInHand { get; set; }
        /// <summary>
        /// 出掉的牌
        /// </summary>
        public List<MaJiang> MaJiangsOut { get; set; }
        /// <summary>
        /// 碰的或者杠的牌
        /// </summary>
        public List<EatedCard> EatedCards { get; set; }
        /// <summary>
        /// 缺的牌
        /// </summary>
        public MaJiangTypeEnum LackType { get; set; }
        /// <summary>
        /// 摸牌
        /// </summary>
        /// <param name="maJiang"></param>
        public void PickCard(MaJiang maJiang);
        /// <summary>
        /// 出牌
        /// </summary>
        /// <param name="maJiang"></param>
        public void DisCard(MaJiang maJiang);
        /// <summary>
        /// 初始化摸牌
        /// </summary>
        /// <param name="maJiangs"></param>
        public void InitCard(List<MaJiang> maJiangs);
        /// <summary>
        /// 出牌顺位
        /// </summary>
        public int SEQ { get; set; }
        /// <summary>
        /// 是否是庄家
        /// </summary>
        public bool IsBanker { get; set; }
        /// <summary>
        /// 手上剩余牌数
        /// </summary>
        public int CardInHand { get; set; }
    }
}
