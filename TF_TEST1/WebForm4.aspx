<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="TF_TEST1.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link href="style/style1_custom.css" rel="stylesheet" type="text/css" />


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


             <div class="table-container">
        
                <table>
                    <tr>
                        <td><asp:Label ID="Label2" runat="server" Text="Label"></asp:Label></td>
                        <td>: اسم جهة التدريب </td>
                    </tr>
                    <tr>
            
                        <td><asp:Label ID="Label3" runat="server" Text="Label"></asp:Label></td>
                        <td>: رقم الموظف</td>
                    </tr>
                    <tr>
           
                        <td><asp:Label ID="Label6" runat="server">كلية الحاسبات وتقنية المعلومات</asp:Label></td>
                        <td>: المجال</td>
                    </tr>
                     <tr>
           
                        <td><asp:Label ID="Label7" runat="server">الثاني 1444</asp:Label></td>
                        <td>: عدد المتدربين</td>
                    </tr>
                </table>
            </div>



        <div class="control_buttons">

            <asp:Button ID="Button1" class="submit_button" runat="server" OnClick="Button1_Click" Text="تأكيد"/> 

            <asp:DropDownList ID="DropDownList1" class="list" runat="server"  OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Selected="True">اختر للتواصل</asp:ListItem>
                <asp:ListItem>الطلاب</asp:ListItem>
                <asp:ListItem>المشرف الاكاديمي</asp:ListItem>
            </asp:DropDownList>

             <asp:Button ID="Button3" runat="server" Text="الغياب" PostBackUrl="~/WebForm10.aspx" />  

            <asp:Button ID="Button4" runat="server" Text="الطلاب و المهام " PostBackUrl="~/WebForm5.aspx" /> 


         </div>
 
        <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label> 


    </form>
</body>
</html>
