using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoPlayControl
{
    public class DebugRelevant
    {

        public delegate void DebugLogDelegate(object sender, object DebugLogDelegateValue);

        public static event DebugLogDelegate DebugLogEvent;

        public static void DebugLog(object sender, object DebugLogDelegateValue)
        {
            if (DebugLogEvent != null)
            {
                DebugLogEvent(sender, DebugLogDelegateValue);
            }
        }
    }
}
