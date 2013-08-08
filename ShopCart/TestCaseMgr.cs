using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Test.ShopCart
{
    public class TestStep
    {
        public int Qty {get;set;}
        public string Sku {get;set;}
        public string ProdType {get;set;}
        public string Description {get;set;}
        public string ProductID { get; set; }
    }

    public class TestCaseMgr : ProductCatalogMgr
    {
        public delegate void runTeststep(TestStep testStep);
        public event runTeststep RunTestStep;
        public delegate void testStart(string test);
        public event testStart TestStart;
        public delegate void testStop();
        public event testStop TestStop;

        public string TestCasePath { get; set; }
        public bool TestCasesReady { get; set; }
        public IList<List<TestStep>> TestSuite = new List<List<TestStep>>();
        public int CurrentTestID { get; set; }
        public string Error { get; set; }

        public TestCaseMgr()
        {
            this.Error = "";
            this.TestCasePath = Settings1.Default.TestCasePath;
            this.TestCasesReady = LoadTestcases();
        }

        public List<TestStep> getTest()
        {
            return getTest(this.CurrentTestID);
        }

        public List<TestStep> getTest(int testID)
        {
            if (testID >= 0 && (testID < this.TestSuite.Count))
            {
                this.CurrentTestID = testID;
                return this.TestSuite[this.CurrentTestID];

            }
            else
                this.CurrentTestID = -1;
            return null;
        }

        public List<TestStep> getFirstTest()
        {
            return getTest(0);
        }

        public List<TestStep> getNextTest()
        {
            this.CurrentTestID++;
            return getTest();
        }

        private enum TestCaseRow { Qty, Sku, ProdType, Description, ProductID };
        private List<TestStep> getFileListData(string path)
        {
            
            List<TestStep> fdata = new List<TestStep>();
            TestStep tstep = null;
            string[] data = Utils.Utils.GetTextArray(path);
            string[] cols = null;
            int n;
            bool row_ok = false;
            if (data != null && data.Length > 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    if (data[i] != null || data[i].Length > 0)
                    {
                        cols = data[i].Split(new char[] { '\t' });
                        tstep = new TestStep();
                        row_ok = false;
                        if (cols != null)
                        {
                            if (cols.Length > 0)
                            {
                                if (cols[(int)TestCaseRow.Qty].Trim() == "+")
                                    tstep.Qty = 1;
                                else if (cols[(int)TestCaseRow.Qty].Trim() == "-")
                                    tstep.Qty = -1;
                                else
                                {
                                    if (!int.TryParse(cols[(int)TestCaseRow.Qty].Trim(), out n))
                                    {
                                        this.Error += "\r\nFAILED Field Qty:";
                                        continue;
                                    }
                                    else
                                        tstep.Qty = n;
                                }
                            }
                            if (cols.Length > 1)
                            {
                                tstep.Sku = cols[(int)TestCaseRow.Sku].Trim();
                                if (tstep.Sku != null && tstep.Sku.Length >= 3)
                                    row_ok = true;
                                else
                                {
                                    this.Error += "\r\nFAILED Field SKU:";
                                    continue;
                                }
                            }
                            //extra optional info for reporting(not used)
                            if (cols.Length > 2)
                                tstep.ProdType = cols[(int)TestCaseRow.ProdType].Trim();
                            if (cols.Length > 3)
                                tstep.Description = cols[(int)TestCaseRow.Description].Trim();
                            if (cols.Length > 4)
                                tstep.ProductID = cols[(int)TestCaseRow.ProductID].Trim();
                            if(row_ok)
                                fdata.Add(tstep);
                            else
                                this.Error += "\r\nFAILED To Load:" + path;

                        }
                    }
                }
            }
            else
                return null;
            return fdata;
        }
        public void RunAllTest()
        {
            List<TestStep> thisTest;
            thisTest=this.getFirstTest();
            
            while (this.CurrentTestID >= 0)
            {
                RunTest(thisTest);
                thisTest = this.getNextTest();
            }
        }
        public void RunTest(List<TestStep> thisTest)
        {
            if (thisTest == null || thisTest.Count == 0)
                return;
            foreach (TestStep ts in thisTest)
            {
                eventRunTestStep(ts);
            }
        }

        private void eventRunTestStep(TestStep testStep)
        {
            if(this.RunTestStep!=null)
                this.RunTestStep(testStep);
        }
        public bool LoadTestcases()
        {
            bool rc = false;
            if (Directory.Exists(this.TestCasePath))
            {
                this.Error = "";
                this.TestSuite = new List<List<TestStep>>();
                string[] files = Directory.GetFiles(this.TestCasePath, "*.txt", SearchOption.TopDirectoryOnly);
                if (files != null || files.Length > 0)
                {
                    foreach (string Tfile in files)
                    {
                        List<TestStep> test = getFileListData(Tfile);
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
