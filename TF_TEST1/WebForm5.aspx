<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="TF_TEST1.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>

        table.center {
  margin-left: auto; 
  margin-right: auto;}



table, tr {
  border: 2px solid black;
  border-collapse: collapse;
}
</style>    


    <style type="text/css">
        .auto-style1 {
            margin-left: 330px;
            margin-right: 0px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 125px;
        }
        .auto-style4 {
            width: 119px;
            height: 150px;
        }
        .auto-style5 {
            width: 574px;
            text-align: center;
            font-size: xx-large;
            height: 150px;
        }
        .auto-style6 {
            width: 1078px;
            text-align: center;
            font-size: xx-large;
            height: 150px;
        }
        .auto-style7 {
            width: 125px;
            height: 150px;
        }
        .auto-style8 {
            height: 150px;
        }
        .auto-style9 {
            width: 595px;
        }
        .auto-style10 {
            width: 321px;
        }
        .auto-style11 {
            width: 338px;
        }
        .auto-style12 {
            width: 459px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <div>
                            <table class="auto-style2">
                                <tr>
                                    <td class="auto-style7">
                            <asp:Button ID="Button6" runat="server" BackColor="#82FF82" Height="50px" PostBackUrl="~/WebForm1.aspx" Text="LogOut" Width="142px" />


                                    </td>
                                    <td class="auto-style4">


                            <asp:Button ID="Button5" runat="server" Text="Home" BackColor="#82FF82" CssClass="auto-style3" Height="50px" Width="142px" PostBackUrl="~/WebForm4.aspx" />
                                    </td>
                                    <td class="auto-style5">التدريب الميداني </td>
                                    <td class="auto-style6">جامعة تبوك </td>
                                    <td class="auto-style8">
                        <asp:Image ID="Image1" runat="server" Height="102px" Width="185px" />
                                    </td>
                                </tr>
                            </table>
            </div>

        


        <div>
             <br />
            <h2  style="text-align:center;" >(المهام (جهة التدريب </h2>
        </div>

         <div>

              <table class="auto-style2">
                  <tr>
                      <td class="auto-style12">&nbsp;</td>
                      <td class="auto-style10">
                          <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#82FF82" Width="289px" DataSourceID="SqlDataSource1" DataTextField="Name_Student" DataValueField="Name_Student">
                              <asp:ListItem Selected="True">اختر الطالب</asp:ListItem>
                          </asp:DropDownList>
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=DESKTOP-1HIT6UB\SQLEXPRESS;Initial Catalog=&quot;project database&quot;;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Name_Student] FROM [Student_Info]" OnSelecting="SqlDataSource1_Selecting"></asp:SqlDataSource>
                      </td>
                      <td class="auto-style11">
                          <asp:Button ID="Button7" runat="server" BackColor="#82FF82" CssClass="auto-style9" Text="submit" Width="280px" />
                      </td>
                      <td>&nbsp;</td>
                  </tr>
              </table>

              </div>

        <div>
             <br />
             <br />
             <br />
             <br />
             <br />
            <h2  style="text-align:center;" >weekly Assessments </h2>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" BackColor="#82FF82" BorderStyle="Dotted" CellPadding="10" CssClass="auto-style1" EnableTheming="True" Font-Bold="True" TextAlign="Left" Width="850px">
                <asp:ListItem>Recognize the organization workflow , and tools used in the organization field</asp:ListItem>
                <asp:ListItem> Practise on models , tools and hardware </asp:ListItem>
                <asp:ListItem>Learn practical management process for real computer based systems</asp:ListItem>
                <asp:ListItem>Create , analyze , and design model for a specific computer based problem</asp:ListItem>
                <asp:ListItem> Implement and test a small application </asp:ListItem>
                <asp:ListItem>Study and analyze the structure of the developed system in the organization field </asp:ListItem>
                <asp:ListItem>Debug and finalize the implemented solution of a specific computer based problem</asp:ListItem>
                <asp:ListItem>Study the Database structure</asp:ListItem>
                <asp:ListItem> Study and analyze the structure of the computer networks deployed in the organization field </asp:ListItem>
                <asp:ListItem>Test the overall system , and correct and fix system errors in specific computer based problem</asp:ListItem>
                <asp:ListItem>Conduct Computer maintenance</asp:ListItem>
                <asp:ListItem> Conduct Network maintenance </asp:ListItem>
                <asp:ListItem>Write technical reports</asp:ListItem>
                <asp:ListItem>Conduct presentation on computer based problem</asp:ListItem>
                <asp:ListItem> Faculty Assessment</asp:ListItem>
            </asp:CheckBoxList>

            </div>


    </form>
</body>
</html>
