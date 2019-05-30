using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl.VideoEnvironment
{
    public class VideoEnvironment_HikStream 
    {
        public static void Init(string strServiceAddress)
        {
            ProgParameter.strHikStreamIP = strServiceAddress;
            SDKInterface.SDK_HikStream.InitStreamClientLib();
            
            //InitStreamClientLib();
            //throw new NotImplementedException();
        }

        public static void Release()
        {
            SDKInterface.SDK_HikStream.FiniStreamClientLib();
        }
    }
}
