using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace Test.ShopCart
{
    public class ProductCatalogMgr
    {

        public string ProductCatalogPathXML { get; set; }
        public string ProductCatalogPathXSD { get; set; }
        internal DataSet ShopcartCatalog { get; set; }
        public void ReadData()
        {
            ReadData(this.ProductCatalogPathXML);
        }


        public void ReadData(string path)
        {
            this.ShopcartCatalog = null;
            //default path & filenames
            if (path == null || !File.Exists(path) || !File.Exists(this.ProductCatalogPathXML))
            {
                this.ProductCatalogPathXML = Utility.THIS_PATH + "\\ProductCatData.xml";
                this.ProductCatalogPathXSD = Utility.THIS_PATH + "\\ProductCatData.xsd";
            }

            //overide
            if (path !=null && File.Exists(path))
            {
                this.ProductCatalogPathXML = path;
                //xsd must have same file name
                this.ProductCatalogPathXSD = Path.GetDirectoryName(this.ProductCatalogPathXML) +
                    "\\" + Path.GetFileNameWithoutExtension(this.ProductCatalogPathXML) + ".xsd";
            }

            if (File.Exists(this.ProductCatalogPathXML) && File.Exists(this.ProductCatalogPathXSD))
            {
                this.ShopcartCatalog = new DataSet();
                this.ShopcartCatalog.ReadXmlSchema(this.ProductCatalogPathXSD);
                this.ShopcartCatalog.ReadXml(this.ProductCatalogPathXML);
            }

        }

        public  void Loaddata()
        {
            var connStr = Settings1.Default.ProductCatalogConnectionString;// "Data Source=KFISCHER-DT\\SQLEXPRESS;Initial Catalog=ProductCatalog;Integrated Security=True";
            //var xmlFileData = "";
            DataSet ds = new DataSet();
            DataSet db = new DataSet();
            DataTable dt = new DataTable();
            string[] tables = Settings1.Default.DataTableNames.Split(new char[] { ',' });
            //var tables = new[] { "Product", "ProductBundle" ,"ProductSku","ProductSkuRule","ProductType"};
            foreach (var table in tables)
            {

                var query = "SELECT "+table+".* FROM " + table;// + " WHERE (Hospital_Code = 'Hosp1')";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                dt.TableName = table;
                da.Fill(dt);
                
                db.Tables.Add(dt);

                conn.Close();
                conn.Dispose();
                //xmlFileData += db.GetXml();
            }
            db.WriteXml("C:\\temp\\ProductCatData.xml");
            db.WriteXmlSchema("C:\\temp\\ProductCatData.xsd");
            //xmlFileData += db.GetXml();
            //File.WriteAllText("C://SelectiveDatabaseBackup.xml", xmlFileData);
        }
    }
}
