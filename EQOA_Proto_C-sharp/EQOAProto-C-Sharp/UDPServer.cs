﻿using EQLogger;
using ServerSelect;
using System.Net;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using RdpComm;

namespace EQOAProto
{
    /*
    Keep this in main.cs
    Will also start a thread for packet processing
    */
    public class udpServer
    {

        public static System.Timers.Timer OutBoundTimer = new System.Timers.Timer();

        ///Shared queue between udpServer and commManager
        public static Queue<(IPEndPoint, List<byte>)> IncomingQueue = new Queue<(IPEndPoint, List<byte>)>();

        public static void Main(string[] args)
        {

            IPEndPoint remEndpoint = new IPEndPoint(IPAddress.Any, 9764);
            Logger.Info("Starting commManager");
            Thread commManager = new Thread(() => CommManager.ProcPacket());

            ///Start the Thread
            commManager.Start();
            Thread.Sleep(1000);

            List<byte> ClientConnect = new List<byte>{0xea, 0xa0, 0xfe, 0xff, 0xca, 0xe0, 0x21, 0xea, 0xa0, 0x03, 0x00, 0x20, 0x01, 0x00, 0xfb, 
                                                        0x06, 0x01, 0x00, 0x00, 0x00, 0x25, 0x00, 0x00, 0x00, 0xfb, 0x39, 0x02, 0x00, 0x04, 0x09, 
                                                        0x00, 0x03, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00, 0x45, 0x51, 0x4f, 0x41, 0x05, 0x00, 
                                                        0x00, 0x00, 0x62, 0x65, 0x65, 0x62, 0x73, 0x01, 0x4c, 0x93, 0xd6, 0xf6, 0x6a, 0x2c, 0x4a, 
                                                        0x50, 0x5e, 0x71, 0x91, 0xdd, 0xfd, 0x25, 0x35, 0xc0, 0xb7, 0x1c, 0x12, 0xae, 0x76, 0xc4, 
                                                        0x98, 0xfd, 0xf3, 0xce, 0xeb, 0x44, 0x4a, 0x0a, 0x49, 0xb5, 0xfb, 0xc6, 0x51, 0x19};

            List<byte> ClientResponse = new List<byte> {0x12, 0x22, 0xb0, 0x73, 0x87, 0xe0, 0x01, 0x12, 0x22, 0x12, 0x00, 0x23, 0x02, 0x00, 0x01, 
                                                        0x00, 0x01, 0x00, 0x3f, 0xc5, 0x85, 0x1c};

            List<byte> ClientDelSession = new List<byte> {0x12, 0x22, 0xb0, 0x73, 0x80, 0xe0, 0x14, 0x12, 0x22, 0x12, 0x00, 0x12, 0x22, 0x12, 0x00, 
                                                          0xca, 0xe0, 0x21, 0x13, 0x22, 0x12, 0x00, 0x20, 0x01, 0x00, 0xfb, 0x06, 0x01, 0x00, 0x00, 
                                                          0x00, 0x25, 0x00, 0x00, 0x00, 0xfb, 0x39, 0x02, 0x00, 0x01, 0x00, 0x00, 0x03, 0x00, 0x00, 
                                                          0x00, 0x04, 0x00, 0x00, 0x00, 0x45, 0x51, 0x4f, 0x41, 0x05, 0x00, 0x00, 0x00, 0x62, 0x65, 
                                                          0x65, 0x62, 0x73, 0x01, 0x4c, 0x93, 0xd6, 0xf6, 0x6a, 0x2c, 0x4a, 0x50, 0x5e, 0x71, 0x91, 
                                                          0xdd, 0xfd, 0x25, 0x35, 0xc0, 0xb7, 0x1c, 0x12, 0xae, 0x76, 0xc4, 0x98, 0xfd, 0xf3, 0xce, 
                                                          0xeb, 0x44, 0x4a, 0x0a, 0x49, 0xb5, 0x99, 0x1a, 0x31, 0x8a};


            List<byte> ClientConnect2 = new List<byte>{0x12, 0x22, 0xb0, 0x73, 0xca, 0xe0, 0x21, 0x13, 0x22, 0x12, 0x00, 0x20, 0x02, 0x00, 0xfb, 0x06, 0x01, 0x00, 
                                                       0x00, 0x00, 0x25, 0x00, 0x00, 0x00, 0xfb, 0x39, 0x02, 0x00, 0x01, 0x00, 0x00, 0x03, 0x00, 0x00, 0x00, 0x04, 
                                                       0x00, 0x00, 0x00, 0x45, 0x51, 0x4f, 0x41, 0x05, 0x00, 0x00, 0x00, 0x62, 0x65, 0x65, 0x62, 0x73, 0x01, 0x4c, 
                                                       0x93, 0xd6, 0xf6, 0x6a, 0x2c, 0x4a, 0x50, 0x5e, 0x71, 0x91, 0xdd, 0xfd, 0x25, 0x35, 0xc0, 0xb7, 0x1c, 0x12, 
                                                       0xae, 0x76, 0xc4, 0x98, 0xfd, 0xf3, 0xce, 0xeb, 0x44, 0x4a, 0x0a, 0x49, 0xb5, 0x49, 0x16, 0x31, 0x5f};

            List<byte> ClientResponse2 = new List<byte> {0x12, 0x22, 0xb0, 0x73, 0x87, 0xe0, 0x01, 0x13, 0x22, 0x12, 0x00, 0x23, 0x03, 0x00, 0x01, 
                                                         0x00, 0x01, 0x00, 0x5a, 0xc9, 0x57, 0x16};


            ///Load in config for Server Select stuff
            SelectServer.ReadConfig();

            ///Instantiate our UdpListener and toss it into it's own thread
            ///Allows for uninterrupted incoming/outgoing packets
            Thread newListener = new Thread(() => UDPListener.StartListener(IncomingQueue));
            ///Start the Thread
            newListener.Start();
            ///Start commManager
            ///Test
            StartOutBoundTimer();
        }
        
        public static void StartOutBoundTimer()
        {
            ///Our timer for outbound queue
            OutBoundTimer.Elapsed += new ElapsedEventHandler(RdpCommOut.PrepPacket);
            ///Check 10x/second
            OutBoundTimer.Interval = 100;
            ///Enable timer
            OutBoundTimer.Start();
        }
    }
}

