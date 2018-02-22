<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalcClient.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
</head>
<body>
    <h2>Mortgage Calculator</h2>
    <form id="form1" runat="server">
    <div class="container">
        <asp:Label ID="purchasePrice" runat="server" Text="Purchase Price"></asp:Label>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        
        <asp:TextBox ID="purchaseText" runat="server" Height="26px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Interest" runat="server" Text="Interest Rate"></asp:Label>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
         <asp:TextBox ID="InterestText" runat="server" Height="22px" OnTextChanged="InterestText_TextChanged"></asp:TextBox>

        <br />
        <br />
&nbsp;<asp:Label ID="Amort" runat="server" Text="Amortization"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:DropDownList ID="amortization" runat="server">
            <asp:ListItem Text="25 Years" Value="25" />
            <asp:ListItem Text="30 Years" Value="30" />
            <asp:ListItem Text="35 Years" Value="35" />
            </asp:DropDownList>
        <br />
        <br />
         <asp:Label ID="DownPercentage" runat="server" Text="Down Percentage"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="percentDown" runat="server" Height="40px" Width="89px">
            <asp:ListItem Text="5%" Value="5" />
            <asp:ListItem Text="10%" Value="10" />
            <asp:ListItem Text="15%" Value="15" />
            <asp:ListItem Text="20%" Value="20" />
            </asp:DropDownList>

        <br />
        <br />

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

        <asp:Button ID="Button1" runat="server" Text="Calculate" OnClick="Button1_Click" Width="300px" />
        <br />
        <br />

        <asp:Label ID="downPayment" runat="server" Text="Down Payment"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="downText" runat="server"></asp:TextBox>
        <br />
        <br />

        <asp:Label ID="RemMortgage" runat="server" Text="Remaining mortgage"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="remText" runat="server"></asp:TextBox>
         <br />
        <br />
        <asp:Label ID="MonthlyMortgage" runat="server" Text="Monthly Mortgage"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="monthlyText" runat="server"></asp:TextBox>
    &nbsp;
        <br />
        <br />
        <asp:Label ID="MonthlyInterest" runat="server" Text="Monthly Interest"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="MiText" runat="server"></asp:TextBox>
    &nbsp;
        <br />
        <br />
        <br />
    </div>
    </form>
</body>
</html>
