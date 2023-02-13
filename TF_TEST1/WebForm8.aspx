<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="TF_TEST1.WebForm8" %>

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
        .auto-style16 {
            text-align: center;
        }
        .auto-style17 {
            font-size: xx-large;
        }
        .auto-style22 {
            border: 2px solid black;
            border-collapse: collapse;
            width: 539px;
            text-align: center;
        }
        .auto-style23 {
            border: 2px solid black;
            border-collapse: collapse;
            width: 11657px;
            text-align: center;
        }
        .auto-style24 {
            border: 2px solid black;
            border-collapse: collapse;
            width: 439px;
            text-align: center;
        }
        .auto-style25 {
            border: 2px solid black;
            border-collapse: collapse;
            width: 880px;
            text-align: center;
            margin-left: 295px;
        }
        .auto-style26 {
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



        </div>



        <div>
        </div>
        <br />
    
      

        <div>



            <table class="auto-style7">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style16">
                        <asp:Label ID="Label2" runat="server" CssClass="auto-style17" Text="الغياب"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>



        </div>
        <br />
        <br /> <br />


        <br />
        <div>

            <table class="auto-style7">
                <tr>
                    <td class="auto-style26">
                        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style26">: الرقم الاكاديمي</td>
                    <td class="auto-style26">
                        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                    </td>
                    <td class="auto-style26">: اسم الطالب</td>
                </tr>
            </table>

            </div>
        <br />

        <br />
        <br />
        
          <div>



              <table class="auto-style7">
                  <tr>
                      <td>&nbsp;</td>
                      <td>
                          <table class="auto-style25">
                                             <tr>
                    <td class="auto-style23"><strong>التاريخ</strong></td>
                    <td class="auto-style22"><strong>غائب</strong></td>
                    <td class="auto-style24"><strong>متأخر</strong></td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox1" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox41" runat="server" Enabled="False" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox2" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox42" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox3" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox43" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox4" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox44" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox5" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox45" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox6" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox46" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox7" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox47" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox8" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox48" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox9" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox49" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox10" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox50" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox11" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox51" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox12" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox52" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox13" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox53" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox14" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox54" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox15" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox55" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox16" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox56" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox17" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox57" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox18" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox58" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox19" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox59" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox20" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox60" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox21" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox61" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox22" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox62" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox23" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox63" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox24" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox64" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox25" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox65" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox26" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox66" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox27" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox67" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox28" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox68" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox29" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox69" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox30" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox70" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox31" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox71" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox32" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox72" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox33" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox73" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox34" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox74" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox35" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox75" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox36" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox76" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox37" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox77" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox38" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox78" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox39" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox79" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:CheckBox ID="CheckBox40" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                    <td class="auto-style24">
                        <asp:CheckBox ID="CheckBox80" runat="server" Enabled="False" OnCheckedChanged="CheckBox1_CheckedChanged" />
                    </td>
                </tr>
                          </table>
                      </td>
                      <td>&nbsp;</td>
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
