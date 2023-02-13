<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="TF_TEST1.WebForm7" %>

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
            width: 100%;
        }
        .auto-style2 {
            width: 101px;
        }
        .auto-style3 {
            width: 125px;
        }
        .auto-style4 {
            width: 100px;
        }
        .auto-style5 {
            width: 466px;
            text-align: center;
            font-size: xx-large;
        }
        .auto-style6 {
            width: 921px;
            text-align: center;
            font-size: xx-large;
        }
        .auto-style7 {
            width: 450px;
        }
        .auto-style8 {
            width: 321px;
        }
        .auto-style9 {
            margin-left: 0px;
        }
        .auto-style10 {
            width: 338px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       
        
        <div>



            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                            <asp:Button ID="Button6" runat="server" BackColor="#82FF82" Height="50px" PostBackUrl="~/WebForm1.aspx" Text="LogOut" Width="142px" />


                                    </td>
                    <td class="auto-style4">


                            <asp:Button ID="Button5" runat="server" Text="Home" BackColor="#82FF82" CssClass="auto-style3" Height="50px" Width="142px" PostBackUrl="~/WebForm3.aspx" />
                                    </td>
                    <td class="auto-style5">التدريب الميداني </td>
                    <td class="auto-style6">جامعة تبوك </td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="102px" Width="185px" />
                                    </td>
                </tr>
            </table>



            </div>








        <div>
             <br />
            <h2  style="text-align:center;" >(المهام (المشرف </h2>
        </div>
         <div>

              <table class="auto-style1">
                  <tr>
                      <td class="auto-style7">&nbsp;</td>
                      <td class="auto-style8">
                          <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#82FF82" Width="289px">
                              <asp:ListItem Selected="True">اختر الطالب</asp:ListItem>
                              <asp:ListItem>مؤيد حسين محمد - 391010486</asp:ListItem>
                          </asp:DropDownList>
                      </td>
                      <td class="auto-style10">
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
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" BackColor="#82FF82" BorderStyle="Dotted" CellPadding="10" CssClass="auto-style1" EnableTheming="True" Font-Bold="True" TextAlign="Left" Width="850px" style="margin-left: 330px" Enabled="False">
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
