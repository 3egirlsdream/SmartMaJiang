using SmartMaJiang.Enums;
using SmartMaJiang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartMaJiang.Interfaces
{
    public class OperateEvent
    {
        public OperateEvent(OperateEventEnum eventType, People people, MaJiang maJiang) 
        { 
            EventType = eventType;
            OperatePeople = people;
            OperateMaJiang = maJiang;
        }
        public OperateEventEnum EventType { get; set; }
        public People OperatePeople { get; set; }
        public MaJiang OperateMaJiang { get; set; }
    }
}
