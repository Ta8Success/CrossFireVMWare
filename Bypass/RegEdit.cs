using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bypass
{
    class RegEdit
    {
        public static void DeleteRegistry(string regPath)
        {
            try
            {
                RegistryKey registrykeyHKLM = Registry.LocalMachine;
                registrykeyHKLM.DeleteSubKeyTree(regPath);
                registrykeyHKLM.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error 101 - Already Patched"); Console.ResetColor(); ;
            }
        }

        public static void EditRegistry(string regPath, string regName, string regValue)
        {
            try
            {
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey(regPath, true);
                if (myKey != null)
                {
                    myKey.SetValue(regName, regValue, RegistryValueKind.String);
                    myKey.Close();
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error 202 - Run as Administrator // Premission Denied"); Console.ResetColor();
            }
        }
    }
    class BetterRegEdit
    {
        static int MAX_BUFFER = 64;

        public static void Search_Edit(string keyPath, string value)
        {
            try
            {
                GetRegistrySubKeys(keyPath, value);
            }
            catch { };
        }
        private static void GetRegistrySubKeys(string keyPath, string value)
        {
            string[] subKey = new string[MAX_BUFFER];

            string[] rootKey =
                Registry.LocalMachine.OpenSubKey(keyPath).GetSubKeyNames();

            int i = 0;
            foreach (string key in rootKey)
            {
                //Console.WriteLine(rootKey[i]);
                string[] BelowIDE = Registry.LocalMachine.OpenSubKey(keyPath + rootKey[i]).GetSubKeyNames();
                subKey[i] = BelowIDE[0];

                string fullPath = keyPath + rootKey[i] + @"\" + subKey[i];
                //Console.WriteLine(fullPath);
                GetRegistryValue(fullPath, value);

                i++;
            }
        }
        private static bool GetRegistryValue(string valuePath, string value)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(valuePath);
            string[] values = new string[MAX_BUFFER];
            bool isThere = false;

            foreach (string keyName in key.GetValueNames())
            {
                if (keyName == value)
                {
                    EditRegistry(valuePath, value, "RegWin32");
                }
                else
                {
                    isThere = false;
                }
            }
            return isThere;
        }
        public static void DeleteRegistry(string regPath)
        {
            try
            {
                RegistryKey registrykeyHKLM = Registry.LocalMachine;
                registrykeyHKLM.DeleteSubKeyTree(regPath);
                registrykeyHKLM.Close();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error 101 - Already Patched"); Console.ResetColor(); ;
            }
        }
        public static void EditRegistry(string regPath, string regName, string regValue)
        {
            try
            {
                RegistryKey myKey = Registry.LocalMachine.OpenSubKey(regPath, true);
                if (myKey != null)
                {
                    myKey.SetValue(regName, regValue, RegistryValueKind.String);
                    myKey.Close();
                }
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Error 202 - Run as Administrator // Premission Denied"); Console.ResetColor();
            }
        }
    }
}
