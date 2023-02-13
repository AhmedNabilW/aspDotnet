<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="TF_TEST1.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>



    <style>

        table.center {
  margin-left: auto; 
  margin-right: auto;}



table, tr {
  border: 1.5px solid black;
  border-collapse: collapse;
}
</style>    

        <style type="text/css">
        .auto-style1 {
            width: 50%;
            height: 317px;
            margin-left: 543px;
        }
        .auto-style2 {
            height: 105px;
        }
        .auto-style3 {
            float: inherit;
            height: 105px;
        }
            .auto-style4 {
                width: 100%;
            }
        .auto-style11 {
            font-size: xx-large;
            text-align: center;
            width: 635px;
                height: 150px;
            }
        .auto-style9 {
            font-size: xx-large;
            text-align: center;
            width: 675px;
                height: 150px;
            }
            .auto-style12 {
                height: 150px;
            }
            .auto-style13 {
                width: 131px;
                height: 150px;
            }
            .auto-style14 {
                width: 50px;
                height: 150px;
            }
            .auto-style15 {
                width: 326px;
            }
            .auto-style16 {
                width: 229px;
            }
        </style>

</head>
<body>
    <form id="form1" runat="server">

         <div>




             <table class="auto-style4">
                 <tr>
                     <td class="auto-style13">
                            <asp:Button ID="Button6" runat="server" BackColor="#82FF82" Height="50px" PostBackUrl="~/WebForm1.aspx" Text="LogOut" Width="142px" />


                            </td>
                     <td class="auto-style14">


                            <asp:Button ID="Button5" runat="server" Text="Home" BackColor="#82FF82" CssClass="auto-style3" Height="50px" Width="142px" PostBackUrl="~/WebForm3.aspx" />
                     </td>
                <td class="auto-style11">التدريب الميداني </td>
                <td class="auto-style9">جامعة تبوك </td>
                <td class="auto-style12">
                    <asp:Image ID="Image1" runat="server" />
                </td>
                 </tr>
             </table>




        </div>


      


        <div>
        </div>
        <br />
        <br />
        <br />
        <br />
         <table class="auto-style1" style="text-decoration: blink; border-spacing: 10px">
        <tr>
            
            <td class="auto-style3" style="border-width: 10px; text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style2" style="border-width: 10px; text-align: right">: اسم المعلم </td>
        </tr>
        <tr>
            
            <td style="border-width: 10px; text-align: right">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="border-width: 10px; text-align: right">: الرقم الاكاديمي</td>
        </tr>
        <tr>
           
            <td style="border-width: 10px; text-align: right">كلية الحاسبات وتقنية المعلومات</td>
            <td style="border-width: 10px; text-align: right">: الكلية</td>
        </tr>
        
         <tr>
           
            <td style="border-width: 10px; text-align: right">الثاني 1444</td>
            <td style="border-width: 10px; text-align: right">: الفصل</td>
        </tr>
    </table>



                <br />
                <br />
        <br />
        <br />
         <div>


             <table class="auto-style4">
                 <tr>
                     <td class="auto-style15">
        <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#82FF82" CssClass="auto-style6" ForeColor="Black" Height="45px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="333px" style="margin-top: 0px">
            <asp:ListItem Selected="True">اختر للتواصل</asp:ListItem>
            <asp:ListItem>الطالب</asp:ListItem>
            <asp:ListItem>جهة التدريب</asp:ListItem>
        </asp:DropDownList>
        
                     </td>
                     <td class="auto-style16">
                         <asp:Button ID="Button7" runat="server" OnClick="Button1_Click" Text="submit" Width="262px" />
                     </td>
                     <td>
        
        <asp:Button ID="Button3" runat="server" CssClass="auto-style6" Text="الغياب" Width="454px" BackColor="#82FF82" Height="45px" style="margin-left: 0px" PostBackUrl="~/WebForm9.aspx" /> 
                     </td>
                     <td> 
        <asp:Button ID="Button1" runat="server" CssClass="auto-style6" Text="الطلاب و المهام " Width="454px" BackColor="#82FF82" Height="45px" PostBackUrl="~/WebForm7.aspx" style="margin-left: 0px" /> 
                     </td>
                 </tr>
             </table>


        </div>
        
        <br />
         <br />
         <br />
         <br />



        <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label> 
    </form>
</body>
</html>
