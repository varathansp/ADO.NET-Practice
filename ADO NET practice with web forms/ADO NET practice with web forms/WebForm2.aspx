<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="ADO_NET_practice_with_web_forms.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnLoadData" runat="server" OnClick="btnLoadData_Click" Text="ExecuteReader" />
        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
        </asp:GridView>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ExecuteScalar" />
        <br />
        <table class="auto-style1">
            <tr>
                <td>Employee ID</td>
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>To Delete</td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="ExecuteNonQuery" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
