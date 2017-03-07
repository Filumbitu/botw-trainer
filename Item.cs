﻿namespace BotwTrainer
{
    using System;
    using System.Linq;

    public class Item
    {
        public string Name { get; set; }

        public uint NameStart { get; set; }

        public uint BaseAddress { get; set; }

        public string BaseAddressHex
        {
            get
            {
                return this.BaseAddress.ToString("x8").ToUpper();
            }
        }

        public uint Value { get; set; }

        public string ValueHex
        {
            get
            {
                return this.Value.ToString("x8").ToUpper();
            }
        }

        public uint Equipped { get; set; }

        public bool EquippedBool
        {
            get
            {
                try
                {
                    var val = BitConverter.GetBytes(this.Equipped).Reverse().First().ToString();
                    return val != "0";
                }
                catch
                {
                    return false;
                }
                
            }
        }

        public string Modifier1Value { get; set; }

        public string Modifier1Address
        {
            get
            {
                var offset = this.BaseAddress + 0x5c;
                return offset.ToString("x8").ToUpper();
            }
        }

        public string Modifier2Value { get; set; }

        public string Modifier2Address
        {
            get
            {
                var offset = this.BaseAddress + 0x60;
                return offset.ToString("x8").ToUpper();
            }
        }

        public string Modifier3Value { get; set; }

        public string Modifier3Address
        {
            get
            {
                var offset = this.BaseAddress + 0x64;
                return offset.ToString("x8").ToUpper();
            }
        }

        public string Modifier4Value { get; set; }

        public string Modifier4Address
        {
            get
            {
                var offset = this.BaseAddress + 0x68;
                return offset.ToString("x8").ToUpper();
            }
        }

        public string Modifier5Value { get; set; }

        public string Modifier5Address
        {
            get
            {
                var offset = this.BaseAddress + 0x6c;
                return offset.ToString("x8").ToUpper();
            }
        }

        public int Page { get; set; }

        public int Unknown { get; set; }
    }
}

/*X00000YY
X = Modifier Level (0 = Level 1, 8 = Level 2)
YY = Modifier Type
--
01 = Attack Up
02 = Durability Up
04 = Critical Hit
08 = Long Throw
10 = Five-Shot Burst
20 = Zoom x3
40 = Quick Shot
80 = Shield Surf Up*/