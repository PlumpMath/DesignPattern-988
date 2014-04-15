using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace BowlingLaneUpdateService
{
    [ServiceContract]
    public interface IBowlingLaneUpdateService
    {

        [OperationContract]
        bool setScore(int lane, bool[] pins, bool gutterBall);

        [OperationContract]
        void setLaneEnable(int lane, bool enabled);
    }
}
