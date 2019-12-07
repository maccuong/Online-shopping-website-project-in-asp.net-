<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style3 {
            width: 701px;
        height: 176px;
    }
        .auto-style5 {
            height: 23px;
        }
        .auto-style6 {
        height: 34px;
    }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    <table class="auto-style3" _>
    <tr >
        <td style="border-bottom:1px" >ĐĂNG NHẬP</td>
    </tr>
    <tr>
        <td class="auto-style5" >Email*</td>
    </tr>
    <tr >
        <td >
            <asp:TextBox ID="txtemail" runat="server" Width="498px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtemail" ErrorMessage="Chưa nhập email"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style5" >Mật khẩu*</td>
    </tr>
    <tr >
        <td>
            <asp:TextBox ID="txtmatkhau" runat="server" Width="496px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtmatkhau" ErrorMessage="Chưa nhập mật khẩu"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td  class="auto-style6">
            <asp:Button ID="Btdangnhap1" runat="server" Text="Đăng nhập" Width="88px" OnClick="Btdangnhap1_Click" NavigateUrl='<%# "trangchu.aspx?loai="+Eval("loaitk") %>'/>
            <asp:Label ID="Lbdangnhap" runat="server" Text="Label" Visible="False"></asp:Label>
        </td>
    </tr>
</table></div>

</asp:Content>

