﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;
using System.Security.Cryptography;
using System.Management;
using System.Globalization;
using System.IO;

namespace ShoreTel_Director_Password_Reset_Tool
{
    class License
    {
            /// <summary>
            /// Generates a 16 byte Unique Identification code of a computer
            /// Example: 4876-8DB5-EE85-69D3-FE52-8CF7-395D-2EA9
            /// </summary>
            // Create an md5 sum string of this string

            public void SaveKeyFile()
            {
                using (StreamWriter writer = new StreamWriter("KeyFile", true))
                {
                    writer.WriteLine(GetMd5Sum(Value()));
                }
            }
            static public string GetMd5Sum(string str)
            {
                // First we need to convert the string into bytes, which
                // means using a text encoder.
                Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

                // Create a buffer large enough to hold the string
                byte[] unicodeText = new byte[str.Length * 2];
                enc.GetBytes(str.ToCharArray(), 0, str.Length, unicodeText, 0, true);

                // Now that we have a byte array we can ask the CSP to hash it
                MD5 md5 = new MD5CryptoServiceProvider();
                byte[] result = md5.ComputeHash(unicodeText);

                // Build the final string by converting each byte
                // into hex and appending it to a StringBuilder
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    sb.Append(result[i].ToString("X2"));
                }

                // And return it
                return sb.ToString();
            }
        private static string _fingerPrint = string.Empty;
            public static string Value()
            {
                //You don't need to generate the HWID again if it has already been generated. This is better for performance
                //Also, your HWID generally doesn't change when your computer is turned on but it can happen.
                //It's up to you if you want to keep generating a HWID or not if the function is called.
                if (string.IsNullOrEmpty(_fingerPrint))
                {
                    _fingerPrint = GetHash("CPU >> " + CpuId() + "\nBIOS >> " + BiosId() + "\nBASE >> " + BaseId() + "\nDISK >> " + DiskId() + "\nVIDEO >> " + VideoId() + "\nMAC >> " + MacId());
                }
                return _fingerPrint;
            }
            private static string GetHash(string s)
            {
                //Initialize a new MD5 Crypto Service Provider in order to generate a hash
                MD5 sec = new MD5CryptoServiceProvider();
                //Grab the bytes of the variable 's'
                byte[] bt = Encoding.ASCII.GetBytes(s);
                //Grab the Hexadecimal value of the MD5 hash
                return GetHexString(sec.ComputeHash(bt));
            }

            private static string GetHexString(IList<byte> bt)
            {
                string s = string.Empty;
                for (int i = 0; i < bt.Count; i++)
                {
                    byte b = bt[i];
                    int n = b;
                    int n1 = n & 15;
                    int n2 = (n >> 4) & 15;
                    if (n2 > 9)
                        s += ((char)(n2 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                    else
                        s += n2.ToString(CultureInfo.InvariantCulture);
                    if (n1 > 9)
                        s += ((char)(n1 - 10 + 'A')).ToString(CultureInfo.InvariantCulture);
                    else
                        s += n1.ToString(CultureInfo.InvariantCulture);
                    if ((i + 1) != bt.Count && (i + 1) % 2 == 0) s += "-";
                }
                return s;
            }

            //Return a hardware identifier
            private static string Identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
            {
                string result = "";
                System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementBaseObject mo in moc)
                {
                    if (mo[wmiMustBeTrue].ToString() != "True") continue;
                    //Only get the first one
                    if (result != "") continue;
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
                return result;
            }
            //Return a hardware identifier
            private static string Identifier(string wmiClass, string wmiProperty)
            {
                string result = "";
                System.Management.ManagementClass mc = new System.Management.ManagementClass(wmiClass);
                System.Management.ManagementObjectCollection moc = mc.GetInstances();
                foreach (System.Management.ManagementBaseObject mo in moc)
                {
                    //Only get the first one
                    if (result != "") continue;
                    try
                    {
                        result = mo[wmiProperty].ToString();
                        break;
                    }
                    catch
                    {
                    }
                }
                return result;
            }
            private static string CpuId()
            {
                //Uses first CPU identifier available in order of preference
                //Don't get all identifiers, as it is very time consuming
                string retVal = Identifier("Win32_Processor", "UniqueId");
                if (retVal != "") return retVal;
                retVal = Identifier("Win32_Processor", "ProcessorId");
                if (retVal != "") return retVal;
                retVal = Identifier("Win32_Processor", "Name");
                if (retVal == "") //If no Name, use Manufacturer
                {
                    retVal = Identifier("Win32_Processor", "Manufacturer");
                }
                //Add clock speed for extra security
                retVal += Identifier("Win32_Processor", "MaxClockSpeed");
                return retVal;
            }
            //BIOS Identifier
            private static string BiosId()
            {
                return Identifier("Win32_BIOS", "Manufacturer") + Identifier("Win32_BIOS", "SMBIOSBIOSVersion") + Identifier("Win32_BIOS", "IdentificationCode") + Identifier("Win32_BIOS", "SerialNumber") + Identifier("Win32_BIOS", "ReleaseDate") + Identifier("Win32_BIOS", "Version");
            }
            //Main physical hard drive ID
            private static string DiskId()
            {
                return Identifier("Win32_DiskDrive", "Model") + Identifier("Win32_DiskDrive", "Manufacturer") + Identifier("Win32_DiskDrive", "Signature") + Identifier("Win32_DiskDrive", "TotalHeads");
            }
            //Motherboard ID
            private static string BaseId()
            {
                return Identifier("Win32_BaseBoard", "Model") + Identifier("Win32_BaseBoard", "Manufacturer") + Identifier("Win32_BaseBoard", "Name") + Identifier("Win32_BaseBoard", "SerialNumber");
            }
            //Primary video controller ID
            private static string VideoId()
            {
                return Identifier("Win32_VideoController", "DriverVersion") + Identifier("Win32_VideoController", "Name");
            }
            //First enabled network card ID
            private static string MacId()
            {
                return Identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
            }
        
    }
}
