<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TF_TEST1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>


     <style>
    
table, td ,tr {
  border: 2px solid black;
  border-collapse: collapse;
}

</style> 


    <style type="text/css">
        .auto-style1 {
            margin-left: 568px;
            margin-right: 0px;
        }
        .auto-style2 {
            width: 100%;
            margin-bottom: 95px;
        }
        .auto-style3 {
            width: 898px;
            font-size: xx-large;
            text-align: center;
            height: 143px;
        }
        .auto-style4 {
            text-align: center;
            font-size: xx-large;
            width: 684px;
            height: 143px;
        }
        .auto-style5 {
            height: 143px;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">





        <div>



            <table class="auto-style2">
                <tr>
                    <td class="auto-style3">التدريب الميداني </td>
                    <td class="auto-style4">جامعة تبوك&nbsp;
        </td>
                    <td class="auto-style5">
                        <asp:Image ID="Image1" runat="server" Height="100px" Width="150px" />
                    </td>
                </tr>
            </table>

            </div>

        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" PostBackUrl="~/WebForm2.aspx" style="height: 29px" Text="Button" />
            <asp:Login ID="Login1" runat="server" CssClass="auto-style1" Height="211px" Width="402px" OnAuthenticate="Login1_Authenticate" BackColor="#82FF82" BorderPadding="10" BorderStyle="Double" FailureText="تسجيل الدخول" LoginButtonText="تسجيل الدخول " PasswordLabelText="كلمة المرور :" RememberMeText="تذكرني في المره القادمة" TitleText="تسجيل الدخول " UserNameLabelText="رقم المستخدم" BorderWidth="0px">
                <CheckBoxStyle BackColor="#82FF82" Font-Bold="False" />
                <TitleTextStyle Font-Bold="True" />
            </asp:Login>
        </div>




    </form>
</body>
</html>
