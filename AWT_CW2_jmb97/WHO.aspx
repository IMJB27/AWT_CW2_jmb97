<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WHO.aspx.cs" Inherits="AWT_CW2_jmb97.WHO" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid">
        <div class="row">
             <div class="col mx-auto">
                <div class="card">
                    <div class="card-body">
                         <div class="row">
                          <div class="col-md-9">
                                <label>Country Code</label>
                               <div class="form-group">
                                <div class="input-group">
                                     <asp:Button CssClass="btn btn-success" ID="btLoad" runat="server" Text="Load" OnClick="btLoad_Click"></asp:Button>
                                    <asp:DropDownList CssClass="form-control" ID="ddlCountryCode" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlCountryCode_SelectedIndexChanged" Visible="false">
                                        <asp:ListItem Text="Select" Value=""/> 
                                    </asp:DropDownList>                             
                                </div>
                               </div>
                            </div>

                            <div class="col-md-3">
                                <asp:Label runat="server" Visible="false" ID="Label1">Total Countries Loaded</asp:Label>
                                <div class="form-group">
                                   <asp:Label CssClass="form-control" runat="server" ID="lbTotalCountries" Visible="false"></asp:Label>
   
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-md-1">
                                <asp:Label runat="server">New Cases</asp:Label>
                            </div>
                            <div class="col-md-10">
                               <div class="form-group">
                                <div class="input-group">
                                    <asp:Chart ID="Chart1" CssClass="align-content-md-center" runat="server" BackGradientStyle="LeftRight" Height="150px" Palette="None"   
                                        PaletteCustomColors="192, 0, 0" Width="1300px">  
                                        <Series>  
                                            <asp:Series Name="Series1">  
                                            </asp:Series>  
                                        </Series>  
                                        <ChartAreas>  
                                            <asp:ChartArea Name="ChartArea1" >  
                                            </asp:ChartArea>  
                                        </ChartAreas>  
                                        <BorderSkin BackColor="" PageColor="" />  
                                    </asp:Chart>  
                                </div>
                               </div>
                            </div>
                        </div>  
                        
                        <div class="row">

                             <div class="col-md-1">
                                <asp:Label runat="server">Cumulative Cases</asp:Label>
                            </div>
                            <div class="col-md-10">
                               <div class="form-group">
                                <div class="input-group">
                                    <asp:Chart ID="Chart2" runat="server" BackColor=""   
                                        BackGradientStyle="LeftRight" Height="150px" Palette="None"   
                                        PaletteCustomColors="192, 0, 0" Width="1300px">  
                                        <Series>  
                                            <asp:Series Name="Series1">  
                                            </asp:Series>  
                                        </Series>  
                                        <ChartAreas>  
                                            <asp:ChartArea Name="ChartArea1" >  
                                            </asp:ChartArea>  
                                        </ChartAreas>  
                                        <BorderSkin BackColor="" PageColor="" />  
                                    </asp:Chart>  
                                </div>
                               </div>
                            </div>
                        </div> 
                        
                        <div class="row">
                             <div class="col-md-1">
                                <asp:Label runat="server">New Deaths</asp:Label>
                            </div>
                            <div class="col-md-10">
                               <div class="form-group">
                                <div class="input-group">
                                    <asp:Chart ID="Chart3" runat="server" BackColor=""   
                                        BackGradientStyle="LeftRight" Height="150px" Palette="None"   
                                        PaletteCustomColors="192, 0, 0" Width="1300px">  
                                        <Series>  
                                            <asp:Series Name="Series1">  
                                            </asp:Series>  
                                        </Series>  
                                        <ChartAreas>  
                                            <asp:ChartArea Name="ChartArea1" >  
                                            </asp:ChartArea>  
                                        </ChartAreas>  
                                        <BorderSkin BackColor="" PageColor="" />  
                                    </asp:Chart>   
                                </div>
                               </div>
                            </div>
                        </div>     
                        

                          <div class="row">
                             <div class="col-md-1">
                                <asp:Label runat="server">Cumulative Deaths</asp:Label>
                            </div>
                            <div class="col-md-10">
                               <div class="form-group">
                                <div class="input-group">
                                  <asp:Chart ID="Chart4" runat="server" BackColor=""   
                                        BackGradientStyle="LeftRight" Height="150px" Palette="None"   
                                        PaletteCustomColors="192, 0, 0" Width="1300px">  
                                        <Series>  
                                            <asp:Series Name="Series1">  
                                            </asp:Series>  
                                        </Series>  
                                        <ChartAreas>  
                                            <asp:ChartArea Name="ChartArea1" >  
                                            </asp:ChartArea>  
                                        </ChartAreas>  
                                        <BorderSkin BackColor="" PageColor="" />  
                                    </asp:Chart>  
                                </div>
                               </div>
                            </div>
                        </div> 

                    </div>
                 </div>
              </div>
          </div>
      </div>
</asp:Content>
