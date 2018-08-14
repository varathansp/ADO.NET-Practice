<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayersForm.aspx.cs" Inherits="ADO.Net_Players.PlayersForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnCheck" runat="server" OnClick="btnCheck_Click" Text="Check" />
        <asp:Label ID="lblCheck" runat="server"></asp:Label>
    
        <br />
        <br />
        <table class="auto-style1">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>DOB</td>
                <td>
                    <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Club</td>
                <td>
                    <asp:TextBox ID="txtClub" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Salary</td>
                <td>
                    <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style3">
                    <asp:Button ID="btnAddPlayer" runat="server" OnClick="btnAddPlayer_Click" Text="ADD" />
                    <asp:Button ID="btnParaAdd" runat="server" OnClick="btnParaAdd_Click" Text="Parameterized Add" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblResult" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
        <table class="auto-style1">
            <tr>
                <td>Name</td>
                <td>
                    <asp:DropDownList ID="ddlName" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>Club</td>
                <td>
                    <asp:TextBox ID="txtUpdateClub" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Salary</td>
                <td>
                    <asp:TextBox ID="txtUpdateSalary" runat="server" ></asp:TextBox>
                    </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lblUpdate" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">ToView Data Reader</td>
                <td class="auto-style2">
                    <asp:Button ID="btnReader" runat="server" OnClick="btnReader_Click" Text="Reader" />
                </td>
            </tr>
            <tr>
                <td>ToView Data Adapter</td>
                <td>
                    <asp:Button ID="btnAdapter" runat="server" OnClick="btnAdapter_Click" Text="Adapter" />
                </td>
            </tr>
        </table>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
