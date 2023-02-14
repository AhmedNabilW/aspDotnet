<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="TF_TEST1.WebForm6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link href="style/style2_custom.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
       

       <div class="header">
             <div class="logo"><asp:Image ID="Image2" runat="server" Height="100px" Width="100px" ImageUrl="~/images/logo2.png" /></div>
                    <div class="title">التدريب الميداني جامعة تبوك</div>
                    <div class="buttons_container">
                       <div><asp:Button ID="Button6" runat="server" class="exit" PostBackUrl="~/WebForm1.aspx" Text="خروج"/></div>
                       <div><asp:Button ID="Button5" runat="server" class="home" PostBackUrl="~/WebForm2.aspx"  Text="الرئيسية" /></div>
              </div>
        </div>




        <div><h2  style="text-align:center; margin-top:10px;" >(المهام (الطالب </h2></div>

        <div>
            <h2 class="table_header" >weekly Assessments </h2>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server"  CssClass="checkBoxList" EnableTheming="True" TextAlign="Left" Width="850px" Enabled="False">
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
