using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BowlingLaneUpdateService
{
    public class Service1 : IBowlingLaneUpdateService
    {
        public bool setScore(int lane, bool[] pins, bool gutterBall)
        {
            throw new NotImplementedException();
        }

        public void setLaneEnable(int lane, bool enabled)
        {
            throw new NotImplementedException();
        }
    }
}
