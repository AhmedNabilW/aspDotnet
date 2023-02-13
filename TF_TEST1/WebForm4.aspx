<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="TF_TEST1.WebForm4" %>

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
            width: 682px;
        }
        .auto-style4 {
            width: 618px;
        }
        .auto-style5 {
            width: 100%;
        }
        .auto-style6 {
            width: 810px;
        }
        .auto-style7 {
            width: 92px;
            height: 150px;
        }
        .auto-style8 {
            width: 50px;
            height: 150px;
        }
        .auto-style9 {
            text-align: center;
            font-size: xx-large;
            width: 635px;
            height: 150px;
        }
        .auto-style10 {
            text-align: center;
            font-size: xx-large;
            width: 675px;
            height: 150px;
        }
        .auto-style11 {
            height: 150px;
        }
        .auto-style12 {
            margin-left: 0px;
        }
        .auto-style13 {
            float: inherit;
            height: 105px;
            width: 618px;
        }
        </style>


</head>
<body>
    <form id="form1" runat="server">
      

        <div>

            <table class="auto-style5">
                <tr>
                    <td class="auto-style7">
                            <asp:Button ID="Button6" runat="server" BackColor="#82FF82" Height="50px" PostBackUrl="~/WebForm1.aspx" Text="LogOut" Width="142px" />


                            </td>
                    <td class="auto-style8">


                            <asp:Button ID="Button5" runat="server" Text="Home" BackColor="#82FF82" CssClass="auto-style3" Height="50px" Width="142px" PostBackUrl="~/WebForm4.aspx" />
                     </td>
                    <td class="auto-style9">التدريب الميداني </td>
                    <td class="auto-style10">جامعة تبوك </td>
                    <td class="auto-style11">
                        <asp:Image ID="Image1" runat="server" Height="102px" Width="185px" />
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
            
            <td class="auto-style13" style="border-width: 10px; text-align: right">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style2" style="border-width: 10px; text-align: right">: اسم جهة التدريب </td>
        </tr>
        <tr>
            
            <td style="border-width: 10px; text-align: right" class="auto-style4">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </td>
            <td style="border-width: 10px; text-align: right">: رقم الموظف </td>
        </tr>
        <tr>
           
            <td style="border-width: 10px; text-align: right" class="auto-style4">IT </td>
            <td style="border-width: 10px; text-align: right">: المجال</td>
        </tr>
        
         <tr>
           
            <td style="border-width: 10px; text-align: right" class="auto-style4">5</td>
            <td style="border-width: 10px; text-align: right">: عدد المتدربين</td>
        </tr>
    </table>



                <br />
                <br />
        <br />

                <br />


         <div>





             <table class="auto-style5">
                 <tr>
                     <td>
                <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#82FF82" CssClass="auto-style6" ForeColor="Black" Height="45px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="333px">
            <asp:ListItem Selected="True">اختر للتواصل</asp:ListItem>
            <asp:ListItem>الطلاب</asp:ListItem>
            <asp:ListItem>المشرف الاكاديمي</asp:ListItem>
        </asp:DropDownList>


                     </td>
                     <td>


         <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" Width="165px" />  
                     </td>
                    
                     <td> 
        <asp:Button ID="Button3" runat="server" Text="الغياب" Width="333px" BackColor="#82FF82" Height="45px" PostBackUrl="~/WebForm10.aspx" /> 
                     </td>
                     <td>


        <asp:Button ID="Button4" runat="server" CssClass="auto-style12" Text="الطلاب و المهام " Width="333px" BackColor="#82FF82" Height="45px" PostBackUrl="~/WebForm5.aspx" /> 
                     </td>
                 </tr>
             </table>





        </div>


        <br />
        <br />  
        <br />  
        <asp:Label ID="Label1" runat="server" EnableViewState="False"></asp:Label> 




    </form>
</body>
</html>
