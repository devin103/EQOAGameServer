﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Utility
{
    public static class HotKeyFuncs
    {
        public static Dictionary<string, short> OutHoingHotkeyDict = new Dictionary<string, short> {{"NNNN" , 4}, {"NNNW" , 260}, {"NNNE" , 516}, {"NNNS" , 772}, {"NNWN" , 68},
                                                                                            {"NNWW" , 324}, {"NNWE" , 580}, {"NNWS" , 836}, {"NNEN" , 132}, {"NNEW" , 388},
                                                                                            {"NNEE" , 644}, {"NNES" , 900}, {"NNSN" , 196}, {"NNSW" , 452}, {"NNSE" , 708},
                                                                                            {"NNSS" ,964}, {"NWNN" , 20}, {"NWNW" , 276}, {"NWNE" , 532}, {"NWNS" , 788},
                                                                                            {"NWWN" , 84}, {"NWWW" , 340}, {"NWWE" , 596}, {"NWWS" , 852}, {"NWEN" , 148},
                                                                                            {"NWEW" , 404}, {"NWEE" , 660}, {"NWES" , 916}, {"NWSN" , 212}, {"NWSW" , 468},
                                                                                            {"NWSE" , 724}, {"NWSS" , 980}, {"NENN" , 36}, {"NENW" , 292}, {"NENE" , 548},
                                                                                            {"NENS" , 804}, {"NEWN" , 100}, {"NEWW" , 356}, {"NEWE" , 612}, {"NEWS" , 868},
                                                                                            {"NEEN" , 164}, {"NEEW" ,420}, {"NEEE" , 676}, {"NEES" , 932}, {"NESN" , 228},
                                                                                            {"NESW" , 484}, {"NESE" , 740}, {"NESS" , 996}, {"NSNN" , 52}, {"NSNW" , 308},
                                                                                            {"NSNE" , 564}, {"NSNS" , 820}, {"NSWN" , 116}, {"NSWW" , 372}, {"NSWE" , 628},
                                                                                            {"NSWS" , 884}, {"NSEN" , 180}, {"NSEW" , 436}, {"NSEE" , 692}, {"NSES" , 948},
                                                                                            {"NSSN" , 244}, {"NSSW" , 500}, {"NSSE" , 756}, {"NSSS" , 1012}, {"WNNN" , 8},
                                                                                            {"WNNW" , 264}, {"WNNE" , 520}, {"WNNS" , 776}, {"WNWN" , 72}, {"WNWW" , 328},
                                                                                            {"WNWE" , 584}, {"WNWS" , 840}, {"WNEN" , 136}, {"WNEW" , 392}, {"WNEE" , 648},
                                                                                            {"WNES" , 904}, {"WNSN" , 200}, {"WNSW" , 456}, {"WNSE" , 712}, {"WNSS" , 968},
                                                                                            {"WWNN" , 24}, {"WWNW" , 280}, {"WWNE" , 536}, {"WWNS" , 792}, {"WWWN" , 88},
                                                                                            {"WWWW" , 344}, {"WWWE" , 600}, {"WWWS" , 856}, {"WWEN" , 152}, {"WWEW" , 408},
                                                                                            {"WWEE" , 664}, {"WWES" , 920}, {"WWSN" , 216}, {"WWSW" , 472}, {"WWSE" , 728},
                                                                                            {"WWSS" , 984}, {"WENN" , 40}, {"WENW" , 296}, {"WENE" , 552}, {"WENS" , 808},
                                                                                            {"WEWN" , 104}, {"WEWW" , 360}, {"WEWE" , 616}, {"WEWS" , 872}, {"WEEN" , 168},
                                                                                            {"WEEW" , 424}, {"WEEE" , 680}, {"WEES" , 936}, {"WESN" , 232}, {"WESW" , 488},
                                                                                            {"WESE" , 744}, {"WESS" , 1000}, {"WSNN" , 56}, {"WSNW" , 312}, {"WSNE" , 568},
                                                                                            {"WSNS" , 824}, {"WSWN" , 120}, {"WSWW" , 376}, {"WSWE" , 632}, {"WSWS" , 888},
                                                                                            {"WSEN" , 184}, {"WSEW" , 440}, {"WSEE" , 696}, {"WSES" , 952}, {"WSSN" ,248},
                                                                                            {"WSSW" , 504}, {"WSSE" , 760}, {"WSSS" , 1016}, {"ENNN" , 12}, {"ENNW" , 268},
                                                                                            {"ENNE" , 524}, {"ENNS" , 780}, {"ENWN" , 76}, {"ENWW" , 332}, {"ENWE" , 588},
                                                                                            {"ENWS" , 844}, {"ENEN" , 140}, {"ENEW" , 396}, {"ENEE" , 652}, {"ENES" , 908},
                                                                                            {"ENSN" , 204}, {"ENSW" , 460}, {"ENSE" , 716}, {"ENSS" , 972}, {"EWNN" , 28},
                                                                                            {"EWNW" , 284}, {"EWNE" , 540}, {"EWNS" , 796}, {"EWWN" , 92}, {"EWWW" , 348},
                                                                                            {"EWWE" ,604}, {"EWWS" , 860}, {"EWEN" , 156}, {"EWEW" , 412}, {"EWEE" , 668},
                                                                                            {"EWES" , 924}, {"EWSN" , 220}, {"EWSW" , 476}, {"EWSE" , 732}, {"EWSS" , 988},
                                                                                            {"EENN" , 44}, {"EENW" , 300}, {"EENE" , 556}, {"EENS" , 812}, {"EEWN" , 108},
                                                                                            {"EEWW" , 364}, {"EEWE" , 620}, {"EEWS" , 876}, {"EEEN" , 172}, {"EEEW" , 428},
                                                                                            {"EEEE" , 684}, {"EEES" , 940}, {"EESN" , 236}, {"EESW" , 492}, {"EESE" , 748},
                                                                                            {"EESS" , 1004}, {"ESNN" , 60}, {"ESNW" , 316}, {"ESNE" , 572}, {"ESNS" , 828},
                                                                                            {"ESWN" , 124}, {"ESWW" , 380}, {"ESWE" , 636}, {"ESWS" , 892}, {"ESEN" , 188},
                                                                                            {"ESEW" , 444}, {"ESEE" , 700}, {"ESES" , 956}, {"ESSN" , 252}, {"ESSW" , 508},
                                                                                            {"ESSE" , 764}, {"ESSS" , 1020}, {"SNNN" , 16}, {"SNNW" , 272}, {"SNNE" , 528},
                                                                                            {"SNNS" , 784}, {"SNWN" , 80}, {"SNWW" , 336}, {"SNWE" , 592}, {"SNWS" , 848},
                                                                                            {"SNEN" , 144}, {"SNEW" , 400}, {"SNEE" , 656}, {"SNES" , 912}, {"SNSN" , 208},
                                                                                            {"SNSW" , 464}, {"SNSE" , 720}, {"SNSS" , 976}, {"SWNN" , 32}, {"SWNW" , 288},
                                                                                            {"SWNE" , 544}, {"SWNS" , 800}, {"SWWN" , 96}, {"SWWW" , 352}, {"SWWE" , 608},
                                                                                            {"SWWS" , 864}, {"SWEN" , 160}, {"SWEW" , 416}, {"SWEE" , 672}, {"SWES" , 928},
                                                                                            {"SWSN" , 224}, {"SWSW" , 480}, {"SWSE" , 736}, {"SWSS" , 992}, {"SENN" , 48},
                                                                                            {"SENW" , 304}, {"SENE" , 560}, {"SENS" , 816}, {"SEWN" , 112}, {"SEWW" , 368},
                                                                                            {"SEWE" , 624}, {"SEWS" , 880}, {"SEEN" , 176}, {"SEEW" , 432}, {"SEEE" , 688},
                                                                                            {"SEES" , 944}, {"SESN" , 240}, {"SESW" , 496}, {"SESE" , 752}, {"SESS" , 1008},
                                                                                            {"SSNN" , 64}, {"SSNW" , 320}, {"SSNE" , 576}, {"SSNS" , 832}, {"SSWN" , 128},
                                                                                            {"SSWW" , 384}, {"SSWE" , 640}, {"SSWS" , 896}, {"SSEN" , 192}, {"SSEW" , 448},
                                                                                            {"SSEE" , 704}, {"SSES" , 960}, {"SSSN" , 256}, {"SSSW" , 512}, {"SSSE" , 768},
                                                                                            {"SSSS" , 1024}, {"NNN" , 3}, {"NNW" , 67}, {"NNE" , 131}, {"NNS" , 195},
                                                                                            {"NWN" , 19}, {"NWW" , 83}, {"NWE" , 147}, {"NWS" , 211}, {"NEN" , 35},
                                                                                            {"NEW" , 99}, {"NEE" , 163}, {"NES" , 227}, {"NSN" , 51}, {"NSW" , 115},
                                                                                            {"NSE" , 179}, {"NSS" , 243}, {"WNN" , 7}, {"WNW" , 71}, {"WNE" , 135},
                                                                                            {"WNS" , 199}, {"WWN" , 23}, {"WWW" , 87}, {"WWE" ,151}, {"WWS" , 215},
                                                                                            {"WEN" , 39}, {"WEW" , 103}, {"WEE" , 167}, {"WES" , 231}, {"WSN" , 55},
                                                                                            {"WSW" , 119}, {"WSE" , 183}, {"WSS" , 247}, {"ENN" , 11}, {"ENW" , 75},
                                                                                            {"ENE" , 139}, {"ENS" , 203}, {"EWN" , 27}, {"EWW" , 91}, {"EWE" , 155},
                                                                                            {"EWS" , 219}, {"EEN" , 43}, {"EEW" , 107}, {"EEE" , 171}, {"EES" , 235},
                                                                                            {"ESN" , 59}, {"ESW" , 123}, {"ESE" , 187}, {"ESS" , 251}, {"SNN" , 15},
                                                                                            {"SNW" , 79}, {"SNE" , 143}, {"SNS" , 207}, {"SWN" , 31}, {"SWW" , 95},
                                                                                            {"SWE" , 159}, {"SWS" , 223}, {"SEN" , 47}, {"SEW" , 111}, {"SEE" , 175},
                                                                                            {"SES" , 239}, {"SSN" , 63}, {"SSW" , 127}, {"SSE" , 191}, {"SSS" , 255},
                                                                                            {"NN" , 2}, {"NW" , 18}, {"NE" , 34}, {"NS" , 50}, {"WN" , 6}, {"WW" , 22},
                                                                                            {"WE" , 38}, {"WS" , 54}, {"EN" , 10}, {"EW" , 26}, {"EE" , 42}, {"ES" , 58},
                                                                                            {"SN", 14}, {"SW" , 30}, {"SE" , 46}, {"SS" , 62}, {"Submenu" , 0x20 },
                                                                                            {"N" , 1}, {"W" , 5}, {"E" , 9}, {"S" , 13}, {"Main Menu" , 0}};
    }
}
