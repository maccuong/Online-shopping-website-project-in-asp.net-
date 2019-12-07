<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="chitiet.aspx.cs" Inherits="chitiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <asp:GridView ID="Gv2" runat="server" AutoGenerateColumns="False" DataKeyNames="masp" OnRowCommand="Gv2_RowCommand" Width="1054px">
        <Columns>
            <asp:BoundField DataField="masp" HeaderText="Mã sản phẩm" />
            <asp:BoundField DataField="tensp" HeaderText="Tên sản phẩm " />
            <asp:BoundField DataField="gia" HeaderText="Giá" />
            <asp:BoundField DataField="mota" HeaderText="Chi tiết sản phẩm" />
            <asp:BoundField DataField="hinhanh" HeaderText="Hình ảnh" />
            <asp:CommandField ButtonType="Button" SelectText="Thêm vào giỏ hàng" ShowSelectButton="True" />
        </Columns>
        <EmptyDataTemplate>
            <asp:Image ID="Image1" runat="server" Height="368px" ImageUrl='<%# "~hinh/"+Eval("hinhanh") %>' Width="491px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label26" runat="server" Text="Mã sản phẩm: "></asp:Label>
            <asp:Label ID="Label27" runat="server" Text='<%# Eval("masp") %>'></asp:Label>
            <br />
            <asp:Label ID="Label25" runat="server" Text="Giá: "></asp:Label>
            <asp:Label ID="Label28" runat="server" Text='<%# Eval("gia") %>'></asp:Label>
            <br />
            <asp:Label ID="Label29" runat="server" Text="Mô tả: "></asp:Label>
            <asp:Label ID="Label30" runat="server" Text='<%# Eval("mota") %>'></asp:Label>
        </EmptyDataTemplate>
    </asp:GridView>

    <br />
    <br />
    <asp:Label ID="lbtongtien" runat="server" Text="Label"></asp:Label>

</asp:Content>

