using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Utils;
namespace Test.ShopCart
{
    class Utility : Utils.Utils
    {
        static public string[] getStringArray(List<string> list)
        {
            string[] rc = new string[list.Count];
            list.CopyTo(rc);
            return rc;
        }
        static internal List<string> getFileListData(string path)
        {
            List<string> fdata = new List<string>();
            string[] data = Utils.Utils.GetTextArray(path);
            if (data != null && data.Length > 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != null || data[i].Length > 0)
                    {
                        data[i] = data[i].Split(new char[] { '\t' })[0].Trim();
                        fdata.Add(data[i]);
                    }
                }
            }
            else
                return null;
            return fdata;
        }
    }
}
