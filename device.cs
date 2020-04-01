using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EndaModbus
{
    class device
    {
        private byte[] Data = null;
        private byte[] CasualData = null;

        #region Function Code 4
        public byte[] ReadInputRegister(byte DeviceID, ushort RegisterAdress, byte RegisterCount)
        {
            Data = null;
            Data = new byte[8];
            Data[0] = DeviceID;
            Data[1] = 4;
            #region RegisterAdress 
            if (RegisterAdress > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterAdress);
                Data[2] = CasualData[0];
                Data[3] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[2] = 0;
                Data[3] = (byte)RegisterAdress;
            }
            #endregion
            #region RegisterCount
            if (RegisterCount > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterCount);
                Data[4] = CasualData[0];
                Data[5] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[4] = 0;
                Data[5] = RegisterCount;
            }
            #endregion
            #region Crc
            CasualData = new byte[2];
            CasualData = Crc_Calculatin(Data);
            Data[6] = CasualData[1];
            Data[7] = CasualData[0];
            CasualData = null;
            #endregion
            return Data;
        }
        #endregion

        #region Function Code 2
        public byte[] ReadDiscreteInputs(byte DeviceID,ushort RegisterAdress,ushort RegisterCount)
        {
            Data = null;
            Data = new byte[8];
            CasualData = null;
            Data[0] = DeviceID;
            Data[1] = 2;
            #region RegisterAdress
            if (RegisterAdress > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterAdress);
                Data[2] = CasualData[0];
                Data[3] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[2] = 0;
                Data[3] = (byte)RegisterAdress;
            }
            #endregion
            #region RegisterCount
            if (RegisterCount > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterCount);
                Data[4] = CasualData[0];
                Data[5] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[4] = 0;
                Data[5] = (byte)RegisterCount;
            }
            #endregion
            #region Crc
            CasualData = new byte[2];
            CasualData = Crc_Calculatin(Data);
            Data[6] = CasualData[1];
            Data[7] = CasualData[0];
            CasualData = null;
            #endregion
            return Data;
        }
        #endregion

        #region Function Code 1
        public byte[] ReadCoilsStatus(byte DeviceID, ushort RegisterAdress, ushort RegisterCount)
        {
            Data = null;
            Data = new byte[8];
            CasualData = null;
            Data[0] = DeviceID;
            Data[1] = 1;
            #region RegisterAdress
            if (RegisterAdress > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterAdress);
                Data[2] = CasualData[0];
                Data[3] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[2] = 0;
                Data[3] = (byte)RegisterAdress;
            }
            #endregion
            #region RegisterCount
            if (RegisterCount > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterCount);
                Data[4] = CasualData[0];
                Data[5] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[4] = 0;
                Data[5] = (byte)RegisterCount;
            }
            #endregion
            #region Crc
            CasualData = new byte[2];
            CasualData = Crc_Calculatin(Data);
            Data[6] = CasualData[1];
            Data[7] = CasualData[0];
            CasualData = null;
            #endregion
            return Data;
        }
        #endregion

        #region Function Code 3
        public byte[] ReadHoldingRegister(byte DeviceID, ushort RegisterAdress, byte RegisterCount)
        {
            Data = null;
            Data = new byte[8];
            Data[0] = DeviceID;
            Data[1] = 3;
            #region RegisterAdress 
            if (RegisterAdress > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterAdress);
                Data[2] = CasualData[0];
                Data[3] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[2] = 0;
                Data[3] = (byte)RegisterAdress;
            }
            #endregion
            #region RegisterCount
            if (RegisterCount > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterCount);
                Data[4] = CasualData[0];
                Data[5] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[4] = 0;
                Data[5] = RegisterCount;
            }
            #endregion
            #region Crc
            CasualData = new byte[2];
            CasualData = Crc_Calculatin(Data);
            Data[6] = CasualData[1];
            Data[7] = CasualData[0];
            CasualData = null;
            #endregion
            return Data;
        }
        #endregion

        #region Function Code 6
        public byte[] WriteSingleRegister(byte DeviceID,ushort RegisterAdress,short WriteData)
        {
            Data = null;
            Data = new byte[8];
            Data[0] = DeviceID;
            Data[1] = 6;
            #region RegisterAdress
            if (RegisterAdress>255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(RegisterAdress);
                Data[2] = CasualData[0];
                Data[3] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[2] = 0;
                Data[3] = (byte)RegisterAdress;
            }
            #endregion
            #region WriteData
            if (WriteData > 255)
            {
                CasualData = new byte[2];
                CasualData = WordToByte(WriteData);
                Data[4] = CasualData[0];
                Data[5] = CasualData[1];
                CasualData = null;
            }
            else
            {
                Data[4] = 0;
                Data[5] = (byte)WriteData;
            }
            #endregion
            #region Crc
            CasualData = new byte[2];
            CasualData = Crc_Calculatin(Data);
            Data[6] = CasualData[1];
            Data[7] = CasualData[0];
            #endregion
            return Data;

        }
        #endregion

        private byte[] WordToByte(int Number)
        {
            byte[] WordToByte = new byte[2];
            int j = 7;
            byte sum = 0;
            string _number = Convert.ToString(Number, 2);
            if (_number.Length < 16)
            {
                for (int i = _number.Length ; i < 16; i++)
                {
                    _number = "0" + _number;
                }
            }
            for (int i = 0; i < 8; i++)
            {
                if (_number[i] == '1')
                {
                    sum += (byte)Math.Pow(2, j);
                }
                j--;
            }
            WordToByte[0] = sum;
            sum = 0;
            j = 7;
            for (int i = 8; i < 16; i++)
            {
                if (_number[i] == '1')
                {
                    sum += (byte)Math.Pow(2, j);
                }
                j--;
            }
            WordToByte[1] = sum;
            sum = 0;
            return WordToByte;
        }
        private byte[] Crc_Calculatin(byte[] buf)
        {
            UInt16 crc = 0xFFFF;
            for (int pos = 0; pos < buf.Length - 2; pos++)
            {
                crc ^= (UInt16)buf[pos];
                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }
            CasualData = new byte[2];
            CasualData = WordToByte(crc);
            return CasualData;
        }
    }
}
