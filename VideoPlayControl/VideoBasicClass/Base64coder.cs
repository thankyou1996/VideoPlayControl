using System;
using System.Collections.Generic;
using System.Text;

namespace Base64coder
{
    ///<summary>
    ///Base64Encoder 的摘要说明
    ///说明:Base编码类
    ///写作者:Quentin
    ///</summary>
    public class Base64Encoder
    {
        byte[] source;
        public char[] lookupTable = null;
        int length, length2;
        int blockCount;
        int paddingCount;

        public Base64Encoder()
        {
            
             //TODO: 在此处添加构造函数逻辑
            
        }

        public Base64Encoder(byte[] input)
        {
            try
            {
                source = input;
                length = input.Length;
                if ((length % 3) == 0)
                {
                    paddingCount = 0;
                    blockCount = length / 3;
                }
                else
                {
                    paddingCount = 3 - (length % 3);
                    blockCount = (length + paddingCount) / 3;
                }
                length2 = length + paddingCount;
            }
            catch
            {
            }
        }

        public char[] GetEncoded()
        {
            try
            {
                byte[] source2;
                source2 = new byte[length2];

                for (int x = 0; x < length2; x++)
                {
                    if (x < length)
                    {
                        source2[x] = source[x];
                    }
                    else
                    {
                        source2[x] = 0;
                    }
                }

                byte b1, b2, b3;
                byte temp, temp1, temp2, temp3, temp4;
                byte[] buffer = new byte[blockCount * 4];
                char[] result = new char[blockCount * 4];
                for (int x = 0; x < blockCount; x++)
                {
                    b1 = source2[x * 3];
                    b2 = source2[x * 3 + 1];
                    b3 = source2[x * 3 + 2];

                    temp1 = (byte)((b1 & 252) >> 2);//and之后字节右移2bit高位补充00

                    temp = (byte)((b1 & 3) << 4);//and之后字节左移4bit底位补充0000
                    temp2 = (byte)((b2 & 240) >> 4);
                    temp2 += temp;

                    temp = (byte)((b2 & 15) << 2);
                    temp3 = (byte)((b3 & 192) >> 6);
                    temp3 += temp;

                    temp4 = (byte)(b3 & 63);

                    buffer[x * 4] = temp1;
                    buffer[x * 4 + 1] = temp2;
                    buffer[x * 4 + 2] = temp3;
                    buffer[x * 4 + 3] = temp4;

                }

                for (int x = 0; x < blockCount * 4; x++)
                {
                    result[x] = sixbit2char(buffer[x]);
                }


                switch (paddingCount)
                {
                    case 0: break;
                    case 1: result[blockCount * 4 - 1] = '='; break;
                    case 2: result[blockCount * 4 - 1] = '=';
                        result[blockCount * 4 - 2] = '=';
                        break;
                    default: break;
                }
                return result;
            }
            catch { return null; }
        }
        private char sixbit2char(byte b)
        {
            try
            {

                if ((b >= 0) && (b <= 63))
                {
                    return lookupTable[(int)b];
                }
                else
                {
                    return ' ';
                }
            }
            catch
            {
                return ' ';
            }
        }

    }
    ///<summary>
    ///Base64Decoder 的摘要说明。
    ///说明:Base解码类
    ///写作者:Quentin
    ///</summary>
    public class Base64Decoder
    {
        char[] source;
        public char[] lookupTable = null;
        int length, length2, length3;
        int blockCount;
        int paddingCount;

        public Base64Decoder()
        {
            
            // TODO: 在此处添加构造函数逻辑
            
        }

        public Base64Decoder(char[] input)
        {
            try
            {
                if (input.Length <= 0)
                {
                    return;
                }
                int temp = 0;
                source = input;
                length = input.Length;

                for (int x = 0; x < 2; x++)
                {
                    if (input[length - x - 1] == '=')
                        temp++;
                }
                paddingCount = temp;

                blockCount = length / 4;
                length2 = blockCount * 3;
            }
            catch
            { }
        }

        public byte[] GetDecoded()
        {
            try
            {
                byte[] buffer = new byte[length];
                byte[] buffer2 = new byte[length2];

                for (int x = 0; x < length; x++)
                {
                    buffer[x] = char2sixbit(source[x]);
                }

                byte b, b1, b2, b3;
                byte temp1, temp2, temp3, temp4;

                for (int x = 0; x < blockCount; x++)
                {
                    temp1 = buffer[x * 4];
                    temp2 = buffer[x * 4 + 1];
                    temp3 = buffer[x * 4 + 2];
                    temp4 = buffer[x * 4 + 3];

                    b = (byte)(temp1 << 2);
                    b1 = (byte)((temp2 & 48) >> 4);
                    b1 += b;

                    b = (byte)((temp2 & 15) << 4);
                    b2 = (byte)((temp3 & 60) >> 2);
                    b2 += b;

                    b = (byte)((temp3 & 3) << 6);
                    b3 = temp4;
                    b3 += b;

                    buffer2[x * 3] = b1;
                    buffer2[x * 3 + 1] = b2;
                    buffer2[x * 3 + 2] = b3;
                }

                length3 = length2 - paddingCount;
                byte[] result = new byte[length3];

                for (int x = 0; x < length3; x++)
                {
                    result[x] = buffer2[x];
                }

                return result;
            }
            catch
            {
                return null;
            }
        }

        private byte char2sixbit(char c)
        {

            try
            {
                if (c == '=')
                    return 0;
                else
                {
                    for (int x = 0; x < 64; x++)
                    {
                        if (lookupTable[x] == c)
                            return (byte)x;
                    }

                    return 0;
                }
            }
            catch
            {
                return 0;
            }

        }

    }


    //初始密钥：UVWXYZuvwxyzABCDEFG+/0123456789opqrstHIJKLMabcdefgNOPlmnSThijkQR
    /// <summary>
    /// 编码解码类
    /// </summary>
    public class Base64coder
    {
        byte[] bytinput;
        char[] charEncode = null;//存放加密之后的字符数组
        byte[] bytDecoder = null;//解密之后的字节数组
        Base64Decoder baseDecode = null;//解码：解密
        Base64Encoder baseEncode = null;//编码：加密
        char[] lookupTable =null;//初始化密钥

        public Base64coder(string strtable)
        {
            if (strtable == "")
            {
                strtable = "UVWXYZuvwxyzABCDEFG+/0123456789opqrstHIJKLMabcdefgNOPlmnSThijkQR";
            }
            char[] looktable = strtable.ToCharArray();
            if (looktable.Length != 64)
            {
                return;//初始化失败
            }
            //不能有重复项存在
            for (int r = 0; r < looktable.Length - 1; r++)
            {
                for (int c = r + 1; c < looktable.Length; c++)
                {
                    if (looktable[r] == looktable[c])
                    {
                        return;//失败
                    }
                }
            }
            lookupTable = looktable;
        }

        /// <summary>
        /// 编码
        /// </summary>
        /// <param name="strSource">待加密字符串</param>
        /// <returns>返回加密后的字符串</returns>
        public string FunBase64Encode(string strSource)
        {
            try
            {
                initEncoder(strSource);
                string strEncoder = "";//加密之后的字符串
                if (baseEncode != null)
                {
                    charEncode = baseEncode.GetEncoded();
                    for (int i = 0; i < charEncode.Length; i++)
                    {
                        strEncoder += charEncode[i].ToString();
                    }

                    return strEncoder;
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }

        }
        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="strEncoded">有编码的字符串</param>
        /// <returns>解码之后的字符串</returns>
        public string FunBase64Decode(string strEncoded)
        {
            try
            {
                if (strEncoded.Length <= 0)
                {
                    return "";
                }
                charEncode = strEncoded.ToCharArray();//把加密之后的字符串转换成字符数组
                baseDecode = new Base64Decoder(charEncode);
                baseDecode.lookupTable = lookupTable;
                string str = "";
                if (baseDecode != null)
                {

                    bytDecoder = baseDecode.GetDecoded();//返回解密之后的字节数组
                    str = System.Text.Encoding.Default.GetString(bytDecoder);
                    return str;
                }
                else
                {
                    return "";
                }
            }
            catch
            {
                return "";
            }

        }

        private void initEncoder(string strSource)
        {
            if (strSource.Length <= 0)
            {
                return;
            }
            bytinput = System.Text.Encoding.Default.GetBytes(strSource);
            baseEncode = new Base64Encoder(bytinput);
            baseEncode.lookupTable = lookupTable;

        }
        /// <summary>
        /// 设置64位密钥,初始化密钥
        /// </summary>
        /// <param name="strKey">密钥</param>
        /// <returns>设置成功返回true否则位false</returns>
        public bool pSetKey(string strKey)
        {
            try
            {
                //先对strkey进行重复性判断  ????效率有待改进
                char[] charary = strKey.ToCharArray();
                for (int row = 0; row < charary.Length - 1; row++)
                {
                    for (int col = row + 1; col < charary.Length; col++)
                    {

                        {
                            if (charary[row] == charary[col])
                            {
                                return false;
                            }
                        }
                    }
                }
                string str = strKey + "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/";
                //取前64位
                str = str.Substring(0, 64);
                //如果str中有重复的字符的话，则返回false
                //在这里效率可能会比较低了
                char[] charKeyAry = str.ToCharArray();
                for (int i = 0; i < charKeyAry.Length - 1; i++)
                {
                    for (int j = i + 1; j < charKeyAry.Length; j++)
                    {
                        //if(i!=j)
                        {
                            if (charKeyAry[i] == charKeyAry[j])
                            {
                                return false;//64个密钥不允许有重复
                            }
                        }
                    }
                }
                lookupTable = charKeyAry;

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
