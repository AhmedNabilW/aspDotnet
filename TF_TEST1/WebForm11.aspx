<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm11.aspx.cs" Inherits="TF_TEST1.WebForm11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style/style4_custom.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">



        <div class="header">
             <div class="logo"><asp:Image ID="Image2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/logo2.png" /></div>
                    <div class="title">التدريب الميداني جامعة تبوك</div>
                    <div class="buttons_container">
                       <div><asp:Button ID="Button1" runat="server" class="exit" PostBackUrl="~/WebForm1.aspx" Text="خروج"/></div>
                       <div><asp:Button ID="Button2" runat="server" class="home" PostBackUrl="~/WebForm2.aspx"  Text="الرئيسية" /></div>
                    </div>
         </div>



        <div class="title_table">
            <table>
                <tr>
                    <td><asp:Label ID="ID_label" runat="server" Text="Label"></asp:Label></td>
                    <td>: الرقم الاكاديمي</td>
                    <td><asp:Label ID="Name_label" runat="server" Text="Label"></asp:Label></td>
                    <td>: اسم الطالب</td>
                </tr>
            </table>
       </div>


        <div class="message_container">
            <table>
                <tr>
                    <td><h3 style="text-align:center;">تقديم طلب تدريب</h3></td>
                </tr>
                <tr>
                    <td><textarea id="TextArea1" placeholder="أدخل طلبك هنا..." dir="rtl"></textarea></td>
                </tr>
                <tr>
                    <td><asp:Button ID="Button7" class="send_button" runat="server" Text="إرسال" /></td>
                </tr>
            </table>
        </div>

    </form>
</body>
</html>
