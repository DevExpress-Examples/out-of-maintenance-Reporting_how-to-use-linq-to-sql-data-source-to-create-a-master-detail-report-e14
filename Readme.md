<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603932/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1455)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/LinqToSqlMasterDetail/Form1.cs) (VB: [Form1.vb](./VB/LinqToSqlMasterDetail/Form1.vb))
* [Program.cs](./CS/LinqToSqlMasterDetail/Program.cs) (VB: [Program.vb](./VB/LinqToSqlMasterDetail/Program.vb))
* [XtraReport1.cs](./CS/LinqToSqlMasterDetail/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/LinqToSqlMasterDetail/XtraReport1.vb))
<!-- default file list end -->
# How to use LINQ to SQL data source to create a Master-Detail report


<p>It's possible to use LINQ to SQL API to bind an XtraReport document to data.<br />
To set up report controls' bindings at design time, use the BindingSource component, which DataSource property is set to the parent (Master) object.<br />
The relation between objects will be recognized automatically.<br />
Then, use a Detail Report Band to create a Master-Detail report layout (see <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument4785">How to: Create a Master-Detail Report using Detail Report Bands</a>).<br />
In the example, Order -> Order_Detail collections (Northwind database) are used.</p><p>In addition, you can filter query results using Linq to Sql syntax.<br />
For instance, use the following code to display a report document, containing Northwind Orders data filtered by customers, whose CustomerID starts with letter "B".</p>

```cs
<newline/>
            NwindDataContext dc = new NwindDataContext();<newline/>
            var _data = from _orders in dc.Orders<newline/>
                        where _orders.CustomerID.StartsWith("B")<newline/>
                        select _orders;<newline/>
            XtraReport1 report = new XtraReport1();<newline/>
            BindingSource bs = (BindingSource)report.DataSource;<newline/>
            bs.DataSource = _data;<newline/>

```



<br/>


