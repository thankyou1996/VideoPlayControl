using Microsoft.VisualStudio.TestTools.UnitTesting;
using VideoPlayControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using static VideoPlayControl.SDK_HuaMai;

namespace VideoPlayControl.Tests
{
    [TestClass()]
    public class SDK_HuaMaiTests
    {
        [TestMethod()]
        public void hm_sdk_initTest()
        {
            UInt32 iResult = 0;
            iResult = SDK_HuaMai.hm_sdk_init();
            SDK_HuaMai.hm_sdk_uninit();
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_sdk_uninitTest()
        {
            UInt32 iResult = SDK_HuaMai.hm_sdk_init();
            SDK_HuaMai.hm_sdk_uninit();
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_server_connectTest()
        {
            UInt32 iResult = 0;
            int le = 0;
            try
            {

                //le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                //SDK_HuaMai.hm_sdk_uninit();
                iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                //loginInfo.ip = "huamaiyun.com".ToCharArray();
                //loginInfo.port = 80;
                ////loginInfo.user = "商丘市视频联网报警中心";
                //UTF8Encoding u = new UTF8Encoding();
                //loginInfo.user = "商丘市视频联网报警中心".ToCharArray();
                //loginInfo.password = "2299578".ToCharArray();
                //loginInfo.plat_type = "pc".ToCharArray();
                //loginInfo.hard_ver = "Pentium4".ToCharArray();
                //loginInfo.soft_ver = "v1.1.0.1789".ToCharArray() ;
                //loginInfo.keep_time = 1240;
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                UTF8Encoding u = new UTF8Encoding();
                Encoding e = Encoding.Default;
                UnicodeEncoding une = new UnicodeEncoding();
                Encoding gb2312 = System.Text.Encoding.GetEncoding("gb2312");
                byte[] b = une.GetBytes("商丘市视频联网报警中心");
                byte[] unicodeBytes = Encoding.Convert(Encoding.Default, Encoding.Unicode, b);
                byte[] Temp_b = Encoding.Convert(Encoding.Unicode, Encoding.UTF8, unicodeBytes);
                //byte[] Temp_b = new byte[unicodeBytes.Length+1];
                //for (int i = 0; i < unicodeBytes.Length; i++)
                //{
                //    Temp_b[i] = unicodeBytes[i];
                //}
                //for (int i = unicodeBytes.Length; i < Temp_b.Length; i++)
                //{
                //    Temp_b[i] = 0; 
                //}
                //loginInfo.user = u.GetString(u.GetBytes("商丘市视频联网报警中心"));
                //loginInfo.user = u.GetString(u.GetBytes("鍟嗕笜甯傝棰戣仈缃戞姤璀︿腑蹇"));
                //loginInfo.user = u.GetString(b);
                //b = e.GetBytes("2299579");
                //unicodeBytes = Encoding.Convert(Encoding.Default, Encoding.Unicode, b);
                //loginInfo.password = u.GetString(unicodeBytes);
                //loginInfo.password = "2299579";
                //loginInfo.user = u.GetString(u.GetBytes());
                //loginInfo.user = Marshal.StringToHGlobalAnsi(u.GetString(Temp_b));
                //loginInfo.password = "2299579";
                //loginInfo.user = "hongdongcheng";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                //loginInfo.keep_time = 1;
                IntPtr intptrServerInfo = IntPtr.Zero;
                ////int intErrlog = 0;
                ////UInt32 uiErrlogLength = 0;
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                ////IntPtr i = Marshal.AllocHGlobal(nSizeInfoLength);
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                string strErr = "";
                //int intErrLength = 0;
                ////int le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                ////le = Marshal.SizeOf(typeof(loginInfo.user));
                //le = Marshal.SizeOf(typeof(UInt32));
                //le = Marshal.SizeOf(typeof(ushort));
                ////le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                ////le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                ////le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                ////le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                ////le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                le = Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO));
                iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServerInfo, 0, 0);
                iResult = SDK_HuaMai.hm_server_disconnect(intptrServerInfo);

            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                SDK_HuaMai.hm_sdk_uninit();
            }



            Assert.AreEqual(Convert.ToUInt32(0), iResult);
            //Assert.AreEqual(0, le);
        }

        [TestMethod()]
        public void hm_server_connectTest1()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServerInfo = IntPtr.Zero;
                iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServerInfo, 0, 0);
                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServerInfo);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }
        public static byte[] setByte2(string str, int len)
        {
            byte[] b = Encoding.Default.GetBytes(str);

            byte[] unicodeBytes = Encoding.Convert(Encoding.Default, Encoding.Unicode, b);
            byte[] s = new byte[len];
            for (int i = 0; i < unicodeBytes.Length; i++)
            {
                s[i] = unicodeBytes[i];
            }
            for (int i = unicodeBytes.Length; i < len; i++)
            {
                s[i] = 0;
            }
            return s;
        }
        public void test()
        {
        }

        [TestMethod()]
        public void hm_pu_loginTest()
        {
            UInt32 iResult = 0;
            try
            {
                IntPtr i;
                iResult = SDK_HuaMai.hm_sdk_init();
                iResult = SDK_HuaMai.hm_pu_login("huamaiyun.com", 80, "AB66616C00609", "商丘市视频联网报警中心", "2299578", out i);

            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_server_get_device_listTest()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                IntPtr i;
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServerInfo = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServerInfo, 0, 0);

                iResult = SDK_HuaMai.hm_server_get_device_list(intptrServerInfo);

                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServerInfo);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_server_get_transfer_infoTest()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                IntPtr i;
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServerInfo = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServerInfo, 0, 0);
                Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServerInfo);

                iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServerInfo);

                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServerInfo);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_server_get_treeTest()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                #region 基本记录信息
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServer = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServer, 0, 0);
                #endregion
                Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServer);
                Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServer);
                IntPtr intptrTree = IntPtr.Zero;
                iResult = SDK_HuaMai.hm_server_get_tree(intptrServer, ref intptrTree);

                Temp_iResult = SDK_HuaMai.hm_server_release_tree(intptrTree);
                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServer);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_server_release_treeTest()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                #region 基本记录信息
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServer = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServer, 0, 0);
                #endregion
                Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServer);
                Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServer);
                IntPtr intptrTree = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_get_tree(intptrServer, ref intptrTree);

                iResult = SDK_HuaMai.hm_server_release_tree(intptrTree);

                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServer);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }


        #region 测试公用方法
        #region 公用变量
        IntPtr intptrServer = IntPtr.Zero;
        IntPtr intptrTree = IntPtr.Zero;
        IntPtr iRootNode = IntPtr.Zero;
        IntPtr iNode = IntPtr.Zero;
        int intCount = 0;
        #endregion

        public void Init()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            //NODE_TYPE_INFO typeInfo = NODE_TYPE_INFO.HME_NT_NODE;
            string strDevUrl = "";
            #region 基本信息初始化
            Temp_iResult = SDK_HuaMai.hm_sdk_init();
            _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
            loginInfo.ip = "huamaiyun.com";
            loginInfo.port = 80;
            loginInfo.user = "test1996";
            loginInfo.password = "123456";
            loginInfo.plat_type = "pc";
            loginInfo.hard_ver = "Pentium4";
            loginInfo.soft_ver = "v1.1.0.1789";
            IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
            Marshal.StructureToPtr(loginInfo, iServerInfo, false);
            Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServer, 0, 0);
            #endregion
            Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServer);
            Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServer);
            Temp_iResult = SDK_HuaMai.hm_server_get_tree(intptrServer, ref intptrTree);
            Temp_iResult = SDK_HuaMai.hm_server_get_root(intptrTree, ref iRootNode);
            Temp_iResult = SDK_HuaMai.hm_server_get_children_count(iRootNode, ref intCount);
        }
        public bool GetNode_ByIndex(IntPtr iNodo, int intindex)
        {
            UInt32 Temp_iResult = 0;
            Temp_iResult = SDK_HuaMai.hm_server_get_child_at(iNodo, intindex, ref iNode);
            return Temp_iResult == 0;
        }

        public void Release()
        {
            UInt32 Temp_iResult = 0;
            Temp_iResult = SDK_HuaMai.hm_server_release_tree(intptrTree);
            Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServer);
        }
        #endregion
        [TestMethod()]
        public void hm_server_get_roootTest()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                #region 基本记录信息
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServer = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServer, 0, 0);
                #endregion
                Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServer);
                Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServer);
                IntPtr intptrTree = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_get_tree(intptrServer, ref intptrTree);

                IntPtr iRootNode = IntPtr.Zero;
                iResult = SDK_HuaMai.hm_server_get_root(intptrTree, ref iRootNode);

                Temp_iResult = SDK_HuaMai.hm_server_release_tree(intptrTree);
                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServer);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hn_server_get_children_countTest()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                #region 基本记录信息
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServer = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServer, 0, 0);
                #endregion
                Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServer);
                Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServer);
                IntPtr intptrTree = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_get_tree(intptrServer, ref intptrTree);
                IntPtr iRootNode = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_get_root(intptrTree, ref iRootNode);

                int intCount = 0;
                iResult = SDK_HuaMai.hm_server_get_children_count(iRootNode, ref intCount);

                Temp_iResult = SDK_HuaMai.hm_server_release_tree(intptrTree);
                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServer);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_server_get_child_atTest()
        {
            UInt32 iResult = 0;
            UInt32 Temp_iResult = 0;
            try
            {
                #region 基本记录信息
                Temp_iResult = SDK_HuaMai.hm_sdk_init();
                _LOGIN_SERVER_INFO loginInfo = new _LOGIN_SERVER_INFO();
                loginInfo.ip = "huamaiyun.com";
                loginInfo.port = 80;
                loginInfo.user = "test1996";
                loginInfo.password = "123456";
                loginInfo.plat_type = "pc";
                loginInfo.hard_ver = "Pentium4";
                loginInfo.soft_ver = "v1.1.0.1789";
                IntPtr iServerInfo = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(_LOGIN_SERVER_INFO)));
                Marshal.StructureToPtr(loginInfo, iServerInfo, false);
                IntPtr intptrServer = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_connect(iServerInfo, ref intptrServer, 0, 0);
                #endregion
                Temp_iResult = SDK_HuaMai.hm_server_get_device_list(intptrServer);
                Temp_iResult = SDK_HuaMai.hm_server_get_transfer_info(intptrServer);
                IntPtr intptrTree = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_get_tree(intptrServer, ref intptrTree);
                IntPtr iRootNode = IntPtr.Zero;
                Temp_iResult = SDK_HuaMai.hm_server_get_root(intptrTree, ref iRootNode);
                int intCount = 0;
                Temp_iResult = SDK_HuaMai.hm_server_get_children_count(iRootNode, ref intCount);

                string strSN = "E322213C04245";
                IntPtr iDevSN = Marshal.StringToHGlobalAnsi(strSN);
                IntPtr iNode = SDK_HuaMai.hm_server_find_device_by_sn(intptrTree, iDevSN);

                if (iNode == IntPtr.Zero)
                {
                    iResult = Convert.ToUInt32(1);
                }
                else
                {
                    iResult = Convert.ToUInt32(0);
                }

                Temp_iResult = SDK_HuaMai.hm_server_release_tree(intptrTree);
                Temp_iResult = SDK_HuaMai.hm_server_disconnect(intptrServer);
            }
            catch (Exception ex)
            {
                iResult = 999999;
            }
            finally
            {
                Temp_iResult = SDK_HuaMai.hm_sdk_uninit();
            }
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }

        [TestMethod()]
        public void hm_server_find_device_by_snTest()
        {
            Init();
            string strDevSN = "E322213C04245";
            IntPtr iDevSN = Marshal.StringToHGlobalUni(strDevSN);
            IntPtr iNode = SDK_HuaMai.hm_server_find_device_by_sn(intptrTree, iDevSN);
            Release();
            Assert.AreEqual(IntPtr.Zero, iNode);
        }

        [TestMethod()]
        public void hm_server_get_node_typeTest()
        {
            UInt32 iResult = 0;
            NODE_TYPE_INFO typeInfo = NODE_TYPE_INFO.HME_NT_NODE;
            Init();
            if (!GetNode_ByIndex(iRootNode, 3))
            {
                Release();
                Assert.Fail();
            }
            iResult = SDK_HuaMai.hm_server_get_node_type(iNode, ref typeInfo);
            Release();
            Assert.AreEqual(NODE_TYPE_INFO.HME_NT_NODE, typeInfo);
        }

        [TestMethod()]
        public void hm_server_get_node_nameTest()
        {
            UInt32 iResult = 0;
            string strDevName = "";
            Init();
            if (!GetNode_ByIndex(iRootNode, 6))
            {
                Release();
                Assert.Fail();
            }
            IntPtr iDevName = IntPtr.Zero;
            iResult = SDK_HuaMai.hm_server_get_node_name(iNode, ref iDevName);
            string Temp_strDevName = Marshal.PtrToStringAnsi(iDevName);
            Temp_strDevName = Temp_strDevName.Replace('?', '0');
            strDevName = Encoding.UTF8.GetString(Encoding.Default.GetBytes(Temp_strDevName));
            //strDevName = Encoding.UTF8.GetString(Encoding.Default.GetBytes(Encoding.UTF8.GetString(Encoding.UTF8.GetBytes(Temp_strDevName))));
            Release();
            Assert.AreEqual("", strDevName);
        }

        [TestMethod()]
        public void hm_server_device_snTest()
        {
            UInt32 iResult = 0;
            string strDevSN = "";
            Init();
            if (!GetNode_ByIndex(iRootNode, 3))
            {
                Release();
                Assert.Fail();
            }
            IntPtr iDevSN = IntPtr.Zero;
            iResult = SDK_HuaMai.hm_server_get_device_sn(iNode, ref iDevSN);
            strDevSN = Marshal.PtrToStringAnsi(iDevSN);
            Release();
            Assert.AreEqual("", strDevSN);
        }

        [TestMethod()]
        public void hm_server_device_urlTest()
        {
            UInt32 iResult = 0;
            string strUrl = "";
            Init();
            if (!GetNode_ByIndex(iRootNode, 3))
            {
                Release();
                Assert.Fail();
            }
            IntPtr iDevUrl = IntPtr.Zero;
            iResult = SDK_HuaMai.hm_server_get_device_url(iNode, ref iDevUrl);
            strUrl = Marshal.PtrToStringAnsi(iDevUrl);
            Release();
            Assert.AreEqual("", strUrl);
        }

        [TestMethod()]
        public void hm_server_is_onlineTest()
        {
            UInt32 iResult = 0;
            bool bolOnlie = false;
            Init();
            if (!GetNode_ByIndex(iRootNode, 3))
            {
                Release();
                Assert.Fail();
            }
            iResult = SDK_HuaMai.hm_server_is_online(iNode, ref bolOnlie);
            Release();
            Assert.IsTrue(bolOnlie);
        }

        [TestMethod()]
        public void hm_server_login_exTest()
        {
            UInt32 iResult = 0;
            Init();
            if (!GetNode_ByIndex(iRootNode, 3))
            {
                Release();
                Assert.Fail();
            }
            IntPtr iDev = IntPtr.Zero;
            _CONNECT_INFO config = new _CONNECT_INFO();
            config.ct = CLIENT_TYPE.CT_PC;
            config.cp = CONNECT_PRI.CPI_DEF;
            iResult = SDK_HuaMai.hm_pu_login_ex(iNode, ref iDev);
            Release();
            Assert.AreEqual(Convert.ToUInt32(0), iResult);
        }
    }
}