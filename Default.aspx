<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MinistryOfJusticeRealEstateAgentRegistration.Default" %>
<!DOCTYPE html>
<html>
<head runat="server">
    <title>Ministry of Justice Real Estate Agent Registration</title>
    <link rel="stylesheet" type="text/css" href="Content/css/style.css" />
    <script src="Scripts/main.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Header ID="Header" runat="server" />
            <h2>Register as a Real Estate Agent</h2>
            <label for="name">Name:</label>
            <input type="text" id="name" runat="server" /><br />
            <label for="license">License Number:</label>
            <input type="text" id="license" runat="server" /><br />
            <label for="username">Username:</label>
            <input type="text" id="username" runat="server" /><br />
            <label for="password">Password:</label>
            <input type="password" id="password" runat="server" /><br />
            <button type="submit" runat="server" onserverclick="Submit_Click">Submit</button>
        </div>
    </form>
</body>
</html>
