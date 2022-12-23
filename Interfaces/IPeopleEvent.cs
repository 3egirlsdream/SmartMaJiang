using SmartMaJiang.Enums;
using SmartMaJiang.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMaJiang.Interfaces
{
    public interface IPeopleEvent
    {
        /// <summary>
        /// 杠
        /// </summary>
        public void GangEvent();
        /// <summary>
        /// 杠
        /// </summary>
        public void GangEvent(MaJiang maJiang);
        /// <summary>
        /// 碰
        /// </summary>
        public void PengEvent();
        /// <summary>
        /// 碰
        /// </summary>
        public void PengEvent(MaJiang maJiang);
        /// <summary>
        /// 胡
        /// </summary>
        public void HuEvent();
        /// <summary>
        /// 定缺
        /// </summary>
        public MaJiangTypeEnum DecideLackCard();
    }
}
