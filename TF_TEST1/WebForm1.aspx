<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TF_TEST1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <link href="style/main_custom_style.css" rel="stylesheet" type="text/css" />
    <title></title>


</head>
<body>

    <form id="form1" runat="server">

       <div class="header">
           <div class="logo"><asp:Image ID="Image2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/logo2.png" /></div>
           <div class="title">التدريب الميداني جامعة تبوك</div>
        </div>

        <div class="log_in_card">
            <div class="card_title">تسجيل الدخول</div>

                <div class="card_input">
                    <div class="user_name_container">
                        <asp:TextBox ID="Login1" runat="server" placeholder="رقم المستخدم"  dir="rtl"></asp:TextBox>
                    </div>
                    <div class="password_container">
                        <asp:TextBox ID="Login2" runat="server" placeholder="كلمة المرور"  dir="rtl" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="checkbox_container">

                        <label style="border-bottom:solid 1px black">تذكرني</label>
                        <asp:CheckBox ID="CheckBox1" runat="server" />

                    </div>
                    <asp:Button class="submit_button" ID="Button1" runat="server" OnClick="Button1_Click" PostBackUrl="~/WebForm3.aspx" Text="دخول"/>
                </div>
            </div>
    </form>
</body>
</html>
