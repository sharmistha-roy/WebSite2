﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>
<%@ Register Src="~/WebUserControl1.ascx" TagName="CurrentTime" TagPrefix="UCCurrentTime" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Output Caching</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    Current Time:&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
     <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
        <br />
        <br />
      <UCCurrentTime:CurrentTime ID="ucTime" runat="server" /> 
    
    </div>
    </form>
</body>
</html>
