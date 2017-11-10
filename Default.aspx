<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h1 style="color:blue;" align="center">Welcome!!</h1>
        <p class="lead">
           
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: larger; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">About<span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
           
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">The Solar Energy Service in this TryIt page returns the annual solar geometry (which determines factor of heat gain, shading and the potential of daylight penetration) of a given position<span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">This service can be used for deciding if installing solar energy device is effective at the location based on latitude and longitude<span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
            <br />
            
             <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">URL of the Service:</span>
            <a font-size: large; style="color:blue;" href="http://localhost:57404/Service1.svc"> http://localhost:57404/Service1.svc </a>

            <br />
            <br />
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: bold; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Method name: SolarIntensity <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	   
            <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Input: latitude and longitude   ( Type: Integer, Range: -90 to 89 )  <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        <span style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: large; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">Output: Solar Intensity  ( Type: Double, Range: -180 to 179 )  <span>&nbsp;</span></span><br style="color: rgb(0, 0, 0); font-family: &quot;Times New Roman&quot;; font-size: medium; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; text-decoration-style: initial; text-decoration-color: initial;" />
	        
            <div>
                    <br />
	   <asp:Label ID="Label2" runat="server" Text="Enter the latitude" Width="150px" BorderStyle="Groove"></asp:Label>&nbsp;
       <asp:TextBox ID="LatitudeInput" runat="server" Height="25px" Width="100px" BorderColor="#999999" ></asp:TextBox>
               
  
          
          <br />
                <br />
	   <asp:Label ID="Label1" runat="server" Text="Enter the longitude" Width="150px"  BorderStyle="Groove"></asp:Label>&nbsp;
       <asp:TextBox ID="LongitudeInput" runat="server" Height="25px" Width="100px" BorderColor="#999999" ></asp:TextBox>&nbsp;
     

	</div>
            <br />
            &nbsp; &nbsp;  &nbsp;  &nbsp;  &nbsp;  &nbsp;     &nbsp;     &nbsp;  &nbsp;           &nbsp;     &nbsp;     &nbsp;     &nbsp;     &nbsp;     &nbsp;    &nbsp;     &nbsp;     &nbsp;     &nbsp;     &nbsp;     &nbsp;     &nbsp; 
     
              <asp:Button ID="button1" runat="server" Width="80px" OnClick="button1_Click" Text="Submit" />

	<p>  <br />  
      
  
        <asp:Label ID="SolarResult" text-align="center" font-size="20px"   ForeColor="blue"  color="LightGreen" Visible="false" runat="server" Text="" ></asp:Label>     </p>                            

	<div>
</asp:Content>
