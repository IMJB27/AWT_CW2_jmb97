using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using MySql.Data.MySqlClient;
using System.Web.Configuration;
using System.Text;
using System.Web.UI.DataVisualization.Charting;


namespace AWT_CW2_jmb97
{
    public partial class WHO : System.Web.UI.Page
    {
        string constr = WebConfigurationManager.ConnectionStrings["whodataConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            Bindchart();
            Bindchart1();
            Bindchart2();
            Bindchart3();
        }

        private void Bindchart()
        {
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand("SELECT Date_reported, New_cases FROM whodataset where Country_code='" + ddlCountryCode.SelectedValue + "';", con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataTable ChartData = ds.Tables[0];

                    //storing total rows count to loop on each Record  
                    string[] XPointMember = new string[ChartData.Rows.Count];
                    int[] YPointMember = new int[ChartData.Rows.Count];

                    for (int count = 0; count < ChartData.Rows.Count; count++)
                    {
                        //storing Values for X axis  
                        XPointMember[count] = ChartData.Rows[count]["Date_reported"].ToString();
                        //storing values for Y Axis  
                        YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["New_cases"]);


                    }
                    //binding chart control  
                    Chart1.Series[0].Points.DataBindXY(XPointMember, YPointMember);

                    //Setting width of line  
                    Chart1.Series[0].BorderWidth = 1;
                    //setting Chart type   
                    Chart1.Series[0].ChartType = SeriesChartType.Line;
                    Chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                    Chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                    Chart1.Series[0].ChartType = SeriesChartType.Spline;
                    Chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;


                    con.Close();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script");
                }
            }
        }

        private void Bindchart1()
        {
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand("SELECT Date_reported, Cumulative_cases FROM whodataset where Country_code='" + ddlCountryCode.SelectedValue + "';", con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataTable ChartData = ds.Tables[0];

                    //storing total rows count to loop on each Record  
                    string[] XPointMember = new string[ChartData.Rows.Count];
                    int[] YPointMember = new int[ChartData.Rows.Count];

                    for (int count = 0; count < ChartData.Rows.Count; count++)
                    {
                        //storing Values for X axis  
                        XPointMember[count] = ChartData.Rows[count]["Date_reported"].ToString();
                        //storing values for Y Axis  
                        YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["Cumulative_cases"]);


                    }
                    //binding chart control  
                    Chart2.Series[0].Points.DataBindXY(XPointMember, YPointMember);

                    //Setting width of line  
                    Chart2.Series[0].BorderWidth = 1;
                    //setting Chart type   
                    Chart2.Series[0].ChartType = SeriesChartType.Line;
                    Chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                    Chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                    Chart2.Series[0].ChartType = SeriesChartType.Spline;
                    Chart2.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;


                    con.Close();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script");
                }
            }
        }

        private void Bindchart2()
        {
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand("SELECT Date_reported, New_deaths FROM whodataset where Country_code='" + ddlCountryCode.SelectedValue + "';", con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataTable ChartData = ds.Tables[0];

                    //storing total rows count to loop on each Record  
                    string[] XPointMember = new string[ChartData.Rows.Count];
                    int[] YPointMember = new int[ChartData.Rows.Count];

                    for (int count = 0; count < ChartData.Rows.Count; count++)
                    {
                        //storing Values for X axis  
                        XPointMember[count] = ChartData.Rows[count]["Date_reported"].ToString();
                        //storing values for Y Axis  
                        YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["New_deaths"]);


                    }
                    //binding chart control  
                    Chart3.Series[0].Points.DataBindXY(XPointMember, YPointMember);

                    //Setting width of line  
                    Chart3.Series[0].BorderWidth = 1;
                    //setting Chart type   
                    Chart3.Series[0].ChartType = SeriesChartType.Line;
                    Chart3.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                    Chart3.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                    Chart3.Series[0].ChartType = SeriesChartType.Spline;
                    Chart3.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;


                    con.Close();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script");
                }
            }
        }

        private void Bindchart3()
        {
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand("SELECT Date_reported, Cumulative_deaths FROM whodataset where Country_code='" + ddlCountryCode.SelectedValue + "';", con);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    DataTable ChartData = ds.Tables[0];

                    //storing total rows count to loop on each Record  
                    string[] XPointMember = new string[ChartData.Rows.Count];
                    int[] YPointMember = new int[ChartData.Rows.Count];

                    for (int count = 0; count < ChartData.Rows.Count; count++)
                    {
                        //storing Values for X axis  
                        XPointMember[count] = ChartData.Rows[count]["Date_reported"].ToString();
                        //storing values for Y Axis  
                        YPointMember[count] = Convert.ToInt32(ChartData.Rows[count]["Cumulative_deaths"]);


                    }
                    //binding chart control  
                    Chart4.Series[0].Points.DataBindXY(XPointMember, YPointMember);

                    //Setting width of line  
                    Chart4.Series[0].BorderWidth = 1;
                    //setting Chart type   
                    Chart4.Series[0].ChartType = SeriesChartType.Line;
                    Chart4.ChartAreas["ChartArea1"].AxisX.MajorGrid.Enabled = false;
                    Chart4.ChartAreas["ChartArea1"].AxisY.MajorGrid.Enabled = false;
                    Chart4.Series[0].ChartType = SeriesChartType.Spline;
                    Chart4.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;


                    con.Close();

                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script");
                }
            }
        }

        protected void btLoad_Click(object sender, EventArgs e)
        {
            ddlCountryCode.Visible = true;
            Label1.Visible = true;
            lbTotalCountries.Visible = true;
            using (MySqlConnection con = new MySqlConnection(constr))
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    MySqlCommand cmd = new MySqlCommand("SELECT Country_code FROM whodataset GROUP BY Country_Code;", con);
                    MySqlDataAdapter msda = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    msda.Fill(dt);
                    var reader = cmd.ExecuteReader();
                    if (dt.Rows.Count > 0)
                    {
                        while (reader.Read())
                        {
                            lbTotalCountries.Text = dt.Rows.Count.ToString() + " Countries Loaded";
                            ddlCountryCode.Items.Add(reader.GetString("Country_code"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "')</script");
                }
            }
        }

        protected void ddlCountryCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            Bindchart();
            Bindchart1();
            Bindchart2();
            Bindchart3();
        }
    }
}