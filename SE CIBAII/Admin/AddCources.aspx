<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AddCources.aspx.vb" Inherits="SE_CIBAII.AddCources" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <h3>Add Courses</h3>
        <asp:MultiView ID="MultiView1" runat="server"ActiveViewIndex="0">
            <asp:View ID="View1" runat="server">

                <div style=""float:right">
                    <asp:Button ID="Button1" CssClass="btn btn-info" runat="server" Text="Add Course" />
                </div>

                <dx:ASPxGridView ID="ASPxGridView1" width="100%" runat="server"></dx:ASPxGridView>
            </asp:View>
        </asp:MultiView>
        <div>
            
        </div>
    </form>
</body>
</html>
