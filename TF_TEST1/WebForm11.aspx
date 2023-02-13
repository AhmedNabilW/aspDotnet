<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="TF_TEST1.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table.center {
  margin-left: auto; 
  margin-right: auto;}



table, tr {
  border: 1px solid black;
  border-collapse: collapse;
}
</style>  
        <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 125px;
        }
        .auto-style3 {
            float: inherit;
            height: 105px;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style8 {
            width: 134px;
            height: 150px;
        }
        .auto-style9 {
            font-size: xx-large;
            text-align: center;
            width: 674px;
            height: 150px;
        }
        .auto-style10 {
            width: 99px;
            height: 150px;
        }
        .auto-style11 {
            font-size: xx-large;
            text-align: center;
            width: 635px;
            height: 150px;
        }
        .auto-style12 {
            height: 150px;
        }
            .auto-style13 {
                text-align: center;
                font-size: x-large;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <div>



        <table align="center" class="auto-style7">
            <tr>
                <td class="auto-style8">
                            <asp:Button ID="Button6" runat="server" BackColor="#82FF82" Height="50px" PostBackUrl="~/WebForm1.aspx" Text="LogOut" Width="142px" />


                            </td>
                <td class="auto-style10">


                            <asp:Button ID="Button5" runat="server" Text="Home" BackColor="#82FF82" CssClass="auto-style3" Height="50px" Width="142px" PostBackUrl="~/WebForm2.aspx" />
                </td>
                <td class="auto-style11">التدريب الميداني </td>
                <td class="auto-style9">جامعة تبوك </td>
                <td class="auto-style12">
                    <asp:Image ID="Image1" runat="server" />
                </td>
            </tr>
        </table>

        <br />

        </div>


        <br />


        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style13">
                        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style13">: الرقم الاكاديمي</td>
                    <td class="auto-style13">
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style13">: اسم الطالب</td>
                </tr>
            </table>

            </div>
        <br />
        <br />
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style13">تقديم طلب تدريب </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:TextBox ID="TextBox1" runat="server" Height="353px" Width="1000px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <asp:Button ID="Button7" runat="server" BackColor="#82FF82" Height="44px" Text="submit" Width="213px" />
                    </td>
                </tr>
            </table>

        </div>



        <div>

        </div>
    </form>
</body>
</html>
