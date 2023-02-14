<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TF_TEST1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>

    <link href="style/WebForm2_custom_style.css" rel="stylesheet" type="text/css" />
 
</head>
<body>

    <form id="form1" runat="server">

    <div class="header">

           <div class="logo"><asp:Image ID="Image2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/logo2.png" /></div>
           <div class="title">التدريب الميداني جامعة تبوك</div>
            <div class="buttons_container">
               <div><asp:Button ID="Button6"  class="exit" runat="server" PostBackUrl="~/WebForm1.aspx" Text="خروج"/></div>
               <div><asp:Button ID="Button5"  class="home" runat="server" PostBackUrl="~/WebForm2.aspx" Text="الرئيسية"/></div>
            </div>
     </div>



        <div class="table-container">
        
                <table>
                    <tr>
                        <td><asp:Label ID="Label2" runat="server">My name</asp:Label></td>
                        <td>: اسم الطالب </td>
                    </tr>
                    <tr>
            
                        <td><asp:Label ID="Label3" runat="server">My ID</asp:Label></td>
                        <td>: الرقم الجامعي</td>
                    </tr>
                    <tr>
           
                        <td><asp:Label ID="Label4" runat="server">كلية الحاسبات وتقنية المعلومات</asp:Label></td>
                        <td>: الكلية</td>
                    </tr>
                     <tr>
            
                        <td><asp:Label ID="Label5" runat="server">علوم الحاسب</asp:Label></td>
                        <td>: التخصص</td>
                    </tr>
                     <tr>
           
                        <td><asp:Label ID="Label6" runat="server">الثاني 1444</asp:Label></td>
                        <td>: الفصل</td>
                    </tr>
                </table>
            </div>


        
          <div class="control_buttons">

            <asp:Button ID="Button7" class="submit_button" runat="server" OnClick="Button1_Click" Text="تأكيد"/>

            <asp:DropDownList ID="DropDownList1" class="list" runat="server"  ForeColor="Black"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True">اختر للتواصل</asp:ListItem>
                <asp:ListItem>المشرفة الاكاديمي</asp:ListItem>
                <asp:ListItem>جهة التدريب</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="Button3" runat="server" Text="الغياب" PostBackUrl="~/WebForm8.aspx" /> 

            <asp:Button ID="Button2" runat="server" Text="تقديم طلب تدريب" PostBackUrl="~/WebForm11.aspx" /> 

             <asp:Button ID="Button4" runat="server" Text="المهام" PostBackUrl="~/WebForm6.aspx" OnClick="Button4_Click" /> 
        </div>

    </form>
    </body>
</html>
