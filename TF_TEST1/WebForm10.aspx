<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm10.aspx.cs" Inherits="TF_TEST1.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
     <link href="style/style3_custom.css" rel="stylesheet" type="text/css" />

</head>
<body>

    <form id="form1" runat="server">


         <div class="header">
             <div class="logo"><asp:Image ID="Image2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/logo2.png" /></div>
                    <div class="title">التدريب الميداني جامعة تبوك</div>
                    <div class="buttons_container">
                       <div><asp:Button ID="Button6" runat="server" class="exit" PostBackUrl="~/WebForm1.aspx" Text="خروج"/></div>
                       <div><asp:Button ID="Button5" runat="server" class="home" PostBackUrl="~/WebForm4.aspx"  Text="الرئيسية" /></div>
                    </div>
         </div>
    
      


        <div style=" text-align:center;font-size:30px; margin: 20px 0; padding: 10px;">
            <h3>الغياب(جهة التدريب)</h3>
        </div>




        
        <div class="database_view">
<%--              <table class="auto-style7">
                  <tr>
                      <td class="auto-style27">&nbsp;</td>
                      <td class="auto-style28">
                          <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#82FF82" Width="289px" DataSourceID="SqlDataSource1" DataTextField="Name_Student" DataValueField="Name_Student">
                              <asp:ListItem Selected="True">اختر الطالب</asp:ListItem>
                              <asp:ListItem>مؤيد حسين محمد - 391010486</asp:ListItem>
                          </asp:DropDownList>
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:project databaseConnectionString %>" SelectCommand="SELECT [Name_Student] FROM [Attendance_Student]"></asp:SqlDataSource>
                      </td>
                      <td class="auto-style29">
                          <asp:Button ID="Button7" runat="server" BackColor="#82FF82" CssClass="auto-style30" Text="submit" Width="280px" OnClick="Button7_Click" />
                      </td>
                      <td>&nbsp;</td>
                  </tr>
              </table>--%>
        </div>
  
<div class="content_table">
                         <table>
                             <tr>
                                <td ><strong>التاريخ</strong></td>
                                <td><strong>غائب</strong></td>
                                <td><strong>متأخر</strong></td>
                             </tr>
                        <tr>
                           <td>
                               <asp:Label ID="Label1" runat="server" Text="date"></asp:Label></td>
                            <td>
                                <asp:CheckBox ID="CheckBox1" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                            <td>
                                <asp:CheckBox ID="CheckBox41" runat="server" Enabled="False" />
                            </td>
                        </tr>
                        <tr>
                            <td><asp:Label ID="Label2" runat="server" Text="date"></asp:Label></td>
                            <td>
                                <asp:CheckBox ID="CheckBox2" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                            <td>
                                <asp:CheckBox ID="CheckBox42" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                        </tr>
                        <tr>
                           <td><asp:Label ID="Label3" runat="server" Text="date"></asp:Label></td>
                            <td>
                                <asp:CheckBox ID="CheckBox3" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                            <td>
                                <asp:CheckBox ID="CheckBox43" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                        </tr>
                        <tr>
                           <td><asp:Label ID="Label4" runat="server" Text="date"></asp:Label></td>
                            <td>
                                <asp:CheckBox ID="CheckBox4" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                            <td>
                                <asp:CheckBox ID="CheckBox44" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                        </tr>
                        <tr>
                          <td><asp:Label ID="Label5" runat="server" Text="date"></asp:Label></td>
                            <td>
                                <asp:CheckBox ID="CheckBox5" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                            <td>
                                <asp:CheckBox ID="CheckBox45" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                        </tr>
                        <tr>
                          <td><asp:Label ID="Label6" runat="server" Text="date"></asp:Label></td>
                            <td>
                                <asp:CheckBox ID="CheckBox6" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                            <td>
                                <asp:CheckBox ID="CheckBox46" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                            </td>
                        </tr>
                </table>
            </div>



    </form>
    </body>
</html>
