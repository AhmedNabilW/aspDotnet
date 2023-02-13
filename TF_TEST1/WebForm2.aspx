<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="TF_TEST1.WebForm2" %>

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
            height: 47px;
            width: 50%;
            margin-right: auto;
            margin-left: auto;
        }
        .table-container{
            width: 100%;
            /*background-color : red;*/
        }
        .auto-style2 {
            height: 47px;
            width: 133px;
        }
        .auto-style3 {
            float: inherit;
            height: 47px;
            width: 864px;
        }
        .auto-style7 {
            width: 100%;
        }
        .auto-style9 {
            font-size: xx-large;
            text-align: center;
            width: 812px;
            height: 55px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        .auto-style13 {
            width: 337px;
        }
        .auto-style15 {
            width: 277px;
        }
        .auto-style16 {
            float: inherit;
            margin-left: 7px;
        }
        .auto-style17 {
            margin-left: 40px;
            margin-right: 40px;
        }
        .auto-style18 {
            width: 168px;
            height: 55px;
        }
        .auto-style19 {
            width: 123px;
            height: 55px;
        }
        .auto-style20 {
            width: 124px;
            height: 55px;
        }
        .auto-style21 {
            float: inherit;
            margin-left: 26px;
        }
        .auto-style22 {
            height: 45px;
            width: 133px;
        }
        .auto-style23 {
            height: 39px;
            width: 133px;
        }
        .auto-style24 {
            height: 45px;
            width: 864px;
        }
        .auto-style25 {
            height: 39px;
            width: 864px;
        }
        .auto-style26 {
            height: 46px;
            width: 864px;
        }
        .auto-style27 {
            height: 46px;
            width: 133px;
        }
        
    </style>
</head>
<body>

    <form id="form1" runat="server">

    <div>



        <table align="center" class="auto-style7">
            <tr>
                <td class="auto-style20" style="margin: auto auto auto 20px">
                            <asp:Button ID="Button6" runat="server" BackColor="#82FF82" Height="50px" PostBackUrl="~/WebForm1.aspx" Text="Log out" Width="110px" CssClass="auto-style21" />


                            </td>
                <td class="auto-style19">


                            <asp:Button ID="Button5" runat="server" Text="Home" BackColor="#82FF82" CssClass="auto-style16" Height="50px" Width="110px" PostBackUrl="~/WebForm2.aspx" />
                </td>
                <td class="auto-style9">جامعة تبوك - التدريب الميداني&nbsp; </td>
                <td class="auto-style18">
                    <asp:Image ID="Image1" runat="server" CssClass="auto-style17" Height="100px" ImageAlign="Middle" Width="100px" ImageUrl="~/logo.png" />
                </td>
            </tr>
        </table>



        </div>



        
        <br />
        <br />
        <br />
        <br />
        <div class="table-container">
        
                <table class="auto-style1">
                    <tr>
            
                        <td class="auto-style3" style="text-align: center">
                            <asp:Label ID="Label2" runat="server"></asp:Label>
                            My name</td>
                        <td class="auto-style2" style="padding: 10px; text-align: right">: اسم الطالب </td>
                    </tr>
                    <tr>
            
                        <td style="text-align: center" class="auto-style24">
                            <asp:Label ID="Label3" runat="server"></asp:Label>
                            My ID</td>
                        <td style="padding: 10px; text-align: right" class="auto-style22">: الرقم الجامعي</td>
                    </tr>
                    <tr>
           
                        <td style="text-align: center" class="auto-style24">كلية الحاسبات وتقنية المعلومات</td>
                        <td style="padding: 10px; text-align: right" class="auto-style22">: الكلية</td>
                    </tr>
                     <tr>
            
                        <td style="text-align: center" class="auto-style25">علوم الحاسب</td>
                        <td style="padding: 10px; text-align: right" class="auto-style23">: التخصص</td>
                    </tr>
                     <tr>
           
                        <td style="text-align: center" class="auto-style26">الثاني 1444</td>
                        <td style="padding: 10px; text-align: right" class="auto-style27">: الفصل</td>
                    </tr>
                </table>
            </div>


        <br />
        <br />

        <br />
        <br />
        
          <div>

              <table class="auto-style7">
                  <tr>
                      <td class="auto-style13">
        <asp:DropDownList ID="DropDownList1" runat="server" BackColor="#82FF82" CssClass="auto-style14" ForeColor="Black" Height="45px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="333px">
            <asp:ListItem Selected="True">اختر للتواصل</asp:ListItem>
            <asp:ListItem>المشرفة الاكاديمي</asp:ListItem>
            <asp:ListItem>جهة التدريب</asp:ListItem>
        </asp:DropDownList>
        
        
       
                      </td>
                      <td class="auto-style15">
        
        
       
                          <asp:Button ID="Button7" runat="server" OnClick="Button1_Click" Text="submit" Width="254px" />
                      </td>
                      <td> 
        <asp:Button ID="Button3" runat="server" CssClass="auto-style14" Text="الغياب" Width="310px" BackColor="#82FF82" Height="45px" PostBackUrl="~/WebForm8.aspx" /> 
                      </td>
                      <td> 
                          &nbsp;</td>
                      <td> 
        <asp:Button ID="Button2" runat="server" CssClass="auto-style14" Text="تقديم طلب تدريب" Width="310px" BackColor="#82FF82" Height="45px" PostBackUrl="~/WebForm11.aspx" /> 
                      </td>
                      <td>


        <asp:Button ID="Button4" runat="server" CssClass="auto-style14" Text="المهام" Width="310px" BackColor="#82FF82" Height="45px" PostBackUrl="~/WebForm6.aspx" /> 
                      </td>
                  </tr>
              </table>

        </div>


        <br />
        
                 <br />
         <br />
         <br />



    </form>
    </body>
</html>
