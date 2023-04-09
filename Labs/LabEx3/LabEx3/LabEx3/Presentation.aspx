<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Presentation.aspx.cs" Inherits="LabEx3.Presentation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div style="text-align: justify; cursor: auto">
                <img alt="" src="files/uj.png" style="height: 109px; width: 124px" /><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="XX-Large" Text="UJ Staff Portal"></asp:Label>
            </div>
        </div>
        <div>
            Identification No:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="idTXT" runat="server" Height="16px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="CreateBTN" runat="server" OnClick="CreateBTN_Click" Text="Create" />
        </div>
        <div>
            Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="nameTXT" runat="server" Height="16px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="SaveBTN" runat="server" OnClick="SaveBTN_Click" Text="Save" />
        </div>
        <div>
            Surname:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="surnameTXT" runat="server" Height="16px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ReadBTN" runat="server" Text="Read" />
        </div>
        <div>
            Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="emailTXT" runat="server" Height="16px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ClearBTN" runat="server" OnClick="ClearBTN_Click" Text="Clear" />
        </div>
        <div>
            Age:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="ageTXT" runat="server" Height="16px" Width="156px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="ExitBTN" runat="server" OnClick="ExitBTN_Click" Text="Exit" />
        </div>
    </form>
    <p>
&nbsp;</p>
</body>
</html>
