using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF18000
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Service1 : IServer
    {
     
        private ICallback callback;
        private string FoursquareTopRight;
        private string FoursquareBottomLeft;
        private uint OTPKey;
        private ulong OFBInitVector;
        private ulong OFBKey;
        private uint delta = 0x9e3779b9;
        private uint[] XXTEAkey = { 0x4a9b1c13, 0x78acd01f, 0x123abc9d, 0x1f5d9a86 };
        public Service1()
        {
            callback = OperationContext.Current.GetCallbackChannel<ICallback>();
            FoursquareTopRight = "ZGPTFOIHMUWDRCNYKEQAXVSBL";
            FoursquareBottomLeft = "MFNBDCRHSAXYOGVITUEWLQZKP";
            OTPKey = 0x42AF70CD;
            OFBInitVector = 0x6A9F18CDE703AD6F;
            OFBKey = 0x5A1D8C0E3AC8F12D;
        }

        public void FourSquareDecrypt(string t)
        {
            string rez = "";
            for (int i = 0; i < t.Length; i += 2)
            {
                int x2 = FoursquareTopRight.IndexOf(t[i]) % 5;
                int y1 = FoursquareTopRight.IndexOf(t[i]) / 5;
                int x1 = FoursquareBottomLeft.IndexOf(t[i + 1]) % 5;
                int y2 = FoursquareBottomLeft.IndexOf(t[i + 1]) / 5;

                char rezChar = (char)('a' + y1 * 5 + x1);
                if (rezChar >= 'j' - 1) rezChar++;
                rez += rezChar;

                rezChar = (char)('a' + y2 * 5 + x2);
                if (rezChar >= 'j' - 1) rezChar++;
                rez += rezChar;
            }

            callback.Message(Encoding.Unicode.GetBytes(rez));
        }
        public void FourSquareEncrypt(string text)
        {
            string result = "";

            if (text.Length % 2 == 1)
            {
                text += 'x';
            }

            text = text.ToLower();

            for (int i = 0; i < text.Length; i += 2)
            {
                char firstChar = text[i];
                if (firstChar >= 'j')
                {
                    firstChar--;
                }

                int firstCharX = (firstChar - 'a') % 5;
                int firstCharY = (firstChar - 'a') / 5;

                char secondChar = text[i + 1];
                if (secondChar >= 'j')
                {
                    secondChar--;
                }

                int secondCharX = (secondChar - 'a') % 5;
                int secondCharY = (secondChar - 'a') / 5;

                result += FoursquareTopRight[firstCharY * 5 + secondCharX];
                result += FoursquareBottomLeft[secondCharY * 5 + firstCharX];
            }

            callback.Message(Encoding.Unicode.GetBytes(result));
        }


        public void OTPEncrypt(byte[] data)
        {
            uint OTPKeyCopy = OTPKey;
            BitArray dataBits = new BitArray(data);
            BitArray encryptedBits = new BitArray(dataBits.Length);
            for (int i = 0; i < dataBits.Length; i++)
            {
                bool keyBit = (OTPKeyCopy >> 31 & 1) == 1;
                encryptedBits[i] = dataBits[i] ^ keyBit;
                OTPKeyCopy = (OTPKeyCopy << 1) | (((OTPKeyCopy >> 20) ^ (OTPKeyCopy >> 17) ^ (OTPKeyCopy >> 15)) & 1);
            }
            byte[] result = new byte[encryptedBits.Length / 8];
            encryptedBits.CopyTo(result, 0);
            callback.Message(result);
        }


        public void OTPDecrypt(byte[] data)
        {
            OTPEncrypt(data);
        }

        public void OFBEncrypt(byte[] data)
        {
            int encLength = data.Length - 54;
            byte[] encData = new byte[encLength + (8 - (encLength % 8))];
            Array.Copy(data, 54, encData, 0, data.Length - 54);

            byte[] rez = new byte[encData.Length + 54];
            Array.Copy(data, 0, rez, 0, 54);
            ulong initVector = OFBInitVector;
            ulong[] plainTextData = new ulong[encData.Length / 8];
            Buffer.BlockCopy(encData, 0, plainTextData, 0, encData.Length);
            for (int i = 0; i < plainTextData.Length; i++)
            {
                ulong plainText = plainTextData[i];
                ulong cipher = initVector ^ OFBKey;
                cipher = (cipher << 3) | (cipher >> 61);
                initVector = cipher;
                cipher ^= plainText;
                byte[] cipherBytes = BitConverter.GetBytes(cipher);
                Array.Copy(cipherBytes, 0, rez, 54 + i * 8, 8);
            }

            callback.Message(rez);
        }

        public void OFBDecrypt(byte[] data)
        {
            OFBEncrypt(data);
        }

 
        public void XXTEAEncrypt(byte[] data)
        {
            int blockCount = (data.Length + 3) / 4;
            uint[] blocks = new uint[blockCount];
            Buffer.BlockCopy(data, 0, blocks, 0, data.Length);

            int rounds = 6 + 52 / 2;
            uint sum = 0;
            uint y, z, e, MX;
            int p;

            for (int i = 0; i < blockCount / 2; i++)
            {
                y = blocks[i * 2];
                z = blocks[i * 2 + 1];
                sum = 0;

                for (int j = 0; j < rounds; j++)
                {
                    sum += delta;
                    e = (sum >> 2) & 3;
                    for (p = 0; p < 2 - 1; p++)
                    {
                        MX = ((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (XXTEAkey[p & 3 ^ e] ^ z));
                        y = blocks[i * 2 + p] += MX;
                    }
                    MX = ((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (XXTEAkey[p & 3 ^ e] ^ z));
                    y = blocks[i * 2] += MX;
                }
            }

            byte[] rez = new byte[blockCount * 4];
            Buffer.BlockCopy(blocks, 0, rez, 0, blockCount * 4);
            callback.Message(rez);
        }
    

       public void XXTEADecrypt(byte[] data)
        {
            int wordCount = data.Length / 4;
            if (data.Length % 4 != 0) wordCount++;
            if (wordCount % 2 != 0) wordCount++;

            uint[] decryptionData = new uint[wordCount];
            decryptionData[wordCount - 1] = 0;
            decryptionData[wordCount - 2] = 0;

            Buffer.BlockCopy(data, 0, decryptionData, 0, data.Length);

            int blockCount = wordCount / 2;
            int rounds, p;
            uint y, z, sum, MX, e;

            byte[] decryptedBytes = new byte[wordCount * 4];

            for (int i = 0; i < blockCount; i++)
            {
                uint[] block = new uint[2];
                block[0] = decryptionData[i * 2];
                block[1] = decryptionData[i * 2 + 1];

                rounds = 6 + 52 / 2;
                sum = ((uint)rounds) * delta;
                y = block[0];

                do
                {
                    e = (sum >> 2) & 3;
                    for (p = 2 - 1; p > 0; p--)
                    {
                        z = block[p - 1];
                        MX = ((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (XXTEAkey[(p & 3) ^ e] ^ z));
                        y = block[p] -= MX;
                    }

                    z = block[2 - 1];
                    MX = ((z >> 5 ^ y << 2) + (y >> 3 ^ z << 4)) ^ ((sum ^ y) + (XXTEAkey[(p & 3) ^ e] ^ z));
                    y = block[0] -= MX;
                    sum -= delta;
                }
                while (--rounds != 0);

                byte[] b0 = BitConverter.GetBytes(block[0]);
                Array.Copy(b0, 0, decryptedBytes, i * 8, 4);
                byte[] b1 = BitConverter.GetBytes(block[1]);
                Array.Copy(b1, 0, decryptedBytes, i * 8 + 4, 4);
            }
            callback.Message(decryptedBytes);
        }
    }
}
