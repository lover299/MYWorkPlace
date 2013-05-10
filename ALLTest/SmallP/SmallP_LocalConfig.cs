using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmallP
{
    public class SmallP_LocalConfig
    {

        /// <summary>
        /// 去除冗余项 0
        /// </summary>
        /// <param name="message"></param>
        /// <param name="count">连续0的个数</param>
        /// <returns></returns>
        private static byte[] MessageDele(byte[] message, int count)
        {
            List<byte> temp = new List<byte>();
            //if (message.Count() < count)
            //{
            //    return new byte[1];
            //}
            int zerocount = 0;
            for (int i = 0; i < message.Count(); i++)
            {
                temp.Add(message[i]);
                if (message[i] == 0)
                {
                    zerocount++;
                }
                else
                {
                    zerocount = 0;
                }
                if (zerocount == count)
                {
                    temp.RemoveRange(temp.Count - count, count);
                    break;
                }
            }

            if (temp.Count != 0)
            {
                return temp.ToArray();
            }
            else
            {
                return new byte[1];
            }

        }
        /// <summary>
        /// string转16进制byte[]  byte[999]为错误
        /// </summary>
        /// <param name="hex">'-', ',', '.', '，'</param>
        /// <returns></returns>
        public static byte[] StringToByteArray(string hex)
        {
            try
            {


                //hex = hex.Replace()
                //BitConverter
                string[] hexs = hex.Split('-', ',', '.', '，');

                byte[] tempp = hexs.Select(x => Convert.ToByte(x, 16)).ToArray();
                //foreach (var item in hexs)
                //{
                //    Convert.ToByte(item);
                return tempp;
            }
            catch
            {
                //MessageBox.Show("格式错误！");
                return new byte[999];
            }
        }
    }
}
