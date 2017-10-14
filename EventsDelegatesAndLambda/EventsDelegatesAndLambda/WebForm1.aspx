<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EventsDelegatesAndLambda.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Countries"></asp:Label>
        </div>
        <!--Module 1: our delegate is "OnSelectedIndexChanged" and the event handler is "CountriesDropDown_SelectedIndexChanged"-->
        <!--Module 1: behind the scene the code that magically  wire up the pipeline from event to event handler is done for us-->
        <asp:DropDownList ID="CountriesDropDown" runat="server" OnSelectedIndexChanged="CountriesDropDown_SelectedIndexChanged">
        </asp:DropDownList>
        <p>
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
        </p>
        <asp:Label ID="OutputLabel" runat="server" Text="OutputLabel"></asp:Label>
    </form>
</body>
</html>
