using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoPlayControl.VideoRemoteBackplay
{
    public class PubMethod
    {
        delegate IntPtr GetPicPlayMainHandleDelegate(PictureBox pic);
        public static IntPtr  GetPicPlayMainHandle(PictureBox pic)
        {
            if (pic.InvokeRequired)
            {
                GetPicPlayMainHandleDelegate delegate1 = new GetPicPlayMainHandleDelegate(GetPicPlayMainHandle);
                return (IntPtr)pic.Invoke(delegate1, new object[] { pic });
            }
            else
            {
                return pic.Handle;
            }
        }
    }
}
