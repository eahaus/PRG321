<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Enter Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged" style="margin-left: 11px"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Enter To Do"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged" style="margin-left: 14px"></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add to List" />
            <asp:Button ID="Button2" runat="server" style="margin-left: 34px; margin-top: 11px; margin-bottom: 0px" Text="Remove" Width="95px" />
        </p>
        <asp:TextBox ID="TextBox3" runat="server" Height="101px" style="margin-top: 59px"></asp:TextBox>
    </form>
</body>
</html>
