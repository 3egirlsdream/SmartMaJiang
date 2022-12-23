using SmartMaJiang.Enums;
using SmartMaJiang.Interfaces;
using SmartMaJiang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMaJiang.Chessboard
{
    public class MaJiangBoard
    {
        List<People> Peoples = new List<People>();
        People Top, Left, Right;
        People Myself;
        public MaJiangBoard(string bankerName) 
        {
            OperatesStack = new Stack<OperateEvent>();
            int seq = 0;

            if (nameof(Top).ToLower() == bankerName.ToLower())
            {
                Top =new People(this, true, seq++);
                Left = new People(this, false, seq++);
                Right = new People(this, false, seq++);
                Myself = new People(this, false, seq++);
            }
            else if (nameof(Left).ToLower() == bankerName.ToLower())
            {
                Left = new People(this, true, seq++);
                Top = new People(this, false, seq++);
                Right = new People(this, false, seq++);
                Myself = new People(this, false, seq++);
            }
            else if (nameof(Right).ToLower() == bankerName.ToLower())
            {
                Right = new People(this, true, seq++);
                Top = new People(this, false, seq++);
                Left = new People(this, false, seq++);
                Myself = new People(this, false, seq++);
            }
            else
            {
                Myself = new People(this, true, seq++);
                Top = new People(this, false, seq++);
                Left = new People(this, false, seq++);
                Right = new People(this, false, seq++);
            }

        }
        private Stack<OperateEvent> OperatesStack;
        /// <summary>
        /// 执行运算逻辑
        /// </summary>
        /// <param name="operate"></param>
        public void Excute(OperateEvent operate)
        {
            OperatesStack.Push(operate);
        }

        /// <summary>
        /// 初始化我的手牌
        /// </summary>
        public void InitMySelfCards(MaJiang maJiang) 
        { 
            Myself.PickCard(maJiang);
        }
        /// <summary>
        /// 初始化我的手牌
        /// </summary>
        public void InitMySelfCards(List<MaJiang> maJiang)
        {
            maJiang.ForEach(ma => InitMySelfCards(ma));
        }
    } 
}
