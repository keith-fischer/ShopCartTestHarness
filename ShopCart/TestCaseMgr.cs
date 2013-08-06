using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Test.ShopCart
{
    public class TestCaseMgr : ProductCatalogMgr
    {
        public string TestCasePath { get; set; }
        public bool TestCasesReady { get; set; }
        public IList<List<string>> TestSuite = new List<List<string>>();
        public int CurrentTestID { get; set; }
        public string Error { get; set; }
        public TestCaseMgr()
        {
            this.Error = "";
            this.TestCasePath = Settings1.Default.TestCasePath;
            this.TestCasesReady = LoadTestcases();
        }

        public string[] getTest()
        {
            return getTest(this.CurrentTestID);
        }
        public string[] getTest(int testID)
        {
            if (testID >= this.TestSuite.Count)
                return null;
            this.CurrentTestID = testID;
            return Utility.getStringArray(this.TestSuite[this.CurrentTestID]);
        }

        public string[] getFirstTest()
        {
            return getTest(0);
        }
        public string[] getNextTest()
        {
            this.CurrentTestID++;
            return getTest();
        }

        public bool LoadTestcases()
        {
            bool rc = false;
            if (Directory.Exists(this.TestCasePath))
            {
                this.TestSuite = new List<List<string>>();
                string[] files = Directory.GetFiles(this.TestCasePath, "*.txt", SearchOption.TopDirectoryOnly);
                if (files != null || files.Length > 0)
                {
                    foreach (string Tfile in files)
                    {
                        List<string> test = Utility.getFileListData(Tfile);
                        if (test != null && test.Count > 0)
                        {
                            this.TestSuite.Add(test);
                        }
                        else
                            this.Error += "Failed to load:" + Path.GetFileName(Tfile);
                    }
                }
                else
                    this.Error += "Failed to load files:" + this.TestCasePath;

                //should load all test cases found
                if (files.Length == this.TestSuite.Count)
                    rc = true;
                else
                    this.Error += "Failed to load all testcases";
            }
            
            return rc;
        }
    }
}
