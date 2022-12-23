using SmartMaJiang.Chessboard;
using SmartMaJiang.Enums;
using SmartMaJiang.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMaJiang.Model
{
    public class People : IPeople, IPeopleEvent
    {
        private MaJiangBoard ThisBoard;
        public People(MaJiangBoard board, bool isBanker, int seq)
        {
            MaJiangsInHand = new List<MaJiang>();
            MaJiangsOut = new List<MaJiang>();
            EatedCards = new List<EatedCard>();
            IsBanker= isBanker;
            SEQ = seq;
            ThisBoard = board;
            ID = Guid.NewGuid().ToString("N").ToUpper();
            if(isBanker)
            {
                CardInHand = 14;
            }
            else
            { 
                CardInHand = 13; 
            }
        }

        public string ID { get; private set; }
        public List<MaJiang> MaJiangsInHand { get; set; }
        public List<MaJiang> MaJiangsOut { get; set; }
        public List<EatedCard> EatedCards { get; set; }
        public MaJiangTypeEnum LackType { get; set; }
        public int SEQ { get; set; }
        public bool IsBanker { get; set; }
        public int CardInHand { get; set; }

        public void PickCard(MaJiang maJiang)
        {
            MaJiangsInHand.Add(maJiang);
        }

        public void DisCard(MaJiang maJiang)
        {
            var item = MaJiangsInHand.FirstOrDefault(c => c.MaJiangNumber == maJiang.MaJiangNumber && c.MaJiangType == maJiang.MaJiangType);
            if (item != null)
            {
                MaJiangsInHand.Remove(item);
            }
        }

        public void GangEvent()
        {
            OperateEvent operate = new(OperateEventEnum.Gang, this, null);
            ThisBoard.Excute(operate);

        }

        public void GangEvent(MaJiang maJiang)
        {
            OperateEvent operate = new(OperateEventEnum.Gang, this, maJiang);
            ThisBoard.Excute(operate);
        }

        public void HuEvent()
        {
            OperateEvent operate = new(OperateEventEnum.Hu, this, null);
            ThisBoard.Excute(operate);
        }

        public void PengEvent()
        {
            OperateEvent operate = new(OperateEventEnum.Peng, this, null);
            ThisBoard.Excute(operate);
        }

        public void PengEvent(MaJiang maJiang)
        {
            OperateEvent operate = new(OperateEventEnum.Peng, this, maJiang);
            ThisBoard.Excute(operate);
        }

        public void InitCard(List<MaJiang> maJiangs)
        {
            MaJiangsInHand = maJiangs;
        }

        public MaJiangTypeEnum DecideLackCard()
        {
            var group = MaJiangsInHand.GroupBy(c => c.MaJiangType).ToDictionary(c => c.Key, z => z.ToList());

        }
    }
}
