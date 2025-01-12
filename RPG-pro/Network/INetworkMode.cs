﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Network
{
    /// <summary>
    /// 指示一个参与 <see cref="NetworkCore"/> 工作的对象.
    /// </summary>
    public interface INetworkMode
    {
        /// <summary>
        /// 发送数据.
        /// <br>[!] 该方法为每帧执行.</br>
        /// </summary>
        /// <param name="writer">写入流.</param>
        void SendDatas(BinaryWriter writer, NetModeState state);

        /// <summary>
        /// 读取数据.
        /// <br>[!] 该方法将会每帧执行.</br>
        /// </summary>
        /// <param name="reader">读取流.</param>
        void ReceiveDatas(BinaryReader reader, NetModeState state);
    }

    public class Server : INetworkMode
    {
        public void SendDatas(BinaryWriter writer, NetModeState state)
        {

        }
        public void ReceiveDatas(BinaryReader reader, NetModeState state)
        {

        }
    }
}
