﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StronglyTypedDataSet.aspx.cs" Inherits="ADO_NET_practice_with_web_forms.StronglyTypedDataSet" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="font-family:Arial">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" Text="Button" 
        onclick="Button1_Click" />
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</div>
    </form>
</body>
</html>
